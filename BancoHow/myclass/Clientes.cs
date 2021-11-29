using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoHow.myclass;
using System.Windows.Forms;





namespace BancoHow.myclass
{
    class Clientes
    { // atributos classe cliente
        private int id;
       private String nome;
        private long cpf;
        private String data_nascimento;
        private String uf;
        private int cep;
        private int ativo;
        public int contaFK;

       
        // meto abrircadastro() faz um insert na tabela clientes no banco de dados
        // apos fazer conexão a partir da classe banco de dados
        public void abrircadastro()
        {
            BancoDados con = new BancoDados();
            try
            {
                con.connectdb.Open();

                MySqlCommand comandoMySql = con.connectdb.CreateCommand();
                comandoMySql.CommandText = "INSERT INTO clientes ( Nome, Cpf, Data, Uf, Cep) " +
"VALUES('" + getNome() + "', '" + getCPF() + "','" + GetDate() + "', '" + getUF() + "','"
+ getCep() + "')";

                comandoMySql.ExecuteNonQuery();

                con.connectdb.Close();
                MessageBox.Show("Inserido com sucesso");
                

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        // meto fecharcadastro() faz um DELETE na tabela clientes no banco de dados
        // apos fazer conexão a partir da classe banco de dados
        public void fecharcadastro()
        {
            BancoDados con = new BancoDados();
            try
            {
                con.connectdb.Open();

                MySqlCommand comandoMySql = con.connectdb.CreateCommand();
                comandoMySql.CommandText = "DELETE FROM clientes WHERE ID = " + getID() + "";


                comandoMySql.ExecuteNonQuery();

                con.connectdb.Close();
                MessageBox.Show("Deletado com Sucesso");


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        // meto alterarcadastro() faz um UPDADTE na tabela clientes no banco de dados
        // apos fazer conexão a partir da classe banco de dados
        public void alterarcadastro()
        {
            BancoDados con = new BancoDados();
            try
            {
                con.connectdb.Open();

                MySqlCommand comandoMySql = con.connectdb.CreateCommand();
                comandoMySql.CommandText = "UPDATE clientes SET Nome = '" + getNome() + "', " +
                     "Cpf = '" + Convert.ToInt64(getCPF()) + "', " +
                     "Data = '" + GetDate() + "', " +
                    "Uf = '" + getUF() + "', " +
                    "Cep = " + Convert.ToInt32(getCep()) + ", " +
                    "Conta = " + Convert.ToInt32(getContaFK()) +
                    " WHERE ID = " + getID() + "";

                comandoMySql.ExecuteNonQuery();

                con.connectdb.Close();
                MessageBox.Show("Cadastro alterado com sucesso");


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        // AQUI FIZ OS METODOS GET E SET para cada atributo foi da forma que aprendi, é meio estilo java
        // mas funcionou, tentar depois aplicar da forma que o c# é mais usual.
        public int getID()
        {
            return this.id;

        }
        public void setId(int id)
        {
            this.id = id;

        }
            public String getNome()
        {
            return this.nome;

        }
        public void setNome(String nome)
        {
            this.nome = nome;

        }
        public long getCPF()
        {
            return this.cpf;
        }

        public void setCPF(long cpf)
        {
            this.cpf = cpf;
        }

        public String GetDate()
        {
            return this.data_nascimento;
        }
        public void setDate(String date)
        {
            this.data_nascimento = date;
        }

        public String getUF()
        {
            return this.uf;
        }

        public void setUF(String uf)
        {

            this.uf = uf;
        }

        public int getCep()
        {
            return this.cep;
        }

        public void setCep(int cep)
        {
            this.cep = cep;
        }

        public int getAtivo()
        {
            return this.ativo;
        }

        public void setAtivo(int ativo)
        {
            this.ativo = ativo;
        }
        public int getContaFK()
        {
            return this.contaFK;
        }

        public void setContaFK(int contaFK)
        {
            this.contaFK = contaFK;
        }

        
    }
}
