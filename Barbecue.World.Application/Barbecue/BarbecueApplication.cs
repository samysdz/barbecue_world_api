using Barbecue.World.Data.Barbecue;
using Barbecue.World.Domain.Models;
using System.Globalization;

namespace Barbecue.World.Application.Barbecue
{
    public class BarbecueApplication : IBarbecueApplication
    {
        private readonly IBarbecueRepository _barbecueRepository;
        public BarbecueApplication(IBarbecueRepository barbecueRepository)
        {
            _barbecueRepository = barbecueRepository;
        }

        public async Task<Result> Discover(string country)
        {
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

            string formattedCountry = textInfo.ToTitleCase(country.ToLowerInvariant());

            var data = await _barbecueRepository.CountryDetails(formattedCountry);
            string retorno = null;
            if(data == null)
            {
                retorno  = "COUNTRY NOT FOUND";
            }
            return new Result()
            {
                CountryDetails = data,
                Message = retorno
            };
        }

        public async Task<bool> AddBarbecue(CountriesData info)
        {
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

            info.Country = textInfo.ToTitleCase(info.Country.ToLowerInvariant());

            Countries dataSend = new Countries()
            {
                Id = 0,
                Country = info.Country,
                Style = info.Style,
                Description = info.Description
            };

            return await _barbecueRepository.AddBarbecue(dataSend);
        }

    }
}
