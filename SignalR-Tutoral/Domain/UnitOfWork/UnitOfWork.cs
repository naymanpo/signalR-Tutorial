using SignalR_Tutoral.Domain.Data;
using SignalR_Tutoral.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalR_Tutoral.Domain.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _dataContext;
        public UnitOfWork(DataContext context)
        {
            _dataContext = context;
            EmployeeRepository = new EmployeeRepository(context);
        }

        public EmployeeRepository EmployeeRepository { get; private set; }

        public int Complete()
        {
            return _dataContext.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}