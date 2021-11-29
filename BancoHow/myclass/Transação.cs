using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoHow.myclass;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace BancoHow.myclass
{
    class Transação:Conta
    { float valor;
        string tp_movimento;


        public void Depositar()
        {
           setSaldo(getSaldo() + getValor());

            BancoDados con = new BancoDados();
            try
            {
                con.connectdb.Open();

                MySqlCommand comandoMySql = con.connectdb.CreateCommand();
                comandoMySql.CommandText = "UPDATE conta SET " +

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
        public void Sacar()
        {
            
            BancoDados con = new BancoDados();
            try
            {
                con.connectdb.Open();

                MySqlCommand comandoMySql = con.connectdb.CreateCommand();
                comandoMySql.CommandText = "UPDATE conta SET " +
                   

                    "Saldo = " + getSaldo() +
                " WHERE conta = " + Convert.ToString(getConta()) + "";

                comandoMySql.ExecuteNonQuery();

                con.connectdb.Close();
                // MessageBox.Show("Inserido com sucesso");


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public float getValor() {
            return this.valor;
        }
        public void setValor(float valor) {
            this.valor = valor;
        }
    }
}
