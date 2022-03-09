using System;
using System.Collections.Generic;

#nullable disable

namespace NetWebAPI.Models
{
    public partial class Gender
    {
        public Gender()
        {
            Customers = new HashSet<Customer>();
        }

        public int GenderId { get; set; }
        public string GenderName { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
