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
    public partial class Usuario : Form {
        Model.CsUsuario usuario = new Model.CsUsuario();

        int selectedID = 0;

        public Usuario(Model.CsUsuario usuario) {
            InitializeComponent();
            this.usuario = usuario;
            UpdateDgv();
        }

        public void UpdateDgv() {
            dgvUsuario.DataSource = usuario.Listar();
        }

        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e) {

            int ls = dgvUsuario.SelectedCells[0].RowIndex;

            lblUsuario.Text = dgvUsuario.Rows[ls].Cells[1].Value.ToString();

            selectedID = (int)dgvUsuario.Rows[ls].Cells[0].Value;

            grbUsuario.Enabled = true;

        }

        private void btnUsuario_Click(object sender, EventArgs e) {

            DialogResult r = MessageBox.Show($"tem certeza que Ativar Ou Desativar o {lblUsuario.Text} ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes) {

                Model.CsUsuario usuarioRegistrado = new Model.CsUsuario();

                int ls = dgvUsuario.SelectedCells[0].RowIndex;

                usuarioRegistrado.Ativo = (bool)dgvUsuario.Rows[ls].Cells[3].Value;

                usuarioRegistrado.Id = selectedID;

                if (!usuarioRegistrado.Ativo) {

                    usuarioRegistrado.Ativar();

                }
                else {
                
                    usuarioRegistrado.Desativar();
                }

            }

            UpdateDgv();

        }
    }
}
