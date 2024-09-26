
namespace BooksApplication.Services.Api
{
    public interface IApiService
    {
        Task Create<T>(T value);
        Task Delete<T>(int id);
        Task<IEnumerable<T>> GetAll<T>(string fieldName);
        Task<T> GetById<T>(int id);
        Task<T> Update<T>(int id, T value);
    }
}