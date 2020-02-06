using Infra.DB;
using Infra.IDAO;
using Model.Entity;
using Service.IService;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Service
{
    public class ServiceModalidade : IServiceRepository<Modalidade>
    {

        private readonly IDAO<Modalidade> dAO;

        public ServiceModalidade(IDAO<Modalidade> dAO)
        {
            this.dAO = dAO;
        }

        public bool Adicionar(Modalidade entidade)
        {
            if (VerificaSeJaExisteNobBancoDeDadosServico(entidade))
                return false;
            else
                return dAO.Adicionar(entidade);
        }

        private bool VerificaSeJaExisteNobBancoDeDadosServico(Modalidade entidade)
        {
            return dAO.VerificarSeJaExisteNoBanco(entidade);
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
    }
}
