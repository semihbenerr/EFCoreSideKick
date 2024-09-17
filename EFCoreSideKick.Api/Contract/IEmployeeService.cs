using EFCoreSideKick.Api;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace EFCoreSideKick.Api
{
    public interface IEmployeeService : IEntityServiceBase<Employee, int>
    {
    }
}
