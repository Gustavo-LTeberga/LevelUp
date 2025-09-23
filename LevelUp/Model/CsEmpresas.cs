using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelUp.Model {
    public class CsEmpresas {

        public int Id { get; set; }

        public string Nome { get; set; }

        public DataTable Listar() {

            string comando = "SELECT id, Nome FROM empresas";

            BancoDeDados conexaoBD = new BancoDeDados();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Prepare();
            DataTable tabela = new DataTable();
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;

        }

        public bool Cadastrar() {


            string comand = "INSERT INTO empresas (Nome) VALUES " + "(@Nome)";
            BancoDeDados conexaoBD = new BancoDeDados();

            MySqlConnection con = conexaoBD.ObterConexao();

            MySqlCommand cmd = new MySqlCommand(comand, con);

            cmd.Parameters.AddWithValue("@Nome", Nome);


            // Obs.: Certifique-se de utilizar alguma método para obter o hash da senha antes de cadastrar!

            cmd.Prepare();

            // O trecho abaixo irá retornar true caso o cadastro dê certo:

            // Em caso de erro, experimente comentar o try/catch e executar novamente o código;

            // Grande parte dos problemas estão associados à um comando SQL incorreto. Verifique a string comando.

            try {

                if (cmd.ExecuteNonQuery() == 0) {

                    conexaoBD.Desconectar(con);

                    return false;

                }

                else {

                    conexaoBD.Desconectar(con);

                    return true;

                }

            }

            catch {

                conexaoBD.Desconectar(con);

                return false;

            }

        }

        public bool Modificar() {

            string comand = "UPDATE empresas SET Nome = @Nome WHERE Id = @Id";
            BancoDeDados conexaoBD = new BancoDeDados();

            MySqlConnection con = conexaoBD.ObterConexao();

            MySqlCommand cmd = new MySqlCommand(comand, con);

            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Parameters.AddWithValue("@Nome", Nome);


            cmd.Prepare();

            try {

                if (cmd.ExecuteNonQuery() == 0) {

                    conexaoBD.Desconectar(con);

                    return false;

                }

                else {

                    conexaoBD.Desconectar(con);

                    return true;

                }

            }

            catch {

                conexaoBD.Desconectar(con);

                return false;

            }

        }




    }
}
