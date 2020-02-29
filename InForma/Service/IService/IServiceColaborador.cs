using Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.IService
{   //Interface Service Repository
    public interface IServiceColaborador<T> where T: class
    {
        bool Adicionar(T entidade);
        IList<T> ListaCompleta();
        ColaboradorFormViewModel ListaColaboradorEFuncao();
        bool Atualizar(T entidade, T entidadeEditar);
        bool Deletar(T entidade);
    }
}
