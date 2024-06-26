﻿using Microsoft.EntityFrameworkCore;
using Project.Core.Models;

namespace back_end.Data
{
    public class ApplicationDbContext: DbContext
    {
        protected readonly IConfiguration Configuration;

        public ApplicationDbContext(DbContextOptions options): base(options) { }

        public DbSet<Meal> Meals { get; set; }
    }
}
