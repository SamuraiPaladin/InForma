using OpenQA.Selenium;
using System;
using System.Drawing;
using System.IO;
using Test;
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

	public static void CepValidates(String Endereco, String Bairro, String Cidade, String Estado)
	{
		PageObject.RegisterUnitScreen.EnderecoTextBox(Endereco);
		PageObject.RegisterUnitScreen.BairroTextBox(Bairro);
		PageObject.RegisterUnitScreen.CidadeTextBox(Cidade);
		PageObject.RegisterUnitScreen.EstadoTextBox(Estado);
	}


}
