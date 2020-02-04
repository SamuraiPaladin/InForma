using Infra.Contexto;
using Infra.IDAO;
using Microsoft.EntityFrameworkCore;
using Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.DB
{
    public class ModalidadeDAO : IDAO<Modalidade>
    {
        public bool Adicionar(Modalidade entidade)
        {
            throw new NotImplementedException();
        }

        public string Atualizar(Modalidade entidade)
        {
            throw new NotImplementedException();
        }

        public Modalidade BuscaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public string Deletar(Modalidade entidade)
        {
            throw new NotImplementedException();
        }

        public IList<Modalidade> ListaCompleta()
        {
            throw new NotImplementedException();
        }

        public bool VerificarSeJaExisteNoBanco(Modalidade entidade)
        {
            throw new NotImplementedException();
        }
    }
}
