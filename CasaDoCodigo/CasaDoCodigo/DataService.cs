using CasaDoCodigo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo
{
    public class DataService : IDataService
    {
        public Contexto Contexto { get; }

        public DataService(Contexto contexto)
        {
            this.Contexto = contexto;
        }
        
        public void InicializaDB()
        {
            this.Contexto.Database.EnsureCreated();

            if (this.Contexto.protudos.Count() == 0)
            {
                List<Produto> produtos = new List<Produto>
                {
                    new Produto("Sleep not found", 59.90m),
                    new Produto("May the code be with you", 59.90m),
                    new Produto("Rollback", 59.90m),
                    new Produto("REST", 69.90m),
                    new Produto("Design Patterns com Java", 69.90m),
                    new Produto("Vire o jogo com Spring Framework", 69.90m),
                    new Produto("Test-Driven Development", 69.90m),
                    new Produto("iOS: Programe para iPhone e iPad", 69.90m),
                    new Produto("Desenvolvimento de Jogos para Android", 69.90m)
                };

                foreach(var produto in produtos)
                {
                    this.Contexto.protudos.Add(produto);

                    this.Contexto.ItensPedido.Add(new ItemPedido(produto,1));

                    this.Contexto.SaveChanges();
                }
            }
        }

        public List<Produto> GetProdutos()
        {
            return this.Contexto.protudos.ToList();
            
        }
    }
}
