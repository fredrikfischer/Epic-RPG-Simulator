using System;
using Newtonsoft.Json;

namespace OOP2
{
    public class Export<T> : IExport<T>
    {
        public async void ExportToFileInJson(T t, string filename)
        {
            string json = JsonConvert.SerializeObject(t);
            await File.AppendAllTextAsync(filename, json);
        }

    }
}