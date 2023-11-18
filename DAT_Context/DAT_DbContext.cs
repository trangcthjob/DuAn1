using DAT_Context.Seeding;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DAT_Context
{
    /// <summary>
    /// Db Context
    /// </summary>
    public class DAT_DbContext : DbContext
    {
        public DAT_DbContext()
        {
                
        }
        // connect to database
        public DAT_DbContext(DbContextOptions<DAT_DbContext> options) : base(options)
        {
        }
        // connection string
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            /// Chuỗi kết nối tới database
            optionsBuilder.UseSqlServer(@"Server=MSI\SQLEXPRESS;Database=DAT_QLSV;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // create all model 
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
        // ánh xạ các bảng trong database
        public virtual DbSet<Account>? Accounts { get; set; }
        public virtual DbSet<Roles>? Roles { get; set; }
    }
}
