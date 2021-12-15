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
    public partial class frmRemocao : Form
    {
        public frmRemocao()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        void carregaComboSimulado()
        {
            Geral.Adaptador = new MySqlDataAdapter("SELECT * FROM Simulados " +
                                                 "ORDER BY simulado ASC", Geral.Conexao);
            Geral.Adaptador.Fill(Geral.datTabela = new DataTable());
            cboSimulado.DataSource = Geral.datTabela;
            cboSimulado.DisplayMember = "simulado";
            cboSimulado.ValueMember = "simulado";
        }

        private void frmRemocao_Load(object sender, EventArgs e)
        {
            carregaComboSimulado();
            cboProva.SelectedIndex = -1;
            cboSimulado.SelectedIndex = -1;
            cboProva.Enabled = false;
            btnRemover.Enabled = false;

            Geral.desconectar();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
        if (MessageBox.Show("Deseja Realmente Atualizar os Alunos?" +
                    "\n Ao clicar em 'SIM' todos os alunos do 3º Ano serão exluidos," +
                    "\n passando os do 2º Ano para o 3º Ano e " +
                    "\n do 1º para o 2º Ano.",
                "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Geral.Conexao.Open();
                    try
                    {
                        Geral.Comando = new MySqlCommand("DELETE FROM Alunos " +
                                                               "WHERE ano = 3", Geral.Conexao);

                        Geral.Comando.ExecuteNonQuery();

                        Geral.Comando = new MySqlCommand("UPDATE Alunos " +
                                                          "SET ano = 3 " +
                                                        "WHERE ano = 2", Geral.Conexao);

                        Geral.Comando.ExecuteNonQuery();

                        Geral.Comando = new MySqlCommand("UPDATE Alunos " +
                                                       "SET ano = 2 " +
                                                     "WHERE ano = 1", Geral.Conexao);

                        Geral.Comando.ExecuteNonQuery();
                        Geral.desconectar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
            }
        }

        private void cboProva_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemover.Enabled = true;

       
            Geral.Adaptador = new MySqlDataAdapter("SELECT COUNT(c.corrigido) Total " +
             "FROM corrigidos c " +
            "WHERE c.simulado = @simulado " +
            "AND c.corrigido = 0 " +
            "AND c.prova = @prova " +
            "AND c.rm = c.rm " +
            "GROUP BY c.rm ", Geral.Conexao);
            Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@simulado", cboSimulado.Text);
            Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@prova", cboProva.Text);
            Geral.Adaptador.Fill(Geral.datTabela = new DataTable());
            if (Geral.datTabela.Rows.Count > 0)
            {
                lblTotal_alunos.Text = Geral.datTabela.Rows.Count.ToString();
            }
            else if (Geral.datTabela.Rows.Count <= 0)
            {
                lblTotal_alunos.Text = "0";
            }
            Geral.Adaptador = new MySqlDataAdapter("SELECT c.corrigido Total " +
             "FROM corrigidos c " +
            "WHERE c.simulado = @simulado " +
            "AND c.corrigido = 0 " +
            "AND c.prova = @prova ", Geral.Conexao);
            Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@simulado", cboSimulado.Text);
            Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@prova", cboProva.Text);
            Geral.Adaptador.Fill(Geral.datTabela = new DataTable());
            if (Geral.datTabela.Rows.Count > 0)
            {
                lblTotal_linhas.Text = Geral.datTabela.Rows.Count.ToString();
            }
            else if (Geral.datTabela.Rows.Count <= 0)
            {
                lblTotal_linhas.Text = "0";
            }

        }

        private void cboSimulado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboProva.Enabled = true;
            lblTotal_linhas.Text = "0";
            lblTotal_alunos.Text = "0";
            cboProva.SelectedIndex = -1;

            btnRemover.Enabled = false;

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja remover todas as ausencias do simulado " + cboSimulado.Text + "?",
                "Remoção", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Geral.Conexao.Open();
                Geral.Comando = new MySqlCommand("DELETE FROM corrigidos " +
                                                  "WHERE corrigido = 0 AND simulado = @simulado AND prova = @prova ", Geral.Conexao);
                Geral.Comando.Parameters.AddWithValue("@simulado", cboSimulado.Text);
                Geral.Comando.Parameters.AddWithValue("@prova", cboProva.Text);

                Geral.Comando.ExecuteNonQuery();
                Geral.Conexao.Close();
            }
        }
    }
}
