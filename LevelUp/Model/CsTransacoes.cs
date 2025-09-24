using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelUp.Model {
    public class CsTransacoes {

        public int Id { get; set; }

        public string Nome { get; set; }

        public int ClienteId { get; set; }

        public int GameId { get; set; }

        public int PagamentoId { get; set; }

        public DataTable Listar() {

            string comando = "SELECT transacoes.Id, transacoes.DataCompra, usuarios.Nome AS NomeCliente, games.Nome AS NomeGame, formas_pagamento.Nome AS FormaPagamento FROM transacoes INNER JOIN usuarios ON transacoes.ClienteId = usuarios.Id INNER JOIN games ON transacoes.GameId = games.Id INNER JOIN formas_pagamento ON transacoes.PagamentoId = formas_pagamento.Id;";

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


            string comand = "INSERT INTO transacoes (ClienteId, GameId, PagamentoId) VALUES " + "(@ClienteId, @GameId, @PagamentoId)";
            BancoDeDados conexaoBD = new BancoDeDados();

            MySqlConnection con = conexaoBD.ObterConexao();

            MySqlCommand cmd = new MySqlCommand(comand, con);

            cmd.Parameters.AddWithValue("@ClienteId", ClienteId);
            cmd.Parameters.AddWithValue("@GameId", GameId);
            cmd.Parameters.AddWithValue("@PagamentoId", PagamentoId);
          







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
