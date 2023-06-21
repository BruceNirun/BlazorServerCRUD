using BlazorServerCRUD.Interfaces;
using BlazorServerCRUD.Models.db;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerCRUD.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly DemoShopContext _db;

        public CategoryService(DemoShopContext db) { _db = db; }
        public async Task<List<Category>> Read()
        {
            return await _db.Categories
                .OrderBy(c => c.CategoryName).ToListAsync();
        }
    }
}
