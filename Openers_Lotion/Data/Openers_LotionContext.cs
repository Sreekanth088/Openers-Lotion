using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Openers_Lotion.Models;
using ProductStore.Models;

namespace Openers_Lotion.Data
{
    public class Openers_LotionContext(DbContextOptions<Openers_LotionContext> options) : DbContext(options)
    {
        public DbSet<Openers_Lotion.Models.Lotion> Lotion { get; set; } = default!;
        public DbSet<ProductStore.Models.Product> Product { get; set; } = default!;
    }
}
