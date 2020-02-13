using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.IDAO
{   //Interface DAO
    public interface IDAO<T> where T: class
    {
        bool Adicionar(T entidade);
        IList<T> ListaCompleta();
        bool Atualizar(T entidade, T entidadeEditar);
        bool Deletar(T entidade);
        bool VerificarSeJaExisteNoBanco(T entidade);
    }
}
