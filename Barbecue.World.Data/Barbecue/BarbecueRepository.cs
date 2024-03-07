using Barbecue.World.Data.DB;
using Barbecue.World.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using System.Xml;

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

        public async Task<Countries> Teste(string pais)
        {
            var query = "SELECT * FROM countries WHERE Country = @Country";
            return await _context.Countries.FromSqlRaw(query, pais).FirstOrDefaultAsync();
        }
    }
}
