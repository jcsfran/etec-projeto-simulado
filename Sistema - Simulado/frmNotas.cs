using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sistema___Simulado
{
    public partial class Notas : Form
    {
        int relatorio = 1;
        
        void LimparCampos()
        {
            for (int i = 0; i < dgvAcertos.RowCount; i++)
            {
                dgvAcertos.Rows[i].DataGridView.Columns.Clear();
            }

            cboCurso.SelectedIndex = -1;
            cboSimulado.SelectedIndex = -1;
            cboAno.SelectedIndex = -1;

            cboCurso.Enabled = false;
            cboSimulado.Enabled = false;

        }

        void carregaComboSimulado()
        {
            Geral.conectar();
            Geral.Adaptador = new MySqlDataAdapter("SELECT * FROM Simulados ORDER BY simulado ASC", Geral.Conexao);
            Geral.Adaptador.Fill(Geral.datTabela = new DataTable());
            cboSimulado.DataSource = Geral.datTabela;
            cboSimulado.DisplayMember = "simulado";
            cboSimulado.ValueMember = "simulado";
            Geral.desconectar();
        }

        void carregaComboCurso()
        {
            Geral.conectar();
            Geral.Adaptador = new MySqlDataAdapter("SELECT * FROM cursos ORDER BY descricao DESC", Geral.Conexao);
            Geral.Adaptador.Fill(Geral.datTabela = new DataTable());
            cboCurso.DataSource = Geral.datTabela;
            cboCurso.DisplayMember = "descricao";
            cboCurso.ValueMember = "id";
            Geral.desconectar();
        }

        void carregaGrid()
        {
            Geral.conectar();
            try
            {
                Geral.Adaptador = new MySqlDataAdapter("SELECT c.rm RM, c.materia Materia, SUM(c.nota) Total, LEFT(u.nome, 12) Corretor " +
                                                             //", (n.prova1 + n.prova2) Total  " +
                                              "FROM Corrigidos c " +
                                        //"INNER JOIN Notas n ON c.rm = n.rm " +
                                        "INNER JOIN Alunos a ON c.rm = a.rm " +
                                        "INNER JOIN Usuarios u ON c.id_usuario = u.id " +
                                        "WHERE c.id = c.id " +
                                               "AND c.simulado = @simulado " +
                                               "AND a.ano = @ano " +
                                               "AND a.curso = @curso " +
                                               "AND c.corrigido = '1' " +
                                               //"AND c.nota > '0' " +
                                               "GROUP BY c.materia, c.rm, u.nome " +
                                               "order by c.rm asc, u.nome asc", Geral.Conexao);
                Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@ano", cboAno.SelectedItem);
                Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@curso", cboCurso.SelectedValue);
                Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@simulado", cboSimulado.SelectedValue);
                Geral.Adaptador.Fill(Geral.datTabela = new DataTable());
                dgvAcertos.DataSource = Geral.datTabela;
                dgvAcertos.Columns[0].Width = 45;
                dgvAcertos.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvAcertos.Columns[2].Width = 45;
                dgvAcertos.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Geral.desconectar();
        }

        public Notas()
        {
            InitializeComponent();
        }

        private void frmNotas_Load(object sender, EventArgs e)
        {
            carregaComboSimulado();
            carregaComboCurso();
            LimparCampos();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            if (cboCurso.SelectedIndex == -1)
            {
                MessageBox.Show("Curso Não Selecionado!", "RM",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            carregaGrid();
            btnAcertos.Enabled = true;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }


        private void cboAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboSimulado.Enabled = true;
        }

        private void cboCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCurso.SelectedIndex == -1)
            {
                btnCarregar.Enabled = false;
                btnAcertos.Enabled = false;
            } else
            {
                btnCarregar.Enabled = true;
                btnAcertos.Enabled = false;
            }
            
        }

        private void cboSimulado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCurso.Enabled = true;
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
        
            string biologia = "", filosofia = "", fisica = "", geografia = "", historia = "", ingles = "",
                matematica = "", portugues = "", quimica = "", sociologia = "", artes = "", simulado = "", anulados = "";

            Geral.conectar();
            Geral.Adaptador = new MySqlDataAdapter("SELECT descricao, data_p1 " +
                                  "FROM Simulados " +
                                 "WHERE simulado = @simulado ", Geral.Conexao);
            Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@simulado", cboSimulado.SelectedValue);
            Geral.Adaptador.Fill(Geral.datTabela = new DataTable());
            simulado = Geral.datTabela.Rows[0][0].ToString();
            DateTime data = Convert.ToDateTime(Geral.datTabela.Rows[0][1].ToString());

            Geral.Adaptador = new MySqlDataAdapter("SELECT questao " +
                      "FROM Provas " +
                     "WHERE simulado = @simulado " +
                     "AND anulado = '1' ", Geral.Conexao);
            Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@simulado", cboSimulado.SelectedValue);
            Geral.Adaptador.Fill(Geral.datTabela = new DataTable());
            int i = 0, ll = Geral.datTabela.Rows.Count, anulado = 0;
            if (Geral.datTabela.Rows.Count == 0)
            {
                anulados = "";
            }
            else if (Geral.datTabela.Rows.Count == 1)
            {
                Geral.Adaptador = new MySqlDataAdapter("SELECT questao " +
                  "FROM Provas " +
                 "WHERE simulado = @simulado " +
                 "AND anulado = '1' ", Geral.Conexao);
                Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@simulado", cboSimulado.SelectedValue);
                Geral.Adaptador.Fill(Geral.datTabela = new DataTable());
                anulados = Geral.datTabela.Rows[0][0].ToString();
            }
            else
            {
                while (i < ll)
                {
                    //if (i == 5)
                    //break;
                    Console.WriteLine(i);
                    i++;
                    Geral.Adaptador = new MySqlDataAdapter("SELECT questao " +
                 "FROM Provas " +
                "WHERE simulado = @simulado " +
                "AND anulado = '1' " +
                "AND questao > @anulados ", Geral.Conexao);
                    Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@simulado", cboSimulado.SelectedValue);
                    Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@anulados", anulado);
                    Geral.Adaptador.Fill(Geral.datTabela = new DataTable());
                    anulado = Convert.ToInt16(Geral.datTabela.Rows[0][0].ToString());
                    anulados = anulados + ", " + Geral.datTabela.Rows[0][0].ToString();
                }
            }
            Geral.Adaptador = new MySqlDataAdapter("SELECT COUNT(p.materia) BIOLOGIA " +
                                              "FROM Provas p " +
                                             "WHERE p.simulado = @simulado " +
                                               "AND p.anulado < '1' " +
                                               "AND p.materia = 'BIOLOGIA' ", Geral.Conexao);
            Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@simulado", cboSimulado.SelectedValue);
            Geral.Adaptador.Fill(Geral.datTabela = new DataTable());
            biologia = Geral.datTabela.Rows[0][0].ToString();

            Geral.Adaptador = new MySqlDataAdapter("SELECT COUNT(p.materia) FILOSOFIA " +
                                             "FROM Provas p " +
                                            "WHERE p.simulado = @simulado " +
                                              "AND p.anulado < '1' " +
                                              "AND p.materia = 'FILOSOFIA' ", Geral.Conexao);
            Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@simulado", cboSimulado.SelectedValue);
            Geral.Adaptador.Fill(Geral.datTabela = new DataTable());
            filosofia = Geral.datTabela.Rows[0][0].ToString();

            Geral.Adaptador = new MySqlDataAdapter("SELECT COUNT(p.materia) FISICA " +
                                                  "FROM Provas p " +
                                                 "WHERE p.simulado = @simulado " +
                                                   "AND p.anulado < '1' " +
                                                   "AND p.materia = 'FISICA' ", Geral.Conexao);
            Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@simulado", cboSimulado.SelectedValue);
            Geral.Adaptador.Fill(Geral.datTabela = new DataTable());
            fisica = Geral.datTabela.Rows[0][0].ToString();

            Geral.Adaptador = new MySqlDataAdapter("SELECT COUNT(p.materia) GEOGRAFIA " +
                                                  "FROM Provas p " +
                                                 "WHERE p.simulado = @simulado " +
                                                   "AND p.anulado < '1' " +
                                                   "AND p.materia = 'GEOGRAFIA' ", Geral.Conexao);
            Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@simulado", cboSimulado.SelectedValue);
            Geral.Adaptador.Fill(Geral.datTabela = new DataTable());
            geografia = Geral.datTabela.Rows[0][0].ToString();

            Geral.Adaptador = new MySqlDataAdapter("SELECT COUNT(p.materia) HISTORIA " +
                                            "FROM Provas p " +
                                           "WHERE p.simulado = @simulado " +
                                             "AND p.anulado < '1' " +
                                             "AND p.materia = 'HISTORIA' ", Geral.Conexao);
            Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@simulado", cboSimulado.SelectedValue);
            Geral.Adaptador.Fill(Geral.datTabela = new DataTable());
            historia = Geral.datTabela.Rows[0][0].ToString();

            Geral.Adaptador = new MySqlDataAdapter("SELECT COUNT(p.materia) INGLES " +
                                             "FROM Provas p " +
                                            "WHERE p.simulado = @simulado " +
                                              "AND p.anulado < '1' " +
                                              "AND p.materia = 'INGLES' ", Geral.Conexao);
            Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@simulado", cboSimulado.SelectedValue);
            Geral.Adaptador.Fill(Geral.datTabela = new DataTable());
            ingles = Geral.datTabela.Rows[0][0].ToString();

            Geral.Adaptador = new MySqlDataAdapter("SELECT COUNT(p.materia) MATEMATICA " +
                                                 "FROM Provas p " +
                                                "WHERE p.simulado = @simulado " +
                                                  "AND p.anulado < '1' " +
                                                  "AND p.materia = 'MATEMATICA' ", Geral.Conexao);
            Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@simulado", cboSimulado.SelectedValue);
            Geral.Adaptador.Fill(Geral.datTabela = new DataTable());
            matematica = Geral.datTabela.Rows[0][0].ToString();

            Geral.Adaptador = new MySqlDataAdapter("SELECT COUNT(p.materia) PORTUGUES " +
                                             "FROM Provas p " +
                                            "WHERE p.simulado = @simulado " +
                                              "AND p.anulado < '1' " +
                                              "AND p.materia = 'PORTUGUES' ", Geral.Conexao);
            Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@simulado", cboSimulado.SelectedValue);
            Geral.Adaptador.Fill(Geral.datTabela = new DataTable());
            portugues = Geral.datTabela.Rows[0][0].ToString();

            Geral.Adaptador = new MySqlDataAdapter("SELECT COUNT(p.materia) QUIMICA " +
                                                        "FROM Provas p " +
                                                       "WHERE p.simulado = @simulado " +
                                                         "AND p.anulado < '1' " +
                                                         "AND p.materia = 'QUIMICA' ", Geral.Conexao);
            Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@simulado", cboSimulado.SelectedValue);
            Geral.Adaptador.Fill(Geral.datTabela = new DataTable());
            quimica = Geral.datTabela.Rows[0][0].ToString();

            Geral.Adaptador = new MySqlDataAdapter("SELECT COUNT(p.materia) SOCIOLOGIA " +
                                                      "FROM Provas p " +
                                                     "WHERE p.simulado = @simulado " +
                                                       "AND p.anulado < '1' " +
                                                       "AND p.materia = 'SOCIOLOGIA' ", Geral.Conexao);
            Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@simulado", cboSimulado.SelectedValue);
            Geral.Adaptador.Fill(Geral.datTabela = new DataTable());
            sociologia = Geral.datTabela.Rows[0][0].ToString();

            Geral.Adaptador = new MySqlDataAdapter("SELECT COUNT(p.materia) ARTES " +
                                                     "FROM Provas p " +
                                                    "WHERE p.simulado = @simulado " +
                                                      "AND p.anulado < '1' " +
                                                      "AND p.materia = 'ARTES' ", Geral.Conexao);
            Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@simulado", cboSimulado.SelectedValue);
            Geral.Adaptador.Fill(Geral.datTabela = new DataTable());
            artes = Geral.datTabela.Rows[0][0].ToString();
            Geral.desconectar();

            using (var doc = new PdfSharp.Pdf.PdfDocument())
            {
                var page = doc.AddPage();
                var graphics = PdfSharp.Drawing.XGraphics.FromPdfPage(page);
                var textFormatter = new PdfSharp.Drawing.Layout.XTextFormatter(graphics);
                var font = new PdfSharp.Drawing.XFont("Calibri", 10);
                var cabecalho = new PdfSharp.Drawing.XFont("Calibri", 12, PdfSharp.Drawing.XFontStyle.Bold);
                var materias = new PdfSharp.Drawing.XFont("Calibri", 10, PdfSharp.Drawing.XFontStyle.Bold);

                int posicao, user;

                graphics.DrawRoundedRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.DarkGray, 10, 4, 582, 83, 0, 0);
                graphics.DrawRoundedRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.White, 10, 4, 582, 66, 0, 0);
                graphics.DrawImage(PdfSharp.Drawing.XImage.FromFile(Directory.GetCurrentDirectory() + "\\imagens\\CPSP.png"), 18, 0);
                textFormatter.DrawString("Relatório de Notas", cabecalho, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(330, 30, page.Width, page.Height));
                textFormatter.DrawString("Simulado " + cboSimulado.SelectedValue + " (" + simulado +") - " + data.ToString().Substring(0, 10), cabecalho, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(330, 7, page.Width, page.Height));
                textFormatter.DrawString("Curso:  " + cboCurso.Text, cabecalho, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(330, 45, page.Width, page.Height));
                graphics.DrawLine(PdfSharp.Drawing.XPens.Black, 10, 4, 592, 4);

                textFormatter.DrawString("RM", materias, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(20, 73, page.Width, page.Height));
                textFormatter.DrawString("BIO (" + biologia + ")", materias, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 73, page.Width, page.Height));
                textFormatter.DrawString("FILO (" + filosofia + ")", materias, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(90, 73, page.Width, page.Height));
                textFormatter.DrawString("FIS (" + fisica + ")", materias, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(129, 73, page.Width, page.Height));
                textFormatter.DrawString("GEO (" + geografia + ")", materias, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(164, 73, page.Width, page.Height));
                textFormatter.DrawString("HIS (" + historia + ")", materias, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(206, 73, page.Width, page.Height));
                textFormatter.DrawString("ING (" + ingles + ")", materias, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(248, 73, page.Width, page.Height));
                textFormatter.DrawString("MAT (" + matematica + ")", materias, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(290, 73, page.Width, page.Height));
                textFormatter.DrawString("PORT (" + portugues + ")", materias, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(332, 73, page.Width, page.Height));
                textFormatter.DrawString("QUI (" + quimica + ")", materias, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(386, 73, page.Width, page.Height));
                textFormatter.DrawString("SOCIO (" + sociologia + ")", materias, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(428, 73, page.Width, page.Height));
                textFormatter.DrawString("ART (" + artes + ")", materias, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(490, 73, page.Width, page.Height));
                textFormatter.DrawString("TOTAL", materias, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(548, 73, page.Width, page.Height));
                graphics.DrawLine(PdfSharp.Drawing.XPens.Black, 10, 70, 592, 70);

                textFormatter.DrawString("Corretor(es): ", cabecalho, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(520, 10, page.Width, page.Height));
                posicao = 70;
                user = 10;
                string rm = "", corretor1 = "", corretor2 = "", corretor3 ="";
                int linhas = 1;

                foreach (DataGridViewRow linha in dgvAcertos.Rows)
                {
                    var pagi = doc.PageCount;
                    if (rm == linha.Cells[0].Value.ToString())
                    {
                        posicao -= 17;
                        linhas--;
                    }
                    posicao += 17;
                    linhas++;

                    if (linhas > 43)
                    {
                        graphics.DrawLine(PdfSharp.Drawing.XPens.Black, 10, 87, 10, 800);
                        graphics.DrawLine(PdfSharp.Drawing.XPens.Black, 48, 70, 48, 800);
                        graphics.DrawLine(PdfSharp.Drawing.XPens.Black, 98, 70, 98, 800);
                        graphics.DrawLine(PdfSharp.Drawing.XPens.Black, 148, 70, 148, 800);
                        graphics.DrawLine(PdfSharp.Drawing.XPens.Black, 198, 70, 198, 800);
                        graphics.DrawLine(PdfSharp.Drawing.XPens.Black, 248, 70, 248, 800);
                        graphics.DrawLine(PdfSharp.Drawing.XPens.Black, 298, 70, 298, 800);
                        graphics.DrawLine(PdfSharp.Drawing.XPens.Black, 348, 70, 348, 800);
                        graphics.DrawLine(PdfSharp.Drawing.XPens.Black, 398, 70, 398, 800);
                        graphics.DrawLine(PdfSharp.Drawing.XPens.Black, 448, 70, 448, 800);
                        graphics.DrawLine(PdfSharp.Drawing.XPens.Black, 498, 70, 498, 800);
                        graphics.DrawLine(PdfSharp.Drawing.XPens.Black, 548, 70, 548, 800);
                        graphics.DrawLine(PdfSharp.Drawing.XPens.Black, 592, 70, 592, 800);

                        graphics.DrawRoundedRectangle(PdfSharp.Drawing.XPens.White, PdfSharp.Drawing.XBrushes.White, 10, 800, 38, 820, 0, 0);
                        graphics.DrawLine(PdfSharp.Drawing.XPens.Black, 10, 800, 592, 800);
                        textFormatter.DrawString("OBS: Sem questões das matérias com espaços vazios.", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(10, 805, page.Width, page.Height));
                        //textFormatter.DrawString("pagina " + pagi.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(552, 805, page.Width, page.Height));
                        //textFormatter.DrawString("As questões 19 e 27 foram anuladas".ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(10, 820, page.Width, page.Height));

                        var page2 = doc.AddPage();

                        graphics = PdfSharp.Drawing.XGraphics.FromPdfPage(page2);
                        textFormatter = new PdfSharp.Drawing.Layout.XTextFormatter(graphics);

                        graphics.DrawRoundedRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.DarkGray, 10, 4, 582, 83, 0, 0);
                        graphics.DrawRoundedRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.White, 10, 4, 582, 66, 0, 0);
                        graphics.DrawImage(PdfSharp.Drawing.XImage.FromFile(Directory.GetCurrentDirectory() + "\\imagens\\CPSP.png"), 18, 0);
                        textFormatter.DrawString("Relatório de Notas", cabecalho, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(330, 7, page.Width, page.Height));
                        textFormatter.DrawString("Simulado " + cboSimulado.SelectedValue + " (" + simulado + ") - " + data.Date, cabecalho, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(330, 7, page.Width, page.Height));
                        textFormatter.DrawString("Curso:  " + cboCurso.Text, cabecalho, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(330, 45, page.Width, page.Height));
                        graphics.DrawLine(PdfSharp.Drawing.XPens.Black, 10, 4, 592, 4);

                        textFormatter.DrawString("RM", materias, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(20, 73, page.Width, page.Height));
                        textFormatter.DrawString("BIO (" + biologia + ")", materias, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 73, page.Width, page.Height));
                        textFormatter.DrawString("FILO (" + filosofia + ")", materias, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(100, 73, page.Width, page.Height));
                        textFormatter.DrawString("FIS (" + fisica + ")", materias, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(150, 73, page.Width, page.Height));
                        textFormatter.DrawString("GEO (" + geografia + ")", materias, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(164, 73, page.Width, page.Height));
                        textFormatter.DrawString("HIS (" + historia + ")", materias, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(250, 73, page.Width, page.Height));
                        textFormatter.DrawString("ING (" + ingles + ")", materias, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(300, 73, page.Width, page.Height));
                        textFormatter.DrawString("MAT (" + matematica + ")", materias, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(350, 73, page.Width, page.Height));
                        textFormatter.DrawString("PORT (" + portugues + ")", materias, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(400, 73, page.Width, page.Height));
                        textFormatter.DrawString("QUI (" + quimica + ")", materias, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(450, 73, page.Width, page.Height));
                        textFormatter.DrawString("SOCIO (" + sociologia + ")", materias, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(500, 73, page.Width, page.Height));
                        textFormatter.DrawString("ART (" + artes + ")", materias, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(550, 73, page.Width, page.Height));
                        graphics.DrawLine(PdfSharp.Drawing.XPens.Black, 10, 70, 592, 70);

                        graphics.DrawLine(PdfSharp.Drawing.XPens.Black, 10, posicao, 592, posicao);
                   
                        textFormatter.DrawString("Corretor(es): ", cabecalho, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(520, 10, page.Width, page.Height));
                        textFormatter.DrawString(corretor1.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(520, 25, page.Width, page.Height));
                        textFormatter.DrawString(corretor2.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(520, 40, page.Width, page.Height));

                        posicao = 87;

                        linhas = 1;
                    }

                    graphics.DrawLine(PdfSharp.Drawing.XPens.Black, 10, posicao, 592, posicao);
                    graphics.DrawRoundedRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.DarkGray, 10, posicao, 38, posicao +20, 0, 0);
                    textFormatter.DrawString(linha.Cells[0].Value.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(15, posicao, 560, page.Height));
                    if (linha.Cells[1].Value.ToString() == "BIOLOGIA")
                    {
                        textFormatter.DrawString(linha.Cells[2].Value.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(68, posicao, 560, page.Height));
                    }

                    else if (linha.Cells[1].Value.ToString() == "FILOSOFIA")
                    {
                        textFormatter.DrawString(linha.Cells[2].Value.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(104, posicao, 560, page.Height));
                    }

                    else if (linha.Cells[1].Value.ToString() == "FISICA")
                    {
                        textFormatter.DrawString(linha.Cells[2].Value.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(144, posicao, 560, page.Height));
                    }

                    else if (linha.Cells[1].Value.ToString() == "GEOGRAFIA")
                    {
                        textFormatter.DrawString(linha.Cells[2].Value.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(184, posicao, 560, page.Height));
                    }

                    else if (linha.Cells[1].Value.ToString() == "HISTORIA")
                    {
                        textFormatter.DrawString(linha.Cells[2].Value.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(224, posicao, 560, page.Height));
                    }

                    else if (linha.Cells[1].Value.ToString() == "INGLES")
                    {
                        textFormatter.DrawString(linha.Cells[2].Value.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(264, posicao, 560, page.Height));
                    }

                    else if (linha.Cells[1].Value.ToString() == "MATEMATICA")
                    {
                        textFormatter.DrawString(linha.Cells[2].Value.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(304, posicao, 560, page.Height));
                    }

                    else if (linha.Cells[1].Value.ToString() == "PORTUGUES")
                    {
                        textFormatter.DrawString(linha.Cells[2].Value.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(354, posicao, 560, page.Height));
                    }

                    else if (linha.Cells[1].Value.ToString() == "QUIMICA")
                    {
                        textFormatter.DrawString(linha.Cells[2].Value.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(394, posicao, 560, page.Height));
                    }

                    else if (linha.Cells[1].Value.ToString() == "SOCIOLOGIA")
                    {
                        textFormatter.DrawString(linha.Cells[2].Value.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(454, posicao, 560, page.Height));
                    }

                    else if (linha.Cells[1].Value.ToString() == "ARTES")
                    {
                        textFormatter.DrawString(linha.Cells[2].Value.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(510, posicao, 560, page.Height));
                    }
                    rm = linha.Cells[0].Value.ToString();

                    Geral.conectar();
                    Geral.Adaptador = new MySqlDataAdapter("SELECT (n.prova1 + n.prova2) Total " +
                                                      "FROM notas n " +
                                                "WHERE n.simulado = @simulado " +
                                                  "AND n.rm = @rm ", Geral.Conexao);
                        Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@simulado", cboSimulado.SelectedValue);
                        Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@rm", rm);
                        Geral.Adaptador.Fill(Geral.datTabela = new DataTable());
                        string total = Geral.datTabela.Rows[0][0].ToString();
                        Geral.desconectar();
                   
                    Geral.desconectar();

                    textFormatter.DrawString(total, font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(560, posicao, 560, page.Height));

                    if (corretor1 == "")
                    {
                        corretor1 = linha.Cells[3].Value.ToString();
                        user = 25;
                        textFormatter.DrawString(linha.Cells[3].Value.ToString() + "...", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(520, user, page.Width, page.Height));
                    }
                    else if (corretor1 != linha.Cells[3].Value.ToString() & corretor2 == "")
                    {
                        corretor2 = linha.Cells[3].Value.ToString();
                        user = 40;
                        textFormatter.DrawString(linha.Cells[3].Value.ToString() + "...", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(520, user, page.Width, page.Height));
                    }
                    else if (corretor2 != linha.Cells[3].Value.ToString() & corretor1 != linha.Cells[3].Value.ToString())
                    {
                        corretor3 = linha.Cells[3].Value.ToString();
                        user = 55;
                        textFormatter.DrawString(linha.Cells[3].Value.ToString() + "...", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(520, user, page.Width, page.Height));
                    }
                }
                graphics.DrawLine(PdfSharp.Drawing.XPens.Black, 10, 87, 10, posicao + 20);
                graphics.DrawLine(PdfSharp.Drawing.XPens.Black, 48, 70, 48, posicao + 20);
                graphics.DrawLine(PdfSharp.Drawing.XPens.Black, 88, 70, 88, posicao + 20);
                graphics.DrawLine(PdfSharp.Drawing.XPens.Black, 127, 70, 127, posicao + 20);
                graphics.DrawLine(PdfSharp.Drawing.XPens.Black, 162, 70, 162, posicao + 20);
                graphics.DrawLine(PdfSharp.Drawing.XPens.Black, 204, 70, 204, posicao + 20);
                graphics.DrawLine(PdfSharp.Drawing.XPens.Black, 246, 70, 246, posicao + 20);
                graphics.DrawLine(PdfSharp.Drawing.XPens.Black, 288, 70, 288, posicao + 20);
                graphics.DrawLine(PdfSharp.Drawing.XPens.Black, 330, 70, 330, posicao + 20);
                graphics.DrawLine(PdfSharp.Drawing.XPens.Black, 384, 70, 384, posicao + 20);
                graphics.DrawLine(PdfSharp.Drawing.XPens.Black, 426, 70, 426, posicao + 20);
                graphics.DrawLine(PdfSharp.Drawing.XPens.Black, 488, 70, 488, posicao + 20);
                graphics.DrawLine(PdfSharp.Drawing.XPens.Black, 532, 70, 532, posicao + 20);
                graphics.DrawLine(PdfSharp.Drawing.XPens.Black, 592, 70, 592, posicao + 20);

                graphics.DrawRoundedRectangle(PdfSharp.Drawing.XPens.White, PdfSharp.Drawing.XBrushes.White, 10, posicao + 20, 38, 840, 0, 0);
                graphics.DrawLine(PdfSharp.Drawing.XPens.Black, 10, posicao + 20, 592, posicao + 20);
                textFormatter.DrawString("OBS: Sem questões das matérias com espaços vazios." + anulados, font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(10, posicao + 25, page.Width, page.Height));
                var pag = doc.PageCount;
                textFormatter.DrawString("As questões 19 e 27 foram anuladas".ToString()+ anulados, font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(10, 820, page.Width, page.Height));
                //textFormatter.DrawString("pagina " +pag.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(552, posicao + 25, page.Width, page.Height));

                doc.Save(cboAno.SelectedItem + " " + cboCurso.Text + " Simulado " + cboSimulado.SelectedValue + " -Acertos -Rl " + relatorio + ".pdf");
                System.Diagnostics.Process.Start(cboAno.SelectedItem + " " + cboCurso.Text + " Simulado " + cboSimulado.SelectedValue + " -Acertos -Rl " + relatorio + ".pdf");
                relatorio++;
            }
        }
    }
}
