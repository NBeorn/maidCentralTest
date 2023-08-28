using Abp.Application.Services;
using Abp.Domain.Repositories;
using maidCentralTest.StartingValues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maidCentralTest.Starting_Values
{
    public class StartingValuesAppService : AsyncCrudAppService<StartingValue, StartingValuesDto>, IStartingValuesAppService
    {
        public StartingValuesAppService(IRepository<StartingValue, int> repository) : base(repository)
        {
        }
    }
}
