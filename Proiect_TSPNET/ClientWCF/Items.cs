using Proiect_TSPNET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace ClientWCF
{
    public partial class Items : Form
    {
        private readonly ServiceClient service;
        private static bool warningShown = false;
        public Items()
        {
            service = new ServiceClient();
            InitializeComponent();
            FillItemGrid();
            List<string> movedItems = service.CheckForMovedOrDeletedFiles().ToList();
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
            List<MediaItemDTO> itemsList = service.GetItems(this.MfdCheck.Checked, this.DeleteCheck.Checked).ToList();
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
            this.service.MarkForDelete(currentItemPath);
            FillItemGrid();

        }

        private void PermaDelete_Click(object sender, EventArgs e)
        {
            this.service.RemoveMarkedFiles();
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
            service.ViewItem(currentItemPath);
        }

        private void MoveItem_Click(object sender, EventArgs e)
        {
            var currentItem = (MediaItemDTO)this.ItemsTable.CurrentRow.DataBoundItem;
            string currentItemPath = currentItem.Path;
            if (this.SelectFolder.ShowDialog() == DialogResult.OK)
            {
                string destinationFolder = SelectFolder.SelectedPath;
                destinationFolder += @"\" + service.GetItemName(currentItemPath, true);
                service.MoveFile(currentItemPath, destinationFolder);
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
                service.ExportAsJSON(SelectFile.FileName, (MediaItemDTO[])ItemsTable.DataSource);
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
                if (service.IsVideo(item.Path))
                {
                    VideoWindow video = new VideoWindow(item.Path);
                    video.ShowDialog();
                }
                else if (service.IsPhoto(item.Path))
                {
                    PhotoWindow photo = new PhotoWindow(item.Path);
                    photo.ShowDialog();
                }

            }
        }

        private void MailBtn_Click(object sender, EventArgs e)
        {
            FormOpener.Open(new MailForm((List<MediaItemDTO>)this.ItemsTable.DataSource));
        }

        private void Items_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.service.Close();
        }
    }
}
