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
    public class TurmaDAO : IDAO<Turma>
    {
        private readonly DataContext _context;

        public TurmaDAO(DataContext context)
        {
            _context = context;
        }

        public bool Adicionar(Turma entidade)
        {
            _context.Turmas.Add(entidade);
            return SalvarAlteracoes(entidade);
        }

        private bool SalvarAlteracoes(Turma entidadeEditar)
        {
            _context.SaveChanges();
            return entidadeEditar.Id > 0 ? true : false;
        }


        public bool Atualizar(Turma entidade, Turma entidadeEditar)
        {
            _context.Turmas.Update(entidadeEditar);
            return SalvarAlteracoes(entidadeEditar);
        }

        public bool Deletar(Turma entidade)
        {
            _context.Turmas.Remove(entidade);
            return SalvarAlteracoes(entidade);
        }

        public IList<Turma> ListaCompleta()
        {
            return _context.Turmas.OrderBy(x => x.Descricao).ToList();
        }

        public bool VerificarSeJaExisteNoBanco(Turma entidade)
        {
            var quantidadeDeRegistros = _context.Turmas.Where(x => x.Descricao == entidade.Descricao).ToList();

            return quantidadeDeRegistros.Count() > 0 ? true : false;
        }
    }
}
