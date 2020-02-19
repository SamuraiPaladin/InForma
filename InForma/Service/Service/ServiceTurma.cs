using Infra.Contexto;
using Infra.DB;
using Infra.IDAO;
using Model.Entity;
using Model.Enums;
using Model.ViewModels;
using Service.IService;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Service
{
    public class ServiceTurma : IServiceTurma<Turma>
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
            return (IList<Turma>)TurmaFormViewModel(true).Turmas;
        }

        public TurmaFormViewModel ListaUnidadeEModalidade()
        {
            return TurmaFormViewModel(false);
        }

        public TurmaFormViewModel TurmaFormViewModel(bool isListComplete)
        {
            IList<Turma> turmas = new List<Turma>(); 
            if (isListComplete)
            {
                turmas = dAO.ListaCompleta();
            }

            var unidades = dAOUnidade.ListaCompleta();
            var modalidades = dAOModalidade.ListaCompleta();

            return new TurmaFormViewModel() { Unidades = unidades, Modalidades = modalidades, Turmas = turmas, DiasDaSemana = Enum.GetValues(typeof(EnumDays.DaysOfWeek)) };

        }

    }
}
