using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoHow.myclass;
using MySql.Data.MySqlClient;

namespace BancoHow.myclass
{
    internal class Conta:Clientes
    {  //atributos classe conta
        private String titular;
        private int agencia;
        private int conta;
        private float saldo;        
        private String tp_conta;




        // meto abrirconta() faz um insert na tabela conta no banco de dados
        // apos fazer conexão a partir da classe banco de dados
        public void AbrirConta()
        {
            {
                BancoDados con = new BancoDados();
                try
                {
                    con.connectdb.Open();

                    MySqlCommand comandoMySql = con.connectdb.CreateCommand();
                    comandoMySql.CommandText = "INSERT INTO conta ( Titular ,Tipo, Agencia, conta,Saldo) " +
    "VALUES('" + getTitular() + "','" + getTp_conta() + "', '" + getAgencia() + "','" + getConta() + "', '" + getSaldo() + "')";

                    comandoMySql.ExecuteNonQuery();

                    con.connectdb.Close();
                    //MessageBox.Show("Inserido com sucesso");


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }
        // meto alterarconta() faz um UPDATE na tabela conta no banco de dados
        // apos fazer conexão a partir da classe banco de dados
        public void alterarConta()
        {
            BancoDados con = new BancoDados();
            try
            {
                con.connectdb.Open();

                MySqlCommand comandoMySql = con.connectdb.CreateCommand();
                comandoMySql.CommandText = "UPDATE conta SET " +
                    "Titular = '" + getTitular() + "', " +
                     "tipo = '" + getTp_conta() + "', " +
                    "Agencia = '" + Convert.ToInt64(getAgencia()) + "', " +
                   
                    "Saldo = " + getSaldo() + 
                " WHERE conta = " + Convert.ToInt32(getConta()) + "";

                comandoMySql.ExecuteNonQuery();

                con.connectdb.Close();
               // MessageBox.Show("Inserido com sucesso");


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
      
                    
        public String getTitular()
        {
            return this.titular;
        }
        public void setTitular(String titular)
        {
            this.titular = titular;
        }
        public int getAgencia()
        {
            return this.agencia;
        }

        public void setAgencia(int agencia)
        {
            this.agencia = agencia;
        }

        public int getConta()
        {
            return this.conta;
        }
        public void setConta(int conta)
        {
            this.conta = conta;

        }
        public float getSaldo()
        {
            return this.saldo;

        }
        public void setSaldo(float saldo)
        {

            this.saldo = saldo;

        }
        
        public String getTp_conta()
        {
            return this.tp_conta;
        }
        public void setTp_conta(String tp_conta)
        {
            this.tp_conta = tp_conta;
        }

        

        }



    }


