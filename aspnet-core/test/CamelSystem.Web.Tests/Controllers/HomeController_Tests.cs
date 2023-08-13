using System.Threading.Tasks;
using CamelSystem.Models.TokenAuth;
using CamelSystem.Web.Controllers;
using Shouldly;
using Xunit;

namespace CamelSystem.Web.Tests.Controllers
{
    public class HomeController_Tests: CamelSystemWebTestBase
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