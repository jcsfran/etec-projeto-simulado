namespace Sistema___Simulado
{
    partial class frmTreineiros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTreineiros));
            this.btnIncluir = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.cboSimulado = new System.Windows.Forms.ComboBox();
            this.cboAluno = new System.Windows.Forms.ComboBox();
            this.txtP1 = new System.Windows.Forms.TextBox();
            this.txtP2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboCurso = new System.Windows.Forms.ComboBox();
            this.cboAno = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotal_alunos = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIncluir
            // 
            this.btnIncluir.BackColor = System.Drawing.SystemColors.Window;
            this.btnIncluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIncluir.BackgroundImage")));
            this.btnIncluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIncluir.Enabled = false;
            this.btnIncluir.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnIncluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnIncluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluir.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluir.Location = new System.Drawing.Point(12, 174);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(120, 54);
            this.btnIncluir.TabIndex = 106;
            this.btnIncluir.Text = "Confirmar";
            this.btnIncluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIncluir.UseVisualStyleBackColor = false;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label12.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.label12.Location = new System.Drawing.Point(157, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 14);
            this.label12.TabIndex = 100;
            this.label12.Text = "RM:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.label1.Location = new System.Drawing.Point(12, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 14);
            this.label1.TabIndex = 110;
            this.label1.Text = "Simulado:";
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
            this.btnFechar.Location = new System.Drawing.Point(191, 5);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(120, 54);
            this.btnFechar.TabIndex = 125;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // cboSimulado
            // 
            this.cboSimulado.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cboSimulado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSimulado.Enabled = false;
            this.cboSimulado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSimulado.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.cboSimulado.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cboSimulado.FormattingEnabled = true;
            this.cboSimulado.Location = new System.Drawing.Point(15, 118);
            this.cboSimulado.Name = "cboSimulado";
            this.cboSimulado.Size = new System.Drawing.Size(77, 22);
            this.cboSimulado.TabIndex = 124;
            this.cboSimulado.SelectedIndexChanged += new System.EventHandler(this.cboSimulado_SelectedIndexChanged);
            // 
            // cboAluno
            // 
            this.cboAluno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboAluno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboAluno.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cboAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboAluno.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.cboAluno.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cboAluno.FormattingEnabled = true;
            this.cboAluno.Location = new System.Drawing.Point(157, 65);
            this.cboAluno.Name = "cboAluno";
            this.cboAluno.Size = new System.Drawing.Size(93, 22);
            this.cboAluno.TabIndex = 126;
            this.cboAluno.SelectedIndexChanged += new System.EventHandler(this.cboAluno_SelectedIndexChanged);
            // 
            // txtP1
            // 
            this.txtP1.BackColor = System.Drawing.SystemColors.Window;
            this.txtP1.Enabled = false;
            this.txtP1.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.txtP1.Location = new System.Drawing.Point(18, 32);
            this.txtP1.Name = "txtP1";
            this.txtP1.ReadOnly = true;
            this.txtP1.Size = new System.Drawing.Size(47, 22);
            this.txtP1.TabIndex = 127;
            // 
            // txtP2
            // 
            this.txtP2.BackColor = System.Drawing.SystemColors.Window;
            this.txtP2.Enabled = false;
            this.txtP2.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.txtP2.Location = new System.Drawing.Point(83, 32);
            this.txtP2.Name = "txtP2";
            this.txtP2.ReadOnly = true;
            this.txtP2.Size = new System.Drawing.Size(47, 22);
            this.txtP2.TabIndex = 128;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 14);
            this.label2.TabIndex = 129;
            this.label2.Text = "Prova 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.label3.Location = new System.Drawing.Point(71, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 14);
            this.label3.TabIndex = 130;
            this.label3.Text = "Prova 2:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.txtP2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtP1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(160, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 65);
            this.groupBox1.TabIndex = 131;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Número de Questões";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label4.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.label4.Location = new System.Drawing.Point(9, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 14);
            this.label4.TabIndex = 150;
            this.label4.Text = "Curso:";
            // 
            // cboCurso
            // 
            this.cboCurso.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cboCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCurso.Enabled = false;
            this.cboCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCurso.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.cboCurso.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cboCurso.FormattingEnabled = true;
            this.cboCurso.Location = new System.Drawing.Point(12, 66);
            this.cboCurso.Name = "cboCurso";
            this.cboCurso.Size = new System.Drawing.Size(139, 22);
            this.cboCurso.TabIndex = 149;
            this.cboCurso.SelectedIndexChanged += new System.EventHandler(this.cboCurso_SelectedIndexChanged);
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
            this.cboAno.Location = new System.Drawing.Point(12, 25);
            this.cboAno.Name = "cboAno";
            this.cboAno.Size = new System.Drawing.Size(77, 22);
            this.cboAno.TabIndex = 148;
            this.cboAno.SelectedIndexChanged += new System.EventHandler(this.cboAno_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label7.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.label7.Location = new System.Drawing.Point(9, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 14);
            this.label7.TabIndex = 147;
            this.label7.Text = "Ano:";
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
            this.btnCancelar.Location = new System.Drawing.Point(196, 174);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 54);
            this.btnCancelar.TabIndex = 151;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.label5.Location = new System.Drawing.Point(12, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 14);
            this.label5.TabIndex = 131;
            this.label5.Text = "Alunos cadastrados:";
            // 
            // lblTotal_alunos
            // 
            this.lblTotal_alunos.AutoSize = true;
            this.lblTotal_alunos.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.lblTotal_alunos.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTotal_alunos.Location = new System.Drawing.Point(126, 143);
            this.lblTotal_alunos.Name = "lblTotal_alunos";
            this.lblTotal_alunos.Size = new System.Drawing.Size(13, 14);
            this.lblTotal_alunos.TabIndex = 152;
            this.lblTotal_alunos.Text = "0";
            // 
            // frmTreineiros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(325, 247);
            this.ControlBox = false;
            this.Controls.Add(this.lblTotal_alunos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboCurso);
            this.Controls.Add(this.cboAno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboAluno);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.cboSimulado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.label12);
            this.Name = "frmTreineiros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Treineiros";
            this.Load += new System.EventHandler(this.frmTreineiros_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.ComboBox cboSimulado;
        private System.Windows.Forms.ComboBox cboAluno;
        private System.Windows.Forms.TextBox txtP1;
        private System.Windows.Forms.TextBox txtP2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboCurso;
        private System.Windows.Forms.ComboBox cboAno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotal_alunos;
    }
}