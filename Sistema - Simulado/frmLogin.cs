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
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
            cboServer.SelectedIndex = 0;
            //Envia o IP selecionado para a class Geral 
            Geral servidor = new Geral(cboServer.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Verifica se os campos estão vazios
            if (txtUsuario.Text == "" && txtSenha.Text == "")
            {
                MessageBox.Show("Digite o usuário ee a senha, Login");
                txtUsuario.Focus();
                return;
            }

            Geral.conectar();
            try
            {
                //Verifica se o usuario existe
                Geral.Adaptador = new MySqlDataAdapter("SELECT id, senha, nome, adm FROM usuarios WHERE senha = @senha " +
                                                                       "AND nome = @usuario", Geral.Conexao);
                Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@senha", txtSenha.Text);
                Geral.Adaptador.SelectCommand.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                Geral.Adaptador.Fill(Geral.datTabela = new DataTable());
                if (Geral.datTabela.Rows.Count > 0)
                {
                    //Caso o usuario exista o formulario menu é aberto, levando as informações do usuario (seu ID)
                    string id_usuario = Geral.datTabela.Rows[0][0].ToString();
                    frmMenu form = new frmMenu(id_usuario);
                    this.Hide();
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("usuario ou senha invalidos!", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Tente outro IP", "IP Incorreto!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Geral.desconectar();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cboServer_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Envia o IP selecionado para a class Geral 
            Geral servidor = new Geral(cboServer.Text);
            if (cboServer.SelectedIndex == -1)
            {
                btnEntrar.Enabled = false;
            }

            else if (cboServer.SelectedIndex != -1)
            {
                btnEntrar.Enabled = true;
            }
      
        }
    }
}
