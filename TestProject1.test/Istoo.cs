using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using NSubstitute;
using Shopping;
using Shopping.DTO;
using Shopping.Eumes;
using Shopping.Goods;
using Shopping.GoodsApp;
using Volo.Abp;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;
using Xunit;

namespace TestProject12.test
{
    public class IssueManager : ApplicationService, ITodoAppService
    {
       

        private readonly ITodoAppService _issueRepository;

        public IssueManager(ITodoAppService issueRepository)
        {
            _issueRepository = issueRepository;
        }

        public async Task<Task<List<GoodsTypeDTO>>> AssignToUserAsync(int uid)
        {
            var issueCount =  _issueRepository.GetListAsync(uid);

            return issueCount;

        }

        public Task<Eume> CreateAsync(GoodsDTO goodsDTO)
        {
            throw new NotImplementedException();
        }

        public Task CreateAsync(bool isShow)
        {
            throw new NotImplementedException();
        }

        public Task CreateAsync()
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<GoodsTypeDTO>> GetListAsync(int uid)
        {
            throw new NotImplementedException();
        }

        public Task<GoodsTypeDTO> GetTaskById(int id)
        {
            throw new NotImplementedException();
        }

        public ResStatus IsShowDTO(int id)
        {
            throw new NotImplementedException();
        }

        public Task<GoodsTypeDTO> UpdategoodsClassDTO(GoodsDTO goodsDTO)
        {
            throw new NotImplementedException();
        }
    }
}
