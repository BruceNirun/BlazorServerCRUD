using BlazorServerCRUD.Models.db;

namespace BlazorServerCRUD.Interfaces
{
    public interface IPublisherService
    {
        Task<List<Publisher>> Read();
    }
}
