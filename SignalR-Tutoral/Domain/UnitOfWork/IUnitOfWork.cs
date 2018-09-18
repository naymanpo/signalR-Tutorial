using SignalR_Tutoral.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR_Tutoral.Domain.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        EmployeeRepository EmployeeRepository { get; }
        int Complete();
    }
}
