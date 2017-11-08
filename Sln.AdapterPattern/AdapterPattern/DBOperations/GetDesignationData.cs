using AdapterExercise.Entities;
using System.Collections.Generic;

namespace AdapterPattern.DBOperations
{
    class GetDesignationData : IAdapter<Designation>
    {
        public List<Designation> GetData(string tableName)
        {
            Adaptee<Designation> _Adaptee = new Adaptee<Designation>();
            return _Adaptee.GetDBData(tableName);
        }
    }
}
