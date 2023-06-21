using BlazorServerCRUD.Models.db;

namespace BlazorServerCRUD.Interfaces
{
    public interface IBookService
    {
        Task<Book> Create (Book b);
        Task<List<Book>> Read ();
        Task<Book> ReadById (int id);
        Task Update (Book b);
        Task Detele(Book b);
    }
}
