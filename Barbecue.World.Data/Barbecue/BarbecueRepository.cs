using Barbecue.World.Data.DB;
using Barbecue.World.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Barbecue.World.Data.Barbecue
{
    public class BarbecueRepository: IBarbecueRepository
    {
        private  readonly BarbecueDbContext _context;

        public BarbecueRepository (
            BarbecueDbContext context
            )
        {
            _context = context;
        }

        public async Task<Countries> CountryDetails(string country)
        {
            var query = "SELECT * FROM countries WHERE Country = {0}";
            return await _context.Countries.FromSqlRaw(query, country).FirstOrDefaultAsync();
        }

        public async Task<bool> AddBarbecue(Countries info)
        {
            try
            {
                _context.Countries.Add(info);

                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
