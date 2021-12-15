namespace Sistema___Simulado
{
    partial class Notas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notas));
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboAno = new System.Windows.Forms.ComboBox();
            this.cboCurso = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboSimulado = new System.Windows.Forms.ComboBox();
            this.btnAcertos = new System.Windows.Forms.Button();
            this.dgvAcertos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcertos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.SystemColors.Window;
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFechar.Location = new System.Drawing.Point(362, 5);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(120, 54);
            this.btnFechar.TabIndex = 135;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Window;
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelar.Location = new System.Drawing.Point(12, 185);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 54);
            this.btnCancelar.TabIndex = 134;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCarregar
            // 
            this.btnCarregar.BackColor = System.Drawing.SystemColors.Window;
            this.btnCarregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCarregar.BackgroundImage")));
            this.btnCarregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCarregar.Enabled = false;
            this.btnCarregar.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCarregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCarregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCarregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarregar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregar.Location = new System.Drawing.Point(12, 65);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(120, 54);
            this.btnCarregar.TabIndex = 130;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCarregar.UseVisualStyleBackColor = false;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 14);
            this.label2.TabIndex = 127;
            this.label2.Text = "Ano:";
            // 
            // cboAno
            // 
            this.cboAno.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cboAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboAno.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.cboAno.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cboAno.FormattingEnabled = true;
            this.cboAno.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cboAno.Location = new System.Drawing.Point(15, 25);
            this.cboAno.Name = "cboAno";
            this.cboAno.Size = new System.Drawing.Size(77, 22);
            this.cboAno.TabIndex = 137;
            this.cboAno.SelectedIndexChanged += new System.EventHandler(this.cboAno_SelectedIndexChanged);
            // 
            // cboCurso
            // 
            this.cboCurso.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cboCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCurso.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.cboCurso.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cboCurso.FormattingEnabled = true;
            this.cboCurso.Location = new System.Drawing.Point(188, 25);
            this.cboCurso.Name = "cboCurso";
            this.cboCurso.Size = new System.Drawing.Size(168, 22);
            this.cboCurso.TabIndex = 138;
            this.cboCurso.SelectedIndexChanged += new System.EventHandler(this.cboCurso_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.label1.Location = new System.Drawing.Point(95, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 14);
            this.label1.TabIndex = 139;
            this.label1.Text = "Simulado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.label3.Location = new System.Drawing.Point(185, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 14);
            this.label3.TabIndex = 140;
            this.label3.Text = "Curso:";
            // 
            // cboSimulado
            // 
            this.cboSimulado.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cboSimulado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSimulado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSimulado.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.cboSimulado.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cboSimulado.FormattingEnabled = true;
            this.cboSimulado.Location = new System.Drawing.Point(98, 25);
            this.cboSimulado.Name = "cboSimulado";
            this.cboSimulado.Size = new System.Drawing.Size(85, 22);
            this.cboSimulado.TabIndex = 141;
            this.cboSimulado.SelectedIndexChanged += new System.EventHandler(this.cboSimulado_SelectedIndexChanged);
            // 
            // btnAcertos
            // 
            this.btnAcertos.BackColor = System.Drawing.SystemColors.Window;
            this.btnAcertos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAcertos.BackgroundImage")));
            this.btnAcertos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAcertos.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAcertos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAcertos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAcertos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcertos.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcertos.Location = new System.Drawing.Point(12, 125);
            this.btnAcertos.Name = "btnAcertos";
            this.btnAcertos.Size = new System.Drawing.Size(120, 57);
            this.btnAcertos.TabIndex = 146;
            this.btnAcertos.Text = "Acertos  ";
            this.btnAcertos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAcertos.UseVisualStyleBackColor = false;
            this.btnAcertos.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvAcertos
            // 
            this.dgvAcertos.AllowUserToAddRows = false;
            this.dgvAcertos.AllowUserToDeleteRows = false;
            this.dgvAcertos.AllowUserToOrderColumns = true;
            this.dgvAcertos.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dgvAcertos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcertos.GridColor = System.Drawing.Color.Black;
            this.dgvAcertos.Location = new System.Drawing.Point(142, 65);
            this.dgvAcertos.Name = "dgvAcertos";
            this.dgvAcertos.ReadOnly = true;
            this.dgvAcertos.Size = new System.Drawing.Size(214, 174);
            this.dgvAcertos.TabIndex = 147;
            this.dgvAcertos.Visible = false;
            // 
            // Notas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(487, 250);
            this.ControlBox = false;
            this.Controls.Add(this.btnAcertos);
            this.Controls.Add(this.dgvAcertos);
            this.Controls.Add(this.cboSimulado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboCurso);
            this.Controls.Add(this.cboAno);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.label2);
            this.Name = "Notas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notas";
            this.Load += new System.EventHandler(this.frmNotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcertos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboAno;
        private System.Windows.Forms.ComboBox cboCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboSimulado;
        private System.Windows.Forms.Button btnAcertos;
        private System.Windows.Forms.DataGridView dgvAcertos;
    }
}