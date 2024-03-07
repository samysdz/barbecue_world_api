using Barbecue.World.Data.Barbecue;
using Barbecue.World.Domain.Models;

namespace Barbecure.World.Application.Barbecue
{
    public class BarbecueApplication : IBarbecueApplication
    {
        private readonly IBarbecueRepository _barbecueRepository;
        public BarbecueApplication(IBarbecueRepository barbecueRepository)
        {
            _barbecueRepository = barbecueRepository;
        }

        public async Task<Countries> Teste(int n, string pais) // Updated return type to Task<int>
        {
            var t = await _barbecueRepository.Teste(pais);
            var result = await Task.FromResult(t); // Example asynchronous operation
            return t;
        }

    }
}
