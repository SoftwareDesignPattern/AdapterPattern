using AdapterExercise.Entities;
using System.Collections.Generic;

namespace AdapterPattern.DBOperations
{
    class GetBranchData : IAdapter<Branch>
    {
        public List<Branch> GetData(string tableName)
        {
            Adaptee<Branch> _Adaptee = new Adaptee<Branch>();
            return _Adaptee.GetDBData(tableName);
        }
    }
}
