using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_TSPNET
{
    public class MediaItemDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Path { get; set; }
        public string Extension { get; set; }
        public DateTime Date { get; set; }
        public bool IsPhoto { get; set; }
        public string Location { get; set; }
        public string Event { get; set; }
        public bool MarkedForDelete { get; set; }
        public bool PermanentDelete { get; set; }

        public MediaItemDTO(MediaItems item)
        {
            this.Title = item.Title;
            this.Description = item.Description;
            this.Path = item.Path;
            this.Date = item.Date;
            this.Extension = item.Extension;
            this.IsPhoto = item.IsPhoto;
            this.MarkedForDelete = item.MarkedForDelete;
            this.PermanentDelete = item.PermanentDelete;
            if (item.Location == null)
            {
                this.Location = string.Empty;
            }
            else
            {
                this.Location = item.Location.Name;
            }
            if (item.Event == null)
            {
                this.Event = string.Empty;
            }
            else
            {
                this.Event = item.Event.Name;
            }
        }
    }
}
