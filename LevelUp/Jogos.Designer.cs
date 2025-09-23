namespace LevelUp {
    partial class Jogos {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dgvGames = new System.Windows.Forms.DataGridView();
            this.grbGamesCadastrar = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblEmpresaCadastrar = new System.Windows.Forms.Label();
            this.cmbEmpresaCadastrar = new System.Windows.Forms.ComboBox();
            this.txbAnoCadastrar = new System.Windows.Forms.TextBox();
            this.lblAnoCadastrar = new System.Windows.Forms.Label();
            this.txbPrecoCadastrar = new System.Windows.Forms.TextBox();
            this.lblPrecoCadastrar = new System.Windows.Forms.Label();
            this.txbNomeCadastrar = new System.Windows.Forms.TextBox();
            this.lblNomeCadastrar = new System.Windows.Forms.Label();
            this.grbGamesEditar = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblEmpresaEditar = new System.Windows.Forms.Label();
            this.cmbEmpresaEditar = new System.Windows.Forms.ComboBox();
            this.txbAnoEditar = new System.Windows.Forms.TextBox();
            this.lblAnoEditar = new System.Windows.Forms.Label();
            this.txbPrecoEditar = new System.Windows.Forms.TextBox();
            this.lblPrecoEditar = new System.Windows.Forms.Label();
            this.txbNomeEditar = new System.Windows.Forms.TextBox();
            this.lblNomeEditar = new System.Windows.Forms.Label();
            this.grbComercio = new System.Windows.Forms.GroupBox();
            this.btnComercio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGames)).BeginInit();
            this.grbGamesCadastrar.SuspendLayout();
            this.grbGamesEditar.SuspendLayout();
            this.grbComercio.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGames
            // 
            this.dgvGames.AllowUserToAddRows = false;
            this.dgvGames.AllowUserToDeleteRows = false;
            this.dgvGames.AllowUserToResizeColumns = false;
            this.dgvGames.AllowUserToResizeRows = false;
            this.dgvGames.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGames.Location = new System.Drawing.Point(30, 15);
            this.dgvGames.Margin = new System.Windows.Forms.Padding(6);
            this.dgvGames.Name = "dgvGames";
            this.dgvGames.ReadOnly = true;
            this.dgvGames.Size = new System.Drawing.Size(958, 289);
            this.dgvGames.TabIndex = 0;
            this.dgvGames.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGames_CellClick);
            // 
            // grbGamesCadastrar
            // 
            this.grbGamesCadastrar.Controls.Add(this.btnCadastrar);
            this.grbGamesCadastrar.Controls.Add(this.lblEmpresaCadastrar);
            this.grbGamesCadastrar.Controls.Add(this.cmbEmpresaCadastrar);
            this.grbGamesCadastrar.Controls.Add(this.txbAnoCadastrar);
            this.grbGamesCadastrar.Controls.Add(this.lblAnoCadastrar);
            this.grbGamesCadastrar.Controls.Add(this.txbPrecoCadastrar);
            this.grbGamesCadastrar.Controls.Add(this.lblPrecoCadastrar);
            this.grbGamesCadastrar.Controls.Add(this.txbNomeCadastrar);
            this.grbGamesCadastrar.Controls.Add(this.lblNomeCadastrar);
            this.grbGamesCadastrar.Location = new System.Drawing.Point(30, 316);
            this.grbGamesCadastrar.Margin = new System.Windows.Forms.Padding(6);
            this.grbGamesCadastrar.Name = "grbGamesCadastrar";
            this.grbGamesCadastrar.Padding = new System.Windows.Forms.Padding(6);
            this.grbGamesCadastrar.Size = new System.Drawing.Size(373, 215);
            this.grbGamesCadastrar.TabIndex = 1;
            this.grbGamesCadastrar.TabStop = false;
            this.grbGamesCadastrar.Text = "CadastrarGame";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(13, 170);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(351, 36);
            this.btnCadastrar.TabIndex = 9;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblEmpresaCadastrar
            // 
            this.lblEmpresaCadastrar.AutoSize = true;
            this.lblEmpresaCadastrar.Location = new System.Drawing.Point(9, 135);
            this.lblEmpresaCadastrar.Name = "lblEmpresaCadastrar";
            this.lblEmpresaCadastrar.Size = new System.Drawing.Size(91, 24);
            this.lblEmpresaCadastrar.TabIndex = 6;
            this.lblEmpresaCadastrar.Text = "Empresa";
            // 
            // cmbEmpresaCadastrar
            // 
            this.cmbEmpresaCadastrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpresaCadastrar.FormattingEnabled = true;
            this.cmbEmpresaCadastrar.Location = new System.Drawing.Point(106, 132);
            this.cmbEmpresaCadastrar.Name = "cmbEmpresaCadastrar";
            this.cmbEmpresaCadastrar.Size = new System.Drawing.Size(258, 32);
            this.cmbEmpresaCadastrar.TabIndex = 2;
            // 
            // txbAnoCadastrar
            // 
            this.txbAnoCadastrar.Location = new System.Drawing.Point(175, 96);
            this.txbAnoCadastrar.Name = "txbAnoCadastrar";
            this.txbAnoCadastrar.Size = new System.Drawing.Size(189, 30);
            this.txbAnoCadastrar.TabIndex = 5;
            // 
            // lblAnoCadastrar
            // 
            this.lblAnoCadastrar.AutoSize = true;
            this.lblAnoCadastrar.Location = new System.Drawing.Point(9, 99);
            this.lblAnoCadastrar.Name = "lblAnoCadastrar";
            this.lblAnoCadastrar.Size = new System.Drawing.Size(167, 24);
            this.lblAnoCadastrar.TabIndex = 4;
            this.lblAnoCadastrar.Text = "Ano Lançamento";
            // 
            // txbPrecoCadastrar
            // 
            this.txbPrecoCadastrar.Location = new System.Drawing.Point(77, 60);
            this.txbPrecoCadastrar.Name = "txbPrecoCadastrar";
            this.txbPrecoCadastrar.Size = new System.Drawing.Size(287, 30);
            this.txbPrecoCadastrar.TabIndex = 3;
            // 
            // lblPrecoCadastrar
            // 
            this.lblPrecoCadastrar.AutoSize = true;
            this.lblPrecoCadastrar.Location = new System.Drawing.Point(9, 63);
            this.lblPrecoCadastrar.Name = "lblPrecoCadastrar";
            this.lblPrecoCadastrar.Size = new System.Drawing.Size(62, 24);
            this.lblPrecoCadastrar.TabIndex = 2;
            this.lblPrecoCadastrar.Text = "Preço";
            // 
            // txbNomeCadastrar
            // 
            this.txbNomeCadastrar.Location = new System.Drawing.Point(77, 26);
            this.txbNomeCadastrar.Name = "txbNomeCadastrar";
            this.txbNomeCadastrar.Size = new System.Drawing.Size(287, 30);
            this.txbNomeCadastrar.TabIndex = 1;
            // 
            // lblNomeCadastrar
            // 
            this.lblNomeCadastrar.AutoSize = true;
            this.lblNomeCadastrar.Location = new System.Drawing.Point(9, 29);
            this.lblNomeCadastrar.Name = "lblNomeCadastrar";
            this.lblNomeCadastrar.Size = new System.Drawing.Size(62, 24);
            this.lblNomeCadastrar.TabIndex = 0;
            this.lblNomeCadastrar.Text = "Nome";
            // 
            // grbGamesEditar
            // 
            this.grbGamesEditar.Controls.Add(this.btnEditar);
            this.grbGamesEditar.Controls.Add(this.lblEmpresaEditar);
            this.grbGamesEditar.Controls.Add(this.cmbEmpresaEditar);
            this.grbGamesEditar.Controls.Add(this.txbAnoEditar);
            this.grbGamesEditar.Controls.Add(this.lblAnoEditar);
            this.grbGamesEditar.Controls.Add(this.txbPrecoEditar);
            this.grbGamesEditar.Controls.Add(this.lblPrecoEditar);
            this.grbGamesEditar.Controls.Add(this.txbNomeEditar);
            this.grbGamesEditar.Controls.Add(this.lblNomeEditar);
            this.grbGamesEditar.Enabled = false;
            this.grbGamesEditar.Location = new System.Drawing.Point(415, 316);
            this.grbGamesEditar.Margin = new System.Windows.Forms.Padding(6);
            this.grbGamesEditar.Name = "grbGamesEditar";
            this.grbGamesEditar.Padding = new System.Windows.Forms.Padding(6);
            this.grbGamesEditar.Size = new System.Drawing.Size(373, 215);
            this.grbGamesEditar.TabIndex = 7;
            this.grbGamesEditar.TabStop = false;
            this.grbGamesEditar.Text = "EditarGame";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(13, 170);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(351, 36);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblEmpresaEditar
            // 
            this.lblEmpresaEditar.AutoSize = true;
            this.lblEmpresaEditar.Location = new System.Drawing.Point(9, 135);
            this.lblEmpresaEditar.Name = "lblEmpresaEditar";
            this.lblEmpresaEditar.Size = new System.Drawing.Size(91, 24);
            this.lblEmpresaEditar.TabIndex = 6;
            this.lblEmpresaEditar.Text = "Empresa";
            // 
            // cmbEmpresaEditar
            // 
            this.cmbEmpresaEditar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpresaEditar.FormattingEnabled = true;
            this.cmbEmpresaEditar.Location = new System.Drawing.Point(106, 132);
            this.cmbEmpresaEditar.Name = "cmbEmpresaEditar";
            this.cmbEmpresaEditar.Size = new System.Drawing.Size(258, 32);
            this.cmbEmpresaEditar.TabIndex = 2;
            // 
            // txbAnoEditar
            // 
            this.txbAnoEditar.Location = new System.Drawing.Point(175, 96);
            this.txbAnoEditar.Name = "txbAnoEditar";
            this.txbAnoEditar.Size = new System.Drawing.Size(189, 30);
            this.txbAnoEditar.TabIndex = 5;
            // 
            // lblAnoEditar
            // 
            this.lblAnoEditar.AutoSize = true;
            this.lblAnoEditar.Location = new System.Drawing.Point(9, 99);
            this.lblAnoEditar.Name = "lblAnoEditar";
            this.lblAnoEditar.Size = new System.Drawing.Size(167, 24);
            this.lblAnoEditar.TabIndex = 4;
            this.lblAnoEditar.Text = "Ano Lançamento";
            // 
            // txbPrecoEditar
            // 
            this.txbPrecoEditar.Location = new System.Drawing.Point(77, 60);
            this.txbPrecoEditar.Name = "txbPrecoEditar";
            this.txbPrecoEditar.Size = new System.Drawing.Size(287, 30);
            this.txbPrecoEditar.TabIndex = 3;
            // 
            // lblPrecoEditar
            // 
            this.lblPrecoEditar.AutoSize = true;
            this.lblPrecoEditar.Location = new System.Drawing.Point(9, 63);
            this.lblPrecoEditar.Name = "lblPrecoEditar";
            this.lblPrecoEditar.Size = new System.Drawing.Size(62, 24);
            this.lblPrecoEditar.TabIndex = 2;
            this.lblPrecoEditar.Text = "Preço";
            // 
            // txbNomeEditar
            // 
            this.txbNomeEditar.Location = new System.Drawing.Point(77, 26);
            this.txbNomeEditar.Name = "txbNomeEditar";
            this.txbNomeEditar.Size = new System.Drawing.Size(287, 30);
            this.txbNomeEditar.TabIndex = 1;
            // 
            // lblNomeEditar
            // 
            this.lblNomeEditar.AutoSize = true;
            this.lblNomeEditar.Location = new System.Drawing.Point(9, 29);
            this.lblNomeEditar.Name = "lblNomeEditar";
            this.lblNomeEditar.Size = new System.Drawing.Size(62, 24);
            this.lblNomeEditar.TabIndex = 0;
            this.lblNomeEditar.Text = "Nome";
            // 
            // grbComercio
            // 
            this.grbComercio.Controls.Add(this.btnComercio);
            this.grbComercio.Enabled = false;
            this.grbComercio.Location = new System.Drawing.Point(799, 332);
            this.grbComercio.Name = "grbComercio";
            this.grbComercio.Size = new System.Drawing.Size(191, 181);
            this.grbComercio.TabIndex = 8;
            this.grbComercio.TabStop = false;
            this.grbComercio.Text = "Comercio";
            // 
            // btnComercio
            // 
            this.btnComercio.Location = new System.Drawing.Point(6, 29);
            this.btnComercio.Name = "btnComercio";
            this.btnComercio.Size = new System.Drawing.Size(179, 146);
            this.btnComercio.TabIndex = 0;
            this.btnComercio.Text = "Ativar/Desativar";
            this.btnComercio.UseVisualStyleBackColor = true;
            this.btnComercio.Click += new System.EventHandler(this.btnComercio_Click);
            // 
            // Jogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 557);
            this.Controls.Add(this.grbComercio);
            this.Controls.Add(this.grbGamesEditar);
            this.Controls.Add(this.grbGamesCadastrar);
            this.Controls.Add(this.dgvGames);
            this.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Jogos";
            this.Text = "Jogos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGames)).EndInit();
            this.grbGamesCadastrar.ResumeLayout(false);
            this.grbGamesCadastrar.PerformLayout();
            this.grbGamesEditar.ResumeLayout(false);
            this.grbGamesEditar.PerformLayout();
            this.grbComercio.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGames;
        private System.Windows.Forms.GroupBox grbGamesCadastrar;
        private System.Windows.Forms.Label lblNomeCadastrar;
        private System.Windows.Forms.Label lblEmpresaCadastrar;
        private System.Windows.Forms.ComboBox cmbEmpresaCadastrar;
        private System.Windows.Forms.TextBox txbAnoCadastrar;
        private System.Windows.Forms.Label lblAnoCadastrar;
        private System.Windows.Forms.TextBox txbPrecoCadastrar;
        private System.Windows.Forms.Label lblPrecoCadastrar;
        private System.Windows.Forms.TextBox txbNomeCadastrar;
        private System.Windows.Forms.GroupBox grbGamesEditar;
        private System.Windows.Forms.Label lblEmpresaEditar;
        private System.Windows.Forms.ComboBox cmbEmpresaEditar;
        private System.Windows.Forms.TextBox txbAnoEditar;
        private System.Windows.Forms.Label lblAnoEditar;
        private System.Windows.Forms.TextBox txbPrecoEditar;
        private System.Windows.Forms.Label lblPrecoEditar;
        private System.Windows.Forms.TextBox txbNomeEditar;
        private System.Windows.Forms.Label lblNomeEditar;
        private System.Windows.Forms.GroupBox grbComercio;
        private System.Windows.Forms.Button btnComercio;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnEditar;
    }
}