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
    public partial class frmProvas : Form
    {

        void LimparCampos()
        {
            txtId.Clear();
            nmdQuestao.Text = "0";
            txtPesquisar_questao.Clear();
            txtPesquisar_prova.Clear();
            txtPesquisar_simulado.Clear();

            cboSimulado.SelectedIndex = -1;
            cboMateria.SelectedIndex = -1;
            cboGabarito.SelectedIndex = -1;
            cboProva.SelectedIndex = -1;

            chbAnular.Checked = false;

            mtbData_simulado.Clear();
        }

        void carregaComboSimulado()
        {
            Geral.Adaptador = new MySqlDataAdapter("SELECT * FROM Simulados ORDER BY simulado ASC", Geral.Conexao);
            Geral.Adaptador.Fill(Geral.datTabela = new DataTable());
            cboSimulado.DataSource = Geral.datTabela;
            cboSimulado.DisplayMember = "simulado";
            cboSimulado.ValueMember = "simulado";
        }

        void carregaGrid()
        {
            Geral.Adaptador = new MySqlDataAdapter("SELECT p.id, p.simulado Simulado, p.questao Questao, p.gabarito Gabarito, " +
                                                     "p.materia Materia, p.prova Prova, " +
                                                     "p.data_prova Data_Simulado, " +
                                                     "p.anulado Anulado " +
                                                     "FROM Provas p " +
                                                    "WHERE p.questao LIKE @questao " +
                                                      "AND p.simulado LIKE @simulado " +
                                                      "AND p.prova LIKE @prova " +
                                                 "ORDER BY questao ASC", Geral.Conexao);
            Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@questao", txtPesquisar_questao.Text + "%");
            Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@simulado", txtPesquisar_simulado.Text + "%");
            Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@prova", txtPesquisar_prova.Text + "%");
            Geral.Adaptador.Fill(Geral.datTabela = new DataTable());
            dgvProva.DataSource = Geral.datTabela;
            dgvProva.Columns[1].Width = 40;
            dgvProva.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProva.Columns[2].Width = 50;
            dgvProva.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProva.Columns[3].Width = 50;
            dgvProva.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProva.Columns[4].Width = 75;
            dgvProva.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProva.Columns[5].Width = 50;
            dgvProva.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProva.Columns[6].Width = 90;
            dgvProva.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        public frmProvas()
        {
            InitializeComponent();
        }

        private void frmProvas_Load(object sender, EventArgs e)
        {
            carregaComboSimulado();
            LimparCampos();
            carregaGrid();

            dgvProva.Columns[0].Visible = false;
            dgvProva.Columns[7].Visible = false;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (nmdQuestao.Value == 0)
            {
                return;
            }

            if (cboSimulado.SelectedIndex == -1)
            {
                MessageBox.Show("Simulado não Selecionado", "Não Selecionado!!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboSimulado.Focus();
                return;
            }

            if (cboProva.SelectedIndex == -1)
            {
                MessageBox.Show("Prova não Selecionada", "Não Selecionado!!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboSimulado.Focus();
                return;
            }

            if (cboGabarito.SelectedIndex == -1)
            {
                MessageBox.Show("Gabarito não Selecionado", "Não Selecionado!!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboGabarito.Focus();
                return;
            }

            if (cboMateria.SelectedIndex == -1)
            {
                MessageBox.Show("Matéria não Selecionada", "Não Selecionado!!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboMateria.Focus();
                return;
            }

            Geral.conectar();
            Geral.Adaptador = new MySqlDataAdapter("SELECT * " +
                                                     "FROM Provas " +
                                                     "WHERE questao = @questao " +
                                                       "AND simulado = @simulado " +
                                                       "AND prova = @prova", Geral.Conexao);
            Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@questao", nmdQuestao.Text);
            Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@simulado", cboSimulado.SelectedValue);
            Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@prova", cboProva.SelectedItem);
            Geral.Adaptador.Fill(Geral.datTabela = new DataTable());
            if (Geral.datTabela.Rows.Count > 0)
            {
                MessageBox.Show("Número da questão já foi cadastrado", "Já cadastrado",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                nmdQuestao.Focus();
                return;
            }

            Geral.desconectar();
            Geral.conectar();

            try
            {
                Geral.Comando = new MySqlCommand("INSERT INTO Provas (materia, gabarito, questao, data_prova, " +
                                                           "prova, simulado) " +
                                                  "VALUES (@materia, @gabarito, @questao, @data_prova, " +
                                                           "@prova, @simulado)", Geral.Conexao);
                Geral.Comando.Parameters.AddWithValue("@questao", nmdQuestao.Text);
                Geral.Comando.Parameters.AddWithValue("@gabarito", cboGabarito.SelectedItem);
                Geral.Comando.Parameters.AddWithValue("@materia", cboMateria.SelectedItem);
                Geral.Comando.Parameters.AddWithValue("@data_prova", Convert.ToDateTime(mtbData_simulado.Text));
                Geral.Comando.Parameters.AddWithValue("@prova", cboProva.SelectedItem);
                Geral.Comando.Parameters.AddWithValue("@simulado", cboSimulado.SelectedValue);


                Geral.Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Geral.desconectar();

            int n_questao = int.Parse(nmdQuestao.Text) + 1;
            nmdQuestao.Text = n_questao.ToString();
            
            cboGabarito.SelectedIndex = -1;

            carregaGrid();
        }

        private void dgvProva_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProva.RowCount > 0)
            {
                txtId.Text = dgvProva.CurrentRow.Cells[0].Value.ToString();
                nmdQuestao.Text = dgvProva.CurrentRow.Cells[2].Value.ToString();
                cboGabarito.Text = dgvProva.CurrentRow.Cells[3].Value.ToString();
                cboMateria.Text = dgvProva.CurrentRow.Cells[4].Value.ToString();
                mtbData_simulado.Text = dgvProva.CurrentRow.Cells[6].Value.ToString();
                cboProva.Text = dgvProva.CurrentRow.Cells[5].Value.ToString();
                cboSimulado.Text = dgvProva.CurrentRow.Cells[1].Value.ToString();
                chbAnular.Checked = Convert.ToBoolean(Convert.ToInt16(dgvProva.CurrentRow.Cells[7].Value.ToString()));

                cboGabarito.Enabled = true;
                cboMateria.Enabled = true;
                cboProva.Enabled = true;
                cboSimulado.Enabled = true;
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

            if (cboSimulado.SelectedIndex == -1)
            {
                MessageBox.Show("Simulado não Selecionado", "Não Selecionado!!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboSimulado.Focus();
                return;
            }

            if (cboProva.SelectedIndex == -1)
            {
                MessageBox.Show("Prova não Selecionada", "Não Selecionado!!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboSimulado.Focus();
                return;
            }

            if (cboGabarito.SelectedIndex == -1)
            {
                MessageBox.Show("Gabarito não Selecionado", "Não Selecionado!!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboGabarito.Focus();
                return;
            }

            if (cboMateria.SelectedIndex == -1)
            {
                MessageBox.Show("Matéria não Selecionada", "Não Selecionado!!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboMateria.Focus();
                return;
            }

            Geral.conectar();
            Geral.Adaptador = new MySqlDataAdapter("SELECT * " +
                                               "FROM Provas " +
                                              "WHERE id <> @id " +
                                                     "AND questao = @questao " +
                                                     "AND simulado = @simulado " +
                                                     "AND prova = @prova", Geral.Conexao);
            Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@id", txtId.Text);
            Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@questao", nmdQuestao.Text);
            Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@simulado", cboSimulado.SelectedValue);
            Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@prova", cboProva.SelectedItem);
            Geral.Adaptador.Fill(Geral.datTabela = new DataTable());
            if (Geral.datTabela.Rows.Count > 0)
            {
                MessageBox.Show("Número da questão já foi cadastrado", "Já cadastrado",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                nmdQuestao.Focus();
                return;
            }
            Geral.desconectar();

                Geral.conectar();
                Geral.Comando = new MySqlCommand("UPDATE Provas " +
                                          "SET materia = @materia, gabarito = @gabarito, questao =  @questao, " +
                                               "data_prova = @data_prova, prova = @prova, " +
                                               "simulado = @simulado, anulado = @anular " +
                                        "WHERE id = @id", Geral.Conexao);
                Geral.Comando.Parameters.AddWithValue("@id", Convert.ToInt16(txtId.Text));
                Geral.Comando.Parameters.AddWithValue("@questao", nmdQuestao.Text);
                Geral.Comando.Parameters.AddWithValue("@gabarito", cboGabarito.SelectedItem);
                Geral.Comando.Parameters.AddWithValue("@materia", cboMateria.SelectedItem);
                Geral.Comando.Parameters.AddWithValue("@data_prova", Convert.ToDateTime(mtbData_simulado.Text));
                Geral.Comando.Parameters.AddWithValue("@prova", cboProva.SelectedItem);
                Geral.Comando.Parameters.AddWithValue("@simulado", cboSimulado.SelectedValue);
            Geral.Comando.Parameters.AddWithValue("@anular", Convert.ToInt16(chbAnular.Checked));

            Geral.Comando.ExecuteNonQuery();
                Geral.desconectar();

            LimparCampos();
            carregaGrid();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "") return;
            if (MessageBox.Show("Deseja Realmente Excluir a Prova? " + nmdQuestao.Text + " Materia: " + cboMateria.SelectedItem,
                "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Geral.conectar();

                try
                {
                    Geral.Comando = new MySqlCommand("DELETE FROM Provas WHERE id = @id", Geral.Conexao);
                    Geral.Comando.Parameters.AddWithValue("@id", txtId.Text);

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

        private void cboSimulado_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Pega a data da prova selecionada e seu numero MAX de questoes
            cboProva.Enabled = false;
            if (cboSimulado.SelectedIndex != -1)
            {
                cboProva.Enabled = true;
                DataRowView reg = (DataRowView)cboSimulado.SelectedItem;
                if (cboProva.SelectedIndex == -1)
                {
                    cboProva.Focus();
                }

                else if (cboProva.SelectedItem.ToString() == "1")
                {
                    string nmr_questao = reg["prova1"].ToString();
                    lblQuestao.Text = "Max: " + nmr_questao;
                    nmdQuestao.Maximum = int.Parse(nmr_questao);

                    mtbData_simulado.Text = reg["data_p1"].ToString();
                }
                else if (cboProva.SelectedItem.ToString() == "2")
                {
                    string nmr_questao = reg["prova2"].ToString();
                    lblQuestao.Text = "Max: " + nmr_questao;
                    nmdQuestao.Maximum = int.Parse(nmr_questao);

                    mtbData_simulado.Text = reg["data_p2"].ToString();
                }
            }
        }

        private void cboProva_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Pega a data da prova selecionada e seu numero MAX de questoes
            cboMateria.Enabled = false;
            if (cboSimulado.SelectedIndex != -1)
            {
                cboMateria.Enabled = true;
                DataRowView reg = (DataRowView)cboSimulado.SelectedItem;
                if (cboProva.SelectedIndex == -1)
                {
                    cboProva.Focus();
                }

                else if (cboProva.SelectedItem.ToString() == "1")
                {
                    string nmr_questao = reg["prova1"].ToString();
                    lblQuestao.Text = "Max: " + nmr_questao;
                    nmdQuestao.Maximum = int.Parse(nmr_questao);

                    mtbData_simulado.Text = reg["data_p1"].ToString();
                }
                else if (cboProva.SelectedItem.ToString() == "2")
                {
                    string nmr_questao = reg["prova2"].ToString();
                    lblQuestao.Text = "Max: " + nmr_questao;
                    nmdQuestao.Maximum = int.Parse(nmr_questao);

                    mtbData_simulado.Text = reg["data_p2"].ToString();
                }
            }
        }

        private void cboMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMateria.SelectedIndex == -1)
            {
                cboGabarito.Enabled = false;
            } else
            {
                cboGabarito.Enabled = true;
            }

        }

        private void cboGabarito_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGabarito.SelectedIndex == -1)
            {
                btnIncluir.Enabled = false;
                btnAtualizar.Enabled = false;
            }
            else
            {
                btnIncluir.Enabled = true;
                btnAtualizar.Enabled = true;
            }
        }
    }
}
