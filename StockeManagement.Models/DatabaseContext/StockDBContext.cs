using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockeManagement.Models.Models;

namespace StockeManagement.Models.DatabaseContext
{
    public class StockDBContext:DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<StockIn> StockIns { get; set; }
        public DbSet<StockInDetails> StockInDetailses { get; set; }
        public DbSet<StockOut> StockOuts { get; set; }
        public DbSet<StockOutDetails> StockOutDetailses { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Party> Parties { get; set; }
        public DbSet<Employee> Employees { get; set; }
        
    }
}
