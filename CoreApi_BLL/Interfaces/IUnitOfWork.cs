using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreApi_BLL.Interfaces
{
    public interface IUnitOfWork:IDisposable
    {
        IAssignmentRepository AssignmentRepository { get; }
    }
}
