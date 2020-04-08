using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_TSPNET
{
    [DataContract]
    public class MediaItemDTO
    {
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string Path { get; set; }
        [DataMember]
        public string Extension { get; set; }
        [DataMember]
        public DateTime Date { get; set; }
        [DataMember]
        public bool IsPhoto { get; set; }
        [DataMember]
        public string Location { get; set; }
        [DataMember]
        public string Event { get; set; }
        [DataMember]
        public bool MarkedForDelete { get; set; }
        [DataMember]
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
