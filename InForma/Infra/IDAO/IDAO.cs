using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.IDAO
{
    public interface IDAO<T> where T: class
    {
        bool Adicionar(T entidade);
        IList<T> ListaCompleta();
        T BuscaPorId(int id);
        string Atualizar(T entidade);
        string Deletar(T entidade);
        bool VerificarSeJaExisteNoBanco(T entidade);
    }
}
