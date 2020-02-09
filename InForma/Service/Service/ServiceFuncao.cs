using Infra.IDAO;
using Model.Entity;
using Service.IService;
using System.Collections.Generic;

namespace Service.Service
{
    public class ServiceFuncao : IServiceRepository<Funcao>
    {
        private readonly IDAO<Funcao> dAO;

        public ServiceFuncao(IDAO<Funcao> dAO)
        {
            this.dAO = dAO;
        }

        public bool Adicionar(Funcao entidade)
        {
            if (VerificaSeJaExisteNobBancoDeDadosServico(entidade))
                return false;
            else
                return dAO.Adicionar(entidade);
        }

        private bool VerificaSeJaExisteNobBancoDeDadosServico(Funcao entidade)
        {
            return dAO.VerificarSeJaExisteNoBanco(entidade);
        }

        public bool Atualizar(Funcao entidade, Funcao entidadeEditar)
        {
            if (VerificaSeJaExisteNobBancoDeDadosServico(entidadeEditar))
                return false;
            else
                return dAO.Atualizar(entidade, entidadeEditar);
        }

        public bool Deletar(Funcao entidade)
        {
            return dAO.Deletar(entidade);
        }

        public IList<Funcao> ListaCompleta()
        {
            return dAO.ListaCompleta();
        }
    }
}
