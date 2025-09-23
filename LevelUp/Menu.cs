using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LevelUp {
    public partial class Menu : Form {

        Model.CsUsuario usuario = new Model.CsUsuario();
        public Menu(Model.CsUsuario usuario) {
            
            InitializeComponent();

            this.usuario = usuario;

            lblOi.Text = $"Ola {usuario.Nome}!";

            if (usuario.Id != 1) {
                btnEmpresa.Visible = false;
                btnJogos.Visible = false;
                btnTransacoes.Visible = false;
                btnUsuario.Visible = false;
            }

        }

        private void btnUsuario_Click(object sender, EventArgs e) {
            Usuario formusuario = new Usuario(usuario);
            formusuario.ShowDialog();
        }

        private void btnEmpresa_Click(object sender, EventArgs e) {
            Empresas formempresas = new Empresas(usuario);
            formempresas.ShowDialog();
        }

        private void btnJogos_Click(object sender, EventArgs e) {
            Jogos formusuario = new Jogos(usuario);
            formusuario.ShowDialog();
        }

        private void btnTransacoes_Click(object sender, EventArgs e) {
            Transacoes formusuario = new Transacoes(usuario);
            formusuario.ShowDialog();
        }
    }
}
