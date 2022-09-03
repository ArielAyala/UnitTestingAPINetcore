using UnitTestingAPINetCore.Models;

namespace UnitTestingAPINetCore.Services
{
    public interface ICoinService
    {
        public IEnumerable<Coin> Get();
        public Coin? Get(int id);
    }
}
