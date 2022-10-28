using System;

namespace OOP2
{
    public interface IGetStatistics<out T>
    {
        T GetStats<T>();
        
    }
}