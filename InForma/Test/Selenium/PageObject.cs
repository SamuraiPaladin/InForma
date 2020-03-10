using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
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
                while (clicked.Equals(false))
                {
                    try
                    {
                        IWebElement Element = Utilities.driver.FindElement(By.XPath("/html/body/nav/div/ul[1]/li[1]/a"));
                        Element.Click();
                        clicked = true;
                    }
                    catch (Exception e)
                    {
                        count = count + 1;
                        Assert.False(count > 3, "Descrição da Falha: " + e);
                    }
                }

            }

            public class Cadastro
            {
                public static void CadastroList()
                {
                    int count = 0;
                    Boolean clicked = false;
                    while (clicked.Equals(false))
                    {
                        try
                        {
                            IWebElement Element = Utilities.driver.FindElement(By.XPath("//*[@id=\"slide-out\"]/li[3]/ul/li/div[1]"));
                            Element.Click();
                            clicked = true;
                        }
                        catch (Exception e)
                        {
                            count = count + 1;
                            Assert.False(count > 3, "Descrição da Falha: " + e);
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
                            IWebElement Element = Utilities.driver.FindElement(By.XPath("//*[@id=\"slide-out\"]/li[3]/ul/li/div[2]/ul/li[1]/a"));
                            Element.Click();
                            clicked = true;
                        }
                        catch (Exception e)
                        {
                            count = count + 1;
                            Assert.False(count > 3, "Descrição da Falha: " + e);
                        }
                    }
                }

                public static void CadastroModalidadeLink()
                {
                    int count = 0;
                    Boolean clicked = false;
                    if (count < 3 || clicked.Equals(false))
                    {
                        try
                        {
                            IWebElement Element = Utilities.driver.FindElement(By.XPath("//*[@id=\"slide-out\"]/li[3]/ul/li/div[2]/ul/li[2]/a"));
                            Element.Click();
                            clicked = true;
                        }
                        catch (Exception e)
                        {
                            count = count + 1;
                            Assert.False(count > 3, "Descrição da Falha: " + e);
                        }
                    }
                }

                public static void CadastroCargosLink()
                {
                    int count = 0;
                    Boolean clicked = false;
                    if (count < 3 || clicked.Equals(false))
                    {
                        try
                        {
                            IWebElement Element = Utilities.driver.FindElement(By.XPath("//*[@id=\"slide-out\"]/li[3]/ul/li/div[2]/ul/li[3]/a"));
                            Element.Click();
                            clicked = true;
                        }
                        catch (Exception e)
                        {
                            count = count + 1;
                            Assert.False(count > 3, "Descrição da Falha: " + e);
                        }
                    }
                }

                public static void CadastroColaboradoresLink()
                {
                    int count = 0;
                    Boolean clicked = false;
                    if (count < 3 || clicked.Equals(false))
                    {
                        try
                        {
                            IWebElement Element = Utilities.driver.FindElement(By.XPath("//*[@id=\"slide-out\"]/li[3]/ul/li/div[2]/ul/li[4]/a"));
                            Element.Click();
                            clicked = true;
                        }
                        catch (Exception e)
                        {
                            count = count + 1;
                            Assert.False(count > 3, "Descrição da Falha: " + e);
                        }
                    }
                }

                public static void CadastroFornecedoresLink()
                {
                    int count = 0;
                    Boolean clicked = false;
                    if (count < 3 || clicked.Equals(false))
                    {
                        try
                        {
                            IWebElement Element = Utilities.driver.FindElement(By.XPath("//*[@id=\"slide-out\"]/li[3]/ul/li/div[2]/ul/li[5]/a"));
                            Element.Click();
                            clicked = true;
                        }
                        catch (Exception e)
                        {
                            count = count + 1;
                            Assert.False(count > 3, "Descrição da Falha: " + e);
                        }
                    }
                }

            }

            public class Financeiro
            {
                public static void FinanceiroList()
                {
                    int count = 0;
                    Boolean clicked = false;
                    while (clicked.Equals(false))
                    {
                        try
                        {
                            IWebElement Element = Utilities.driver.FindElement(By.XPath("//*[@id=\"slide-out\"]/li[4]/ul/li/div[1]"));
                            Element.Click();
                            clicked = true;
                        }
                        catch (Exception e)
                        {
                            count = count + 1;
                            Assert.False(count > 3, "Descrição da Falha: " + e);
                        }
                    }
                }
                public static void GerenciarPagamentoLink()
                {
                    int count = 0;
                    Boolean clicked = false;
                    while (clicked.Equals(false))
                    {
                        try
                        {
                            IWebElement Element = Utilities.driver.FindElement(By.XPath("//*[@id=\"slide-out\"]/li[4]/ul/li/div[2]/ul/li/a"));
                            Element.Click();
                            clicked = true;
                        }
                        catch (Exception e)
                        {
                            count = count + 1;
                            Assert.False(count > 3, "Descrição da Falha: " + e);
                        }
                    }
                }
            }

            public class Estoque
            {
                public static void EstoqueList()
                {
                    int count = 0;
                    Boolean clicked = false;
                    while (clicked.Equals(false))
                    {
                        try
                        {
                            IWebElement Element = Utilities.driver.FindElement(By.XPath("//*[@id=\"slide-out\"]/li[5]/ul/li/div[2]/ul/li/a"));
                            Element.Click();
                            clicked = true;
                        }
                        catch (Exception e)
                        {
                            count = count + 1;
                            Assert.False(count > 3, "Descrição da Falha: " + e);
                        }
                    }

                }

                public static void LinkLink()
                {
                    int count = 0;
                    Boolean clicked = false;
                    while (clicked.Equals(false))
                    {
                        try
                        {
                            IWebElement Element = Utilities.driver.FindElement(By.XPath("//*[@id=\"slide-out\"]/li[5]/ul/li/div[1]"));
                            Element.Click();
                            clicked = true;
                        }
                        catch (Exception e)
                        {
                            count = count + 1;
                            Assert.False(count > 3, "Descrição da Falha: " + e);
                        }
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
                while (Text.Equals(Unidade))
                {
                    try
                    {
                        IWebElement Element = Utilities.driver.FindElement(By.Id("descricao"));
                        Element.SendKeys(Unidade);
                        Text = Element.GetAttribute("value");
                    }
                    catch (Exception e)
                    {
                        count = count + 1;
                        Assert.False(count > 3, "Descrição da Falha: " + e);
                    }
                }
                Assert.Contains(Unidade, Text);
            }

            public static void TelefoneTextBox(string Unidade)
            {
                int count = 0;
                string Text = "";
                while (Text.Equals(Unidade))
                {
                    try
                    {
                        IWebElement Element = Utilities.driver.FindElement(By.Id("telefone"));
                        Element.SendKeys(Unidade);
                        Text = Element.GetAttribute("value");
                    }
                    catch (Exception e)
                    {
                        count = count + 1;
                        Assert.False(count > 3, "Descrição da Falha: " + e);
                    }
                }
                Assert.Contains(Unidade, Text);
            }

            public static void CepTextBox(string Unidade)
            {
                int count = 0;
                string Text = "";
                while (Text.Equals(Unidade))
                {
                    try
                    {
                        IWebElement Element = Utilities.driver.FindElement(By.Id("cep"));
                        Element.SendKeys(Unidade + Keys.Tab);
                        Text = Element.GetAttribute("value");
                    }
                    catch (Exception e)
                    {
                        count = count + 1;
                        Assert.False(count > 3, "Descrição da Falha: " + e);
                    }
                }
                Assert.Contains(Unidade, Text);
            }

            public static void EnderecoTextBox(string Unidade)
            {
                int count = 0;
                string Text = "";
                while (Text.Equals(Unidade))
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
                        count = count + 1;
                        Assert.False(count > 3, "Descrição da Falha: " + e);
                    }
                }
                Assert.Contains(Unidade, Text);
            }

            public static void NumeroTextBox(string Unidade)
            {
                int count = 0;
                string Text = "";
                while (Text.Equals(Unidade))
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
                        count = count + 1;
                        Assert.False(count > 3, "Descrição da Falha: " + e);
                    }
                }
                Assert.Contains(Unidade, Text);
            }

            public static void BairroTextBox(string Unidade)
            {
                int count = 0;
                string Text = "";
                while (Text.Equals(Unidade))
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
                        count = count + 1;
                        Assert.False(count > 3, "Descrição da Falha: " + e);
                    }
                }
                Assert.Contains(Unidade, Text);
            }

            public static void CidadeTextBox(string Unidade)
            {
                int count = 0;
                string Text = "";
                while (Text.Equals(Unidade))
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
                        count = count + 1;
                        Assert.False(count > 3, "Descrição da Falha: " + e);
                    }
                }
                Assert.Contains(Unidade, Text);
            }

            public static void EstadoTextBox(string Unidade)
            {
                int count = 0;
                string Text = "";
                while (Text.Equals(Unidade))
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
                        count = count + 1;
                        Assert.False(count > 3, "Descrição da Falha: " + e);
                    }
                }
                Assert.Contains(Unidade, Text);
            }
        }    
    }
}
