using Infra.Contexto;
using Infra.DB;
using Infra.IDAO;
using Model.Entity;
using Model.Enums;
using Model.ViewModels;
using Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Service
{
    public class ServiceTurma : IServiceTurma<Turma>
    {

        private readonly IDAO<Turma> dAO;
        private readonly IDAO<Unidade> dAOUnidade;
        private readonly IDAO<Modalidade> dAOModalidade;
        private readonly IDAO<Colaborador> dAOColaborador;
        private readonly IDAO<Funcao> dAOFuncao;

        public ServiceTurma(IDAO<Turma> dAO, IDAO<Unidade> dAOUnidade, IDAO<Modalidade> dAOModalidade, IDAO<Colaborador> dAOColaborador, IDAO<Funcao> dAOFuncao)
        {
            this.dAO = dAO;
            this.dAOUnidade = dAOUnidade;
            this.dAOModalidade = dAOModalidade;
            this.dAOColaborador = dAOColaborador;
            this.dAOFuncao = dAOFuncao;
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
            return dAO.VerificarSeJaExisteNoBanco(entidade);
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

        public List<TurmaFormViewModel> ListaCompleta()
        {
            return ReturnTurmaFormViewModel(true);
        }

        public List<TurmaFormViewModel> ListaUnidadeEModalidade()
        {
            return ReturnTurmaFormViewModel(false);
        }

        public List<TurmaFormViewModel> ReturnTurmaFormViewModel(bool isListComplete)
        {
            List<Turma> turmas = new List<Turma>();
            List<TurmaFormViewModel> turmasList = new List<TurmaFormViewModel>();
            List<Unidade> unidades = dAOUnidade.ListaCompleta().ToList();
            List<Modalidade> modalidades = dAOModalidade.ListaCompleta().ToList();

            if (isListComplete)
            {
                turmas = dAO.ListaCompleta().ToList();
            }

            //filtro para pegar somente os professores de colaboradores
            var professores = (from c in dAOColaborador.ListaCompleta().ToList()
                        join f in dAOFuncao.ListaCompleta() on c.FuncaoId equals f.Id
                        where f.TipoFuncao.ToUpper().Contains("PROFESSOR") || f.TipoFuncao.ToUpper().Contains("PROF")
                        select c).ToList();

            turmasList.Add(new TurmaFormViewModel() { Unidades = unidades,
                Modalidades = modalidades,
                Professores = professores, 
                Turmas = turmas,
                DiasDaSemana = Enum.GetValues(typeof(EnumDays.DaysOfWeek)), 
                TipoClientes = Enum.GetValues(typeof(EnumClients.Clients)) });

            return turmasList;

        }
    }
}
