using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Utilities
{
	public static void OpenChrome()
	{
		IWebDriver driver = new ChromeDriver(@"C:\Users\Thauan Moser Doce\Downloads"); //<-Add your path
		driver.Navigate().GoToUrl("https://www.uol.com.br");
	}
}
