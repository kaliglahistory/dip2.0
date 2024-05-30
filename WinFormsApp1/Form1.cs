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
            Form1.ActiveForm.Hide();
            desctop MyForm2 = new desctop();
            MyForm2.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            Server MyForm2 = new Server();
            MyForm2.ShowDialog();
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
