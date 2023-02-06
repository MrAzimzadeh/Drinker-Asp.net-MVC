using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Banner> Banners{ get; set; }

        public DbSet<Testimonial> Testimonials{ get; set; }
        public DbSet<Product> Products{ get; set; }
        public DbSet<Contact> Contacts{ get; set; }

        
    }
}