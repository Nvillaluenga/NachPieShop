using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NachPieShop.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly PieDbContext _pieDbContext;
        public CategoryRepository(PieDbContext pieDbContext)
        {
            _pieDbContext = pieDbContext;
        }
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return _pieDbContext.Categories;
            }
        }
    }
}
