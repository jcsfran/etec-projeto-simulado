using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sistema___Simulado
{
    public partial class frmTreineiros : Form
    {
        int prova1, prova2;

        void LimparCampos()
        {
            cboSimulado.SelectedIndex = -1;
            cboAluno.SelectedIndex = -1;
            cboAno.SelectedIndex = -1;
            cboCurso.SelectedIndex = -1;

            txtP1.Clear();
            txtP2.Clear();
        }

        void carregaComboAluno()
        {
            Geral.conectar();

            Geral.Adaptador = new MySqlDataAdapter("SELECT * FROM Alunos a " +
                "WHERE a.ano = @ano AND a.curso = @curso GROUP BY a.rm ORDER BY a.rm DESC", Geral.Conexao);
            Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@ano", cboAno.SelectedItem);
            Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@curso", cboCurso.SelectedValue);
            Geral.Adaptador.Fill(Geral.datTabela = new DataTable());
            cboAluno.DataSource = Geral.datTabela;
            cboAluno.DisplayMember = "rm";
            cboAluno.ValueMember = "rm";

            Geral.desconectar();
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

        public frmTreineiros()
        {
            InitializeComponent();
        }

        private void frmTreineiros_Load(object sender, EventArgs e)
        {
            carregaComboCurso();
            carregaComboAluno();
            carregaComboSimulado();
            LimparCampos();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (cboSimulado.SelectedIndex == -1)
            {
                MessageBox.Show("Simulado não Selecionado", "Não Selecionado!!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboSimulado.Focus();
                return;
            }

            if (cboAluno.SelectedIndex == -1)
            {
                MessageBox.Show("Aluno não Selecionado", "Não Selecionado!!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboAluno.Focus();
                return;
            }

            Geral.conectar();

            Geral.Adaptador = new MySqlDataAdapter("SELECT rm, simulado, prova " +
                                               "FROM corrigidos " +
                                              "WHERE rm = @rm " +
                                                     "AND simulado = @simulado", Geral.Conexao);
            Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@rm", cboAluno.SelectedValue);
            Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@simulado", cboSimulado.SelectedValue);
            Geral.Adaptador.Fill(Geral.datTabela = new DataTable());
            if (Geral.datTabela.Rows.Count > 0)
            {
                MessageBox.Show("Esse RM já está cadastrado nesse simulado", "Já cadastrado",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboAluno.Focus();
                return;
            }

            Geral.desconectar();
            Geral.conectar();

            try
            {
                for (int i = 1; i <= prova1; i++)
                {
                    Geral.Comando = new MySqlCommand("INSERT INTO corrigidos (rm, simulado, questao, prova) " +
                                               "VALUES (@rm, @simulado, @questao, 1)", Geral.Conexao);
                    Geral.Comando.Parameters.AddWithValue("@rm", cboAluno.SelectedValue);
                    Geral.Comando.Parameters.AddWithValue("@simulado", cboSimulado.SelectedValue);
                    Geral.Comando.Parameters.AddWithValue("@questao", i);
                    Geral.Comando.ExecuteNonQuery();

                }

                for (int i = 1; i <= prova2; i++)
                {
                    Geral.Comando = new MySqlCommand("INSERT INTO corrigidos (rm, simulado, questao, prova) " +
                                               "VALUES (@rm, @simulado, @questao, 2)", Geral.Conexao);
                    Geral.Comando.Parameters.AddWithValue("@rm", cboAluno.SelectedValue);
                    Geral.Comando.Parameters.AddWithValue("@simulado", cboSimulado.SelectedValue);
                    Geral.Comando.Parameters.AddWithValue("@questao", i);
                    Geral.Comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Geral.desconectar();
            cboAluno.SelectedIndex = -1;
            cboSimulado.SelectedIndex = -1;

            txtP1.Clear();
            txtP2.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboAluno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboAluno.SelectedIndex == -1)
            {
                cboSimulado.Enabled = false;
            } else if (cboAluno.SelectedIndex != -1)
            {
                cboSimulado.Enabled = true;
            }
        }

        private void cboAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboAno.SelectedIndex != -1)
            {
                cboCurso.Enabled = true;
                carregaComboAluno();
            }
            else if (cboAno.SelectedIndex == -1)
            {
                cboCurso.Enabled = false;
            }
        }

        private void cboCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCurso.SelectedIndex != -1)
            {
                cboAluno.Enabled = true;
                carregaComboAluno();
            }
            else if (cboCurso.SelectedIndex == -1)
            {
                cboAluno.Enabled = false;
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            LimparCampos();
            cboCurso.Enabled = false;
            cboAluno.Enabled = false;
            cboSimulado.Enabled = false;
            lblTotal_alunos.Text = "0";
        }

        private void cboSimulado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSimulado.SelectedIndex != -1)
            {
                DataRowView reg = (DataRowView)cboSimulado.SelectedItem;
                string nmr_questao1 = reg["prova1"].ToString();
                txtP1.Text =  nmr_questao1;
                prova1 = int.Parse(nmr_questao1);
                
                string nmr_questao2 = reg["prova2"].ToString();
                txtP2.Text = nmr_questao2;
                prova2 = int.Parse(nmr_questao2);

                btnIncluir.Enabled = true;

                Geral.Adaptador = new MySqlDataAdapter("SELECT (COUNT(c.rm)-s.prova2-s.prova1+1) Total " +
                                         "FROM corrigidos c " +
                                         "INNER JOIN simulados s ON s.simulado = 1 " +
                                        "WHERE c.simulado = @simulado " +
                                        "AND c.rm = c.rm " +
                                     "GROUP BY c.rm ", Geral.Conexao);
                Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@simulado", cboSimulado.SelectedValue);
                Geral.Adaptador.Fill(Geral.datTabela = new DataTable());
                if (Geral.datTabela.Rows.Count > 0)
                {
                    lblTotal_alunos.Text = Geral.datTabela.Rows.Count.ToString();
                }
            } else if (cboSimulado.SelectedIndex == -1)
            {
                btnIncluir.Enabled = false;
                lblTotal_alunos.Text = "0";
            }
        }
    }
}
