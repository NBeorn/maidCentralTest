using Abp.Application.Services;
using Abp.Application.Services.Dto;
using maidCentralTest.StartingValues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maidCentralTest.Starting_Values
{
    public interface IStartingValuesAppService : IAsyncCrudAppService<StartingValuesDto, int>
    {
        public Task<StartingValuesDto> CreateAsync(StartingValuesDto input)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(EntityDto<int> input)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResultDto<StartingValuesDto>> GetAllAsync(PagedAndSortedResultRequestDto input)
        {
            throw new NotImplementedException();
        }

        public Task<StartingValuesDto> GetAsync(EntityDto<int> input)
        {
            throw new NotImplementedException();
        }

        public Task<StartingValuesDto> UpdateAsync(StartingValuesDto input)
        {
            throw new NotImplementedException();
        }
    }
}
