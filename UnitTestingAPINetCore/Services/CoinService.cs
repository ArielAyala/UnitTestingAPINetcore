using UnitTestingAPINetCore.Models;

namespace UnitTestingAPINetCore.Services
{
    public class CoinService : ICoinService
    {
        private List<Coin> _coins = new List<Coin>()
        {
            new Coin(){ Id = 1, Symbol = "BTC", Name = "Bitcoin" },
            new Coin(){ Id = 2, Symbol = "ETH", Name = "Ethereum" },
        };

        public IEnumerable<Coin> Get() => _coins;

        public Coin? Get(int id) => _coins.FirstOrDefault(x => x.Id == id);
    }
}
