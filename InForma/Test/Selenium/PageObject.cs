using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Test
{
    class PageObject
    {
        public static class MainScreen
        {
            public static void GridIcone()
            {
                int count = 0;
                Boolean clicked = false;
                if (count < 3 || clicked.Equals(false))
                {
                    try
                    {
                        IWebElement Element = Utilities.driver.FindElement(By.XPath("/html/body/nav/div/ul[1]/li[1]/a"));
                        Element.Click();
                        clicked = true;
                    }
                    catch (Exception e)
                    {
                        e.ToString();
                        System.Diagnostics.Debug.WriteLine("Erro:" + e.Message);
                        count = count + 1;
                    }
                }

            }

            public static void CadastroList()
            {
                int count = 0;
                Boolean clicked = false;
                if (count < 3 || clicked.Equals(false))
                {
                    try
                    {
                        IWebElement Element = Utilities.driver.FindElement(By.XPath("/html/body/ul/ul[1]/li/a"));
                        Element.Click();
                        clicked = true;
                    }
                    catch (Exception e)
                    {
                        e.ToString();
                        System.Diagnostics.Debug.WriteLine("Erro:" + e.Message);
                        count = count + 1;
                    }
                }

            }

            public static void CadastroUnidadeLink()
            {
                int count = 0;
                Boolean clicked = false;
                if (count < 3 || clicked.Equals(false))
                {
                    try
                    {
                        IWebElement Element = Utilities.driver.FindElement(By.XPath("/html/body/ul/ul[1]/li/div/ul/li[1]/a"));
                        Element.Click();
                        clicked = true;
                    }
                    catch (Exception e)
                    {
                        e.ToString();
                        System.Diagnostics.Debug.WriteLine("Erro:" + e.Message);
                        count = count + 1;
                    }
                }

            }
        }

        public static class RegisterUnitScreen
        {
            public static void NomeUnidadeTextBox(string Unidade)
            {
                int count = 0;
                string Text = "";
                if (count < 3 || Text.Equals(Unidade))
                {
                    try
                    {
                        IWebElement Element = Utilities.driver.FindElement(By.Id("descricao"));
                        Element.SendKeys(Unidade);
                        Text = Element.GetAttribute("value");
                    }
                    catch (Exception e)
                    {
                        e.ToString();
                        System.Diagnostics.Debug.WriteLine("Erro:" + e.Message);
                        count = count + 1;
                    }
                }
                Assert.Contains(Unidade, Text);
            }

            public static void TelefoneTextBox(string Unidade)
            {
                int count = 0;
                string Text = "";
                if (count < 3 || Text.Equals(Unidade))
                {
                    try
                    {
                        IWebElement Element = Utilities.driver.FindElement(By.Id("telefone"));
                        Element.SendKeys(Unidade);
                        Text = Element.GetAttribute("value");
                    }
                    catch (Exception e)
                    {
                        e.ToString();
                        System.Diagnostics.Debug.WriteLine("Erro:" + e.Message);
                        count = count + 1;
                    }
                }
                Assert.Contains(Unidade, Text);
            }

            public static void CepTextBox(string Unidade)
            {
                int count = 0;
                string Text = "";
                if (count < 3 || Text.Equals(Unidade))
                {
                    try
                    {
                        IWebElement Element = Utilities.driver.FindElement(By.Id("cep"));
                        Element.SendKeys(Unidade + Keys.Tab);
                        Text = Element.GetAttribute("value");
                    }
                    catch (Exception e)
                    {
                        e.ToString();
                        System.Diagnostics.Debug.WriteLine("Erro:" + e.Message);
                        count = count + 1;
                    }
                }
                Assert.Contains(Unidade, Text);
            }

            public static void EnderecoTextBox(string Unidade)
            {
                int count = 0;
                string Text = "";
                if (count < 3 || Text.Equals(Unidade))
                {
                    try
                    {
                        IWebElement Element = Utilities.driver.FindElement(By.Id("endereco"));
                        if (Element.GetAttribute("value").Equals(""))
                        { 
                            Element.SendKeys(Unidade + Keys.Tab);
                        } else
                        {
                            Element.SendKeys(Keys.Tab);
                        }
                        Text = Element.GetAttribute("value");
                    }
                    catch (Exception e)
                    {
                        e.ToString();
                        System.Diagnostics.Debug.WriteLine("Erro:" + e.Message);
                        count = count + 1;
                    }
                }
                Assert.Contains(Unidade, Text);
            }

            public static void NumeroTextBox(string Unidade)
            {
                int count = 0;
                string Text = "";
                if (count < 3 || Text.Equals(Unidade))
                {
                    try
                    {
                        IWebElement Element = Utilities.driver.FindElement(By.Id("numero"));
                        if (Element.GetAttribute("value").Equals(""))
                        {
                            Element.SendKeys(Unidade + Keys.Tab);
                        }
                        else
                        {
                            Element.SendKeys(Keys.Tab);
                        }
                        Text = Element.GetAttribute("value");
                    }
                    catch (Exception e)
                    {
                        e.ToString();
                        System.Diagnostics.Debug.WriteLine("Erro:" + e.Message);
                        count = count + 1;
                    }
                }
                Assert.Contains(Unidade, Text);
            }

            public static void BairroTextBox(string Unidade)
            {
                int count = 0;
                string Text = "";
                if (count < 3 || Text.Equals(Unidade))
                {
                    try
                    {
                        IWebElement Element = Utilities.driver.FindElement(By.Id("bairro"));
                        if (Element.GetAttribute("value").Equals(""))
                        {
                            Element.SendKeys(Unidade + Keys.Tab);
                        }
                        else
                        {
                            Element.SendKeys(Keys.Tab);
                        }
                        Text = Element.GetAttribute("value");
                    }
                    catch (Exception e)
                    {
                        e.ToString();
                        System.Diagnostics.Debug.WriteLine("Erro:" + e.Message);
                        count = count + 1;
                    }
                }
                Assert.Contains(Unidade, Text);
            }

            public static void CidadeTextBox(string Unidade)
            {
                int count = 0;
                string Text = "";
                if (count < 3 || Text.Equals(Unidade))
                {
                    try
                    {
                        IWebElement Element = Utilities.driver.FindElement(By.Id("cidade"));
                        if (Element.GetAttribute("value").Equals(""))
                        {
                            Element.SendKeys(Unidade + Keys.Tab);
                        }
                        else
                        {
                            Element.SendKeys(Keys.Tab);
                        }
                        Text = Element.GetAttribute("value");
                    }
                    catch (Exception e)
                    {
                        e.ToString();
                        System.Diagnostics.Debug.WriteLine("Erro:" + e.Message);
                        count = count + 1;
                    }
                }
                Assert.Contains(Unidade, Text);
            }

            public static void EstadoTextBox(string Unidade)
            {
                int count = 0;
                string Text = "";
                if (count < 3 || Text.Equals(Unidade))
                {
                    try
                    {
                        IWebElement Element = Utilities.driver.FindElement(By.Id("estado"));
                        if (Element.GetAttribute("value").Equals(""))
                        {
                            Element.SendKeys(Unidade + Keys.Tab);
                        }
                        else
                        {
                            Element.SendKeys(Keys.Tab);
                        }
                        Text = Element.GetAttribute("value");
                    }
                    catch (Exception e)
                    {
                        e.ToString();
                        System.Diagnostics.Debug.WriteLine("Erro:" + e.Message);
                        count = count + 1;
                    }
                }
                Assert.Contains(Unidade, Text);
            }
        }    
    }
}
