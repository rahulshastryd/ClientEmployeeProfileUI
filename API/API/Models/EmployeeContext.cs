using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options)
            :base(options)
        {

        }
        public DbSet<EmployeeDetail> Employee { get; set; }
        public DbSet<CareerHistory> CareerDetails { get; set; }
        public DbSet<PerformanceHistory> PerformanceDetails { get; set; }
        public DbSet<PreviousEmployment> PreviousJob { get; set; }
        public DbSet<QualificationAndPerformanceRating> Ratings { get; set; }

    }
}
