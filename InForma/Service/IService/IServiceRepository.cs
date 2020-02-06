using System;
using System.Collections.Generic;
using System.Text;

namespace Service.IService
{   //Interface Service Repository
    public interface IServiceRepository<T> where T: class
    {
        bool Adicionar(T entidade);
        IList<T> ListaCompleta();
        T BuscaPorId(int id);
        string Atualizar(T entidade);
        string Deletar(T entidade);
    }
}
