using SignalR_Tutoral.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SignalR_Tutoral.Domain.Data
{
    public class DataContext : DbContext
    {
        public DataContext(): base("DefaultConnectionString")
        {
            
        }
        public DbSet<Employee> Employees { set; get; }
    }
}