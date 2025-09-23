using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelUp.Model {
    public class CsJogos {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Ano { get; set; }
        public double Preco { get; set; }
        public int EmpresaId { get; set; }
        public bool Comercio { get; set; }

        public DataTable Listar() {

            string comando = "SELECT id, Nome, Ano, Preco, EmpresaId, Comercio FROM games";

            BancoDeDados conexaoBD = new BancoDeDados();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Prepare();
            DataTable tabela = new DataTable();
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;

        }

        public bool Ativar() {

            string comand = "UPDATE games SET Comercio = true WHERE id = @id";
            BancoDeDados conexaoBD = new BancoDeDados();

            MySqlConnection con = conexaoBD.ObterConexao();

            MySqlCommand cmd = new MySqlCommand(comand, con);

            cmd.Parameters.AddWithValue("@id", Id);




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

        public bool Desativar() {

            string comand = "UPDATE games SET Comercio = false WHERE id = @id";
            BancoDeDados conexaoBD = new BancoDeDados();

            MySqlConnection con = conexaoBD.ObterConexao();

            MySqlCommand cmd = new MySqlCommand(comand, con);

            cmd.Parameters.AddWithValue("@id", Id);




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

        public bool Cadastrar() {


            string comand = "INSERT INTO games (Nome, Preco, Ano, EmpresaId) VALUES " + "(@Nome, @Preco, @Ano, @EmpresaId)";
            BancoDeDados conexaoBD = new BancoDeDados();

            MySqlConnection con = conexaoBD.ObterConexao();

            MySqlCommand cmd = new MySqlCommand(comand, con);

            cmd.Parameters.AddWithValue("@nome", Nome);
            cmd.Parameters.AddWithValue("@preco", Preco);
            cmd.Parameters.AddWithValue("@Ano", Ano);
            cmd.Parameters.AddWithValue("@EmpresaId", EmpresaId);







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

            string comand = "UPDATE games SET Nome = @Nome, " + "Preco = @Preco, Ano = @Ano, EmpresaId = @EmpresaId  WHERE Id = @Id";
            BancoDeDados conexaoBD = new BancoDeDados();

            MySqlConnection con = conexaoBD.ObterConexao();

            MySqlCommand cmd = new MySqlCommand(comand, con);

            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Parameters.AddWithValue("@Nome", Nome);
            cmd.Parameters.AddWithValue("@Preco", Preco);
            cmd.Parameters.AddWithValue("@Ano", Ano);
            cmd.Parameters.AddWithValue("@EmpresaId", EmpresaId);


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
