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
    public partial class Jogos : Form {
        Model.CsUsuario usuario = new Model.CsUsuario();

        int selectedID = 0;

        public Jogos(Model.CsUsuario usuario) {
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
        public void ListarCategoriaCmb() {

            Model.CsEmpresa category = new Model.CsEmpresa();

            DataTable table = category.Listar();

            foreach (DataRow dr in table.Rows) {

                cmbEmpresaCadastrar.Items.Add($"{dr["id"]} - {dr["nome"]}");
                cmbEmpresaEditar.Items.Add($"{dr["id"]} - {dr["nome"]}");

            }

        }
        public void UpdateDgv() {

            Model.CsJogos game = new Model.CsJogos();

            dgvGames.DataSource = game.Listar();
        }

        private void dgvGames_CellClick(object sender, DataGridViewCellEventArgs e) {

            int ls = dgvGames.SelectedCells[0].RowIndex;

            txbNomeEditar.Text = dgvGames.Rows[ls].Cells[1].Value.ToString();
            txbPrecoEditar.Text = dgvGames.Rows[ls].Cells[3].Value.ToString();
            txbAnoEditar.Text = dgvGames.Rows[ls].Cells[2].Value.ToString();


            selectedID = (int)dgvGames.Rows[ls].Cells[0].Value;

            grbGamesEditar.Enabled = true;

            grbComercio.Enabled = true;

        }

        private void btnComercio_Click(object sender, EventArgs e) {

            DialogResult r = MessageBox.Show($"tem certeza que Ativar Ou Desativar o comercio desse jogo ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes) {

                Model.CsJogos gameRegistrado = new Model.CsJogos();

                int ls = dgvGames.SelectedCells[0].RowIndex;

                gameRegistrado.Comercio = (bool)dgvGames.Rows[ls].Cells[5].Value;

                gameRegistrado.Id = selectedID;

                if (!gameRegistrado.Comercio) {

                    gameRegistrado.Ativar();
                    ResetarCampos();

                }
                else {

                    gameRegistrado.Desativar();
                    ResetarCampos();
                }

            }

            UpdateDgv();
        }

        private void btnCadastrar_Click(object sender, EventArgs e) {
            if (txbNomeCadastrar.Text.Length < 2) {
                MessageBox.Show("o nome deve ter no minimo 2 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbNomeCadastrar.Text.Length < 4) {
                MessageBox.Show("Ano deve ter no minimo 4 caracteres", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbEmpresaCadastrar.Text == "") {
                MessageBox.Show("selecione uma empresa", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                Model.CsJogos gameRegistrado = new Model.CsJogos();

                gameRegistrado.Nome = txbNomeCadastrar.Text;
                gameRegistrado.Preco = double.Parse(txbPrecoCadastrar.Text);
                gameRegistrado.EmpresaId = SplitarCategoria(cmbEmpresaCadastrar.Text);
                gameRegistrado.Ano = int.Parse(txbAnoCadastrar.Text); 

                if (gameRegistrado.Cadastrar()) {
                    MessageBox.Show("jogo cadastrado com sucesso! ", "Ok!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    UpdateDgv();
                    txbNomeCadastrar.Clear();
                    txbPrecoCadastrar.Clear();
                    txbAnoCadastrar.Clear();
                }
                else {
                    MessageBox.Show("erro ao cadastrar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }
        public void ResetarCampos() {

            UpdateDgv();
            txbNomeEditar.Clear();
            txbPrecoEditar.Clear();
            txbAnoEditar.Clear();

            selectedID = 0;

            grbComercio.Enabled = false;
            grbGamesEditar.Enabled = false;

        }

        private void btnEditar_Click(object sender, EventArgs e) {
            if (txbNomeEditar.Text.Length < 2) {
                MessageBox.Show("o nome deve ter no minimo 2 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbNomeEditar.Text.Length < 4) {
                MessageBox.Show("Ano deve ter no minimo 4 caracteres", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbEmpresaEditar.Text == "") {
                MessageBox.Show("selecione uma empresa", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                Model.CsJogos gameRegistrado = new Model.CsJogos();

                gameRegistrado.Id = selectedID;
                gameRegistrado.Nome = txbNomeEditar.Text;
                gameRegistrado.Preco = double.Parse(txbPrecoEditar.Text);
                gameRegistrado.EmpresaId = SplitarCategoria(cmbEmpresaEditar.Text);
                gameRegistrado.Ano = int.Parse(txbAnoEditar.Text);

                if (gameRegistrado.Modificar()) {
                    MessageBox.Show("jogo editado com sucesso! ", "Ok!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    ResetarCampos();
                    UpdateDgv();
                    txbNomeEditar.Clear();
                    txbPrecoEditar.Clear();
                    txbAnoEditar.Clear();
                }
                else {
                    MessageBox.Show("erro ao editar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
