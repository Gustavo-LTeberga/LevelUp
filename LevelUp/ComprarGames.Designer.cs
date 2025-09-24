namespace LevelUp {
    partial class ComprarGames {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComprarGames));
            this.lblGame = new System.Windows.Forms.Label();
            this.cmbGame = new System.Windows.Forms.ComboBox();
            this.cmbMetodo = new System.Windows.Forms.ComboBox();
            this.lblMetodo = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.btnComprar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGame
            // 
            this.lblGame.AutoSize = true;
            this.lblGame.BackColor = System.Drawing.Color.Transparent;
            this.lblGame.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblGame.Location = new System.Drawing.Point(181, 107);
            this.lblGame.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblGame.Name = "lblGame";
            this.lblGame.Size = new System.Drawing.Size(51, 24);
            this.lblGame.TabIndex = 0;
            this.lblGame.Text = "Jogo";
            // 
            // cmbGame
            // 
            this.cmbGame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGame.FormattingEnabled = true;
            this.cmbGame.Location = new System.Drawing.Point(241, 107);
            this.cmbGame.Name = "cmbGame";
            this.cmbGame.Size = new System.Drawing.Size(227, 32);
            this.cmbGame.TabIndex = 1;
            this.cmbGame.SelectedIndexChanged += new System.EventHandler(this.cmbGame_SelectedIndexChanged);
            this.cmbGame.Click += new System.EventHandler(this.cmbGame_Click);
            // 
            // cmbMetodo
            // 
            this.cmbMetodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMetodo.FormattingEnabled = true;
            this.cmbMetodo.Location = new System.Drawing.Point(359, 145);
            this.cmbMetodo.Name = "cmbMetodo";
            this.cmbMetodo.Size = new System.Drawing.Size(148, 32);
            this.cmbMetodo.TabIndex = 3;
            // 
            // lblMetodo
            // 
            this.lblMetodo.AutoSize = true;
            this.lblMetodo.BackColor = System.Drawing.Color.Transparent;
            this.lblMetodo.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblMetodo.Location = new System.Drawing.Point(133, 148);
            this.lblMetodo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMetodo.Name = "lblMetodo";
            this.lblMetodo.Size = new System.Drawing.Size(217, 24);
            this.lblMetodo.TabIndex = 2;
            this.lblMetodo.Text = "Metodo De Pagamento";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.BackColor = System.Drawing.Color.Transparent;
            this.lblPreco.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblPreco.Location = new System.Drawing.Point(133, 186);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(39, 24);
            this.lblPreco.TabIndex = 7;
            this.lblPreco.Text = "R$";
            // 
            // btnComprar
            // 
            this.btnComprar.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnComprar.Enabled = false;
            this.btnComprar.Location = new System.Drawing.Point(137, 213);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(382, 45);
            this.btnComprar.TabIndex = 8;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = false;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // ComprarGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LevelUp.Properties.Resources.BackGroundLvlUp02;
            this.ClientSize = new System.Drawing.Size(652, 346);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.cmbMetodo);
            this.Controls.Add(this.lblMetodo);
            this.Controls.Add(this.cmbGame);
            this.Controls.Add(this.lblGame);
            this.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "ComprarGames";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComprarGames";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGame;
        private System.Windows.Forms.ComboBox cmbGame;
        private System.Windows.Forms.ComboBox cmbMetodo;
        private System.Windows.Forms.Label lblMetodo;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Button btnComprar;
    }
}