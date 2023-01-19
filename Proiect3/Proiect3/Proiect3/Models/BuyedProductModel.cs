using Languages2;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using System.Xml.Linq;

namespace Proiect3.Models
{
    public class BuyedProductModel
    {
        public int Id { get; set; }
        [Display(Name = "ProductId", ResourceType = typeof(Resource))]
        public int ProductId { get; set; }
        [Display(Name = "UserId", ResourceType = typeof(Resource))]
        public int UserId { get; set; }
        [Display(Name = "Name", ResourceType = typeof(Resource))]
        public string Name { get; set; }
        [Display(Name = "Quantity", ResourceType = typeof(Resource))]
        public int Quantity { get; set; }
    }

    public class BuyedProductModelDbContext : DbContext
    {
        public DbSet<BuyedProductModel> BuyedProducts { get; set;}
    }
}