using Infra.Contexto;
using Infra.IDAO;
using Model.Entity;
using System.Collections.Generic;
using System.Linq;

namespace Infra.DB
{
    public class UnidadeDAO : IDAO<Unidade>
    {
        private readonly DataContext _context;

        public UnidadeDAO(DataContext context)
        {
            _context = context;
        }

        public bool Adicionar(Unidade entidade)
        {
            _context.Unidades.Add(entidade);
            return SalvarAlteracoes(entidade);
        }

        public bool Atualizar(Unidade entidade, Unidade entidadeEditar)
        {
            _context.Unidades.Update(entidadeEditar);
            return SalvarAlteracoes(entidadeEditar);
        }

        private bool SalvarAlteracoes(Unidade entidadeEditar)
        {
            _context.SaveChanges();
            return entidadeEditar.Id > 0 ? true : false;
        }

        public bool Deletar(Unidade entidade)
        {
            _context.Unidades.Remove(entidade);
            return SalvarAlteracoes(entidade);
        }

        public IList<Unidade> ListaCompleta()
        {
            return _context.Unidades.OrderBy(x => x.Descricao).ToList();
        }

        public bool VerificarSeJaExisteNoBanco(Unidade entidade)
        {
            var quantidadeDeRegistros = _context.Unidades.Where(x => x.Descricao == entidade.Descricao && x.CEP == entidade.CEP && x.Numero == entidade.Numero).ToList();
            return quantidadeDeRegistros.Count() > 0 ? true : false;
        }
    }
}
