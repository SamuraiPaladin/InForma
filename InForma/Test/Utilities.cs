using OpenQA.Selenium;
using System;
using System.Drawing;
using System.IO;
using Xunit;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace Test
{
	public class Utilities
	{
		public static void OpenChrome()
		{
			var t = Directory.GetCurrentDirectory().Remove(Directory.GetCurrentDirectory().ToString().Length - 23);

			IWebDriver driver = new OpenQA.Selenium.Chrome.ChromeDriver(t); //<-Add your path
			driver.Manage().Window.Maximize();
			////driver.Manage().Window.Size = new Size(1366, 800);
			driver.Navigate().GoToUrl("https://localhost");
		}

		public static void TratarErro()
		{

		}
	}
}
