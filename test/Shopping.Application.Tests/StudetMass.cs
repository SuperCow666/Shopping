using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shopping.DTO;
using Shopping.Goods;
using Shopping.GoodsApp;
using Shouldly;
using Xunit;

namespace Shopping
{
   public class StudetMass: ShoppingApplicationTestBase
    {
        private readonly ITodoAppService _issueAppService;

        public StudetMass()
        {
            _issueAppService = GetRequiredService<ITodoAppService>();
        }

        [Fact]
        public async Task Should_Get_All_Issues()
        {
            var uid = new GoodsKind()
            {

            };
            //Act 测试方法的实际调用
            var issueDtos = await _issueAppService.GetListAsync(uid.Id);


            //Assert
            
            Assert.NotNull(issueDtos);
        }
        [Fact]
        public async Task Should_Get_All_Add()
        {
            var goodsDTO = new GoodsDTO()
            {
                isShow = true,
            };
            //Act
            var issueDtos = await _issueAppService.CreateAsync(goodsDTO);
            Assert.NotNull(issueDtos);
            Assert.Equal(issueDtos, issueDtos);
            //Assert

        }
        [Fact]
        public async Task   Should_Get_All_Del()
        {
            var uid = new GoodsKind()
            {
                
            };
            //Act
            var issueDtos =  _issueAppService.DeleteAsync(uid.Id);

            Assert.Equal(issueDtos, issueDtos);
            //Assert

        }
      [Fact]
      public async Task Should_get_All_Endie()
        {
            var uid = new GoodsKind()
            {
             
            };
            var issueDtos = await _issueAppService.GetTaskById(uid.Id);
            Assert.NotNull(issueDtos);
            Assert.Equal(issueDtos, issueDtos);
        }

    }
}
