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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnEmpresa = new System.Windows.Forms.Button();
            this.btnJogos = new System.Windows.Forms.Button();
            this.btnTransacoes = new System.Windows.Forms.Button();
            this.lblOi = new System.Windows.Forms.Label();
            this.btnComprar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUsuario.Location = new System.Drawing.Point(29, 156);
            this.btnUsuario.Margin = new System.Windows.Forms.Padding(6);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(396, 59);
            this.btnUsuario.TabIndex = 0;
            this.btnUsuario.Text = "Usuario";
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEmpresa.Location = new System.Drawing.Point(437, 156);
            this.btnEmpresa.Margin = new System.Windows.Forms.Padding(6);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Size = new System.Drawing.Size(357, 59);
            this.btnEmpresa.TabIndex = 1;
            this.btnEmpresa.Text = "Empresa";
            this.btnEmpresa.UseVisualStyleBackColor = false;
            this.btnEmpresa.Click += new System.EventHandler(this.btnEmpresa_Click);
            // 
            // btnJogos
            // 
            this.btnJogos.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnJogos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnJogos.Location = new System.Drawing.Point(29, 227);
            this.btnJogos.Margin = new System.Windows.Forms.Padding(6);
            this.btnJogos.Name = "btnJogos";
            this.btnJogos.Size = new System.Drawing.Size(396, 59);
            this.btnJogos.TabIndex = 2;
            this.btnJogos.Text = "Jogos";
            this.btnJogos.UseVisualStyleBackColor = false;
            this.btnJogos.Click += new System.EventHandler(this.btnJogos_Click);
            // 
            // btnTransacoes
            // 
            this.btnTransacoes.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnTransacoes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTransacoes.Location = new System.Drawing.Point(437, 227);
            this.btnTransacoes.Margin = new System.Windows.Forms.Padding(6);
            this.btnTransacoes.Name = "btnTransacoes";
            this.btnTransacoes.Size = new System.Drawing.Size(357, 59);
            this.btnTransacoes.TabIndex = 3;
            this.btnTransacoes.Text = "Transações";
            this.btnTransacoes.UseVisualStyleBackColor = false;
            this.btnTransacoes.Click += new System.EventHandler(this.btnTransacoes_Click);
            // 
            // lblOi
            // 
            this.lblOi.AutoSize = true;
            this.lblOi.BackColor = System.Drawing.Color.Transparent;
            this.lblOi.Font = new System.Drawing.Font("Modern No. 20", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOi.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblOi.Location = new System.Drawing.Point(30, 26);
            this.lblOi.Name = "lblOi";
            this.lblOi.Size = new System.Drawing.Size(180, 98);
            this.lblOi.TabIndex = 4;
            this.lblOi.Text = "Ola";
            // 
            // btnComprar
            // 
            this.btnComprar.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnComprar.Location = new System.Drawing.Point(68, 173);
            this.btnComprar.Margin = new System.Windows.Forms.Padding(6);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(711, 95);
            this.btnComprar.TabIndex = 5;
            this.btnComprar.Text = "Comprar Jogos";
            this.btnComprar.UseVisualStyleBackColor = false;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LevelUp.Properties.Resources.BackGroundLvlUp01;
            this.ClientSize = new System.Drawing.Size(830, 383);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.lblOi);
            this.Controls.Add(this.btnTransacoes);
            this.Controls.Add(this.btnJogos);
            this.Controls.Add(this.btnEmpresa);
            this.Controls.Add(this.btnUsuario);
            this.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button btnComprar;
    }
}