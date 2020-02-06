using Infra.Contexto;
using Infra.IDAO;
using Microsoft.EntityFrameworkCore;
using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infra.DB
{
    //Modalidade
    public class ModalidadeDAO : IDAO<Modalidade>
    {
        private readonly DataContext _context;

        public ModalidadeDAO(DataContext context)
        {
            _context = context;
        }

        public bool Adicionar(Modalidade entidade)
        {
            _context.Modalidades.Add(entidade);
            _context.SaveChanges();
            return entidade.Id > 0 ? true : false;
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

        public bool VerificarSeJaExisteNoBanco(Modalidade entidade)
        {
            var quantidadeDeRegistros = _context.Modalidades.Where(x => x.Descricao == entidade.Descricao && x.TipoModalidade == entidade.TipoModalidade).ToList();
            return quantidadeDeRegistros.Count() > 0 ? true : false;
        }
    }
}
