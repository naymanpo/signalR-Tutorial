using SignalR_Tutoral.Domain.Data;
using SignalR_Tutoral.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalR_Tutoral.Domain.Repository
{
    public class EmployeeRepository: Repository<Employee>
    {
        public EmployeeRepository(DataContext dataContext):base(dataContext)
        {

        }
    }
}