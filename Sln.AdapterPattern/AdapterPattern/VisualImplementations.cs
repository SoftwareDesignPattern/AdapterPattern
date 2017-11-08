using AdapterExercise.Entities;
using AdapterPattern.DBOperations;
using System;
using System.Windows.Forms;

namespace AdapterPattern
{
    public partial class VisualImplementations : Form
    {
        public VisualImplementations()
        {
            InitializeComponent();
        }

        private void VisualImplementations_Load(object sender, EventArgs e)
        {
            tableNameComboBox.Items.Add("Employee");
            tableNameComboBox.Items.Add("Designation");
            tableNameComboBox.Items.Add("Branch");
        }


        private void btnShow_Click(object sender, EventArgs e)
        {
            var tableName = tableNameComboBox.SelectedItem.ToString().Trim();
            object result = null;

            if (tableName.Contains("Branch"))
            {
                IAdapter<Branch> branchList = new GetSQLTableListData<Branch>();
                result = branchList.GetData(tableName);
            }
            else if (tableName.Contains("Designation"))
            {
                IAdapter<Designation> designationList = new GetSQLTableListData<Designation>();
                result = designationList.GetData("Designation");
            }
            else if (tableName.Contains("Employee"))
            {
                IAdapter<Employee> employeeList = new GetSQLTableListData<Employee>();
                result = employeeList.GetData("Employee");
            }


            dataGridView1.DataSource = result;
        }
    }
}
