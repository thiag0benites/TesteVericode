using System;
using System.IO;
using NUnit.Framework;
using OpenQA.Selenium;

namespace TesteVericode.PageObjects
{
    public class ContextoPage
    {
        private readonly IWebDriver driver;
        private const string Url = "https://sampleapp.tricentis.com/101/app.php";

        public ContextoPage(IWebDriver _driver)
        {
            driver = _driver;
        }

        public void AcessarSistema()
        {
            driver.Navigate().GoToUrl(Url);
            Assert.AreEqual(Url, driver.Url, $"Falha ao acessar a URL esperada. URL atual: {driver.Url}");
            //CapturarScreenshot("AcessarSistema");
        }

        //public void CapturarScreenshot(string nomeCenario)
        //{
        //    try
        //    {
        //        if (driver == null)
        //            throw new InvalidOperationException("O WebDriver não foi inicializado corretamente.");

        //        Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();

        //        string diretorio = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Screenshots");
        //        Directory.CreateDirectory(diretorio);

        //        string caminhoArquivo = Path.Combine(diretorio, $"{nomeCenario}_{DateTime.Now:yyyyMMdd_HHmmss}.png");
        //        screenshot.SaveAsFile(caminhoArquivo, ScreenshotImageFormat.Png);

        //        TestContext.AddTestAttachment(caminhoArquivo, "Screenshot");
        //    }
        //    catch (Exception ex)
        //    {
        //        TestContext.WriteLine($"Erro ao capturar screenshot: {ex.Message}");
        //    }
        //}
    }
}
