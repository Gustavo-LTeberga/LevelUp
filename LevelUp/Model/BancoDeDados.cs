using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelUp.Model {
    internal class BancoDeDados {

        // Nas linhas abaixo você poderá mudar as informações da conexão com o bd:
        private const string SERVER = "localhost", // ip/domínio do servidor
                             PORT = "49170",
                             DATABASE = "levelup",
                             UID = "root",
                             PWD = "";
        /*
        IMPORTANTE!
        Ao enviar ao GitHub ou algum diretório público, altere as informações acima ou
        utilize variáveis de ambiente!
        */

        // Método para conectar ao bd. Deve ser instanciado por um objeto MySqlConnection
        public MySqlConnection ObterConexao() {
            MySqlConnection con = null;
            try {
                con = new MySqlConnection("SERVER=" + SERVER + ";PORT=" + PORT + ";DATABASE=" + DATABASE + ";UID=" + UID + ";PWD=" + PWD + ";");
                con.Open();
            }
            catch (MySqlException e) {

                Console.WriteLine(e.ToString());
                Console.WriteLine("Não foi possível realizar a conexão.");

            }
            return con;
        }

        // Método para verificar se a conexão está aberta:
        public bool ConexaoAberta(MySqlConnection con) {
            return (con.State == ConnectionState.Open);
        }

        // Método para desconectar:
        public void Desconectar(MySqlConnection con) {
            try {
                con.Close();
            }
            catch (MySqlException e) {
                Console.WriteLine(e.ToString());
                Console.WriteLine("Não foi possível encerrar a conexão.");
            }
        }

    }
}
