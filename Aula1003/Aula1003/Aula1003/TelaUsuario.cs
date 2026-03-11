using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula1003
{
    public partial class TelaUsuario : Form
    {
        public TelaUsuario()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            List<Usuario> usuarios = carregarUsuarios();

            Usuario usuarioCadastrar = new Usuario();
            usuarioCadastrar.nome = txtNome.Text;
            usuarioCadastrar.senha = txtSenha.Text;
            usuarioCadastrar.email = txtEmail.Text;

            usuarios.Add(usuarioCadastrar);

            salvarUsuarios(usuarios);

            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = carregarUsuarios();
        }
        public List<Usuario> carregarUsuarios()
        {
            if (!File.Exists("usuarios.json"))
                return new List<Usuario>();

            string json = File.ReadAllText("Usuarios.json");

            return JsonSerializer.Deserialize<List<Usuario>>(json);
        }

        public void salvarUsuarios(List<Usuario> lista)
        {
            string json = JsonSerializer.Serialize(lista);
            File.WriteAllText("usuarios.json", json);
        }

        private void TelaUsuario_Load(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = carregarUsuarios();
        }
    }
}
