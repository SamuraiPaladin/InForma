using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class CadastroService : ICadastroColaborador, ICadastroUnidade
    {
        protected string _cadastro;

        public CadastroService(string cadastro)
        {
            this._cadastro = cadastro;
        }

        public void SaveColaborador()
        {
            throw new NotImplementedException();
        }

        public void SaveUnidade()
        {
            throw new NotImplementedException();
        }
    }
}