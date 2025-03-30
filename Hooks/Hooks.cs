using System.Diagnostics;
using Allure.Net.Commons;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TesteVericode.Support;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace TesteVericode.StepDefinitions
{
    [Binding]
    public class Hooks : Report
    {
        // Driver do Selenium WebDriver
        private static IWebDriver? driver;

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            // Configura o driver do Chrome antes da execução dos testes
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            // Define o tempo de espera implícito para 10 segundos
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            // Encerra o driver após a execução dos testes
            driver?.Quit();

            // Gera o relatório HTML do Allure
            BuildHtmlReport();
        }

        [AfterStep]
        public void AfterStep(ScenarioContext context)
        {
            // Se houver um erro no passo, captura uma captura de tela
            if (context.TestError != null)
            {
                byte[] content = CaptureScreenshot();
                // Adiciona a captura de tela ao relatório Allure
                AllureApi.AddAttachment("Failed Screenshot", "application/png", content);
            }
        }

        public static byte[] CaptureScreenshot()
        {
            // Captura uma captura de tela se o driver suportar
            if (driver is ITakesScreenshot screenshotDriver)
            {
                return screenshotDriver.GetScreenshot().AsByteArray;
            }

            // Lança uma exceção se o driver não suportar capturas de tela
            throw new InvalidOperationException("O driver não suporta capturas de tela");
        }

        // Propriedade para acessar o driver do Selenium WebDriver
        public static IWebDriver Driver => driver ?? throw new InvalidOperationException("Driver is not initialized");
    }
}
