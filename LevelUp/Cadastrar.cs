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
    public partial class Cadastrar : Form {

        Model.CsUsuario usuario = new Model.CsUsuario();

        int selectedID = 0;

        public Cadastrar(Model.CsUsuario usuario) {
            InitializeComponent();

            this.usuario = usuario;
        }

        private void btnCadastrar_Click(object sender, EventArgs e) {

            if (txbNome.Text.Length < 5) {
                MessageBox.Show("o nome deve ter no minimo 5 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbEmail.Text.Length < 7) {
                MessageBox.Show("o nome deve ter no minimo 7 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbSenha.Text.Length < 6) {
                MessageBox.Show("o nome deve ter no minimo 6 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbSenha.Text != txbConfirmarSenha.Text) {
                MessageBox.Show("senha confirmada errada, verificar novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                Model.CsUsuario registrarUsuario = new Model.CsUsuario();

                registrarUsuario.Nome = txbNome.Text;
                registrarUsuario.Email = txbEmail.Text.ToLower();
                registrarUsuario.Senha = txbSenha.Text;

                if (registrarUsuario.Cadastrar()) {
                    MessageBox.Show("usuario cadastrado com sucesso! ", "Ok!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else {
                    MessageBox.Show("erro ao cadastrar! usuario com o mesmo email", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }
    }
}
