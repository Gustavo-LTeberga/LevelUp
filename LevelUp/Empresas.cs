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
    public partial class Empresas : Form {

        int selectedID = 0;

        Model.CsUsuario usuario = new Model.CsUsuario();
        public Empresas(Model.CsUsuario usuario) {
            InitializeComponent();
            this.usuario = usuario;
            UpdateDgv();
        }

        public void UpdateDgv() {

            Model.CsEmpresas empresas = new Model.CsEmpresas();

            dgvEmpresas.DataSource = empresas.Listar();
        }

        private void dgvEmpresas_CellClick(object sender, DataGridViewCellEventArgs e) {

            int ls = dgvEmpresas.SelectedCells[0].RowIndex;

            txbNomeEditar.Text = dgvEmpresas.Rows[ls].Cells[1].Value.ToString();

            selectedID = (int)dgvEmpresas.Rows[ls].Cells[0].Value;

            grbEditar.Enabled = true;

        }

        private void btnCadastrar_Click(object sender, EventArgs e) {

            if (txbNomeCadastrar.Text.Length < 2) {
                MessageBox.Show("o nome deve ter no minimo 2 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                Model.CsEmpresas empresaRegistrado = new Model.CsEmpresas();

                empresaRegistrado.Nome = txbNomeCadastrar.Text;

                if (empresaRegistrado.Cadastrar()) {
                    MessageBox.Show("empresa cadastrado com sucesso! ", "Ok!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    UpdateDgv();
                    txbNomeCadastrar.Clear();
             
                }
                else {
                    MessageBox.Show("erro ao cadastrar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        public void ResetarCampos() {

            UpdateDgv();
            txbNomeEditar.Clear();

            selectedID = 0;

            grbEditar.Enabled = false;

        }

        private void btnEditar_Click(object sender, EventArgs e) {

            DialogResult r = MessageBox.Show($"tem certeza que deseja editar essa empresa ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes) {
                if (txbNomeEditar.Text.Length < 2) {
                    MessageBox.Show("o nome deve ter no minimo 2 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    Model.CsEmpresas empresaRegistrado = new Model.CsEmpresas();

                    empresaRegistrado.Id = selectedID;
                    empresaRegistrado.Nome = txbNomeEditar.Text;

                    if (empresaRegistrado.Modificar()) {
                        MessageBox.Show("Empresa editado com sucesso! ", "Ok!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        ResetarCampos();
                        UpdateDgv();
                        txbNomeEditar.Clear();

                    }
                    else {
                        MessageBox.Show("erro ao editar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
        }
    }
}
