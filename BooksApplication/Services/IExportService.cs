
namespace BooksApplication.Services
{
    public interface IExportService
    {
        void ExportJson(IEnumerable<object> list, string path);
        IEnumerable<T> ImportFromJson<T>(string path);
    }
}