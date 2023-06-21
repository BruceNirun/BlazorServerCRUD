using BlazorServerCRUD.Models.db;

namespace BlazorServerCRUD.Interfaces
{
    public interface ICategoryService
    {
        Task<List<Category>> Read();
    }
}
