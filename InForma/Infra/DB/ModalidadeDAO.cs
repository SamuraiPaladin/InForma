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
            return SalvarAlteracoes(entidade);
        }

        public bool Atualizar(Modalidade entidade, Modalidade entidadeEditar)
        {
            _context.Modalidades.Update(entidadeEditar);
            return SalvarAlteracoes(entidadeEditar);
        }

        private bool SalvarAlteracoes(Modalidade entidadeEditar)
        {
            _context.SaveChanges();
            return entidadeEditar.Id > 0 ? true : false;
        }

        public bool Deletar(Modalidade entidade)
        {
            _context.Modalidades.Remove(entidade);
            return SalvarAlteracoes(entidade);
        }

        public IList<Modalidade> ListaCompleta()
        {
            return _context.Modalidades.OrderBy(x=> x.TipoModalidade).ToList();
        }

        public bool VerificarSeJaExisteNoBanco(Modalidade entidade)
        {
            var quantidadeDeRegistros = _context.Modalidades.Where(x => x.TipoModalidade == entidade.TipoModalidade).ToList();
            return quantidadeDeRegistros.Count() > 0 ? true : false;
        }
    }
}
