using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Proiect3.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int Quantity { get; set; }
    }

    public class ProductModelDbContext : DbContext
    {
        public DbSet<ProductModel> Products { get; set; }
    }
}