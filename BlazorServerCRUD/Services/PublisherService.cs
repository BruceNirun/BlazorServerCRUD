using BlazorServerCRUD.Interfaces;
using BlazorServerCRUD.Models.db;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace BlazorServerCRUD.Services
{
    public class PublisherService : IPublisherService
    {
        private readonly DemoShopContext _db;

        public PublisherService(DemoShopContext db) { _db = db; }
        public async Task<List<Publisher>> Read()
        {
            return await _db.Publishers
                .OrderBy(p => p.PublishName).ToListAsync();
        }
    }
}
