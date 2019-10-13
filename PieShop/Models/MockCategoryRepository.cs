using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        List<Category> Categories; 
        public MockCategoryRepository()
        {
            Categories = new List<Category>
            {
                new Category{CategoryId = 1 , CategoryName = "Fruit Pies", Description = "Fruit Pies organic" },
                new Category{CategoryId = 2 , CategoryName = "Cheese cakes", Description = "Best cheesecakes" },
                new Category{CategoryId = 3 , CategoryName = "Seasonal pies", Description = "Healthy seasonal pies" }
            };
        }

        IEnumerable<Category> ICategoryRepository.GetAllCategories()
        {
            return Categories;
        }
    }
}
