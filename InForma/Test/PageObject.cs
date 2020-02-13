using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class PageObject
{
	public static IWebElement elemento;
	public static IWebDriver driver;
	public static class LoginScreen {
		public static IWebElement LoginBox() 
		{
			try
			{
				elemento = driver.FindElement(By.Id(""));
				return elemento;
			}
			catch (Exception e)
			{
				TratarErro();
			}

		}

	}
}
