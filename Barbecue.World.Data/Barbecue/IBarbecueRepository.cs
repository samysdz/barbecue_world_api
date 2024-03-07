using Barbecue.World.Domain.Models;

namespace Barbecue.World.Data.Barbecue
{
    public interface IBarbecueRepository
    {
        Task<Countries> CountryDetails(string pais);
        Task<bool> AddBarbecue(Countries info);
    }
}
