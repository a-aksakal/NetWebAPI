using System;
using System.Collections.Generic;

#nullable disable

namespace NetWebAPI.Models
{
    public partial class FlatStatus
    {
        public FlatStatus()
        {
            Flats = new HashSet<Flat>();
        }

        public int FlatStatusId { get; set; }
        public string FlatStatusName { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual ICollection<Flat> Flats { get; set; }
    }
}
