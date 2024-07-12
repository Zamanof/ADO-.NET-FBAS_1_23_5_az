using System.Data;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.Windows.Forms.Design;

namespace ADO_03._Picture_in_Database
{
    public partial class Form1 : Form
    {
        private SqlConnection conn = null!;
        private SqlDataAdapter adapter = null!;
        private DataSet dataSet = null!;
        private SqlCommandBuilder cmd = null!;
        private string fileName = "";
        string cs = @"Server = (localdb)\MSSQLLocalDB; 
                        Integrated Security = SSPI; Database = MyLibrary";

        public Form1()
        {
            InitializeComponent();
            conn = new(cs);
        }

        private void loadPictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Pictures|*.bmp;*.jpg;*.jpeg;*.png";
            openFileDialog.FileName = "";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
                LoadPicture();
            }
        }

        private void LoadPicture()
        {
            try
            {
                conn.Open();
                byte[] bytes;
                bytes = CreateCopy();
                SqlCommand command = new SqlCommand("INSERT INTO Pictures(BookId, [Name], Picture)" +
                    "VALUES(@bookId, @name, @picture)", conn);
                if (idTextBox.Text == null || idTextBox.Text.Length == 0) return;
                int index = -1;
                int.TryParse(idTextBox.Text, out index);
                if (index == -1) return;
                command.Parameters.Add("@bookId", SqlDbType.Int).Value = index;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = fileName;
                command.Parameters.Add("@picture", SqlDbType.Image, bytes.Length).Value = bytes;
                command.ExecuteNonQuery();
                idTextBox.Clear();

            }
            finally
            {
                if (conn != null) conn.Close();
            }
        }

        private byte[] CreateCopy()
        {
            Image image = Image.FromFile(fileName);
            int maxWidth = 300, maxHeight = 300;
            double ratioX = (double)maxWidth / image.Width;
            double ratioY = (double)maxHeight / image.Height;
            double ratio = Math.Min(ratioX, ratioY);
            int newWidth = (int)(image.Width * ratio);
            int newHeight = (int)(image.Height * ratio);
            Image myImage = new Bitmap(newWidth, newHeight);
            Graphics graphics = Graphics.FromImage(myImage);
            graphics.DrawImage(image, 0, 0, newWidth, newHeight);
            MemoryStream ms = new();
            myImage.Save(ms, ImageFormat.Jpeg);
            ms.Flush();
            ms.Seek(0, SeekOrigin.Begin);
            BinaryReader reader = new BinaryReader(ms);
            byte[] bytes = reader.ReadBytes((int)ms.Length);
            return bytes;
        }

        private void showAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("SELECT * FROM Pictures", conn);
            cmd = new(adapter);
            adapter.Fill(dataSet, "pictures");
            picturesGridView.DataSource = dataSet.Tables["pictures"];
        }

        private void showOneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text == null || idTextBox.Text.Length == 0)
                MessageBox.Show("Enter book Id please");
            int index = -1;
            int.TryParse(idTextBox.Text, out index);
            if(index == -1)
            {
                MessageBox.Show("Enter correct book Id please");
                return;
            }
            adapter = new SqlDataAdapter("SELECT Picture FROM Pictures WHERE BookId=@id", conn);
            cmd = new SqlCommandBuilder(adapter);
            adapter.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = index;
            dataSet = new();
            adapter.Fill(dataSet);
            byte[] bytes = (byte[])dataSet.Tables[0].Rows[0]["picture"];
            MemoryStream ms = new(bytes);
            bookCoverPictureBox.Image = Image.FromStream(ms);
            idTextBox.Clear();
        }
    }
}
