using Infra.Contexto;
using Infra.DB;
using Infra.IDAO;
using Model.Entity;
using Service.IService;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Service
{
    public class ServiceTurma : IServiceRepository<Turma>
    {

        private readonly IDAO<Turma> dAO;
        private readonly IDAO<Unidade> dAOUnidade;
        private readonly IDAO<Modalidade> dAOModalidade;

        public ServiceTurma(IDAO<Turma> dAO, IDAO<Unidade> dAOUnidade, IDAO<Modalidade> dAOModalidade)
        {
            this.dAO = dAO;
            this.dAOUnidade = dAOUnidade;
            this.dAOModalidade = dAOModalidade;
        }

        public bool Adicionar(Turma entidade)
        {
            entidade.Modalidade.TipoModalidade = entidade.Modalidade.Descricao;
            if (VerificaSeJaExisteNobBancoDeDadosServico(entidade))
                return false;
            else
                return dAO.Adicionar(entidade);
        }

        private bool VerificaSeJaExisteNobBancoDeDadosServico(Turma entidade)
        {
            return dAO.VerificarSeJaExisteNoBanco(entidade) && dAOUnidade.VerificarSeJaExisteNoBanco(entidade.Unidade) && dAOModalidade.VerificarSeJaExisteNoBanco(entidade.Modalidade);
        }

        public bool Atualizar(Turma entidade, Turma entidadeEditar)
        {
            if (VerificaSeJaExisteNobBancoDeDadosServico(entidadeEditar))
                return false;
            else
                return dAO.Atualizar(entidade, entidadeEditar);
        }

        public bool Deletar(Turma entidade)
        {
            return dAO.Deletar(entidade);
        }

        public IList<Turma> ListaCompleta()
        {
            return dAO.ListaCompleta();
        }
    }
}
