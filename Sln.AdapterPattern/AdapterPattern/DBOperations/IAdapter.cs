using System.Collections.Generic;

namespace AdapterPattern.DBOperations
{
    interface IAdapter<T> where T : class
    {
        List<T> GetData(string tableName);
    }
}
