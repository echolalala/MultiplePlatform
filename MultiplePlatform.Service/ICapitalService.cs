using MultiplePlatform.Core;
using MultiplePlatform.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplePlatform.Service
{
    public interface ICapitalService : IRepository<T_Capital>, IDependency
    {
    }
}
