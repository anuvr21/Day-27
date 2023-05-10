using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorEmployeePages.EmpModels;

namespace RazorEmployeePages.Data
{
    public class RazorEmployeePagesContext : DbContext
    {
        public RazorEmployeePagesContext (DbContextOptions<RazorEmployeePagesContext> options)
            : base(options)
        {
        }

        public DbSet<RazorEmployeePages.EmpModels.Employee> Employee { get; set; } = default!;
    }
}
