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

        public bool Atualizar(Modalidade entidade, Modalidade entidadeEditar)
        {
            if (VerificaSeJaExisteNobBancoDeDadosServico(entidadeEditar))
                return false;
            else
                return dAO.Atualizar(entidade, entidadeEditar);
        }

        public bool Deletar(Modalidade entidade)
        {
            return dAO.Deletar(entidade);
        }

        public IList<Modalidade> ListaCompleta()
        {
            return dAO.ListaCompleta();
        }
    }
}
