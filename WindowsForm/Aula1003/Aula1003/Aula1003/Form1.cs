namespace Aula1003
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            TelaUsuario telausuario = new TelaUsuario();

            telausuario.Show();
        }
    }
}
