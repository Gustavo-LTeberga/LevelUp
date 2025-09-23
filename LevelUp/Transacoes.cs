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
    public partial class Transacoes : Form {
        Model.CsUsuario usuario = new Model.CsUsuario();
        public Transacoes(Model.CsUsuario usuario) {
            InitializeComponent();
            this.usuario = usuario;
            UpdateDgv();
        }

        public void UpdateDgv() {
            Model.CsTransacoes transacoes = new Model.CsTransacoes();

            dgvEmpresas.DataSource = transacoes.Listar();

        }
    }
}
