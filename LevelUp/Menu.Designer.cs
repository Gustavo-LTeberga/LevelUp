namespace LevelUp {
    partial class Menu {
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
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnEmpresa = new System.Windows.Forms.Button();
            this.btnJogos = new System.Windows.Forms.Button();
            this.btnTransacoes = new System.Windows.Forms.Button();
            this.lblOi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUsuario
            // 
            this.btnUsuario.Location = new System.Drawing.Point(29, 156);
            this.btnUsuario.Margin = new System.Windows.Forms.Padding(6);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(396, 59);
            this.btnUsuario.TabIndex = 0;
            this.btnUsuario.Text = "Usuario";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.Location = new System.Drawing.Point(437, 156);
            this.btnEmpresa.Margin = new System.Windows.Forms.Padding(6);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Size = new System.Drawing.Size(357, 59);
            this.btnEmpresa.TabIndex = 1;
            this.btnEmpresa.Text = "Empresa";
            this.btnEmpresa.UseVisualStyleBackColor = true;
            this.btnEmpresa.Click += new System.EventHandler(this.btnEmpresa_Click);
            // 
            // btnJogos
            // 
            this.btnJogos.Location = new System.Drawing.Point(29, 227);
            this.btnJogos.Margin = new System.Windows.Forms.Padding(6);
            this.btnJogos.Name = "btnJogos";
            this.btnJogos.Size = new System.Drawing.Size(396, 59);
            this.btnJogos.TabIndex = 2;
            this.btnJogos.Text = "Jogos";
            this.btnJogos.UseVisualStyleBackColor = true;
            this.btnJogos.Click += new System.EventHandler(this.btnJogos_Click);
            // 
            // btnTransacoes
            // 
            this.btnTransacoes.Location = new System.Drawing.Point(437, 227);
            this.btnTransacoes.Margin = new System.Windows.Forms.Padding(6);
            this.btnTransacoes.Name = "btnTransacoes";
            this.btnTransacoes.Size = new System.Drawing.Size(357, 59);
            this.btnTransacoes.TabIndex = 3;
            this.btnTransacoes.Text = "Transações";
            this.btnTransacoes.UseVisualStyleBackColor = true;
            this.btnTransacoes.Click += new System.EventHandler(this.btnTransacoes_Click);
            // 
            // lblOi
            // 
            this.lblOi.AutoSize = true;
            this.lblOi.Location = new System.Drawing.Point(253, 80);
            this.lblOi.Name = "lblOi";
            this.lblOi.Size = new System.Drawing.Size(43, 24);
            this.lblOi.TabIndex = 4;
            this.lblOi.Text = "Ola";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 383);
            this.Controls.Add(this.lblOi);
            this.Controls.Add(this.btnTransacoes);
            this.Controls.Add(this.btnJogos);
            this.Controls.Add(this.btnEmpresa);
            this.Controls.Add(this.btnUsuario);
            this.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnEmpresa;
        private System.Windows.Forms.Button btnJogos;
        private System.Windows.Forms.Button btnTransacoes;
        private System.Windows.Forms.Label lblOi;
    }
}