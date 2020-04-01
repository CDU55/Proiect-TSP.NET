using Proiect_TSPNET;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class Items : Form
    {
        private readonly ItemsService service;
        private static bool warningShown = false;
        public Items()
        {
            service = new ItemsService();
            InitializeComponent();
            FillItemGrid();
            List<string> movedItems = (List<string>)service.localItems.CheckForMovedOrDeletedFiles();
            if (movedItems.Count > 0 && !warningShown)
            {
                string message = "\t\tUrmatoarele fisiere au fost mutate sau sterse:\n";
                foreach (var item in movedItems)
                {
                    message += "\t\t" + item + "\n";
                }
                warningShown = true;
                AlertBox.DisplayMessage(message);
            }
        }

        private void MfdCheck_CheckedChanged(object sender, EventArgs e)
        {
            this.FillItemGrid();

        }

        private void FillItemGrid()
        {
            List<MediaItemDTO> itemsList = service.dbService.queryService.GetItems(this.MfdCheck.Checked, this.DeleteCheck.Checked);
            this.ItemsTable.DataSource = itemsList;
        }

        private void DeleteCheck_CheckedChanged(object sender, EventArgs e)
        {
            this.FillItemGrid();

        }

        private void Back_Click(object sender, EventArgs e)
        {
            FormOpener.Switch(this, new MainMenu());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var x = (MediaItemDTO)this.ItemsTable.CurrentRow.DataBoundItem;
            AlertBox.DisplayMessage(x.Path);
        }

        private void Attach_Click(object sender, EventArgs e)
        {
            var currentItem = (MediaItemDTO)this.ItemsTable.CurrentRow.DataBoundItem;
            string currentItemPath = currentItem.Path;
            FormOpener.Open(new AddItemRelation(currentItemPath));
        }

        private void ViewRelated_Click(object sender, EventArgs e)
        {
            var currentItem = (MediaItemDTO)this.ItemsTable.CurrentRow.DataBoundItem;
            string currentItemPath = currentItem.Path;
            FormOpener.Open(new ItemsRelationsDisplay(currentItemPath));
        }

        private void MarkForDelete_Click(object sender, EventArgs e)
        {
            var currentItem = (MediaItemDTO)this.ItemsTable.CurrentRow.DataBoundItem;
            string currentItemPath = currentItem.Path;
            this.service.dbService.editService.MarkForDelete(currentItemPath);
            FillItemGrid();

        }

        private void PermaDelete_Click(object sender, EventArgs e)
        {
            this.service.localItems.RemoveMarkedFiles();
            FillItemGrid();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            var currentItem = (MediaItemDTO)this.ItemsTable.CurrentRow.DataBoundItem;
            string currentItemPath = currentItem.Path;
            FormOpener.Open(new AddDescription(currentItemPath));
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            FillItemGrid();
        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            FormOpener.Open(new AddItem());
        }

        private void AddFromFolder_Click(object sender, EventArgs e)
        {
            FormOpener.Open(new AddFromFolder());
        }

        private void ViewItem_Click(object sender, EventArgs e)
        {
            var currentItem = (MediaItemDTO)this.ItemsTable.CurrentRow.DataBoundItem;
            string currentItemPath = currentItem.Path;
            service.localItems.ViewItem(currentItemPath);
        }

        private void MoveItem_Click(object sender, EventArgs e)
        {
            var currentItem = (MediaItemDTO)this.ItemsTable.CurrentRow.DataBoundItem;
            string currentItemPath = currentItem.Path;
            if (this.SelectFolder.ShowDialog() == DialogResult.OK)
            {
                string destinationFolder = SelectFolder.SelectedPath;
                destinationFolder += @"\" + service.localItems.GetItemName(currentItemPath, true);
                service.localItems.MoveFile(currentItemPath, destinationFolder);
            }
        }

        private void FilterProperties_Click(object sender, EventArgs e)
        {
            FilterByProperties filter = new FilterByProperties((List<MediaItemDTO>)this.ItemsTable.DataSource);
            if (filter.ShowDialog() != DialogResult.OK)
            {
                this.ItemsTable.DataSource = filter.items;
            }
        }

        private void Export_Click(object sender, EventArgs e)
        {
            SelectFile.Filter = "Json files (*.json)|*.json|Text files (*.txt)|*.txt";
            if (SelectFile.ShowDialog() == DialogResult.OK)
            {
                service.localItems.ExportAsJSON(SelectFile.FileName, (List<MediaItemDTO>)ItemsTable.DataSource);
            }
        }

        private void FilterByRel_Click(object sender, EventArgs e)
        {
            FilterByRelations filter = new FilterByRelations((List<MediaItemDTO>)this.ItemsTable.DataSource);
            if (filter.ShowDialog() != DialogResult.OK)
            {
                this.ItemsTable.DataSource = filter.items;
            }
        }

        private void ViewInApp_Click(object sender, EventArgs e)
        {
            var item = (MediaItemDTO)this.ItemsTable.CurrentRow.DataBoundItem;
            if (item != null)
            {
                if (service.localItems.IsVideo(item.Path))
                {
                    VideoWindow video = new VideoWindow(item.Path);
                    video.ShowDialog();
                }
                else if (service.localItems.IsPhoto(item.Path))
                {
                    PhotoWindow photo = new PhotoWindow(item.Path);
                    photo.ShowDialog();
                }

            }
        }
    }
}
