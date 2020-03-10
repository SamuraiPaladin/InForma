using OpenQA.Selenium;
using System;
using System.Drawing;
using System.IO;
using Test;
using Xceed.Wpf.Toolkit;
using Xunit;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Utilities
{
	public static IWebDriver driver;
	public static void OpenChrome()
	{
		var t = Directory.GetCurrentDirectory().Remove(Directory.GetCurrentDirectory().ToString().Length - 26);

		driver = new OpenQA.Selenium.Chrome.ChromeDriver(t); //<-Add your path
		driver.Manage().Window.Maximize();
		////driver.Manage().Window.Size = new Size(1366, 800);
		driver.Navigate().GoToUrl("http://localhost:5200/");
	}

	public static void AcessoGrid(String Modulo, String Sessao)
	{
		PageObject.MainScreen.GridIcone();

		if (Modulo.Equals("Cadastro"))
		{
			PageObject.MainScreen.Cadastro.CadastroList();

			if(Sessao.Equals("Unidade"))
			{
				PageObject.MainScreen.Cadastro.CadastroUnidadeLink();
			} else if (Sessao.Equals("Modalidade"))
			{
				PageObject.MainScreen.Cadastro.CadastroModalidadeLink();
			} else if (Sessao.Equals("Cargos"))
			{
				PageObject.MainScreen.Cadastro.CadastroCargosLink();
			} else if (Sessao.Equals("Colaborador"))
			{
				PageObject.MainScreen.Cadastro.CadastroColaboradoresLink();
			} else if (Sessao.Equals("Fornecedor"))
			{
				PageObject.MainScreen.Cadastro.CadastroFornecedoresLink();
			}

		} else if (Modulo.Equals("Financeiro"))
		{
			PageObject.MainScreen.Financeiro.FinanceiroList();
			if (Sessao.Equals("Gerenciar Pagamento"))
			{
				PageObject.MainScreen.Financeiro.GerenciarPagamentoLink();
			}

		} else if (Modulo.Equals("Estoque"))
		{
			PageObject.MainScreen.Estoque.EstoqueList();
			if (Sessao.Equals("Link"))
			{
				PageObject.MainScreen.Estoque.LinkLink();
			}
		}
	}

	public static void CepValidates(String Endereco, String Bairro, String Cidade, String Estado)
	{
		PageObject.RegisterUnitScreen.EnderecoTextBox(Endereco);
		PageObject.RegisterUnitScreen.BairroTextBox(Bairro);
		PageObject.RegisterUnitScreen.CidadeTextBox(Cidade);
		PageObject.RegisterUnitScreen.EstadoTextBox(Estado);
	}


}
