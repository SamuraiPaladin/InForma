using Infra.IDAO;
using Model.Entity;
using Service.IService;
using System;
using System.Collections.Generic;
using System.Text;
using ViaCEP;

namespace Service.Service
{
    public class ServiceUnidade : IServiceUnidade<Unidade>
    {
        private readonly IDAO<Unidade> dAO;
        public ServiceUnidade()
        {

        }
        public ServiceUnidade(IDAO<Unidade> dAO)
        {
            this.dAO = dAO;
        }

        public bool Adicionar(Unidade entidade)
        {
            if (VerificaSeJaExisteNobBancoDeDadosServico(entidade))
                return false;
            else
                return dAO.Adicionar(entidade);
        }

        private bool VerificaSeJaExisteNobBancoDeDadosServico(Unidade entidade)
        {
            return dAO.VerificarSeJaExisteNoBanco(entidade);
        }

        public bool Atualizar(Unidade entidade, Unidade entidadeEditar)
        {
            if (VerificaSeJaExisteNobBancoDeDadosServico(entidadeEditar))
                return false;
            else
                return dAO.Atualizar(entidade, entidadeEditar);
        }

        public bool Deletar(Unidade entidade)
        {
            return dAO.Deletar(entidade);
        }

        public IList<Unidade> ListaCompleta()
        {
            return dAO.ListaCompleta();
        }
        public Unidade BuscarCEP(string cep)
        {
            try
            {

                var dadosCEP = ViaCEPClient.Search(cep);
                return new Unidade()
                {
                    Bairro = dadosCEP.Neighborhood,
                    Cidade = dadosCEP.City,
                    CEP = dadosCEP.ZipCode,
                    Endereco = dadosCEP.Street,
                    Estado = dadosCEP.StateInitials
                };
            }
            catch (AggregateException)
            {
                return new Unidade();
            }
        }
    }
}
