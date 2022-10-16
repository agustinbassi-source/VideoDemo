using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using VideoDemo.Models;

namespace VideoDemo.Repository
{
    public class VideoDemoContext : DbContext
    {
        public VideoDemoContext(DbContextOptions<VideoDemoContext> options)
               : base(options)
        {
        }

        public DbSet<Carrito> Carrito { get; set; }
        public DbSet<ItemCarrito> ItemCarrito { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Producto> Producto { get; set; }
    }
}
