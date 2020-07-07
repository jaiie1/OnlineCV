using Microsoft.EntityFrameworkCore;
using OnlineCV.Api.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace OnlineCV.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Jobb> jobbs { get; set; }
        public DbSet<School> Schools { get; set; }
    }
}
