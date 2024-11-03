using System.Data.SqlClient;

namespace test_user_login_con_db
{
    public partial class Form1 : Form
    {

        private string connect = "Data Source=SOMONOR;Initial Catalog=DBASP;Integrated Security=True;";
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_pw.Text;
            if (Validation(username, password))
            {
                MessageBox.Show("Login Success");
            }
            else
            {
                MessageBox.Show("Login Fail");
            }
        }

        private bool Validation(string username, string password)
        {
            bool isAction = false;
            using(SqlConnection conn = new SqlConnection(connect))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(1) FROM tbl_user_login_charp WHERE username=@username AND passwordd=@password";// @ mean ney tha tang variable
                    using(SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username); // username refer to line 21
                        cmd.Parameters.AddWithValue("@password", password); // password refer to line 22
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        isAction = count > 0;
                    }
                }catch (Exception ex)
                {
                    MessageBox.Show("Error : "+ ex.Message);
                }
            }
            return isAction;
        }

    }
}
