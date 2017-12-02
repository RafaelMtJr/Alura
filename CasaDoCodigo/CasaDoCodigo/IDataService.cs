using CasaDoCodigo.Models;
using System.Collections.Generic;

namespace CasaDoCodigo
{
    public interface IDataService
    {
        Contexto Contexto { get; }

        void InicializaDB();
        List<Produto> GetProdutos();
    }
}