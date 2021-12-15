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
    public partial class frmAlunos : Form
    {

        void LimparCampos()
        {
            txtId.Clear();
            txtNome.Clear();
            txtPesquisar.Clear();
            txtRm.Clear();

            cboCurso.SelectedIndex = -1;
            cboAno.SelectedIndex = -1;
        }

        void carregaGrid()
        {
            Geral.conectar();
            Geral.Adaptador = new MySqlDataAdapter("SELECT a.id, a.nome Nome, a.rm RM, c.descricao Curso, a.ano Ano " +
                                                     "FROM Alunos a " +
                                               "INNER JOIN cursos c ON c.id = a.curso " +
                                                    "WHERE a.rm like @rm " +
                                                 "ORDER BY a.rm DESC", Geral.Conexao);
            Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@rm", "%" + txtPesquisar.Text + "%");
            Geral.Adaptador.Fill(Geral.datTabela = new DataTable());
            dgvAlunos.DataSource = Geral.datTabela;
            dgvAlunos.Columns[1].Width = 250;
            dgvAlunos.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
            dgvAlunos.Columns[2].Width = 50;
            dgvAlunos.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAlunos.Columns[3].Width = 150;
            dgvAlunos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
            dgvAlunos.Columns[4].Width = 40;
            dgvAlunos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Geral.desconectar();
        }

        void carregaComboCurso()
        {
            Geral.conectar();
            Geral.Adaptador = new MySqlDataAdapter("SELECT * FROM cursos " +
                                                 "ORDER BY descricao ASC", Geral.Conexao);
            Geral.Adaptador.Fill(Geral.datTabela = new DataTable());
            cboCurso.DataSource = Geral.datTabela;
            cboCurso.DisplayMember = "descricao";
            cboCurso.ValueMember = "id";
            Geral.desconectar();
        }

        public frmAlunos()
        {
            InitializeComponent();
        }

        private void frmAlunos_Load(object sender, EventArgs e)
        {
            carregaComboCurso();
            LimparCampos();
            carregaGrid();
           
            dgvAlunos.Columns[0].Visible = false;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtRm.Text == "")
            {
                MessageBox.Show("RM não Informado", "Informe o RM!!",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtRm.Focus();
                return;
            }

            if (txtNome.Text == "")
            {
                MessageBox.Show("Nome não Informado", "Informe o Nome!!",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNome.Focus();
                return;
            }

            if (cboAno.SelectedIndex == -1)
            {
                MessageBox.Show("Ano não Selecionado", "Não Selecionado!!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboAno.Focus();
                return;
            }

            if (cboCurso.SelectedIndex == -1)
            {
                MessageBox.Show("Curso não Selecionado", "Não Selecionado!!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboCurso.Focus();
                return;
            }
            Geral.conectar();
            Geral.Adaptador = new MySqlDataAdapter("SELECT rm FROM Alunos " +
                                                    "WHERE rm = @rm", Geral.Conexao);
            Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@rm", txtRm.Text);
            Geral.Adaptador.Fill(Geral.datTabela = new DataTable());
            if (Geral.datTabela.Rows.Count > 0)
            {
                MessageBox.Show("RM já esta cadastrado", "Já cadastrado",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtRm.Focus();
                return;
            }
            Geral.desconectar();
            Geral.conectar();

            try
            {
                Geral.Comando = new MySqlCommand("INSERT INTO Alunos (nome, rm, curso, ano) " +
                                                             "VALUES (@nome, @rm, @curso, @ano)"
                                                             , Geral.Conexao);
                Geral.Comando.Parameters.AddWithValue("@nome", txtNome.Text);
                Geral.Comando.Parameters.AddWithValue("@rm", txtRm.Text);
                Geral.Comando.Parameters.AddWithValue("@curso", cboCurso.SelectedValue);
                Geral.Comando.Parameters.AddWithValue("@ano", cboAno.SelectedItem);

                Geral.Comando.ExecuteNonQuery();
                Geral.desconectar();
                LimparCampos();
                carregaGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
    
        }

        private void dgvAlunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAlunos.RowCount > 0)
            {
                txtId.Text = dgvAlunos.CurrentRow.Cells[0].Value.ToString();
                txtNome.Text = dgvAlunos.CurrentRow.Cells[1].Value.ToString();
                txtRm.Text = dgvAlunos.CurrentRow.Cells[2].Value.ToString();
                cboAno.Text = dgvAlunos.CurrentRow.Cells[4].Value.ToString();
                cboCurso.Text = dgvAlunos.CurrentRow.Cells[3].Value.ToString();
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
            if (txtRm.Text == "")
            {
                MessageBox.Show("RM não Informado", "Informe o RM!!",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtRm.Focus();
                return;
            }

            if (txtNome.Text == "")
            {
                MessageBox.Show("Nome não Informado", "Informe o Nome!!",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNome.Focus();
                return;
            }

            if (cboAno.SelectedIndex == -1)
            {
                MessageBox.Show("Ano não Selecionado", "Não Selecionado!!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboAno.Focus();
                return;
            }

            if (cboCurso.SelectedIndex == -1)
            {
                MessageBox.Show("Curso não Selecionado", "Não Selecionado!!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboCurso.Focus();
                return;
            }

            Geral.conectar();
            Geral.Adaptador = new MySqlDataAdapter("SELECT id, rm " +
                                                     "FROM Alunos " +
                                                    "WHERE rm = @rm " +
                                                      "AND id <> @id", Geral.Conexao);
            Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@id", txtId.Text);
            Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@rm", txtRm.Text);
            Geral.Adaptador.Fill(Geral.datTabela = new DataTable());
            if (Geral.datTabela.Rows.Count > 0)
            {
                MessageBox.Show("RM já esta cadastrado", "Já cadastrado",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtRm.Focus();
                return;
            }
            Geral.desconectar();

            Geral.conectar();
            try
            {
                Geral.Comando = new MySqlCommand("UPDATE Alunos " +
                                                    "SET nome = @nome, rm = @rm, curso =  @curso, ano = @ano " +
                                                  "WHERE id = @id", Geral.Conexao);
                Geral.Comando.Parameters.AddWithValue("@nome", txtNome.Text);
                Geral.Comando.Parameters.AddWithValue("@id", Convert.ToInt16(txtId.Text));
                Geral.Comando.Parameters.AddWithValue("@rm", txtRm.Text);
                Geral.Comando.Parameters.AddWithValue("@curso", cboCurso.SelectedValue);
                Geral.Comando.Parameters.AddWithValue("@ano", cboAno.SelectedItem);

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

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "") return;
            if (MessageBox.Show("Deseja Realmente Excluir o Aluno: " + txtNome.Text + " De RM: " + txtRm.Text + "?",
                "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Geral.Conexao.Open();
                try
                {
                    Geral.Comando = new MySqlCommand("DELETE FROM Alunos " +
                                                           "WHERE id = @id", Geral.Conexao);
                    Geral.Comando.Parameters.AddWithValue("@id", txtId.Text);

                    Geral.Comando.ExecuteNonQuery();
                    Geral.Conexao.Close();
                    LimparCampos();
                    carregaGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            carregaGrid();
            txtPesquisar.Clear();
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

        private void cboCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCurso.SelectedIndex != -1)
            {
                DataRowView reg = (DataRowView)cboCurso.SelectedItem;
                cboCurso.Text = reg["descricao"].ToString();
            }
        }
    }
}
