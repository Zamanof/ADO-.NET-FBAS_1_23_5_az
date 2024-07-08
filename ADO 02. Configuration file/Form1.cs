using System.Configuration;
using System.Data.SqlClient;

namespace ADO_02._Configuration_file
{
    public partial class Form1 : Form
    {
        List<Authors> authors = new List<Authors> ();
        string connectionString = ConfigurationManager
                                .ConnectionStrings["MyConnectionString"]
                                .ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }

        private void MyLoad(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Authors", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    authors.Add(new Authors
                    {
                        Id = (int)reader[0],
                        FirstName = reader[1].ToString(),
                        LastName = reader[2].ToString()
                    });
                }
            }
            listBox1.DataSource = authors;
        }
    }
}
