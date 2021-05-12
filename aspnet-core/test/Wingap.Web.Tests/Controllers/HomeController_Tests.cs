using System.Threading.Tasks;
using Wingap.Models.TokenAuth;
using Wingap.Web.Controllers;
using Shouldly;
using Xunit;

namespace Wingap.Web.Tests.Controllers
{
    public class HomeController_Tests: WingapWebTestBase
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