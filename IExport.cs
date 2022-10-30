using System;

namespace OOP2
{
    public interface IExport<in T>
    {
        public void ExportToFileInJson(T t, string filename);
    }
}