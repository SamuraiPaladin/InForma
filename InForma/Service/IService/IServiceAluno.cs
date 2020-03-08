﻿using Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.IService
{   //Interface Service Repository
    public interface IServiceAluno<T> where T: class
    {
        bool Adicionar(T entidade);
        IList<T> ListaCompleta();
        TurmaFormViewModel ListaUnidadeEModalidade();
        bool Atualizar(T entidade, T entidadeEditar);
        bool Deletar(T entidade);
    }
}