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
    public partial class ComprarGames : Form {

        Model.CsUsuario usuario = new Model.CsUsuario();
        public ComprarGames(Model.CsUsuario usuario) {
            InitializeComponent();
            this.usuario = usuario;
            ListarCategoriaCmb();
            UpdateDgv();
        }

        public int SplitarCategoria(string empres) {

            string linha = empres;
            string numero = linha.Split('-')[0].Trim();
            return int.Parse(numero);
        }

        public void UpdateDgv() {

            Model.CsJogos csJogos = new Model.CsJogos();

            if (cmbGame.Text == "") {
                lblPreco.Text = "R$";
            }
            else {

                csJogos.Id = SplitarCategoria(cmbGame.Text);

                DataTable dt = new DataTable();

                dt = csJogos.ListarCompra();

                double preco = double.Parse(dt.Rows[0]["Preco"].ToString());

                lblPreco.Text = $"R$ {preco}";

                btnComprar.Enabled = true;
            }
        
        }

        public void ListarCategoriaCmb() {

            Model.CsJogos category = new Model.CsJogos();

            DataTable table = category.Listar();

            foreach (DataRow dr in table.Rows) {

                cmbGame.Items.Add($"{dr["id"]} - {dr["nome"]}"); 

            }

            Model.CsFormasDePagamento category2 = new Model.CsFormasDePagamento();

            DataTable table2 = category2.Listar();

            foreach (DataRow dr2 in table2.Rows) {

                cmbMetodo.Items.Add($"{dr2["id"]} - {dr2["nome"]}");

            }

        }

        private void cmbGame_Click(object sender, EventArgs e) {
            UpdateDgv();
        }

        private void btnComprar_Click(object sender, EventArgs e) {

            DialogResult r = MessageBox.Show($"tem certeza que deseja comprar esse jogo ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes) {

                if (cmbGame.Text == "") {
                    MessageBox.Show("selecione um jogo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (cmbMetodo.Text == "") {
                    MessageBox.Show("selecione um metodo de pagamento", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {

                    Model.CsTransacoes csTransacoes = new Model.CsTransacoes();

                    csTransacoes.ClienteId = usuario.Id;
                    csTransacoes.PagamentoId = SplitarCategoria(cmbMetodo.Text);
                    csTransacoes.GameId = SplitarCategoria(cmbGame.Text);

                    if (csTransacoes.Cadastrar()) {
                        MessageBox.Show("jogo comprado com sucesso! ", "Ok!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        btnComprar.Enabled = false;

                    }
                    else {
                        MessageBox.Show("erro ao comprar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
        }

        private void cmbGame_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateDgv();
        }
    }
}
