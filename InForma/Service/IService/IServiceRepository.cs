﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Service.IService
{   //Interface Service Repository
    public interface IServiceRepository<T> where T: class
    {
        bool Adicionar(T entidade);
        IList<T> ListaCompleta();
        bool Atualizar(T entidade, T entidadeEditar);
        bool Deletar(T entidade);
    }
}
