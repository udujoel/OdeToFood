using System.Collections.Generic;
using System.Linq;

using OdeToFood.Data.Models;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        private List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {

                new Restaurant{Id = 1,Name = "Peterson's Pizza", Cusine = CuisineType.Italian},
                new Restaurant{Id = 2,Name = "Madison", Cusine = CuisineType.French},
                new Restaurant{Id = 3,Name = "Jacobson's Bites", Cusine = CuisineType.Indian}

            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }

        public Restaurant Get(int id)
        {
            return restaurants.FirstOrDefault(r => r.Id == id);
        }
    }
}