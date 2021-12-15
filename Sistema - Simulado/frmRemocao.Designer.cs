namespace Sistema___Simulado
{
    partial class frmRemocao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRemocao));
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.cboProva = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboSimulado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotal_linhas = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotal_alunos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.btnFechar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFechar.Location = new System.Drawing.Point(271, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(120, 54);
            this.btnFechar.TabIndex = 143;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.SystemColors.Window;
            this.btnAtualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.BackgroundImage")));
            this.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAtualizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAtualizar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnAtualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAtualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(12, 12);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(157, 54);
            this.btnAtualizar.TabIndex = 145;
            this.btnAtualizar.Text = "Atualizar Alunos";
            this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.SystemColors.Window;
            this.btnRemover.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemover.BackgroundImage")));
            this.btnRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRemover.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnRemover.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnRemover.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRemover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(12, 189);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(120, 54);
            this.btnRemover.TabIndex = 146;
            this.btnRemover.Text = "Remover Ausencias";
            this.btnRemover.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // cboProva
            // 
            this.cboProva.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cboProva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboProva.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.cboProva.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cboProva.FormattingEnabled = true;
            this.cboProva.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cboProva.Location = new System.Drawing.Point(152, 212);
            this.cboProva.Name = "cboProva";
            this.cboProva.Size = new System.Drawing.Size(77, 22);
            this.cboProva.TabIndex = 154;
            this.cboProva.SelectedIndexChanged += new System.EventHandler(this.cboProva_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Window;
            this.label9.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(149, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 14);
            this.label9.TabIndex = 153;
            this.label9.Text = "Prova:";
            // 
            // cboSimulado
            // 
            this.cboSimulado.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cboSimulado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSimulado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSimulado.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.cboSimulado.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cboSimulado.FormattingEnabled = true;
            this.cboSimulado.Location = new System.Drawing.Point(237, 212);
            this.cboSimulado.Name = "cboSimulado";
            this.cboSimulado.Size = new System.Drawing.Size(85, 22);
            this.cboSimulado.TabIndex = 152;
            this.cboSimulado.SelectedIndexChanged += new System.EventHandler(this.cboSimulado_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(234, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 14);
            this.label6.TabIndex = 151;
            this.label6.Text = "Simulado:";
            // 
            // lblTotal_linhas
            // 
            this.lblTotal_linhas.AutoSize = true;
            this.lblTotal_linhas.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.lblTotal_linhas.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTotal_linhas.Location = new System.Drawing.Point(274, 246);
            this.lblTotal_linhas.Name = "lblTotal_linhas";
            this.lblTotal_linhas.Size = new System.Drawing.Size(13, 14);
            this.lblTotal_linhas.TabIndex = 156;
            this.lblTotal_linhas.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.label5.Location = new System.Drawing.Point(103, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 14);
            this.label5.TabIndex = 155;
            this.label5.Text = "QTD de questoes sem correção";
            // 
            // lblTotal_alunos
            // 
            this.lblTotal_alunos.AutoSize = true;
            this.lblTotal_alunos.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.lblTotal_alunos.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTotal_alunos.Location = new System.Drawing.Point(274, 271);
            this.lblTotal_alunos.Name = "lblTotal_alunos";
            this.lblTotal_alunos.Size = new System.Drawing.Size(13, 14);
            this.lblTotal_alunos.TabIndex = 157;
            this.lblTotal_alunos.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.label1.Location = new System.Drawing.Point(103, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 14);
            this.label1.TabIndex = 158;
            this.label1.Text = "Alunos ausentes no dia";
            // 
            // frmRemocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 305);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotal_alunos);
            this.Controls.Add(this.lblTotal_linhas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboProva);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboSimulado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnFechar);
            this.Name = "frmRemocao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remover/Atualizar alunos";
            this.Load += new System.EventHandler(this.frmRemocao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.ComboBox cboProva;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboSimulado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotal_linhas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotal_alunos;
        private System.Windows.Forms.Label label1;
    }
}