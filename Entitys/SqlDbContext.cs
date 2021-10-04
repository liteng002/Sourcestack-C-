using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using Entitys;
//using Microsoft.EntityFrameworkCore;

namespace CSharp
{
    class SqlDbContext : DbContext
    {
        public DbSet<User> users
        {
            get; set;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=18bang;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            optionsBuilder.UseSqlServer(connStr);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
