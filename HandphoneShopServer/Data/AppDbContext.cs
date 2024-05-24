﻿using HandphoneShopSharedLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace HandphoneShopServer.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; } = default!;

    }
}
