using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_Polimorfismo
{
    class Livro:Produto
    {
        private string tipo;
        private string titulo;
        private string autor;

        public Livro(string titulo, string autor, float preco):base(preco)
        {
            this.titulo = titulo;
            this.autor = autor;
        }
        public string Titulo
        {
            get
            {
                return titulo;
            }

        }

        public string Autor
        {
            get
            {
                return autor;
            }

        }

        public override string DescricaoINFO()
        {
            return $"{this.titulo} - {this.autor}";
        }
    }
}
