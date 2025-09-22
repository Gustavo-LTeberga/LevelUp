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
        public Jogos(Model.CsUsuario usuario) {
            InitializeComponent();
            this.usuario = usuario;
        }
    }
}
