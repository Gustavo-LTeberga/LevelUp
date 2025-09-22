namespace LevelUp {
    partial class Usuario {
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
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.grbUsuario = new System.Windows.Forms.GroupBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.grbUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.AllowUserToAddRows = false;
            this.dgvUsuario.AllowUserToDeleteRows = false;
            this.dgvUsuario.AllowUserToResizeColumns = false;
            this.dgvUsuario.AllowUserToResizeRows = false;
            this.dgvUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Location = new System.Drawing.Point(15, 15);
            this.dgvUsuario.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.ReadOnly = true;
            this.dgvUsuario.Size = new System.Drawing.Size(853, 262);
            this.dgvUsuario.TabIndex = 0;
            this.dgvUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuario_CellClick);
            // 
            // grbUsuario
            // 
            this.grbUsuario.Controls.Add(this.btnUsuario);
            this.grbUsuario.Controls.Add(this.lblUsuario);
            this.grbUsuario.Enabled = false;
            this.grbUsuario.Location = new System.Drawing.Point(15, 287);
            this.grbUsuario.Name = "grbUsuario";
            this.grbUsuario.Size = new System.Drawing.Size(853, 100);
            this.grbUsuario.TabIndex = 1;
            this.grbUsuario.TabStop = false;
            this.grbUsuario.Text = "Ativar/Desativar Usuario";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(92, 42);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(93, 25);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            // 
            // btnUsuario
            // 
            this.btnUsuario.Location = new System.Drawing.Point(381, 22);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(472, 64);
            this.btnUsuario.TabIndex = 1;
            this.btnUsuario.Text = "Ativar/Desativar";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 400);
            this.Controls.Add(this.grbUsuario);
            this.Controls.Add(this.dgvUsuario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Usuario";
            this.Text = "Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.grbUsuario.ResumeLayout(false);
            this.grbUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.GroupBox grbUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnUsuario;
    }
}