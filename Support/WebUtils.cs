using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace TesteVericode.Support
{
    public static class WebUtils
    {
        public static void PreencherTexto(IWebElement elemento, string valor)
        {
            elemento.Clear();
            elemento.SendKeys(valor);
        }

        public static string ObterMensagemAviso(IWebElement elemento)
        {
            return elemento.FindElement(By.XPath("following-sibling::span")).GetAttribute("innerHTML").Trim();
        }

        public static void SelecionarItemPorTexto(IWebElement selectElement, string texto)
        {
            var select = new SelectElement(selectElement);
            select.SelectByText(texto);
        }

        public static IWebElement EsperarElementoVisivel(IWebDriver driver, By by, TimeSpan timeout)
        {
            var wait = new WebDriverWait(driver, timeout);
            return wait.Until(driver =>
            {
                try
                {
                    var element = driver.FindElement(by);
                    return element.Displayed ? element : null;
                }
                catch (NoSuchElementException)
                {
                    return null;
                }
                catch (StaleElementReferenceException)
                {
                    return null;
                }
            });
        }

        public static void Aguardar(int segundos)
        {
            Thread.Sleep((segundos * 1000));
        }
    }
}
