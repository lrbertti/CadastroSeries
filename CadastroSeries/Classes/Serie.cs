using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroSeries.Classes
{
    public class Serie : EntidadeBasica
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set;}
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.ID = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string concatena_retorno = "";
            concatena_retorno += "Genero: " + this.Genero + Environment.NewLine;
            concatena_retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            concatena_retorno += "Descricao: " + this.Descricao + Environment.NewLine;
            concatena_retorno += "Ano de Inicio: " + this.Ano + Environment.NewLine;
            concatena_retorno += "Excluido: " + this.Excluido;
            return concatena_retorno;
        }

        public string getTitulo()
        {
            return this.Titulo;
        }

        public int getId()
        {
            return this.ID;
        }
        public bool getExcluido()
        {
            return this.Excluido;
        }
        public void Excluir()
        {
            this.Excluido = true;
        }
    }
}
