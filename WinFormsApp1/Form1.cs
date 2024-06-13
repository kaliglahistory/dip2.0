using _2;
using Microsoft.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.f1 = f1;

        }
        private desctop f1;

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.ToString();
            string password = textBox2.ToString();
            DB dB = new DB();
            string qeripass = $" select pasword from dbo.usersA ";
            SqlCommand command = new SqlCommand(qeripass, dB.GetConnection());
            string qeriueser = $" select ueser from dbo.usersA ";
            SqlCommand commandu = new SqlCommand(qeriueser, dB.GetConnection());
            dB.openConnection();
            string login = commandu.ToString();
            string key = command.ToString();
            SqlDataReader reader = command.ExecuteReader();
           
            if (user == login && key == password)
            {
                Form1.ActiveForm.Hide();
                Server MyForm2 = new Server();
                MyForm2.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Неправильный пароль или логин");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            desctop MyForm2 = new desctop();
            MyForm2.ShowDialog();
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
