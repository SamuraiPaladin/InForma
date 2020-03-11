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
    public class ServiceColaborador : IServiceColaborador<Colaborador>
    {

        private readonly IDAO<Colaborador> dAO;
        private readonly IDAO<Funcao> dAOFuncao;

        public ServiceColaborador(IDAO<Colaborador> dAO, IDAO<Funcao> dAOFuncao)
        {
            this.dAO = dAO;
            this.dAOFuncao = dAOFuncao;
        }

        public bool Adicionar(Colaborador entidade)
        {
            if (VerificaSeJaExisteNobBancoDeDadosServico(entidade))
                return false;
            else
                return dAO.Adicionar(entidade);
        }

        private bool VerificaSeJaExisteNobBancoDeDadosServico(Colaborador entidade)
        {
            return dAO.VerificarSeJaExisteNoBanco(entidade);
        }

        public bool Atualizar(Colaborador entidade, Colaborador entidadeEditar)
        {
            if (VerificaSeJaExisteNobBancoDeDadosServico(entidadeEditar))
                return false;
            else
                return dAO.Atualizar(entidade, entidadeEditar);
        }

        public bool Deletar(Colaborador entidade)
        {
            return dAO.Deletar(entidade);
        }

        public List<ColaboradorFormViewModel> ListaCompleta()
        {
            return this.ReturnColaboradorFormViewModel(true);
        }

        public List<ColaboradorFormViewModel> ListaColaboradorEFuncao()
        {
            return this.ReturnColaboradorFormViewModel(false);
        }

        public List<ColaboradorFormViewModel> ReturnColaboradorFormViewModel(bool isListComplete)
        {
            List<Colaborador> Colaboradores = new List<Colaborador>(); 
            List<ColaboradorFormViewModel> ColaboradorFormViewModel = new List<ColaboradorFormViewModel>(); 

            if (isListComplete)
            {
                Colaboradores = dAO.ListaCompleta().ToList();
            }

            var funcoes = dAOFuncao.ListaCompleta().ToList();

            var colaboradores = new ColaboradorFormViewModel() { Colaboradores = Colaboradores, Funcoes = funcoes };
            ColaboradorFormViewModel.Add(colaboradores);

            return ColaboradorFormViewModel;
        }
    }
}
