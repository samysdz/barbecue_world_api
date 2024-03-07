using Barbecue.World.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbecue.World.Data.Barbecue
{
    public interface IBarbecueRepository
    {
        Task<Countries> Teste(string pais);
    }
}
