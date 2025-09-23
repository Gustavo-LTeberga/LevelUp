using LevelUp.Model;
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
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e) {

            if (txbEmail.Text.Length < 6) {
                MessageBox.Show("digite um email válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbSenha.Text.Length < 4) {
                MessageBox.Show("digite uma senha válida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                Model.CsUsuario usuario = new Model.CsUsuario();

                usuario.Email = txbEmail.Text.ToLower();
                usuario.Senha = txbSenha.Text;

                DataTable result = usuario.Logar();

                if (result.Rows.Count == 0) {
                    MessageBox.Show("email ou senha inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    usuario.Id = int.Parse(result.Rows[0]["id"].ToString());
                    usuario.Nome = result.Rows[0]["Nome"].ToString();

                    Menu menuinicial = new Menu(usuario);
                    Hide();
                    menuinicial.ShowDialog();

                    Show();
                }

            }


        }

        private void btnCadastrar_Click(object sender, EventArgs e) {

            Model.CsUsuario usuario = new Model.CsUsuario();

                Cadastrar formcadastrar = new Cadastrar(usuario);
                formcadastrar.ShowDialog();
                Show();
            }


        }
    }
