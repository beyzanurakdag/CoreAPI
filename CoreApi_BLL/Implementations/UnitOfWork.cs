using CoreApi_BLL.Interfaces;
using CoreApi_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreApi_BLL.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyContext _myContext;
        public IAssignmentRepository AssignmentRepository { get; private set; }
        public UnitOfWork(MyContext myContext)
        {
            _myContext = myContext;
            AssignmentRepository = new AssignmentRepository(_myContext);
        }

        public void Dispose()
        {
            _myContext.Dispose();
        }
    }
}
