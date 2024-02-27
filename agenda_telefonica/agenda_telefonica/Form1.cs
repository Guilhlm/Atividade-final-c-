using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agenda_telefonica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listView.View = View.Details;

            listView.Columns.Add("informações", 400);


            CarregarDados();

        }

        private void CarregarDados()
        {
            string conexaoString = "server=localhost;user=root;database=db_agenda_telefonica;port=3306;password=";

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                string scriptsql = "SELECT id, nome, telefone FROM tb_agenda_telefonica";

                using (MySqlCommand command = new MySqlCommand(scriptsql, conexao))
                {
                    conexao.Open();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);

                            string nome = reader.GetString(1);

                            string telefone = reader.GetString(2);

                            ListViewItem lista = new ListViewItem(id.ToString() + "- "+ nome +"                                telefone: " + telefone);

                           
                            listView.Items.Add(lista);

                        }
                    }

                    conexao.Close();
                }
            }
        }
       
        private void BTN_SALVAR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TXT_NOME.Text) || string.IsNullOrEmpty(TXT_TELEFONE.Text))
            {
                return;
            }
            else
            {
               
                string nome = TXT_NOME.Text;
                string telefone = TXT_TELEFONE.Text;

                if (nome.Trim() != "" && telefone.Trim() != "")
                {
                    CadastrarDados(nome, telefone);


                    listView.Items.Clear();
                }

                TXT_NOME.Clear();
                TXT_TELEFONE.Clear();


                CarregarDados();
            }         
        }
     
        private void CadastrarDados(string nome, string telefone)
        {
            string conexaoString = "server=localhost;user=root;database=db_agenda_telefonica;port=3306;password=";

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(conexaoString))
                {
                    string scriptSQL = "INSERT INTO tb_agenda_telefonica (nome, telefone) VALUES (@valornome, @valortelefone)";

                    using (MySqlCommand command = new MySqlCommand(scriptSQL, conexao))
                    {

                        conexao.Open();

                        command.Parameters.AddWithValue("@valornome", nome);

                        command.Parameters.AddWithValue("@valortelefone", telefone);

                        int linhasAfetadas = command.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("palavra cadastrada com sucesso");
                        }

                        conexao.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro ao cadastrar infomação: " + ex.Message);
            }


        }
      
        private void BTN_REMOVER_Click(object sender, EventArgs e)
        {

            string conexaoString = "server=localhost;user=root;database=db_agenda_telefonica;port=3306;password=";

            string id = TXT_NOME.Text;

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                 string remover = "DELETE FROM tb_agenda_telefonica WHERE id=@id";

                using (MySqlCommand command = new MySqlCommand(remover, conexao))
                {
                    conexao.Open();

                    command.Parameters.AddWithValue("@id", id);

                    int linhasAfetadas = command.ExecuteNonQuery();

                    if (linhasAfetadas > 0)
                    {
                        MessageBox.Show("REMOVIDO com sucesso");
                    }

                    conexao.Close();

                    listView.Items.Clear();

                    CarregarDados();
                }


            }
        }

       
    }
}
