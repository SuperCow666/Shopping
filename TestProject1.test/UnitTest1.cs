using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MyProject.Issues;
using Shopping;
using Shopping.DTO;
using Shopping.Goods;
using Shopping.GoodsApp;
using Shouldly;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace TestProject1.test
{
    public class UnitTest1
    {

        [Fact]
        public void Should_Set_The_CloseDate_Whenever_Close_An_Issue()
        {
            // Arrange

            var issue = new Issue();
            issue.CloseDate.ShouldBeNull(); // null at the beginning

            // Act

            issue.Close();

            // Assert

            issue.IsClosed.ShouldBeTrue();
            issue.CloseDate.ShouldNotBeNull();
        }

    }
}
