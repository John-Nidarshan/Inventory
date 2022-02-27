#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Inventory.Models;

namespace Inventory.Data
{
    public class InventoryContext : DbContext
    {
        public InventoryContext (DbContextOptions<InventoryContext> options)
            : base(options)
        {
        }

        public DbSet<Inventory.Models.Item> Item { get; set; }
    }
}
