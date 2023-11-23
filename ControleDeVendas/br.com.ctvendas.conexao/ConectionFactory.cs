using MongoDB.Driver.Core.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeVendas.br.com.ctvendas.conexao
{
    public class ConectionFactory
    {
        //metodo que conecta o banco de dados

        public MySqlConnection Getconnection();
        {
            string conexao = ConfigurationManager.ConnectionStrings{"bdvendas"}.ConnectionString;
            return 

      
        }


    }
}
