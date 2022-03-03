using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDOperation.Data
{
    public class CrudDBContext:DbContext
    {
        public CrudDBContext(DbContextOptions<CrudDBContext> options):base(options)
        {

        }
        
        public DbSet<Employee> tblEmployees { get; set; }

    }
}
