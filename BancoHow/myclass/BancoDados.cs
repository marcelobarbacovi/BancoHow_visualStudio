using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BancoHow.myclass

{

    // faz a conexão banco de dados LOCAL DO XAMMP com PHP admin
    
     class BancoDados
    {
        public MySqlConnection connectdb;
        public BancoDados() {
            string host = "localhost";
            string database = "banco";
            string username = "root";
            string password = "";
            string port = "3306";
            
            string connection_string = "datasource=" + host + "; database=" + database + "; port =" + port + "; username=" + username + "; passoword =" + password + "; SslMode = none;";          
            connectdb = new MySqlConnection(connection_string);
                
        }


    }
}
