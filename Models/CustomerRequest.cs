using System;
using System.Collections.Generic;

#nullable disable

namespace NetWebAPI.Models
{
    public partial class CustomerRequest
    {
        public int CustomerRequestId { get; set; }
        public int? CustomerId { get; set; }
        public int? FlatTypeId { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual FlatType FlatType { get; set; }
    }
}
