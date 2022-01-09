using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanyPieShop_2.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private AppDbContext _appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return _appDbContext.Categories;
            }
        }
    }
}
