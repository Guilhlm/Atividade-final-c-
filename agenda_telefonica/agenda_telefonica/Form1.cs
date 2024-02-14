using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void BTN_SALVAR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TXT_NOME.Text) || string.IsNullOrEmpty(TXT_TELEFONE.Text))
                return;

            ListViewItem item = new ListViewItem(TXT_NOME.Text);

            item.SubItems.Add(TXT_TELEFONE.Text);

            listView.Items.Add(item);

            TXT_NOME.Clear();
            TXT_TELEFONE.Clear();   
            TXT_NOME.Focus();
        }

        private void BTN_REMOVER_Click(object sender, EventArgs e)
        {

            if (listView.Items.Count > 0)
            {
                listView.Items.Remove(listView.SelectedItems[0]);
            }
        }
    }
}
