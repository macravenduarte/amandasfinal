using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COMP2007_S2016_FinalAssignment.Models
{
    public class OrderDetail
    {
        public virtual int OrderDetailId { get; set; }
        public virtual int Quantity { get; set; }
        public virtual decimal UnitPrice { get; set; }
        public virtual int ID { get; set; }
        public virtual ProductModels ProductModels { get; set; }
        public virtual int OrderId { get; set; }
        public virtual Order Order { get; set; }
    }
}