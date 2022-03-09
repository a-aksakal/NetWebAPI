using System;
using System.Collections.Generic;

#nullable disable

namespace NetWebAPI.Models
{
    public partial class City
    {
        public City()
        {
            Customers = new HashSet<Customer>();
            Projects = new HashSet<Project>();
        }

        public int CityID { get; set; }
        public string CityName { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}
