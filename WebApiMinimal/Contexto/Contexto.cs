﻿using Microsoft.EntityFrameworkCore;
using WebApiMinimal.Models;

namespace WebApiMinimal.Contexto
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions options) : base(options) => Database.EnsureCreated();
        public DbSet<Produto> Produto { get; set; }

    }
}
