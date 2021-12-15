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
    public partial class frmCursos : Form
    {
   
        void LimparCampos()
        {
            txtId.Clear();
            txtDescricao.Clear();
            txtPesquisa.Clear();
        }

        void CarregaGrid()
        {
            Geral.Adaptador = new MySqlDataAdapter("SELECT id, descricao Curso " +
                                                     "FROM cursos " +
                                                    "WHERE descricao " +
                                                     "LIKE @descricao " +
                                                 "ORDER BY descricao ASC", Geral.Conexao);
            Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@descricao", txtPesquisa.Text + "%");
            Geral.Adaptador.Fill(Geral.datTabela = new DataTable());
            dgvCursos.DataSource = Geral.datTabela;
            dgvCursos.Columns[1].Width = 150;
        }

        public frmCursos()
        {
            InitializeComponent();
        }

        private void frmCursos_Load(object sender, EventArgs e)
        {
            CarregaGrid();
            LimparCampos();
            dgvCursos.Columns[0].Visible = false;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text == "")
            {
                MessageBox.Show("Informe o Curso", "Problema com o Curso!!",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Geral.Conexao.Open();

            try
            {
                Geral.Comando = new MySqlCommand("INSERT INTO cursos (descricao)  " +
                                                             "VALUES (@descricao)", Geral.Conexao);

                Geral.Comando.Parameters.AddWithValue("@descricao", txtDescricao.Text);

                Geral.Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            Geral.Conexao.Close();
            LimparCampos();
            CarregaGrid();
        }

        private void dgvCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCursos.RowCount > 0)
            {
                txtId.Text = dgvCursos.CurrentRow.Cells[0].Value.ToString();
                txtDescricao.Text = dgvCursos.CurrentRow.Cells[1].Value.ToString();
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

            if (txtDescricao.Text == "")
            {
                MessageBox.Show("Informe o Curso", "Problema com o Curso!!",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Geral.Conexao.Open();

            try
            {
                Geral.Comando = new MySqlCommand("UPDATE cursos " +
                                                    "SET descricao=@descricao " +
                                                    "WHERE id=@id", Geral.Conexao);

                Geral.Comando.Parameters.AddWithValue("@id", Convert.ToInt16(txtId.Text));
                Geral.Comando.Parameters.AddWithValue("@descricao", txtDescricao.Text);

                Geral.Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Geral.Conexao.Close();
            LimparCampos();
            CarregaGrid();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            CarregaGrid();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "") return;
            if (MessageBox.Show("Deseja Realmente Excluir o curso " + txtDescricao.Text + "?",
                "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Geral.Conexao.Open();
                Geral.Comando = new MySqlCommand("DELETE FROM cursos " +
                                                  "WHERE id = @id", Geral.Conexao);
                Geral.Comando.Parameters.AddWithValue("@id", txtId.Text);

                Geral.Comando.ExecuteNonQuery();
                Geral.Conexao.Close();
                LimparCampos();
                CarregaGrid();
            }
        }
    }
}
