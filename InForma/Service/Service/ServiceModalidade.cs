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
        //service modalidade
        private readonly ModalidadeDAO modalidadeDAO;
        public ServiceModalidade()
        {
            modalidadeDAO = new ModalidadeDAO();
        }
        public bool Adicionar(Modalidade entidade)
        {
            modalidadeDAO.VerificarSeJaExisteNoBanco(entidade);
            throw new NotImplementedException();
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
