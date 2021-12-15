namespace Sistema___Simulado
{
    partial class frmProvas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProvas));
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.cboMateria = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboGabarito = new System.Windows.Forms.ComboBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar_questao = new System.Windows.Forms.TextBox();
            this.dgvProva = new System.Windows.Forms.DataGridView();
            this.mtbData_simulado = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboProva = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nmdQuestao = new System.Windows.Forms.NumericUpDown();
            this.txtPesquisar_simulado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPesquisar_prova = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblQuestao = new System.Windows.Forms.Label();
            this.cboSimulado = new System.Windows.Forms.ComboBox();
            this.chbAnular = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmdQuestao)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.btnFechar.Location = new System.Drawing.Point(525, 8);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(120, 54);
            this.btnFechar.TabIndex = 117;
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
            this.btnCancelar.Location = new System.Drawing.Point(12, 259);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 54);
            this.btnCancelar.TabIndex = 115;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.SystemColors.Window;
            this.btnRemover.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemover.BackgroundImage")));
            this.btnRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRemover.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnRemover.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRemover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(12, 328);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(120, 54);
            this.btnRemover.TabIndex = 113;
            this.btnRemover.Text = "Excluir";
            this.btnRemover.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.SystemColors.Window;
            this.btnAtualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.BackgroundImage")));
            this.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAtualizar.Enabled = false;
            this.btnAtualizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAtualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAtualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(12, 199);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(120, 54);
            this.btnAtualizar.TabIndex = 112;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
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
            this.btnIncluir.Location = new System.Drawing.Point(12, 137);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(120, 54);
            this.btnIncluir.TabIndex = 111;
            this.btnIncluir.Text = "Adicionar";
            this.btnIncluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIncluir.UseVisualStyleBackColor = false;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // cboMateria
            // 
            this.cboMateria.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cboMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMateria.Enabled = false;
            this.cboMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMateria.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.cboMateria.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cboMateria.FormattingEnabled = true;
            this.cboMateria.Items.AddRange(new object[] {
            "PORTUGUES",
            "BIOLOGIA",
            "GEOGRAFIA",
            "HISTORIA",
            "FILOSOFIA",
            "FISICA",
            "QUIMICA",
            "MATEMATICA",
            "INGLES",
            "SOCIOLOGIA",
            "ARTES"});
            this.cboMateria.Location = new System.Drawing.Point(12, 82);
            this.cboMateria.Name = "cboMateria";
            this.cboMateria.Size = new System.Drawing.Size(137, 22);
            this.cboMateria.TabIndex = 110;
            this.cboMateria.SelectedIndexChanged += new System.EventHandler(this.cboMateria_SelectedIndexChanged);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.txtId.Location = new System.Drawing.Point(15, 25);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(27, 22);
            this.txtId.TabIndex = 104;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Window;
            this.label12.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.label12.Location = new System.Drawing.Point(153, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 14);
            this.label12.TabIndex = 103;
            this.label12.Text = "Gabarito:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Window;
            this.label10.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.label10.Location = new System.Drawing.Point(192, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 14);
            this.label10.TabIndex = 102;
            this.label10.Text = "Questão: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.label6.Location = new System.Drawing.Point(9, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 14);
            this.label6.TabIndex = 100;
            this.label6.Text = "Matéria:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 14);
            this.label1.TabIndex = 98;
            this.label1.Text = "ID:";
            // 
            // cboGabarito
            // 
            this.cboGabarito.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cboGabarito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGabarito.Enabled = false;
            this.cboGabarito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboGabarito.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.cboGabarito.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cboGabarito.FormattingEnabled = true;
            this.cboGabarito.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.cboGabarito.Location = new System.Drawing.Point(156, 82);
            this.cboGabarito.Name = "cboGabarito";
            this.cboGabarito.Size = new System.Drawing.Size(85, 22);
            this.cboGabarito.TabIndex = 118;
            this.cboGabarito.SelectedIndexChanged += new System.EventHandler(this.cboGabarito_SelectedIndexChanged);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.BackgroundImage")));
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisar.Location = new System.Drawing.Point(226, 26);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(37, 33);
            this.btnPesquisar.TabIndex = 114;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisar_questao
            // 
            this.txtPesquisar_questao.Location = new System.Drawing.Point(6, 34);
            this.txtPesquisar_questao.Name = "txtPesquisar_questao";
            this.txtPesquisar_questao.Size = new System.Drawing.Size(72, 25);
            this.txtPesquisar_questao.TabIndex = 106;
            // 
            // dgvProva
            // 
            this.dgvProva.AllowUserToAddRows = false;
            this.dgvProva.AllowUserToDeleteRows = false;
            this.dgvProva.AllowUserToOrderColumns = true;
            this.dgvProva.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dgvProva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProva.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvProva.Location = new System.Drawing.Point(147, 137);
            this.dgvProva.Name = "dgvProva";
            this.dgvProva.ReadOnly = true;
            this.dgvProva.Size = new System.Drawing.Size(498, 245);
            this.dgvProva.TabIndex = 97;
            this.dgvProva.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProva_CellClick);
            // 
            // mtbData_simulado
            // 
            this.mtbData_simulado.Enabled = false;
            this.mtbData_simulado.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.mtbData_simulado.Location = new System.Drawing.Point(314, 22);
            this.mtbData_simulado.Mask = "00/00/0000";
            this.mtbData_simulado.Name = "mtbData_simulado";
            this.mtbData_simulado.ReadOnly = true;
            this.mtbData_simulado.Size = new System.Drawing.Size(78, 22);
            this.mtbData_simulado.TabIndex = 120;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.Window;
            this.label13.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.label13.Location = new System.Drawing.Point(311, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 14);
            this.label13.TabIndex = 119;
            this.label13.Text = "Data do Simulado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.label2.Location = new System.Drawing.Point(110, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 14);
            this.label2.TabIndex = 121;
            this.label2.Text = "Prova:";
            // 
            // cboProva
            // 
            this.cboProva.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cboProva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProva.Enabled = false;
            this.cboProva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboProva.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.cboProva.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cboProva.FormattingEnabled = true;
            this.cboProva.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cboProva.Location = new System.Drawing.Point(113, 23);
            this.cboProva.Name = "cboProva";
            this.cboProva.Size = new System.Drawing.Size(77, 22);
            this.cboProva.TabIndex = 122;
            this.cboProva.SelectedIndexChanged += new System.EventHandler(this.cboProva_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.label3.Location = new System.Drawing.Point(48, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 14);
            this.label3.TabIndex = 123;
            this.label3.Text = "Simulado: ";
            // 
            // nmdQuestao
            // 
            this.nmdQuestao.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.nmdQuestao.Location = new System.Drawing.Point(195, 23);
            this.nmdQuestao.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmdQuestao.Name = "nmdQuestao";
            this.nmdQuestao.Size = new System.Drawing.Size(50, 22);
            this.nmdQuestao.TabIndex = 126;
            this.nmdQuestao.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtPesquisar_simulado
            // 
            this.txtPesquisar_simulado.Location = new System.Drawing.Point(82, 34);
            this.txtPesquisar_simulado.Name = "txtPesquisar_simulado";
            this.txtPesquisar_simulado.Size = new System.Drawing.Size(66, 25);
            this.txtPesquisar_simulado.TabIndex = 127;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.label4.Location = new System.Drawing.Point(6, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 14);
            this.label4.TabIndex = 128;
            this.label4.Text = "Questão:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.label5.Location = new System.Drawing.Point(79, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 14);
            this.label5.TabIndex = 129;
            this.label5.Text = "Simulado:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Window;
            this.label8.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.label8.Location = new System.Drawing.Point(151, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 14);
            this.label8.TabIndex = 131;
            this.label8.Text = "Prova:";
            // 
            // txtPesquisar_prova
            // 
            this.txtPesquisar_prova.Location = new System.Drawing.Point(154, 34);
            this.txtPesquisar_prova.Name = "txtPesquisar_prova";
            this.txtPesquisar_prova.Size = new System.Drawing.Size(66, 25);
            this.txtPesquisar_prova.TabIndex = 130;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtPesquisar_questao);
            this.groupBox1.Controls.Add(this.txtPesquisar_prova);
            this.groupBox1.Controls.Add(this.txtPesquisar_simulado);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(379, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 65);
            this.groupBox1.TabIndex = 132;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar Por";
            // 
            // lblQuestao
            // 
            this.lblQuestao.AutoSize = true;
            this.lblQuestao.BackColor = System.Drawing.SystemColors.Window;
            this.lblQuestao.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestao.ForeColor = System.Drawing.Color.Tomato;
            this.lblQuestao.Location = new System.Drawing.Point(251, 23);
            this.lblQuestao.Name = "lblQuestao";
            this.lblQuestao.Size = new System.Drawing.Size(47, 16);
            this.lblQuestao.TabIndex = 134;
            this.lblQuestao.Text = "Max: 0";
            // 
            // cboSimulado
            // 
            this.cboSimulado.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cboSimulado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSimulado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSimulado.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.cboSimulado.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cboSimulado.FormattingEnabled = true;
            this.cboSimulado.Location = new System.Drawing.Point(48, 24);
            this.cboSimulado.Name = "cboSimulado";
            this.cboSimulado.Size = new System.Drawing.Size(59, 22);
            this.cboSimulado.TabIndex = 133;
            this.cboSimulado.SelectedIndexChanged += new System.EventHandler(this.cboSimulado_SelectedIndexChanged);
            // 
            // chbAnular
            // 
            this.chbAnular.AutoSize = true;
            this.chbAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbAnular.Location = new System.Drawing.Point(254, 84);
            this.chbAnular.Name = "chbAnular";
            this.chbAnular.Size = new System.Drawing.Size(53, 17);
            this.chbAnular.TabIndex = 135;
            this.chbAnular.Text = "Anular";
            this.chbAnular.UseVisualStyleBackColor = true;
            // 
            // frmProvas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(657, 393);
            this.ControlBox = false;
            this.Controls.Add(this.chbAnular);
            this.Controls.Add(this.lblQuestao);
            this.Controls.Add(this.cboSimulado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nmdQuestao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboProva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtbData_simulado);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cboGabarito);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.cboMateria);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProva);
            this.Name = "frmProvas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Provas";
            this.Load += new System.EventHandler(this.frmProvas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmdQuestao)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.ComboBox cboMateria;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboGabarito;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar_questao;
        private System.Windows.Forms.DataGridView dgvProva;
        private System.Windows.Forms.MaskedTextBox mtbData_simulado;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboProva;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmdQuestao;
        private System.Windows.Forms.TextBox txtPesquisar_simulado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPesquisar_prova;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblQuestao;
        private System.Windows.Forms.ComboBox cboSimulado;
        private System.Windows.Forms.CheckBox chbAnular;
    }
}