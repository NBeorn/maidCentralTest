using System.Threading.Tasks;
using maidCentralTest.Models.TokenAuth;
using maidCentralTest.Web.Controllers;
using Shouldly;
using Xunit;

namespace maidCentralTest.Web.Tests.Controllers
{
    public class HomeController_Tests: maidCentralTestWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}