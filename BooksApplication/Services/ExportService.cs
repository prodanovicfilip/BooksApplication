using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BooksApplication.Services
{
    public class ExportService : IExportService
    {
        public void ExportJson(IEnumerable<object> list, string path)
        {
            string json = JsonConvert.SerializeObject(list);
            File.WriteAllText(path, json);
        }

        public IEnumerable<T> ImportFromJson<T>(string path)
        {
            var json = File.ReadAllText(path);
            var objects = JsonConvert.DeserializeObject<IEnumerable<T>>(json);
            return objects;
        }
    }
}
