using System;
using Xunit;
using OpenQA.Selenium;


namespace Test
{
    public class TesteIntegrado
    {
        [Fact]
        public void CriarUnidade()
        {
            Utilities.OpenChrome();

            Assert.Contains("Principal - inForma", Utilities.driver.Title);

            PageObject.MainScreen.GridIcone();
           
            PageObject.MainScreen.CadastroList();
            
            PageObject.MainScreen.CadastroUnidadeLink();

            Assert.Contains("Cadastrar - inForma", Utilities.driver.Title);

            PageObject.RegisterUnitScreen.NomeUnidadeTextBox("São Paulo");

            PageObject.RegisterUnitScreen.TelefoneTextBox("11999999999");

            PageObject.RegisterUnitScreen.CepTextBox("04664020");

            Utilities.CepValidates(
            "Avenida Ministro Álvaro de Souza Lima",     // Endereço
            "Jardim Marajoara",                          // Bairro
            "São Paulo",                                 // Cidade
            "PR");                                       // Estado

            PageObject.RegisterUnitScreen.NumeroTextBox("666");

        }
    }
}
