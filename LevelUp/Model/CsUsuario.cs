using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelUp.Model {
    public class CsUsuario {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool Ativo {  get; set; }

        public DataTable Logar() {

            string comando = "SELECT * FROM usuarios WHERE Email = @Email AND SenhaHash = @SenhaHash";
            /*
            Caso vá utilizar o WHERE, empregue o uso de caracteres coringas,
            semelhante ao apresentado no metódo Cadastrar() acima.
            */
            BancoDeDados conexaoBD = new BancoDeDados();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            //hash
            String hashSenha = EasyEncryption.SHA.ComputeSHA256Hash(Senha);

            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@SenhaHash", hashSenha);

            cmd.Prepare();
            // Declarar tabela que irá receber o resultado:
            DataTable tabela = new DataTable();
            // Preencher a tabela com o resultado da consulta
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }

        public DataTable Listar() {

            string comando = "SELECT id, Nome, Email, Ativo FROM usuarios";

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

            string comand = "UPDATE usuarios SET Ativo = true WHERE id = @id";
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

            string comand = "UPDATE usuarios SET Ativo = false WHERE id = @id";
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

            string comand = "INSERT INTO usuarios (Nome, Email, SenhaHash) VALUES " + "(@Nome, @Email, @SenhaHash)";
            BancoDeDados conexaoBD = new BancoDeDados();

            MySqlConnection con = conexaoBD.ObterConexao();

            MySqlCommand cmd = new MySqlCommand(comand, con);

            cmd.Parameters.AddWithValue("@Nome", Nome);

            cmd.Parameters.AddWithValue("@Email", Email);
            String senhaHash = EasyEncryption.SHA.ComputeSHA256Hash(Senha);
            cmd.Parameters.AddWithValue("@SenhaHash", senhaHash);

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



    }
}
