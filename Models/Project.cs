using System;
using System.Collections.Generic;

#nullable disable

namespace NetWebAPI.Models
{
    public partial class Project
    {
        public Project()
        {
            Flats = new HashSet<Flat>();
            Visits = new HashSet<Visit>();
        }

        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public int? CityId { get; set; }
        public int? ProjectStatusId { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual City City { get; set; }
        public virtual ProjectStatus ProjectStatus { get; set; }
        public virtual ICollection<Flat> Flats { get; set; }
        public virtual ICollection<Visit> Visits { get; set; }
    }
}
