using BancoHow.myclass;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace BancoHow
{
    public partial class Form1 : Form 
    {
        BancoDados con = new BancoDados();
        public Form1()
        {
            InitializeComponent();
        }
        //faz um load toda vez que o form é carregado para alimentat o datadrid com as 
        // informações do Banco de dados
        private void Form1_Load(object sender, EventArgs e) 
        {
            atualizaGrid();
        }
        public void atualizaGrid()
        {  
            BancoDados con = new BancoDados();
            try
            {
                // conecta ao banco de dados fazendo um slect com 2 tabelas (cliente e conta)
                // fazendo um inner join quando existe relação entr a tabela cliente e a tabela conta
                con.connectdb.Open();

                MySqlCommand comandoMySql = con.connectdb.CreateCommand();
                comandoMySql.CommandText = " SELECT  clientes.ID,  clientes.Nome, clientes.Cpf, clientes.Data, clientes.Uf, clientes.Cep,  Conta.Titular, Conta.tipo , conta.Agencia, conta.conta, conta.Saldo FROM clientes INNER JOIN Conta  ON clientes.Conta= conta.Conta   ;  ";// ON clientes.Conta= conta.Conta ;Seleciona todos os livros
                                                                                                                                                                                                                                                                                     // que tão ativo (1)
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                dtgrid.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dtgrid.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetInt32(0);//ID
                    row.Cells[1].Value = reader.GetString(1);//nome
                    row.Cells[2].Value = reader.GetInt32(2);//cpf
                    row.Cells[3].Value = reader.GetString(3);//datanascimento
                    row.Cells[4].Value = reader.GetString(4);//uf
                    row.Cells[5].Value = reader.GetInt32(5);//cep
                    row.Cells[6].Value = reader.GetString(6);//titular
                    row.Cells[7].Value = reader.GetString(7); //tipo
                    row.Cells[8].Value = reader.GetInt32(8); //agencia
                    row.Cells[9].Value = reader.GetInt32(9); // conta
                    row.Cells[10].Value = reader.GetInt32(10); //saldo

                    dtgrid.Rows.Add(row);//ADICIONO A LINHA NA TABELA

                }

                con.connectdb.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! "); //Aparece esta mensagem caso não tenha conexão com banco de dados
                Console.WriteLine(ex.Message);
            }
        }

        
        private void dtgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dtgrid.CurrentRow.Selected = true;
                //preenche os textbox e combobox com as células da linha selecionada

                tbId.Text = dtgrid.Rows[e.RowIndex].Cells["ColId"].FormattedValue.ToString();
                tbNome.Text = dtgrid.Rows[e.RowIndex].Cells["ColNome"].FormattedValue.ToString();
                tbCpf.Text = dtgrid.Rows[e.RowIndex].Cells["ColCpf"].FormattedValue.ToString();
                tbData_nascimento.Text = dtgrid.Rows[e.RowIndex].Cells["ColData"].FormattedValue.ToString();
                cbUF.Text = dtgrid.Rows[e.RowIndex].Cells["ColUf"].FormattedValue.ToString();
                tbCep.Text = dtgrid.Rows[e.RowIndex].Cells["ColCep"].FormattedValue.ToString();
                tbTitular.Text = dtgrid.Rows[e.RowIndex].Cells["ColNome"].FormattedValue.ToString();
                cbTpConta.Text = dtgrid.Rows[e.RowIndex].Cells["ColTipo"].FormattedValue.ToString();
                tbAgencia.Text = dtgrid.Rows[e.RowIndex].Cells["ColAgencia"].FormattedValue.ToString();
                tbConta.Text = dtgrid.Rows[e.RowIndex].Cells["ColConta"].FormattedValue.ToString();
                tbSaldo.Text = dtgrid.Rows[e.RowIndex].Cells["ColSaldo"].FormattedValue.ToString();
                tbIDConta.Text = dtgrid.Rows[e.RowIndex].Cells["ColId"].FormattedValue.ToString();
                tbContaTransacao.Text = dtgrid.Rows[e.RowIndex].Cells["ColConta"].FormattedValue.ToString();
                tbidtransacao.Text= dtgrid.Rows[e.RowIndex].Cells["ColId"].FormattedValue.ToString();
                tbsaldotransacao.Text = dtgrid.Rows[e.RowIndex].Cells["ColSaldo"].FormattedValue.ToString();


            }
        }


        //Implantação formulario cadastro de clientes
        // estancio objeto na classe cliente e conta onde automaticamente quando crio o cadastro de cliente
        // ja instacnio uma classe conta no banco de dados com valores 0
        // ao final aplico o metodo abrir castro() / conta() que chama os metodos que irão fazer um insert no banco de dados 
        private void salvar_Click(object sender, EventArgs e)
        {
            Conta d1 = new Conta();
            d1.setTitular(tbNome.Text);
            d1.AbrirConta();


            Clientes c1 = new Clientes();
            c1.setNome(tbNome.Text);
            c1.setCPF(Convert.ToInt32(tbCpf.Text));
           c1.setDate(tbData_nascimento.Text);
            c1.setUF(cbUF.Text);
            c1.setCep(Convert.ToInt32(tbCep.Text));
            c1.abrircadastro();

            atualizaGrid();
        }

        // aqui eu deleto o cadastro de cliente chamando o metodo fechar(comta) onde no metodo na classe cliente
        // tem o comando SQL de DELETE
        private void delete_Click(object sender, EventArgs e)
        {
            Clientes c1 = new Clientes();
            c1.setId(Convert.ToInt32(tbId.Text));
            c1.fecharcadastro();
            atualizaGrid();
        }


        // aqui ira altrar o cadastro,  faco um UPDATE no BD pelo metodo alterarcadastro() localizado na classe
        private void Alterar_Click(object sender, EventArgs e)
        {
            Clientes c1 = new Clientes();
            c1.setId(Convert.ToInt32(tbId.Text));
            c1.setNome(tbNome.Text);
            c1.setCPF(Convert.ToInt32(tbCpf.Text));
            c1.setDate(tbData_nascimento.Text);
            c1.setUF(cbUF.Text);
            c1.setCep(Convert.ToInt32(tbCep.Text));
            c1.alterarcadastro();
            atualizaGrid();


        }


        // Implantacção cadastro conta
        // aqui crio a conta ára o cliente selecionado no datagrid,
        // aqui preciso tambem fazer um set em cliente porque não consegui armazenar no prgrama os dados das variaveis
        //por isso se eu fecho e abro exemplo  id da conta na variavel não tem nada, por isso armazeno de novo com as informações do bando de dados
        private void CriarConta_Click(object sender, EventArgs e)
        {
            Conta c1 = new Conta();
            tbTitular.Text = c1.getNome();
            c1.setTitular(tbTitular.Text);
            c1.setContaFK(Convert.ToInt32(tbConta.Text));
            c1.setTp_conta(cbTpConta.Text);
            c1.setAgencia(Convert.ToInt32(tbAgencia.Text));
            c1.setConta(Convert.ToInt32(tbConta.Text));
            tbSaldo.Text = Convert.ToString(c1.getSaldo());
            c1.AbrirConta();
            Clientes d1 = new Clientes();
            d1.setId(Convert.ToInt32(tbIDConta.Text));
            d1.setContaFK(Convert.ToInt32(tbConta.Text));
            d1.setId(Convert.ToInt32(tbIDConta.Text));
            d1.setNome(tbNome.Text);
            d1.setUF(cbUF.Text);
            d1.setCPF(Convert.ToInt32(tbCpf.Text));
            d1.setCep(Convert.ToInt32(tbCep.Text));
            d1.setDate(tbData_nascimento.Text);
            d1.alterarcadastro();
            atualizaGrid();

        }
        // aqui eu altero a conta da mesma forma eu coloco novamente as informações do BD nas variaveis
        //sem nehum metodo na classe cliente e altero as informações da classe conta com o metodo alterar conta()
        // que faz um UPDATE na tabela conta com as informações inseridas
        private void alterarConta_Click(object sender, EventArgs e)
        {
            Clientes d1 = new Clientes();
            d1.setId(Convert.ToInt32(tbIDConta.Text));
            d1.setContaFK(Convert.ToInt32(tbConta.Text));
            d1.setId(Convert.ToInt32(tbIDConta.Text));
            d1.setNome(tbNome.Text);
            d1.setUF(cbUF.Text);
            d1.setCPF(Convert.ToInt32(tbCpf.Text));
            d1.setCep(Convert.ToInt32(tbCep.Text));
            d1.setDate(tbData_nascimento.Text);
          

            Conta c1 = new Conta();

            tbTitular.Text = c1.getNome();
            c1.setContaFK(Convert.ToInt32(tbConta.Text));
            c1.setTp_conta(cbTpConta.Text);
            c1.setAgencia(Convert.ToInt32(tbAgencia.Text));
            c1.setConta(Convert.ToInt32(tbConta.Text));
           c1.setSaldo(Convert.ToInt32(tbSaldo.Text));
            c1.alterarConta();                           
           atualizaGrid();
        }


        // implementação classe teansação "NÃO ESTA PRONTA"
        private void textBox1_Click(object sender, EventArgs e)
        {

            Conta c1 = new Conta();
            c1.setConta(Convert.ToInt32(tbContaTransacao.Text));



            Transação t1 = new Transação();
                t1.setValor(float.Parse(tbValor.Text));
                t1.Depositar();
            c1.setSaldo(c1.getSaldo() + t1.getValor());

          
               

            }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
    }
