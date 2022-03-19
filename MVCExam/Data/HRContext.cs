using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCExam.Data
{
    public class HRContext:DbContext
    {
        IConfiguration configuration;

        public HRContext(IConfiguration _configuration)
        {
            configuration = _configuration;
        }
        public DbSet<Employee> employee { set; get; }

        public DbSet<Department> department { set; get; }

        public DbSet<Country> country { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("HRConnection"));
            base.OnConfiguring(optionsBuilder);
        }
    }
}
