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
    public partial class frmUsuarios : Form
    {
        string adm = "", cadastro = "" , corretor = "";

        void LimparCampos()
        {
            txtId.Clear();
            txtNome.Clear();
            txtConfirmar.Clear();
            txtPesquisar.Clear();
            txtSenha.Clear();

            chbCorrigir.Checked = false;
            chbCadastrar.Checked = false;
            chbAdm.Checked = false;
        }

        void carregaGrid()
        {
            Geral.Adaptador = new MySqlDataAdapter("SELECT id, nome Nome, senha, adm ADM, cadastro Cadastros, " +
                                                           "corretor Corretor " +
                                                     "FROM Usuarios " +
                                                    "WHERE nome LIKE @nome " +
                                                 "ORDER BY nome", Geral.Conexao);
            Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@nome", txtPesquisar.Text + "%");
            Geral.Adaptador.Fill(Geral.datTabela = new DataTable());
            dgvUsuario.DataSource = Geral.datTabela;
            dgvUsuario.Columns[1].Width = 200;
            dgvUsuario.Columns[3].Width = 40;
            dgvUsuario.Columns[4].Width = 40;
            dgvUsuario.Columns[5].Width = 40;
        }

        public frmUsuarios()
        {
            InitializeComponent();
        }

        public frmUsuarios(string id_usuario)
        {
            InitializeComponent();
            Geral.Adaptador = new MySqlDataAdapter("SELECT id, nome, adm, cadastro, corretor " +
                                                     "FROM usuarios " +
                                                    "WHERE id = @id ", Geral.Conexao);
            Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@id", id_usuario);
            Geral.Adaptador.Fill(Geral.datTabela = new DataTable());

            txtId_usuario.Text = id_usuario;
            txtId_usuario.Visible = false;
            string usuario = Geral.datTabela.Rows[0][1].ToString();
            string id = Geral.datTabela.Rows[0][0].ToString();
            adm = Geral.datTabela.Rows[0][2].ToString();
            cadastro = Geral.datTabela.Rows[0][3].ToString();
            corretor = Geral.datTabela.Rows[0][4].ToString();
            if (adm == "True")
            {
                chbAdm.Enabled = true;
                btnRemover.Enabled = true;
                chbCorrigir.Enabled = true;
                chbCadastrar.Enabled = true;
            }

            else if (cadastro == "True" & corretor == "True")
            {
                txtNome.Text = usuario;
                txtId.Text = id;

                chbCadastrar.Checked = true;
                chbCorrigir.Checked = true;

                chbCorrigir.Enabled = true;
                chbCadastrar.Enabled = true;
                chbAdm.Enabled = false;

                btnRemover.Enabled = false;
                btnIncluir.Enabled = false;
            }

            else if (cadastro == "True")
            {
                txtNome.Text = usuario;
                txtId.Text = id;

                chbCadastrar.Checked = true;

                chbCadastrar.Enabled = true;
                chbAdm.Enabled = false;
                chbCorrigir.Enabled = false;

                btnRemover.Enabled = false;
                btnIncluir.Enabled = false;
            }

            else if (corretor == "True")
            {
                txtNome.Text = usuario;
                txtId.Text = id;

                chbCorrigir.Checked = true;

                chbCorrigir.Enabled = true;
                chbAdm.Enabled = false;
                chbCadastrar.Enabled = false;

                btnRemover.Enabled = false;
                btnIncluir.Enabled = false;
            }
            else
            {
                chbAdm.Enabled = false;
                chbCorrigir.Enabled = false;
                chbCadastrar.Enabled = false;

                btnRemover.Enabled = false;
                btnIncluir.Enabled = false;
            }
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            carregaGrid();

            dgvUsuario.Columns[2].Visible = false;
            dgvUsuario.Columns[0].Visible = false;

            Geral.Adaptador = new MySqlDataAdapter("SELECT senha, nome, adm " +
                                                     "FROM usuarios " +
                                                    "WHERE adm = '1'", Geral.Conexao);
            Geral.Adaptador.Fill(Geral.datTabela = new DataTable());
            if (Geral.datTabela.Rows.Count == 0)
            {
                if (MessageBox.Show("Nenhum Usuário ADM \n Deseja cadastrar um ADM?", "Nenhum ADM", MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    chbAdm.Enabled = true;
                    chbAdm.Checked = true;
                } else
                chbAdm.Enabled = true;
                
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "") return;
            if (txtSenha.Text == "") return;
            if (txtConfirmar.Text == "") return;
            if (txtSenha.Text == txtConfirmar.Text)
            {
                Geral.Adaptador = new MySqlDataAdapter("SELECT * FROM Usuarios where nome = @nome", Geral.Conexao);
                Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@nome", txtNome.Text);
                Geral.Adaptador.Fill(Geral.datTabela = new DataTable());
                if (Geral.datTabela.Rows.Count > 0)
                {
                    MessageBox.Show("Usuário Já Cadastrado com esse nome", "Inclusão",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNome.Focus();
                    return;
                }

                Geral.Conexao.Open();

                try
                {
                    Geral.Comando = new MySqlCommand("INSERT INTO Usuarios (nome, senha, adm, cadastro, corretor)  " +
                                                             "VALUES (@nome, @senha, @adm,  @cadastro,  @corretor)", Geral.Conexao);

                    Geral.Comando.Parameters.AddWithValue("@nome", txtNome.Text);
                    Geral.Comando.Parameters.AddWithValue("@senha", txtConfirmar.Text);
                    Geral.Comando.Parameters.AddWithValue("@adm", Convert.ToBoolean(chbAdm.Checked));
                    Geral.Comando.Parameters.AddWithValue("@cadastro", Convert.ToBoolean(chbCadastrar.Checked));
                    Geral.Comando.Parameters.AddWithValue("@corretor", Convert.ToBoolean(chbCorrigir.Checked));

                    Geral.Comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                LimparCampos();
                carregaGrid();

                Geral.Conexao.Close();
            }
            else
            {
                MessageBox.Show("A senha esta incorreta");
            }
        }

        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsuario.RowCount > 0)
            {
                txtId.Text = dgvUsuario.CurrentRow.Cells[0].Value.ToString();
                txtNome.Text = dgvUsuario.CurrentRow.Cells[1].Value.ToString();
                chbAdm.Checked = Convert.ToBoolean(dgvUsuario.CurrentRow.Cells[3].Value.ToString());
                chbCadastrar.Checked = Convert.ToBoolean(dgvUsuario.CurrentRow.Cells[4].Value.ToString());
                chbCorrigir.Checked = Convert.ToBoolean(dgvUsuario.CurrentRow.Cells[5].Value.ToString());
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "") return;
            if (txtSenha.Text == "" & adm == "False") return;
            if (txtConfirmar.Text == "" & adm == "False") return;
            if (txtId.Text != txtId_usuario.Text & adm == "False")
            {
                MessageBox.Show("Você não é esse usuário!!");
                LimparCampos();
                return;
            }

            if (adm == "True" & txtId.Text != txtId_usuario.Text)
            {
                Geral.Conexao.Open();

                try
                {
                    Geral.Comando = new MySqlCommand("UPDATE Usuarios " +
                                                        "SET adm=@adm, cadastro=@cadastro, corretor=@corretor " +
                                                      "WHERE id=@id", Geral.Conexao);

                    Geral.Comando.Parameters.AddWithValue("@id", Convert.ToInt16(txtId.Text));
                    Geral.Comando.Parameters.AddWithValue("@adm", Convert.ToBoolean(chbAdm.Checked));
                    Geral.Comando.Parameters.AddWithValue("@cadastro", Convert.ToBoolean(chbCadastrar.Checked));
                    Geral.Comando.Parameters.AddWithValue("@corretor", Convert.ToBoolean(chbCorrigir.Checked));
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

            else if (txtSenha.Text == txtConfirmar.Text & txtId_usuario.Text == txtId.Text)
            {

                Geral.Conexao.Open();

                try
                {
                    Geral.Comando = new MySqlCommand("UPDATE Usuarios " +
                                                        "SET nome=@nome, senha=@senha, adm=@adm, " +
                                                             "cadastro=@cadastro, corretor=@corretor " +
                                                      "WHERE id=@id", Geral.Conexao);

                    Geral.Comando.Parameters.AddWithValue("@id", Convert.ToInt16(txtId.Text));
                    Geral.Comando.Parameters.AddWithValue("@nome", txtNome.Text);
                    Geral.Comando.Parameters.AddWithValue("@senha", txtConfirmar.Text);
                    Geral.Comando.Parameters.AddWithValue("@adm", Convert.ToBoolean(chbAdm.Checked));
                    Geral.Comando.Parameters.AddWithValue("@cadastro", Convert.ToBoolean(chbCadastrar.Checked));
                    Geral.Comando.Parameters.AddWithValue("@corretor", Convert.ToBoolean(chbCorrigir.Checked));

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
            else
            {
                MessageBox.Show("A senha esta incorreta");
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "") return;
            if (MessageBox.Show("Deseja Realmente Excluir o Usuário " + txtNome.Text + "?",
                "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Geral.Conexao.Open();

                try
                {
                    Geral.Comando = new MySqlCommand("DELETE FROM Usuarios WHERE id = @id", Geral.Conexao);
                    Geral.Comando.Parameters.AddWithValue("@id", txtId.Text);

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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Geral.Adaptador = new MySqlDataAdapter("SELECT senha, nome, adm FROM usuarios", Geral.Conexao);
            Geral.Adaptador.Fill(Geral.datTabela = new DataTable());
            if (Geral.datTabela.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum Usuário Cadastrado. \n O sistema sera encerrado", "Nenhum Usuário");
                Application.Exit();
            }
            else if (txtId_usuario.Text == "")
            {
                frmLogin form = new frmLogin();
                this.Close();
                form.Show();
            }

            Geral.Adaptador = new MySqlDataAdapter("SELECT senha, nome, adm " +
                                                     "FROM usuarios " +
                                                    "WHERE id = @id", Geral.Conexao);
            Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@id", txtId_usuario.Text);
            Geral.Adaptador.Fill(Geral.datTabela = new DataTable());
            if (Geral.datTabela.Rows.Count > 0)
            {
                string id_usuario = txtId_usuario.Text;
                frmMenu form = new frmMenu(id_usuario);
                this.Close();
                form.Show();
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
    }
}
