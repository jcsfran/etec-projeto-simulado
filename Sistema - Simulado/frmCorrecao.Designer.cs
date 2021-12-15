namespace Sistema___Simulado
{
    partial class frmCorrecao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCorrecao));
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.dgvCorrecao = new System.Windows.Forms.DataGridView();
            this.btnDesmarcar = new System.Windows.Forms.Button();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.grbCliente = new System.Windows.Forms.GroupBox();
            this.txtPesquisar_materia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPesquisar_questao = new System.Windows.Forms.TextBox();
            this.cboAluno = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chbCorrigidos = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCurso = new System.Windows.Forms.ComboBox();
            this.cboAno = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboSimulado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboProva = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorrecao)).BeginInit();
            this.grbCliente.SuspendLayout();
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
            this.btnFechar.Location = new System.Drawing.Point(594, 7);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(120, 54);
            this.btnFechar.TabIndex = 126;
            this.btnFechar.Text = "Fechar  ";
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
            this.btnCancelar.Location = new System.Drawing.Point(9, 212);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 54);
            this.btnCancelar.TabIndex = 125;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.SystemColors.Window;
            this.btnConfirmar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirmar.BackgroundImage")));
            this.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConfirmar.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(10, 143);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(120, 54);
            this.btnConfirmar.TabIndex = 124;
            this.btnConfirmar.Text = "Corrigir  ";
            this.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // dgvCorrecao
            // 
            this.dgvCorrecao.AllowUserToAddRows = false;
            this.dgvCorrecao.AllowUserToDeleteRows = false;
            this.dgvCorrecao.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dgvCorrecao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCorrecao.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvCorrecao.Location = new System.Drawing.Point(138, 143);
            this.dgvCorrecao.Name = "dgvCorrecao";
            this.dgvCorrecao.Size = new System.Drawing.Size(576, 346);
            this.dgvCorrecao.StandardTab = true;
            this.dgvCorrecao.TabIndex = 122;
            this.dgvCorrecao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCorrecao_CellClick);
            this.dgvCorrecao.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.dgvCorrecao_PreviewKeyDown);
            // 
            // btnDesmarcar
            // 
            this.btnDesmarcar.BackColor = System.Drawing.SystemColors.Window;
            this.btnDesmarcar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDesmarcar.BackgroundImage")));
            this.btnDesmarcar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDesmarcar.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDesmarcar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDesmarcar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDesmarcar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesmarcar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesmarcar.Location = new System.Drawing.Point(245, 84);
            this.btnDesmarcar.Name = "btnDesmarcar";
            this.btnDesmarcar.Size = new System.Drawing.Size(165, 53);
            this.btnDesmarcar.TabIndex = 121;
            this.btnDesmarcar.Text = "Desmarcar Todos";
            this.btnDesmarcar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDesmarcar.UseVisualStyleBackColor = false;
            this.btnDesmarcar.Click += new System.EventHandler(this.btnDesmarcar_Click);
            // 
            // btnCarregar
            // 
            this.btnCarregar.BackColor = System.Drawing.SystemColors.Window;
            this.btnCarregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCarregar.BackgroundImage")));
            this.btnCarregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCarregar.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCarregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCarregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCarregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarregar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregar.Location = new System.Drawing.Point(12, 52);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(118, 54);
            this.btnCarregar.TabIndex = 119;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCarregar.UseVisualStyleBackColor = false;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // grbCliente
            // 
            this.grbCliente.BackColor = System.Drawing.SystemColors.Window;
            this.grbCliente.Controls.Add(this.txtPesquisar_materia);
            this.grbCliente.Controls.Add(this.label1);
            this.grbCliente.Controls.Add(this.btnPesquisar);
            this.grbCliente.Controls.Add(this.label4);
            this.grbCliente.Controls.Add(this.txtPesquisar_questao);
            this.grbCliente.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCliente.Location = new System.Drawing.Point(421, 75);
            this.grbCliente.Name = "grbCliente";
            this.grbCliente.Size = new System.Drawing.Size(293, 62);
            this.grbCliente.TabIndex = 117;
            this.grbCliente.TabStop = false;
            this.grbCliente.Text = "Pesquisar por:";
            // 
            // txtPesquisar_materia
            // 
            this.txtPesquisar_materia.Location = new System.Drawing.Point(6, 32);
            this.txtPesquisar_materia.Name = "txtPesquisar_materia";
            this.txtPesquisar_materia.Size = new System.Drawing.Size(151, 25);
            this.txtPesquisar_materia.TabIndex = 139;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 138;
            this.label1.Text = "Matéria:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.BackgroundImage")));
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisar.Location = new System.Drawing.Point(241, 21);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(42, 33);
            this.btnPesquisar.TabIndex = 128;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(160, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 14);
            this.label4.TabIndex = 134;
            this.label4.Text = "Questão:";
            // 
            // txtPesquisar_questao
            // 
            this.txtPesquisar_questao.Location = new System.Drawing.Point(163, 32);
            this.txtPesquisar_questao.Name = "txtPesquisar_questao";
            this.txtPesquisar_questao.Size = new System.Drawing.Size(72, 25);
            this.txtPesquisar_questao.TabIndex = 132;
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
            this.cboAluno.Location = new System.Drawing.Point(452, 25);
            this.cboAluno.Name = "cboAluno";
            this.cboAluno.Size = new System.Drawing.Size(88, 22);
            this.cboAluno.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(449, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "RM:";
            // 
            // chbCorrigidos
            // 
            this.chbCorrigidos.AutoSize = true;
            this.chbCorrigidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbCorrigidos.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbCorrigidos.Location = new System.Drawing.Point(452, 52);
            this.chbCorrigidos.Name = "chbCorrigidos";
            this.chbCorrigidos.Size = new System.Drawing.Size(120, 18);
            this.chbCorrigidos.TabIndex = 127;
            this.chbCorrigidos.Text = "Mostrar Corrigidos";
            this.chbCorrigidos.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 14);
            this.label3.TabIndex = 146;
            this.label3.Text = "Curso:";
            // 
            // cboCurso
            // 
            this.cboCurso.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cboCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCurso.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.cboCurso.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cboCurso.FormattingEnabled = true;
            this.cboCurso.Location = new System.Drawing.Point(98, 25);
            this.cboCurso.Name = "cboCurso";
            this.cboCurso.Size = new System.Drawing.Size(168, 22);
            this.cboCurso.TabIndex = 144;
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
            this.cboAno.TabIndex = 143;
            this.cboAno.SelectedIndexChanged += new System.EventHandler(this.cboAno_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 14);
            this.label7.TabIndex = 142;
            this.label7.Text = "Ano:";
            // 
            // cboSimulado
            // 
            this.cboSimulado.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cboSimulado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSimulado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSimulado.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.cboSimulado.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cboSimulado.FormattingEnabled = true;
            this.cboSimulado.Location = new System.Drawing.Point(360, 25);
            this.cboSimulado.Name = "cboSimulado";
            this.cboSimulado.Size = new System.Drawing.Size(85, 22);
            this.cboSimulado.TabIndex = 148;
            this.cboSimulado.SelectedIndexChanged += new System.EventHandler(this.cboSimulado_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(357, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 14);
            this.label6.TabIndex = 147;
            this.label6.Text = "Simulado:";
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
            this.cboProva.Location = new System.Drawing.Point(275, 25);
            this.cboProva.Name = "cboProva";
            this.cboProva.Size = new System.Drawing.Size(77, 22);
            this.cboProva.TabIndex = 150;
            this.cboProva.SelectedIndexChanged += new System.EventHandler(this.cboProva_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Window;
            this.label9.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(272, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 14);
            this.label9.TabIndex = 149;
            this.label9.Text = "Prova:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblUsuario.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(199, 52);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(18, 19);
            this.lblUsuario.TabIndex = 140;
            this.lblUsuario.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label5.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(136, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 140;
            this.label5.Text = "Usuário:";
            // 
            // frmCorrecao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(719, 501);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.cboProva);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboSimulado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboCurso);
            this.Controls.Add(this.cboAno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chbCorrigidos);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvCorrecao);
            this.Controls.Add(this.btnDesmarcar);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.grbCliente);
            this.Controls.Add(this.cboAluno);
            this.Controls.Add(this.label2);
            this.KeyPreview = true;
            this.Name = "frmCorrecao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Correção";
            this.Load += new System.EventHandler(this.frmCorrecao_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCorrecao_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorrecao)).EndInit();
            this.grbCliente.ResumeLayout(false);
            this.grbCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.DataGridView dgvCorrecao;
        private System.Windows.Forms.Button btnDesmarcar;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.GroupBox grbCliente;
        private System.Windows.Forms.ComboBox cboAluno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPesquisar_questao;
        private System.Windows.Forms.TextBox txtPesquisar_materia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chbCorrigidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCurso;
        private System.Windows.Forms.ComboBox cboAno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboSimulado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboProva;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label5;
    }
}