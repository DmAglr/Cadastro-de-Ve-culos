using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroVeiculos
{
    internal class CadastroVeiculos
    {
        private int ID;
        private string PLACA;
        private string MARCA;
        private string ANO_FAB;
        private string ANO_MODEL;
        private string CLIENTE;
        private string TIPO_CLI;
        private string DOCUMENTO;

        public int Id
        {
            get { return ID; }
            set { ID = value; } 
        }

        public string placa

        { 
            get { return PLACA; } 
            set {  PLACA = value; }
        }

        public string marca

        {
            get { return MARCA; }
            set { MARCA = value; }
        }

        public string AnoFab

        {
            get { return ANO_FAB; }
            set { ANO_FAB = value; }
        }

        public string AnoModel

        {
            get { return ANO_MODEL; }
            set { ANO_MODEL = value; }
        }

        public string cliente

        {
            get { return CLIENTE; }
            set { CLIENTE = value; }
        }

        public string TipoCliente

        {
            get { return TIPO_CLI; }
            set { TIPO_CLI = value; }
        }

        public string documento

        {
            get { return DOCUMENTO; }
            set { DOCUMENTO = value; }
        }

        //método para cadastrar funcionário no banco de dados.
        public bool CadastrarVeiculos()
        { 
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.conexao);
                MysqlConexaoBanco.Open();

                string insert = $"insert into veiculos (PLACA,MARCA,ANO_FAB,ANO_MODEL,CLIENTE,TIPO_CLI,DOCUMENTO) values ('{PLACA}','{MARCA}','{ANO_FAB}','{ANO_MODEL}','{CLIENTE}','{TIPO_CLI}','{DOCUMENTO}')";

                MySqlCommand comandoSql = MysqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = insert;

                comandoSql.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                /*
                 Mensagem de erro para quando não for possível cadastrar o veículo no banco.
                 Erro ligado ao banco de dados.
                */ 
                MessageBox.Show("Erro no banco de dados - método CadastrarVeiculos: " + ex.Message);
                return false;
            }
        }

        public MySqlDataReader LocalizarCadastro() 
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.conexao);
                MysqlConexaoBanco.Open();

                string select = $"select ID,PLACA,MARCA,ANO_FAB,ANO_MODEL,CLIENTE,TIPO_CLI,DOCUMENTO from veiculos where DOCUMENTO = '{DOCUMENTO}';";
                MySqlCommand comandoSql = MysqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = select;

                MySqlDataReader reader = comandoSql.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - método LocalizarCadastro: " + ex.Message);
                return null;
            }
        }

        public bool AtualizarCadastro()
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.conexao);
                MysqlConexaoBanco.Open();

                string update = $"update veiculos set PLACA = '{PLACA}',MARCA = '{MARCA}',ANO_FAB = '{ANO_FAB}',ANO_MODEL = '{ANO_MODEL}' where ID = '{ID}'";
                MySqlCommand comandoSql = MysqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = update;

                comandoSql.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - método AtualizarCadastro: " + ex.Message);
                return false;
            }
        }

        public bool DeletarFuncionario()
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.conexao);
                MysqlConexaoBanco.Open();

                string delete = $"delete from veiculos where id = '{ID}'";
                MySqlCommand comandoSql = MysqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = delete;

                comandoSql.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro banco de dados método DeletarFuncionario: " + ex.Message);
                return false;
            }
        }

    }
}
