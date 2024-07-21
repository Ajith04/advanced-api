﻿using Microsoft.EntityFrameworkCore;

namespace Sample.Database
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base (options)
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}
