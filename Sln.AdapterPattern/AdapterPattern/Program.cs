using AdapterExercise.Entities;
using AdapterPattern.DBOperations;
using System.Windows.Forms;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            //Using full Generics
            IAdapter<Branch> branchList = new GetSQLTableListData<Branch>();
            var result1 = branchList.GetData("Branch");

            IAdapter<Designation> designationList = new GetSQLTableListData<Designation>();
            var result2 = designationList.GetData("Designation");


            IAdapter<Employee> employeeList = new GetSQLTableListData<Employee>();
            var result3 = employeeList.GetData("Employee");


            //Using Class wise
            IAdapter<Branch> branchList2 = new GetBranchData();
            var result11 = branchList2.GetData("Branch");

            IAdapter<Designation> designationList2 = new GetDesignationData();
            var result22 = designationList2.GetData("Designation");


            IAdapter<Employee> employeeList2 = new GetEmployeeData();
            var result32 = employeeList2.GetData("Employee");

            //visual Test
            //Application.Run(new VisualImplementations());

        }
    }
}
