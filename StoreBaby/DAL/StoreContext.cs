﻿using StoreBaby.Models;
using System.Data.Entity;

namespace StoreBaby.DAL
{
    public class StoreContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}