using AdapterExercise.Entities;
using System.Collections.Generic;

namespace AdapterPattern.DBOperations
{
    class GetEmployeeData: IAdapter<Employee>
    {
        public List<Employee> GetData(string tableName)
        {
            Adaptee<Employee> _Adaptee = new Adaptee<Employee>();
            return _Adaptee.GetDBData(tableName);
        }
    }
}
