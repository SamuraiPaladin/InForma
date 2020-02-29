using Infra.Contexto;
using Infra.IDAO;
using Model.Entity;
using Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infra.DB
{
    public class ColaboradorDAO : IDAO<Colaborador>
    {
        private readonly DataContext _context;

        public ColaboradorDAO(DataContext context)
        {
            _context = context;
        }

        public bool Adicionar(Colaborador entidade)
        {
            _context.Colaboradores.Add(entidade);
            return SalvarAlteracoes(entidade);
        }

        private bool SalvarAlteracoes(Colaborador entidadeEditar)
        {
            _context.SaveChanges();
            return entidadeEditar.Id > 0 ? true : false;
        }


        public bool Atualizar(Colaborador entidade, Colaborador entidadeEditar)
        {
            _context.Colaboradores.Update(entidadeEditar);
            return SalvarAlteracoes(entidadeEditar);
        }

        public bool Deletar(Colaborador entidade)
        {
            _context.Colaboradores.Remove(entidade);
            return SalvarAlteracoes(entidade);
        }

        public IList<Colaborador> ListaCompleta()
        {
            return _context.Colaboradores.OrderBy(x => x.Nome).ToList();
        }

        public bool VerificarSeJaExisteNoBanco(Colaborador entidade)
        {
            var quantidadeDeRegistros = _context.Colaboradores.Where(x => x.Nome == entidade.Nome).ToList();

            return quantidadeDeRegistros.Count() > 0 ? true : false;
        }
    }
}
