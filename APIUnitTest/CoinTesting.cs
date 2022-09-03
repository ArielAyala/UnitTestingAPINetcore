using Microsoft.AspNetCore.Mvc;
using UnitTestingAPINetCore.Controllers;
using UnitTestingAPINetCore.Models;
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

        [Fact]
        public void Get_Should_return_quantity()
        {
            // Act
            var result = (OkObjectResult)_coinController.Get();

            // Assert
            var coins = Assert.IsType<List<Coin>>(result.Value);
            Assert.True(coins.Count > 0);

        }

        [Fact]
        public void GetById_Should_Be_Ok()
        {
            // Arrange 
            int existingId = 1;

            // Act
            var result = (OkObjectResult)_coinController.GetById(existingId);

            // Assert
            var coin = Assert.IsType<Coin>(result?.Value);
            Assert.True(coin != null);
            Assert.Equal(coin?.Id, existingId);
        }
    }
}