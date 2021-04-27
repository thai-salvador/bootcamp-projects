using System;

namespace cadastroSeries
{
   public class Serie : EntidadeBase // classe Serie herda da classe abstrata EntidadeBase
    {
        // Atributos
        private string Titulo { get; set ; }
        private string Descricao { get; set ; }
        private int Ano { get; set ; }
        private Genero Genero { get; set ; }
        private bool Excluido { get; set; }

        // Métodos

        public Serie(int id, string titulo, string descricao, int ano, Genero genero)
        {
            this.Id = id;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Genero = genero;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Genero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de lançamento: " + this.Ano + Environment.NewLine;
            retorno += "Excluído: " + this.Excluido;
            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId() => this.Id; // é sempre um método, como o acima, com outra sintaxe

        public bool retornaExcluido()
        {
            return this.Excluido;
        }
        public void Excluir() {
            this.Excluido = true;
        }
    }
}