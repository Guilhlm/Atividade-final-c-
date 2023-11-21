using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_telefonica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
            // tenho q entender como funciona a lista

        }

        private void buttonpesquisa_Click(object sender, EventArgs e)
        {
           
            // tenho q fazer a pequisa de usuarios

        }

        private void buttonadicionar_Click(object sender, EventArgs e)
        {
            string nomepessoa = textBoxnome.Text;
            string numerotelefone = textBoxtelefone.Text;

            //nome pessoa

            if (nomepessoa != "")
            {

            }
            else
            {
                textBoxnome.Text = "error";
            }

            //numero telefone

            if (numerotelefone != "")
            {

            }
            else
            {
                textBoxtelefone.Text = "error";
            }

        }












    }
}
