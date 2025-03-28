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
        private static IWebDriver? driver;

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            driver?.Quit();

            // Gera report html do Allure
            BuildHtmlReport();
        }

        [AfterStep]
        public void AfterStep(ScenarioContext context)
        {
            if (context.TestError != null)
            {
                byte[] content = CaptureScreenshot();
                AllureApi.AddAttachment("Failed Screenshot", "application/png", content);
            }
        }

        public static byte[] CaptureScreenshot()
        {
            if (driver is ITakesScreenshot screenshotDriver)
            {
                return screenshotDriver.GetScreenshot().AsByteArray;
            }

            throw new InvalidOperationException("O driver não suporta capturas de tela");
        }

        public static IWebDriver Driver => driver ?? throw new InvalidOperationException("Driver is not initialized");
    }
}
