using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NachPieShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories => new List<Category>
        {
            new Category {CategoryId=1, CategoryName="Fruit Pies", Description="Pies with Fruits"},
            new Category {CategoryId=2, CategoryName="Cheese Cakes", Description="Cakes with Chees"},
            new Category {CategoryId=3, CategoryName="Seasonal Pies", Description="Pies with Seasons"},

        };
    }

}
