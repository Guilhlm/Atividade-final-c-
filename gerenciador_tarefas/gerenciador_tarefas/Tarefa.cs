using System;

namespace gerenciador_tarefas
{
    internal class Tarefa
    {
        private string titulo;
        private string descricao;
        private DateTime dataVencimento;

        public Tarefa(string titulo, string descricao, DateTime dataVencimento)
        {
            this.titulo = titulo;
            this.descricao = descricao;
            this.dataVencimento = dataVencimento;
        }
    }
}