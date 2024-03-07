using Barbecue.World.Domain.Models;

namespace Barbecue.World.Application.Barbecue
{
    public interface IBarbecueApplication
    {
        Task<Result> Discover(string country);
        Task<bool> AddBarbecue(CountriesData info);
    }
}
