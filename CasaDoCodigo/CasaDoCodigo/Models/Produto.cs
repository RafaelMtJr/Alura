using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Models
{
    public class Produto
    {
        public int Id { get; private set; }
        public String Nome { get; private set; }
        public decimal Preco { get; private set; }

        public Produto(int id, String nome, decimal preco)
        {
            this.Id = id;
            this.Nome = nome;
            this.Preco = preco;
        }
    }
}
