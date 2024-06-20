using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroVeiculos
{
    static class ConexaoBanco
    {
        //Variaveis para conectar ao banco
        private const string servidor = "localhost";
        private const string bancodados = "dbcadastroveiculos";
        private const string usuario = "root";
        private const string senha = "admin";

        //Variavel para verificar se a conexao foi realizada
        static public string conexao = $"server={servidor}; user id={usuario}; database={bancodados}; password={senha}";
    }
}
