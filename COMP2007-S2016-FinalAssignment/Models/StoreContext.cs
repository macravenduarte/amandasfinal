using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace COMP2007_S2016_FinalAssignment.Models
{
    public class StoreContext : DbContext
    {
        public StoreContext()
            : base("name=StoreConnection")
        {
        }
        public virtual DbSet<ProductModels> ProductModels { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
    }
}