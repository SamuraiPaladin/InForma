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

        public IList<Colaborador> ListaCompleta()
        {
            return (IList<Colaborador>)this.ReturnColaboradorFormViewModel(true).Colaboradores;
        }

        public ColaboradorFormViewModel ListaColaboradorEFuncao()
        {
            return ReturnColaboradorFormViewModel(false);
        }

        public ColaboradorFormViewModel ReturnColaboradorFormViewModel(bool isListComplete)
        {
            IList<Colaborador> Colaboradores = new List<Colaborador>(); 
            if (isListComplete)
            {
                Colaboradores = dAO.ListaCompleta();
            }

            var funcoes = dAOFuncao.ListaCompleta();

            return new ColaboradorFormViewModel() { Colaboradores = Colaboradores, Funcoes = funcoes };

        }

    }
}
