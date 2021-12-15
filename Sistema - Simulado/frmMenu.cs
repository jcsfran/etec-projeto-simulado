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
    public partial class frmMenu : Form
    {

        public frmMenu()
        {
            InitializeComponent();
        }

        public frmMenu(string id_usuario)
        {
            //Pega o ID do usuario e mostra no MENU, e verifica as suas permissoes
            InitializeComponent();
            Geral.Adaptador = new MySqlDataAdapter("SELECT id, nome, adm, cadastro, corretor FROM usuarios WHERE id = @id ", Geral.Conexao);
            Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@id", id_usuario);
            Geral.Adaptador.Fill(Geral.datTabela = new DataTable());

            tsmId.Text = id_usuario;
            tsmId.Visible = false;
            string usuario = Geral.datTabela.Rows[0][1].ToString();
            string adm = Geral.datTabela.Rows[0][2].ToString();
            string cadastro = Geral.datTabela.Rows[0][3].ToString();
            string corretor = Geral.datTabela.Rows[0][4].ToString();

            tsmUsuario.Text = usuario;
            if (adm == "True")
            {
                cadastrosToolStripMenuItem.Enabled = true;
                provasToolStripMenuItem.Enabled = true;

            }

            else if (cadastro == "True" & corretor == "True")
            {
                cadastrosToolStripMenuItem.Enabled = true;
                provasToolStripMenuItem.Enabled = true;
            }

            else if (cadastro == "True")
            {
                cadastrosToolStripMenuItem.Enabled = true;
                provasToolStripMenuItem.Enabled = false;
            }

            else if (corretor == "True")
            {
                cadastrosToolStripMenuItem.Enabled = false;
                provasToolStripMenuItem.Enabled = true;
            }

            else
            {
                cadastrosToolStripMenuItem.Enabled = false;
                provasToolStripMenuItem.Enabled = false;
            }
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlunos form = new frmAlunos();
            form.Show();
        }

        private void provaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProvas form = new frmProvas();
            form.Show();
        }

        private void treineirosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTreineiros form = new frmTreineiros();
            form.Show();
        }

        private void correçãoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //Envia o ID do usuario para o formulario de correcao
            frmCorrecao form = new frmCorrecao(tsmId.Text);
            form.Show();
        }

        private void simuladosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSimulados form = new frmSimulados();
            form.Show();
        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notas form = new Notas();
            form.Show();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCursos form = new frmCursos();
            form.Show();
        }

        private void finalizarSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void trocarDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin form = new frmLogin();
            this.Hide();
            form.ShowDialog();
        }

        private void usuáriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Envia o ID do usuario para o formulario de usuarios
            frmUsuarios form = new frmUsuarios(tsmId.Text);
            this.Close();
            form.Show();
        }

        private void removerAtualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRemocao form = new frmRemocao();
            form.Show();
        }
    }
}
