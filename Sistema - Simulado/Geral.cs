using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema___Simulado
{
    class Geral
    {
        public static MySqlConnection Conexao;
        public static MySqlCommand Comando;
        public static MySqlDataAdapter Adaptador;
        public static DataTable datTabela;
        private string ip;
        public static string servidor = "";

        //o IP esta recebendo o IP selecionado na cboServer (na tela de login)
        public Geral(string ip)
        {
            this.ip = ip;
            servidor = ip;
        }

        public static void conectar()
        {
           try
            {
                Conexao = new MySqlConnection("server=" + servidor + ";uid=simulado;pwd=;database=simulado");
                Conexao.Open();
            }

            catch
            {
                return;
            }
            

        }

        public static void desconectar()
        {

            Conexao.Close();

        }

    }
}
