using System.Data;
using System.Data.SqlClient;

namespace ADO_03._DataTable
{
    public partial class Form1 : Form
    {
        private SqlConnection conn;
        private DataTable table;
        private SqlDataReader reader;
        string cs = @"Server = (localdb)\MSSQLLocalDB; Integrated Security = SSPI; Database = Library";
        public Form1()
        {
            InitializeComponent();
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = queryTextBox.Text;
                cmd.Connection = conn;
                myDataGrid.DataSource = null;
                conn.Open();
                table = new DataTable();
                reader = cmd.ExecuteReader();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    table.Columns.Add(reader.GetName(i));
                }
                DataRow row;
                while (reader.Read())
                {
                    row = table.NewRow();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        row[i] = reader[i];
                    }
                    table.Rows.Add(row);

                }
            }
            myDataGrid.DataSource = table;
        }
    }
}
