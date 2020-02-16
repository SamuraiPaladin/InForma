using Model.Entity;
using Service.IService;
using Service.Service;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;


namespace Test.Unit
{
    public class UnidadeTest
    {
        private readonly ServiceUnidade _serviceRepository;
        private Unidade unidade;
        public UnidadeTest()
        {
            _serviceRepository = new ServiceUnidade();
            unidade = new Unidade();
        }
        private static bool VerificaSeTemCampoVazioOuNulo(Unidade funcao)
        {
            return string.IsNullOrWhiteSpace(funcao.Bairro) || string.IsNullOrWhiteSpace(funcao.CEP) || string.IsNullOrWhiteSpace(funcao.Cidade) || string.IsNullOrWhiteSpace(funcao.Descricao) || string.IsNullOrWhiteSpace(funcao.Endereco)
                 || string.IsNullOrWhiteSpace(funcao.Estado) || string.IsNullOrWhiteSpace(funcao.Numero) || string.IsNullOrWhiteSpace(funcao.Telefone);
        }
        [Fact]
        public void Unidade_Cadastrar_CamposVazio()
        {
            Assert.True(VerificaSeTemCampoVazioOuNulo(unidade));
        }
        [Theory]
        [InlineData("08568520", "Poá")]
        [InlineData("08710-040", "Mogi das Cruzes")]
        public void Unidade_Cadastrar_CEPExistente(string cep, string cidade)
        {
            unidade = AlimentandoUnidade(cep);
            Assert.Equal(cidade, unidade.Cidade);
        }
        private Unidade AlimentandoUnidade(string cep)
        {
            return _serviceRepository.BuscarCEP(cep);
        }
    }
}
