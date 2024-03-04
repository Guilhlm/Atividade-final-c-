using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gerenciador_tarefas
{
    public partial class Form1 : Form
    {

        private List<Tarefa> listaTarefas;

        public Form1()
        {
            InitializeComponent();

            listaTarefas = new List<Tarefa>();
            ConfigurarDataGridView();
        }

        private void BTN_LIMPAR_Click(object sender, EventArgs e)
        {
            TXT_TITULO.Clear();
            TXT_CONTEUDO.Clear();
            DTPICKER.Value = DateTime.Now;
        }

        private void ConfigurarDataGridView()
        {

            DGView.ColumnCount = 3;
            DGView.Columns[0].Name = "taskzinha";
            DGView.Columns[1].Name = "conteudo";
            DGView.Columns[2].Name = "data";

            DataGridViewButtonColumn coluna = new DataGridViewButtonColumn();
            coluna.Name = "Ações";
            coluna.Text = "Delete";
            coluna.UseColumnTextForButtonValue = true;
            DGView.Columns.Add(coluna);

            DGView.Columns["taskzinha"].Width = 140;
            DGView.Columns["data"].Width = 100;
            DGView.Columns["conteudo"].Width = 150;
            DGView.Columns["Ações"].Width = 50;
        }

        private void AdicionarTarefa(string titulo, string descricao, DateTime dataVencimento)
        {
            Tarefa tarefa = new Tarefa(titulo, descricao, dataVencimento);
            listaTarefas.Add(tarefa);

            AtualizarDataGridView();
            LimparCampos();
        }

        private void AtualizarDataGridView()
        {
            DGView.Rows.Clear();



            foreach (Tarefa tarefa in listaTarefas)
            {

                DGView.Rows.Add(tarefa.Titulo, tarefa.Descricao, tarefa.DataVencimento.ToString("dd/MM/yyyy"));

            }
        }

        private void LimparCampos()
        {
            TXT_TITULO.Clear();
            TXT_CONTEUDO.Clear();
            DTPICKER.Value = DateTime.Now;
        }

        private void BNT_SALVAR_Click(object sender, EventArgs e)
        {
            string titulo = TXT_TITULO.Text;
            string descricao = TXT_CONTEUDO.Text;
            DateTime dataVencimento = DTPICKER.Value;

            if (!string.IsNullOrWhiteSpace(titulo))
            {
                AdicionarTarefa(titulo, descricao, dataVencimento);
            }
            else
            {
                MessageBox.Show("coloca titulo ae.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DGView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == DGView.Columns["Ações"].Index && e.RowIndex >= 0)
            {
                
                DialogResult resultado = MessageBox.Show("quer deletar memu?????", "Confirma ae pai", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    listaTarefas.RemoveAt(e.RowIndex);
                    AtualizarDataGridView();
                }
            }
        }

        public class Tarefa
        {
            public string Titulo { get; set; }
            public string Descricao { get; set; }
            public DateTime DataVencimento { get; set; }

            public Tarefa(string titulo, string descricao, DateTime dataVencimento)
            {
                Titulo = titulo;
                Descricao = descricao;
                DataVencimento = dataVencimento;
            }
        }
    }
}
