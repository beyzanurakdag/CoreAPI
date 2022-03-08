using CoreApi_BLL.Interfaces;
using CoreApi_DAL;
using CoreApi_EL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreApi_BLL.Implementations
{
    public class AssignmentRepository:Repository<Assignment>, IAssignmentRepository
    {
        public AssignmentRepository(MyContext myContext) : base(myContext)
        {

        }
    }
}
