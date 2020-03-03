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
    public class AlunoDAO : IDAO<Aluno>
    {
        private readonly DataContext _context;

        public AlunoDAO(DataContext context)
        {
            _context = context;
        }

        public bool Adicionar(Aluno entidade)
        {
            _context.Alunos.Add(entidade);
            return SalvarAlteracoes(entidade);
        }

        private bool SalvarAlteracoes(Aluno entidadeEditar)
        {
            _context.SaveChanges();
            return entidadeEditar.Id > 0 ? true : false;
        }


        public bool Atualizar(Aluno entidade, Aluno entidadeEditar)
        {
            _context.Alunos.Update(entidadeEditar);
            return SalvarAlteracoes(entidadeEditar);
        }

        public bool Deletar(Aluno entidade)
        {
            _context.Alunos.Remove(entidade);
            return SalvarAlteracoes(entidade);
        }

        public IList<Aluno> ListaCompleta()
        {
            return _context.Alunos.OrderBy(x => x.Nome).ToList();
        }

        public bool VerificarSeJaExisteNoBanco(Aluno entidade)
        {
            var quantidadeDeRegistros = _context.Alunos.Where(x => x.Nome == entidade.Nome).ToList();

            return quantidadeDeRegistros.Count() > 0 ? true : false;
        }
    }
}
