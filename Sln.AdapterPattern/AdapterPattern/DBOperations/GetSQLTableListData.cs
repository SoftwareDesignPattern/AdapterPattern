using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.DBOperations
{
    class GetSQLTableListData<T> : IAdapter<T> where T : class
    {
        List<T> IAdapter<T>.GetData(string tableName)
        {
            Adaptee<T> _Adaptee = new Adaptee<T>();
            return _Adaptee.GetDBData(tableName);
        }
    }
}
