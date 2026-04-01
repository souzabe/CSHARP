namespace Aula1002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello World");
            if(txtNome.Text =="fiap")
            {
                Menu telaMenu = new Menu();
                telaMenu.Show();
            }
            else
            {
                MessageBox.Show("Usuario ou senha inválidos");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Olá, estou na FIAP", "FIAP");
        }
    }
}
