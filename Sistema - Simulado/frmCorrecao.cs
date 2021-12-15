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
    public partial class frmCorrecao : Form
    {
        string id_user = "";

        void LimparCampos()
        {
            for (int i = 0; i < dgvCorrecao.RowCount; i++)
            {
                dgvCorrecao.Rows[i].DataGridView.Columns.Clear();
            }

            cboAluno.SelectedIndex = -1;
            cboCurso.SelectedIndex = -1;
            cboProva.SelectedIndex = -1;
            cboSimulado.SelectedIndex = -1;
            cboAno.SelectedIndex = -1;

            btnCarregar.Enabled = false;
            btnConfirmar.Enabled = false;
            btnDesmarcar.Enabled = false;

            cboAluno.Enabled = false;
            cboProva.Enabled = false;
            cboSimulado.Enabled = false;
            cboCurso.Enabled = false;

            txtPesquisar_materia.Clear();
            txtPesquisar_questao.Clear();
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

        void carregaComboCurso()
        {
            Geral.Adaptador = new MySqlDataAdapter("SELECT * FROM cursos " +
                                                 "ORDER BY descricao DESC", Geral.Conexao);
            Geral.Adaptador.Fill(Geral.datTabela = new DataTable());
            cboCurso.DataSource = Geral.datTabela;
            cboCurso.DisplayMember = "descricao";
            cboCurso.ValueMember = "id";

        }

        void carregaComboAluno()
        {
            Geral.Adaptador = new MySqlDataAdapter("SELECT * FROM Alunos a " +
                                               "INNER JOIN corrigidos c ON a.rm = c.rm " +
                                                    "WHERE a.ano = @ano " +
                                                      "AND a.curso = @curso " +
                                                      "AND c.simulado = @simulado " +
                                                 "GROUP BY a.rm " +
                                                 "ORDER BY a.rm DESC", Geral.Conexao);
            Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@ano", cboAno.SelectedItem);
            Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@curso", cboCurso.SelectedValue);
            Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@simulado", cboSimulado.SelectedValue);
            Geral.Adaptador.Fill(Geral.datTabela = new DataTable());
            cboAluno.DataSource = Geral.datTabela;
            cboAluno.DisplayMember = "rm";
            cboAluno.ValueMember = "rm";
        }

        public frmCorrecao()
        {
            InitializeComponent();
        }

        public frmCorrecao(string id_usuario)
        {

            InitializeComponent();
            id_user = id_usuario;
            Geral.Adaptador = new MySqlDataAdapter("SELECT id, nome " +
                                                     "FROM usuarios " +
                                                    "WHERE id = @id ", Geral.Conexao);
            Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@id", id_user);
            Geral.Adaptador.Fill(Geral.datTabela = new DataTable());

            // txtId_Usuario.Text = id_usuario;
            // tsmId.Visible = false;
            string usuario = Geral.datTabela.Rows[0][1].ToString();

            lblUsuario.Text = usuario;
        }

        void carregaGrid()
        {
            //Geral.Conexao.Open();

            //Geral.Comando = new MySqlCommand("USE simulado", Geral.Conexao);
            //Geral.Comando.ExecuteNonQuery();

            Geral.conectar();

            Geral.Adaptador = new MySqlDataAdapter("SELECT c.rm RM, c.simulado Simulado, c.prova Prova, c.questao Questao, " +
                                                     "c.a A, c.b B, c.c C, c.d D, c.e E, p.materia Materia, p.gabarito, p.anulado " +
                                               "FROM corrigidos c " +
                                         "INNER JOIN Alunos a ON c.rm = a.rm " +
                                         "INNER JOIN Provas p ON c.simulado = p.simulado " +
                                                     "AND c.questao = p.questao " +
                                                     "AND c.prova = p.prova " +
                                         "WHERE c.rm = @rm " +
                                                "AND c.simulado LIKE @simulado " +
                                                "AND c.questao LIKE @questao " +
                                                "AND c.prova LIKE @prova " +
                                                "AND p.materia LIKE @materia " +
                                                "AND c.corrigido LIKE @corrigido " +
                                                "order by questao asc", Geral.Conexao);
            Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@rm", cboAluno.SelectedValue);
            Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@simulado", cboSimulado.SelectedValue);
            Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@questao", txtPesquisar_questao.Text + "%");
            Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@prova", cboProva.SelectedItem);
            Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@materia", txtPesquisar_materia.Text + "%");
            if (chbCorrigidos.Checked == true)
            {
                Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@corrigido", "%");
            } else
            {
                Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@corrigido", 0);
            }
            Geral.Adaptador.Fill(Geral.datTabela = new DataTable());
            dgvCorrecao.DataSource = Geral.datTabela;
            dgvCorrecao.Columns[0].Width = 40;
            dgvCorrecao.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCorrecao.Columns[1].Width = 40;
            dgvCorrecao.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCorrecao.Columns[2].Width = 40;
            dgvCorrecao.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCorrecao.Columns[3].Width = 55;
            dgvCorrecao.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;

            dgvCorrecao.Columns[4].Width = 40;
            dgvCorrecao.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCorrecao.Columns[5].Width = 40;
            dgvCorrecao.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCorrecao.Columns[6].Width = 40;
            dgvCorrecao.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCorrecao.Columns[7].Width = 40;
            dgvCorrecao.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCorrecao.Columns[8].Width = 40;
            dgvCorrecao.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCorrecao.Columns[9].Width = 120;
            dgvCorrecao.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCorrecao.Columns[0].ReadOnly = true;
            dgvCorrecao.Columns[1].ReadOnly = true;
            dgvCorrecao.Columns[2].ReadOnly = true;
            dgvCorrecao.Columns[3].ReadOnly = true;
            dgvCorrecao.Columns[9].ReadOnly = true;
            dgvCorrecao.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;


    

            if (dgvCorrecao.RowCount > 0)
            {
                dgvCorrecao.CurrentCell = dgvCorrecao.Rows[0].Cells[3];
            }

            Geral.desconectar();

        }

        private void frmCorrecao_Load(object sender, EventArgs e)
        {
            carregaComboSimulado();
            carregaComboCurso();
            carregaComboAluno();
            LimparCampos();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {

            if (cboAluno.SelectedIndex == -1)
            {
                MessageBox.Show("RM Não Selecionado!", "RM",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            carregaGrid();

            foreach (DataGridViewRow linha in dgvCorrecao.Rows)
            {
                if ((Convert.ToInt16(linha.Cells[11].Value) == 1))
                {
                    linha.DefaultCellStyle.BackColor = Color.LightCoral;
                }
            }
            dgvCorrecao.Columns[10].Visible = false;
            dgvCorrecao.Columns[11].Visible = false;
            btnConfirmar.Enabled = true;
            btnDesmarcar.Enabled = true;
        }

        private void btnDesmarcar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow linha in dgvCorrecao.Rows)
            {
                ((DataGridViewCheckBoxCell)linha.Cells[4]).Value = false;
            }

            foreach (DataGridViewRow linha in dgvCorrecao.Rows)
            {
                ((DataGridViewCheckBoxCell)linha.Cells[5]).Value = false;
            }

            foreach (DataGridViewRow linha in dgvCorrecao.Rows)
            {
                ((DataGridViewCheckBoxCell)linha.Cells[6]).Value = false;
            }

            foreach (DataGridViewRow linha in dgvCorrecao.Rows)
            {
                ((DataGridViewCheckBoxCell)linha.Cells[7]).Value = false;
            }

            foreach (DataGridViewRow linha in dgvCorrecao.Rows)
            {
                ((DataGridViewCheckBoxCell)linha.Cells[8]).Value = false;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Geral.Conexao.Open();
            int acertos = 0;
            try
            {
                foreach (DataGridViewRow linha in dgvCorrecao.Rows)
                {
                    Geral.Comando = new MySqlCommand("UPDATE corrigidos c " +
                                                "INNER JOIN Alunos a ON c.rm = a.rm " +
                                                "INNER JOIN Provas p ON c.simulado = p.simulado " +
                                                       "AND c.questao = p.questao " +
                                                       "AND c.prova = p.prova " +
                                                  "SET c.materia = p.materia, c.a = @a, c.b = @b, " +
                                                       "c.c = @c, c.d = @d, c.e = @e, " +
                                                       "c.corrigido = @corrigido, c.id_usuario = @id_usuario, " +
                                                       "c.nota = @nota " +
                                                "WHERE c.rm = @rm " +
                                                       "AND c.questao = @questao " +
                                                       "AND c.simulado = @simulado " +
                                                       "AND c.prova = @prova ", Geral.Conexao);
                    Geral.Comando.Parameters.AddWithValue("@rm", cboAluno.SelectedValue);
                    Geral.Comando.Parameters.AddWithValue("@questao", linha.Cells[3].Value);
                    Geral.Comando.Parameters.AddWithValue("@simulado", linha.Cells[1].Value);
                    Geral.Comando.Parameters.AddWithValue("@materia", linha.Cells[9].Value);
                    Geral.Comando.Parameters.AddWithValue("@prova", linha.Cells[2].Value);
                    Geral.Comando.Parameters.AddWithValue("@a", Convert.ToInt16(linha.Cells[4].Value));
                    Geral.Comando.Parameters.AddWithValue("@b", Convert.ToInt16(linha.Cells[5].Value));
                    Geral.Comando.Parameters.AddWithValue("@c", Convert.ToInt16(linha.Cells[6].Value));
                    Geral.Comando.Parameters.AddWithValue("@d", Convert.ToInt16(linha.Cells[7].Value));
                    Geral.Comando.Parameters.AddWithValue("@e", Convert.ToInt16(linha.Cells[8].Value));
                    Geral.Comando.Parameters.AddWithValue("@id_usuario", id_user);

                    int A = Convert.ToInt16(linha.Cells[4].Value);
                    int B = Convert.ToInt16(linha.Cells[5].Value);
                    int C = Convert.ToInt16(linha.Cells[6].Value);
                    int D = Convert.ToInt16(linha.Cells[7].Value);
                    int E = Convert.ToInt16(linha.Cells[8].Value);
                    Geral.Comando.Parameters.AddWithValue("@gabarito", linha.Cells[10].Value);

                    if ((Convert.ToInt16(linha.Cells[11].Value) == 1))
                    {
                        Geral.Comando.Parameters.AddWithValue("@nota", 0);
                    }
                    else if (A == 1 & linha.Cells[10].Value.ToString() == "A")
                    {
                        Geral.Comando.Parameters.AddWithValue("@nota", 1);
                        acertos++;
                    }

                    else if (B == 1 & linha.Cells[10].Value.ToString() == "B")
                    {
                        Geral.Comando.Parameters.AddWithValue("@nota", 1);
                        acertos++;
                    }


                    else if (C == 1 & linha.Cells[10].Value.ToString() == "C")
                    {
                        Geral.Comando.Parameters.AddWithValue("@nota", 1);
                        acertos++;
                    }

                    else if (D == 1 & linha.Cells[10].Value.ToString() == "D")
                    {
                        Geral.Comando.Parameters.AddWithValue("@nota", 1);
                        acertos++;
                    }

                    else if (E == 1 & linha.Cells[10].Value.ToString() == "E")
                    {
                        Geral.Comando.Parameters.AddWithValue("@nota", 1);
                        acertos++;
                    }

                    else
                    {
                        Geral.Comando.Parameters.AddWithValue("@nota", 0);
                    }

                    if (Convert.ToBoolean(linha.Cells[4].Value) == true)
                    {
                        if ((Convert.ToBoolean(linha.Cells[5].Value) != true) & (Convert.ToBoolean(linha.Cells[6].Value) != true)
                            & (Convert.ToBoolean(linha.Cells[7].Value) != true) & (Convert.ToBoolean(linha.Cells[8].Value) != true))
                            Geral.Comando.Parameters.AddWithValue("@corrigido", 1);
                        else
                        {
                            MessageBox.Show("Mais que uma resposta marcada! \n Questão: " + linha.Cells[3].Value, "Erro Gabarito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Geral.Conexao.Close();
                            return;
                        }
                    }
                    else if (Convert.ToBoolean(linha.Cells[5].Value) == true)
                    {
                        if ((Convert.ToBoolean(linha.Cells[4].Value) != true) & (Convert.ToBoolean(linha.Cells[6].Value) != true)
                            & (Convert.ToBoolean(linha.Cells[7].Value) != true) & (Convert.ToBoolean(linha.Cells[8].Value) != true))
                            Geral.Comando.Parameters.AddWithValue("@corrigido", 1);
                        else
                        {
                            MessageBox.Show("Mais que uma resposta marcada! \n Questão: " + linha.Cells[3].Value, "Erro Gabarito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Geral.Conexao.Close();
                            return;
                        }
                    }
                    else if (Convert.ToBoolean(linha.Cells[6].Value) == true)
                    {
                        if ((Convert.ToBoolean(linha.Cells[5].Value) != true) & (Convert.ToBoolean(linha.Cells[4].Value) != true)
                            & (Convert.ToBoolean(linha.Cells[7].Value) != true) & (Convert.ToBoolean(linha.Cells[8].Value) != true))
                            Geral.Comando.Parameters.AddWithValue("@corrigido", 1);
                        else
                        {
                            MessageBox.Show("Mais que uma resposta marcada! \n Questão: " + linha.Cells[3].Value, "Erro Gabarito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Geral.Conexao.Close();
                            return;
                        }
                    }
                    else if (Convert.ToBoolean(linha.Cells[7].Value) == true)
                    {
                        if ((Convert.ToBoolean(linha.Cells[5].Value) != true) & (Convert.ToBoolean(linha.Cells[6].Value) != true)
                            & (Convert.ToBoolean(linha.Cells[4].Value) != true) & (Convert.ToBoolean(linha.Cells[8].Value) != true))
                            Geral.Comando.Parameters.AddWithValue("@corrigido", 1);
                        else
                        {
                            MessageBox.Show("Mais que uma resposta marcada! \n Questão: " + linha.Cells[3].Value, "Erro Gabarito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Geral.Conexao.Close();
                            return;
                        }
                    }
                    else if (Convert.ToBoolean(linha.Cells[8].Value) == true)
                    {
                        if ((Convert.ToBoolean(linha.Cells[5].Value) != true) & (Convert.ToBoolean(linha.Cells[6].Value) != true)
                            & (Convert.ToBoolean(linha.Cells[7].Value) != true) & (Convert.ToBoolean(linha.Cells[4].Value) != true))
                            Geral.Comando.Parameters.AddWithValue("@corrigido", 1);
                        else
                        {
                            MessageBox.Show("Mais que uma resposta marcada! \n Questão: " + linha.Cells[3].Value, "Erro Gabarito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Geral.Conexao.Close();
                            return;
                        }
                    }
                    //else if ((Convert.ToBoolean(linha.Cells[4].Value) == false) & 
                    //         (Convert.ToBoolean(linha.Cells[5].Value) == false) &
                    //         (Convert.ToBoolean(linha.Cells[6].Value) == false) & 
                    //         (Convert.ToBoolean(linha.Cells[7].Value) == false) & 
                    //         (Convert.ToBoolean(linha.Cells[8].Value) == false)
                    //        )
                    //     { 
                    //        MessageBox.Show("Nenhuma resposta marcada! \n Questão: " + linha.Cells[3].Value, "Erro Gabarito", 
                    //                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    Geral.Conexao.Close();
                    //    return;
                    //     }
                    else
                    {
                        Geral.Comando.Parameters.AddWithValue("@corrigido", 0);
                    }
                    Geral.Comando.ExecuteNonQuery();
                }
                Geral.Conexao.Close();

                Geral.conectar();
                Geral.Adaptador = new MySqlDataAdapter("SELECT rm, simulado FROM notas " +
                                                        "WHERE rm = @rm AND simulado = @simulado ", Geral.Conexao);
                Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@rm", cboAluno.SelectedValue);
                Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@simulado", cboSimulado.SelectedValue);
                Geral.Adaptador.Fill(Geral.datTabela = new DataTable());
                if (Geral.datTabela.Rows.Count > 0)
                {
                    if (Convert.ToInt16(cboProva.SelectedItem) == 1)
                    {
                        Geral.Comando = new MySqlCommand("UPDATE notas " +
                                                       "SET prova1 = @prova1 " +
                                                       "WHERE rm = @rm AND simulado = @simulado ", Geral.Conexao);
                        Geral.Comando.Parameters.AddWithValue("@rm", cboAluno.SelectedValue);
                        Geral.Comando.Parameters.AddWithValue("@simulado", cboSimulado.SelectedValue);
                        Geral.Comando.Parameters.AddWithValue("@prova1", acertos);

                        Geral.Comando.ExecuteNonQuery();
                    }

                    if (Convert.ToInt16(cboProva.SelectedItem) == 2)
                    {
                        Geral.Comando = new MySqlCommand("UPDATE notas " +
                                                       "SET prova2 = @prova2 " +
                                                       "WHERE rm = @rm AND simulado = @simulado ", Geral.Conexao);
                        Geral.Comando.Parameters.AddWithValue("@rm", cboAluno.SelectedValue);
                        Geral.Comando.Parameters.AddWithValue("@simulado", cboSimulado.SelectedValue);
                        Geral.Comando.Parameters.AddWithValue("@prova2", acertos);

                        Geral.Comando.ExecuteNonQuery();
                    }
                } else
                {
                    if (Convert.ToInt16(cboProva.SelectedItem) == 1)
                    {
                        Geral.Comando = new MySqlCommand("INSERT INTO notas (rm, simulado, prova1) " +
                                            "VALUES (@rm, @simulado, @prova1) ", Geral.Conexao);
                        Geral.Comando.Parameters.AddWithValue("@rm", cboAluno.SelectedValue);
                        Geral.Comando.Parameters.AddWithValue("@simulado", cboSimulado.SelectedValue);
                        Geral.Comando.Parameters.AddWithValue("@prova1", acertos);
                        Geral.Comando.ExecuteNonQuery();
                    }

                    if (Convert.ToInt16(cboProva.SelectedItem) == 2)
                    {
                        Geral.Comando = new MySqlCommand("INSERT INTO notas (rm, simulado, prova2) " +
                                            "VALUES (@rm, @simulado, @prova2) ", Geral.Conexao);
                        Geral.Comando.Parameters.AddWithValue("@rm", cboAluno.SelectedValue);
                        Geral.Comando.Parameters.AddWithValue("@simulado", cboSimulado.SelectedValue);
                        Geral.Comando.Parameters.AddWithValue("@prova2", acertos);
                        Geral.Comando.ExecuteNonQuery();
                    }
                }
                Geral.desconectar();



                //Limapa os alguns campos
                for (int i = 0; i < dgvCorrecao.RowCount; i++)
                {
                    dgvCorrecao.Rows[i].DataGridView.Columns.Clear();
                }

                cboAluno.SelectedIndex = -1;

                txtPesquisar_materia.Clear();
                txtPesquisar_questao.Clear();
                //

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvCorrecao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (dgvCorrecao.RowCount > 0)
                {
                    if (Convert.ToBoolean(dgvCorrecao.CurrentRow.Cells[4].Value) == false)
                    {
                        ((DataGridViewCheckBoxCell)dgvCorrecao.CurrentRow.Cells[4]).Value = true;

                    }
                    else
                    {
                        ((DataGridViewCheckBoxCell)dgvCorrecao.CurrentRow.Cells[4]).Value = false;

                    }

                    if (Convert.ToBoolean(dgvCorrecao.CurrentRow.Cells[5].Value) == false)
                    {
                        ((DataGridViewCheckBoxCell)dgvCorrecao.CurrentRow.Cells[5]).Value = true;

                    }
                    else
                    {
                        ((DataGridViewCheckBoxCell)dgvCorrecao.CurrentRow.Cells[5]).Value = false;

                    }

                    if (Convert.ToBoolean(dgvCorrecao.CurrentRow.Cells[6].Value) == false)
                    {
                        ((DataGridViewCheckBoxCell)dgvCorrecao.CurrentRow.Cells[6]).Value = true;

                    }
                    else
                    {
                        ((DataGridViewCheckBoxCell)dgvCorrecao.CurrentRow.Cells[6]).Value = false;

                    }

                    if (Convert.ToBoolean(dgvCorrecao.CurrentRow.Cells[7].Value) == false)
                    {
                        ((DataGridViewCheckBoxCell)dgvCorrecao.CurrentRow.Cells[7]).Value = true;

                    }
                    else
                    {
                        ((DataGridViewCheckBoxCell)dgvCorrecao.CurrentRow.Cells[7]).Value = false;

                    }

                    if (Convert.ToBoolean(dgvCorrecao.CurrentRow.Cells[8].Value) == false)
                    {
                        ((DataGridViewCheckBoxCell)dgvCorrecao.CurrentRow.Cells[8]).Value = true;

                    }
                    else
                    {
                        ((DataGridViewCheckBoxCell)dgvCorrecao.CurrentRow.Cells[8]).Value = false;

                    }
                }
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            carregaGrid();
            dgvCorrecao.Columns[11].Visible = false;
            dgvCorrecao.Columns[10].Visible = false;
        }

        private void cboAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCurso.Enabled = true;
            cboAluno.SelectedIndex = -1;
            carregaComboAluno();
        }

        private void cboCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboProva.Enabled = true;
            cboAluno.SelectedIndex = -1;
            carregaComboAluno();
        }

        private void cboSimulado_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCarregar.Enabled = true;
            cboAluno.Enabled = true;
            cboAluno.SelectedIndex = -1;
            carregaComboAluno();
        }

        private void cboProva_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboSimulado.Enabled = true;
        }

        private void frmCorrecao_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Z)
            //{
            //    MessageBox.Show("AA");
            //}
        }
       
        private void dgvCorrecao_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            int linha = dgvCorrecao.CurrentRow.Index;
            if (e.KeyCode == Keys.A)
            {
                if (Convert.ToBoolean(dgvCorrecao.CurrentRow.Cells[4].Value) == false)
                {
                    ((DataGridViewCheckBoxCell)dgvCorrecao.CurrentRow.Cells[4]).Value = true;
                    linha++;
                    if (linha < 90)
                    {
                        dgvCorrecao.CurrentCell = dgvCorrecao.Rows[linha].Cells[3];
                    }
                }
                else
                {
                    ((DataGridViewCheckBoxCell)dgvCorrecao.CurrentRow.Cells[4]).Value = false;

                }
            }

            if (e.KeyCode == Keys.B)
            {
                if (Convert.ToBoolean(dgvCorrecao.CurrentRow.Cells[5].Value) == false)
                {
                    ((DataGridViewCheckBoxCell)dgvCorrecao.CurrentRow.Cells[5]).Value = true;
                    linha++;
                    if (linha < 90)
                    {
                        dgvCorrecao.CurrentCell = dgvCorrecao.Rows[linha].Cells[3];
                    }
                }
                else
                {
                    ((DataGridViewCheckBoxCell)dgvCorrecao.CurrentRow.Cells[5]).Value = false;

                }
            }

            if (e.KeyCode == Keys.C)
            {
                if (Convert.ToBoolean(dgvCorrecao.CurrentRow.Cells[6].Value) == false)
                {
                    ((DataGridViewCheckBoxCell)dgvCorrecao.CurrentRow.Cells[6]).Value = true;

                    linha++;
                    //foreach (DataGridViewRow linha in dgvCorrecao.Rows)
                    //{
                    //    if ((Convert.ToInt16(linha.Cells[3].Value) == b))
                    //    {
                    if (linha < 90)
                    { 
                            dgvCorrecao.CurrentCell = dgvCorrecao.Rows[linha].Cells[3];
                    }
                    //        return;
                    //    }
                    //}


                }
                else
                {
                    ((DataGridViewCheckBoxCell)dgvCorrecao.CurrentRow.Cells[6]).Value = false;

                }
            }

            if (e.KeyCode == Keys.D)
            {
                if (Convert.ToBoolean(dgvCorrecao.CurrentRow.Cells[7].Value) == false)
                {
                    ((DataGridViewCheckBoxCell)dgvCorrecao.CurrentRow.Cells[7]).Value = true;
                    linha++;
                    if (linha < 90)
                    {
                        dgvCorrecao.CurrentCell = dgvCorrecao.Rows[linha].Cells[3];
                    }
                }
                else
                {
                    ((DataGridViewCheckBoxCell)dgvCorrecao.CurrentRow.Cells[7]).Value = false;

                }
            }

            if (e.KeyCode == Keys.E)
            {
                if (Convert.ToBoolean(dgvCorrecao.CurrentRow.Cells[8].Value) == false)
                {
                    ((DataGridViewCheckBoxCell)dgvCorrecao.CurrentRow.Cells[8]).Value = true;
                    linha++;
                    if (linha < 90)
                    {
                        dgvCorrecao.CurrentCell = dgvCorrecao.Rows[linha].Cells[3];
                    }
                }
                else
                {
                    ((DataGridViewCheckBoxCell)dgvCorrecao.CurrentRow.Cells[8]).Value = false;
                    

                }
            }
        }
    }
}
