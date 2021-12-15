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
    public partial class frmSimulados : Form
    {
        //Pega a data atual
        DateTime localDate = DateTime.Now;

        void LimparCampos()
        {
            txtId.Clear();
            nmdNmrQ1.Text = "0";
            nmdSimulado.Text = "0";
            nmdNmrQ2.Text = "0";
            txtPesquisar_simulado.Clear();
            cboTipo_simulado.SelectedIndex = -1;

            //Formata a data das provas
            dtpProva_1.CustomFormat = "dd/MM/yyyy";
            dtpProva_1.Format = DateTimePickerFormat.Custom;
            dtpProva_2.CustomFormat = "dd/MM/yyyy";
            dtpProva_2.Format = DateTimePickerFormat.Custom;

            dtpProva_1.Value = localDate;
            dtpProva_2.Value = localDate;
        }

        void carregaGrid()
        {
            Geral.conectar();
            Geral.Adaptador = new MySqlDataAdapter("SELECT id, simulado Simulado, prova1 Nrm_Quest1, prova2 Nrm_Quest2, " +
                                                     "data_p1 Data_Prova_1, data_p2 Data_Prova_2, descricao Tipo " +
                                               "FROM Simulados " +
                                              "WHERE simulado LIKE @simulado " +
                                           "ORDER BY simulado ASC", Geral.Conexao);
            Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@simulado", txtPesquisar_simulado.Text + "%");
            Geral.Adaptador.Fill(Geral.datTabela = new DataTable());
            dgvSimulado.DataSource = Geral.datTabela;
            dgvSimulado.Columns[1].Width = 60;
            dgvSimulado.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSimulado.Columns[2].Width = 80;
            dgvSimulado.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSimulado.Columns[3].Width = 80;
            dgvSimulado.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSimulado.Columns[4].Width = 100;
            dgvSimulado.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSimulado.Columns[5].Width = 100;
            dgvSimulado.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Geral.desconectar();
        }

        public frmSimulados()
        {
            InitializeComponent();
        }

        private void frmSimulados_Load(object sender, EventArgs e)
        {
            LimparCampos();
            carregaGrid();

            dgvSimulado.Columns[0].Visible = false;
            Geral.desconectar();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (nmdSimulado.Value == 0)
            {
                MessageBox.Show("Simulado inválido", "Simulado 0!!",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (nmdNmrQ1.Value == 0)
            {
                MessageBox.Show("Informe o número de questões", "0 Questões!!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                nmdNmrQ1.Focus();
                return;
            }

            Geral.conectar();

            Geral.Adaptador = new MySqlDataAdapter("SELECT * " +
                                               "FROM Simulados " +
                                              "WHERE simulado = @simulado", Geral.Conexao);
            Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@simulado", nmdSimulado.Text);
            Geral.Adaptador.Fill(Geral.datTabela = new DataTable());
            if (Geral.datTabela.Rows.Count > 0)
            {
                MessageBox.Show("Simulado já esta cadastrado", "Já cadastrado",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                nmdSimulado.Focus();
                return;
            }

            Geral.desconectar();
            Geral.Conexao.Open();

            try
            {
                Geral.Comando = new MySqlCommand("INSERT INTO Simulados (simulado, prova1, prova2, data_p1, data_p2, descricao) " +
                                                       "VALUES (@simulado, @prova1, @prova2, @data_p1, @data_p2, @descricao)", Geral.Conexao);
                Geral.Comando.Parameters.AddWithValue("@simulado", nmdSimulado.Text);
                Geral.Comando.Parameters.AddWithValue("@prova1", nmdNmrQ1.Text);
                Geral.Comando.Parameters.AddWithValue("@prova2", nmdNmrQ2.Text);
                Geral.Comando.Parameters.AddWithValue("@data_p1", Convert.ToDateTime(dtpProva_1.Text));
                Geral.Comando.Parameters.AddWithValue("@data_p2", Convert.ToDateTime(dtpProva_2.Text));
                Geral.Comando.Parameters.AddWithValue("@descricao", cboTipo_simulado.SelectedItem);


                Geral.Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Geral.desconectar();

            LimparCampos();
            carregaGrid();
        }

        private void dgvSimulado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSimulado.RowCount > 0)
            {
                txtId.Text = dgvSimulado.CurrentRow.Cells[0].Value.ToString();
                nmdSimulado.Text = dgvSimulado.CurrentRow.Cells[1].Value.ToString();
                nmdNmrQ1.Text = dgvSimulado.CurrentRow.Cells[2].Value.ToString();
                nmdNmrQ2.Text = dgvSimulado.CurrentRow.Cells[3].Value.ToString();
                dtpProva_1.Text = dgvSimulado.CurrentRow.Cells[4].Value.ToString();
                dtpProva_2.Text = dgvSimulado.CurrentRow.Cells[5].Value.ToString();
                cboTipo_simulado.Text = dgvSimulado.CurrentRow.Cells[6].Value.ToString();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("ID não Informado", "PROBLEMA COM ID!!",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (nmdSimulado.Value == 0)
            {
                MessageBox.Show("Simulado inválido", "Simulado 0!!",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (nmdNmrQ1.Value == 0)
            {
                MessageBox.Show("Informe o número de questões", "0 Questões!!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                nmdNmrQ1.Focus();
                return;
            }

            Geral.conectar();
            Geral.Adaptador = new MySqlDataAdapter("SELECT * " +
                                               "FROM Simulados " +
                                              "WHERE id <> @id " +
                                                     "AND simulado = @simulado", Geral.Conexao);
            Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@id", txtId.Text);
            Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@simulado", nmdSimulado.Text);
            Geral.Adaptador.Fill(Geral.datTabela = new DataTable());
            if (Geral.datTabela.Rows.Count > 0)
            {
                MessageBox.Show("Simulado já esta cadastrado", "Já cadastrado",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                nmdSimulado.Focus();
                return;
            }

            Geral.desconectar();
            Geral.conectar();

            try
            {
                Geral.Comando = new MySqlCommand("UPDATE Simulados " +
                                              "SET simulado = @simulado, prova1 = @prova1, prova2 =  @prova2, " +
                                                   "data_p1 = @data_p1, data_p2 = @data_p2, descricao = @descricao " +
                                            "WHERE id = @id", Geral.Conexao);
                Geral.Comando.Parameters.AddWithValue("@id", txtId.Text);
                Geral.Comando.Parameters.AddWithValue("@simulado", nmdSimulado.Text);
                Geral.Comando.Parameters.AddWithValue("@prova1", nmdNmrQ1.Text);
                Geral.Comando.Parameters.AddWithValue("@prova2", nmdNmrQ2.Text);
                Geral.Comando.Parameters.AddWithValue("@data_p1", Convert.ToDateTime(dtpProva_1.Text));
                Geral.Comando.Parameters.AddWithValue("@data_p2", Convert.ToDateTime(dtpProva_2.Text));
                Geral.Comando.Parameters.AddWithValue("@descricao", cboTipo_simulado.SelectedItem);

                Geral.Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Geral.Conexao.Close();
            LimparCampos();
            carregaGrid();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "") return;
            if (MessageBox.Show("Deseja Realmente Excluir o Simulado " + nmdSimulado.Text +"?" +
                "\n OBS: Isso ira apagar todos os dados do simulado " +
                "\n (Correção, gabarito e nota)",
                "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Geral.Conexao.Open();

                try
                {
                    Geral.Comando = new MySqlCommand("DELETE FROM Simulados WHERE id = @id", Geral.Conexao);
                    Geral.Comando.Parameters.AddWithValue("@id", txtId.Text);

                    Geral.Comando.ExecuteNonQuery();

                    Geral.Comando = new MySqlCommand("DELETE FROM provas WHERE simulado = @simulado", Geral.Conexao);
                    Geral.Comando.Parameters.AddWithValue("@simulado", nmdSimulado.Text);

                    Geral.Comando.ExecuteNonQuery();

                    Geral.Comando = new MySqlCommand("DELETE FROM notas WHERE simulado = @simulado", Geral.Conexao);
                    Geral.Comando.Parameters.AddWithValue("@simulado", nmdSimulado.Text);

                    Geral.Comando.ExecuteNonQuery();

                    Geral.Comando = new MySqlCommand("DELETE FROM corrigidos WHERE simulado = @simulado", Geral.Conexao);
                    Geral.Comando.Parameters.AddWithValue("@simulado", nmdSimulado.Text);

                    Geral.Comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                Geral.Conexao.Close();
                LimparCampos();
                carregaGrid();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            carregaGrid();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            carregaGrid();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtpProva_1_Validated(object sender, EventArgs e)
        {
            //Esse codigo esta adicionando UM dia na data da segunda prova, após sair do dtpProva_1
            dtpProva_2.Value = dtpProva_1.Value.AddDays(1);
        }
    }
}
