using System.Text.Json;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        List<Aluno> listaAlunos = new List<Aluno>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            aluno.id = int.Parse(txtCodigo.Text);
            aluno.nome = txtNome.Text;



            listaAlunos.Add(aluno);

            txtRM.Text = String.Empty;
            txtNome.Text = String.Empty;
            txtCodigo.Text = String.Empty;

            dgvAluno.DataSource = null;
            dgvAluno.DataSource = listaAlunos;

            MessageBox.Show("Aluno cadastrado com sucesso", "Fiap");
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            string url = $"https://viacep.com.br/ws/{txtCEP.Text}/json/";
            HttpClient cliente = new HttpClient();
            var json = await cliente.GetStringAsync(url);

            AlunoEndereco alunoEnd = new AlunoEndereco();
            alunoEnd = JsonSerializer.Deserialize<AlunoEndereco>(json);

            MessageBox.Show(alunoEnd.BairroAluno);

            txtBairro.Text = alunoEnd.BairroAluno;
            txtRua.Text = alunoEnd.RuaAluno;
        }
    }
}
