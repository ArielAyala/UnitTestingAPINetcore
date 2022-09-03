using Microsoft.AspNetCore.Mvc;
using UnitTestingAPINetCore.Controllers;
using UnitTestingAPINetCore.Services;

namespace APIUnitTest
{
    public class CoinTesting
    {
        private readonly CoinController _coinController;
        private readonly ICoinService _coinService;

        public CoinTesting()
        {
            _coinService = new CoinService();
            _coinController = new CoinController(_coinService);
        }

        [Fact]
        public void Get_Should_Be_Ok()
        {
            // Arrange

            // Act
            var result = _coinController.Get();

            // Assert
            Assert.IsType<OkObjectResult>(result);

        }
    }
}