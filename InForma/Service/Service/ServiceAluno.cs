using Infra.IDAO;
using Model.Entity;
using Service.IService;
using System;
using System.Collections.Generic;
using System.Text;
using ViaCEP;

namespace Service.Service
{
    public class ServiceAluno : IServiceAluno<Aluno>
    {
        private readonly IDAO<Aluno> dAO;

        public ServiceAluno(IDAO<Aluno> dAO)
        {
            this.dAO = dAO;
        }

        public bool Adicionar(Aluno entidade)
        {
            if (VerificaSeJaExisteNobBancoDeDadosServico(entidade))
                return false;
            else
                return dAO.Adicionar(entidade);
        }

        private bool VerificaSeJaExisteNobBancoDeDadosServico(Aluno entidade)
        {
            return dAO.VerificarSeJaExisteNoBanco(entidade);
        }

        public bool Atualizar(Aluno entidade, Aluno entidadeEditar)
        {
            if (VerificaSeJaExisteNobBancoDeDadosServico(entidadeEditar))
                return false;
            else
                return dAO.Atualizar(entidade, entidadeEditar);
        }

        public bool Deletar(Aluno entidade)
        {
            return dAO.Deletar(entidade);
        }

        public IList<Aluno> ListaCompleta()
        {
            return dAO.ListaCompleta();
        }

        public Aluno BuscarCEP(string cep)
        {
            try
            {
                var dadosCEP = ViaCEPClient.Search(cep);
                return new Aluno()
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
                return new Aluno();
            }
        }
    }
}
