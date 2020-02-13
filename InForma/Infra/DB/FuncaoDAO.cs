using Infra.Contexto;
using Infra.IDAO;
using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infra.DB
{
    public class FuncaoDAO : IDAO<Funcao>
    {
        private readonly DataContext _context;

        public FuncaoDAO(DataContext context)
        {
            _context = context;
        }

        public bool Adicionar(Funcao entidade)
        {
            _context.Funcoes.Add(entidade);
            return SalvarAlteracoes(entidade);
        }

        public bool Atualizar(Funcao entidade, Funcao entidadeEditar)
        {
            _context.Funcoes.Update(entidadeEditar);
            return SalvarAlteracoes(entidadeEditar);
        }

        private bool SalvarAlteracoes(Funcao entidadeEditar)
        {
            _context.SaveChanges();
            return entidadeEditar.Id > 0 ? true : false;
        }

        public bool Deletar(Funcao entidade)
        {
            _context.Funcoes.Remove(entidade);
            return SalvarAlteracoes(entidade);
        }

        public IList<Funcao> ListaCompleta()
        {
            return _context.Funcoes.OrderBy(x => x.TipoFuncao).ToList();
        }

        public bool VerificarSeJaExisteNoBanco(Funcao entidade)
        {
            var quantidadeDeRegistros = _context.Funcoes.Where(x => x.TipoFuncao == entidade.TipoFuncao).ToList();
            return quantidadeDeRegistros.Count() > 0 ? true : false;
        }
    }
}
