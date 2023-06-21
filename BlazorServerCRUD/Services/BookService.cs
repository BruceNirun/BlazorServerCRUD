using BlazorServerCRUD.Interfaces;
using BlazorServerCRUD.Models.db;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;

namespace BlazorServerCRUD.Services
{
    public class BookService : IBookService
    {
        private readonly DemoShopContext _db;

        public BookService(DemoShopContext db) {  _db = db; }
        public async Task<Book> Create(Book b)
        {
            _db.Books.Add(b);
            await _db.SaveChangesAsync();
            return b;
        }

        public async Task Detele(Book b)
        {
            _db.Books.Remove(b);
            await _db.SaveChangesAsync();
        }

        public async Task<List<Book>> Read()
        {
            return await _db.Books
                .Include(c => c.Category).ToListAsync();
        }

        public async Task<Book> ReadById(int id)
        {
            return await _db.Books
                 .Include(c => c.Category)
                 .FirstOrDefaultAsync(i => i.BookId == id);
        }

        public async Task Update(Book b)
        {
            _db.Books.Update(b);
           await _db.SaveChangesAsync();  
        }
    }
}
