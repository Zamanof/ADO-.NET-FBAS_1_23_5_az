using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace ADO_03._Disconnected_mode
{
    public partial class Form1 : Form
    {
        private SqlConnection conn;
        private DataSet dataSet;
        private SqlDataAdapter adapter;
        private SqlCommandBuilder cmd;
        string cs = @"Server = (localdb)\MSSQLLocalDB; 
Integrated Security = SSPI; 
Database = Library";
        public Form1()
        {
            InitializeComponent();
            conn = new();
            conn.ConnectionString = cs;
        }

        private void fillButton_Click(object sender, EventArgs e)
        {
            dataSet = new();
            string query = queryTextBox.Text;
            SqlCommand sql = new SqlCommand(@"INSERT INTO Authors(Id, FirstName, LastName) VALUES(@p1, @p2, @p3)", conn);
            adapter = new SqlDataAdapter(query, conn);

            sql.Parameters.Add("@p1", SqlDbType.Int, 0, "Id");
            sql.Parameters.Add("@p2", SqlDbType.NVarChar, 25, "LastName");
            sql.Parameters.Add("@p3", SqlDbType.NVarChar, 15);
            sql.Parameters["@p3"].SourceColumn = "FirstName";
            adapter.InsertCommand = sql;

            resultDataGrid.DataSource = null;
            cmd = new(adapter);
            adapter.Fill(dataSet, "authors");

            resultDataGrid.DataSource = dataSet.Tables["authors"];
            queryTextBox.Clear();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {


            adapter.Update(dataSet, "authors");
            //            MessageBox.Show($@"{cmd.GetInsertCommand().CommandText}

            //{cmd.GetUpdateCommand().CommandText}

            //{cmd.GetDeleteCommand().CommandText}");
        }
    }

}
