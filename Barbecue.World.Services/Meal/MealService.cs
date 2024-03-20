using RestSharp;

namespace Barbecue.World.Services.Meal
{
    public class MealService : IMealService
    {
        public MealService()
        {
            
        }

        public async Task<string> ApiMeal()
        {
            RestClient client = new RestClient(Environment.GetEnvironmentVariable("UrlBaseMeal"));

            RestRequest request = new RestRequest("filter.php");

            request.AddParameter("a", "Canadian");

            // Add query parameter
            request.AddParameter("a", "Canadian");

            var response = await client.ExecuteAsync(request);
            return null;
        }

    }
}
