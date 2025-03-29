using System;
using System.Security.Cryptography.X509Certificates;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TesteVericode.Support;

namespace TesteVericode.PageObjects
{
    public class EnterVehicleDataPage
    {
        private readonly IWebDriver driver;

        public EnterVehicleDataPage(IWebDriver _driver)
        {
            driver = _driver;
        }

        // Menu
        public IWebElement menuEnterVehicleData => driver.FindElement(By.Id("idealsteps-nav"));
        public IWebElement menuEnterInsurantData => driver.FindElement(By.Id("enterinsurantdata"));

        // Campos
        public IWebElement selectMake => driver.FindElement(By.Id("make"));
        public IWebElement selectModel => driver.FindElement(By.Id("model"));
        public IWebElement txtCylinderCapacity => driver.FindElement(By.Id("cylindercapacity"));
        public IWebElement txtEnginePerformance => driver.FindElement(By.Id("engineperformance"));
        public IWebElement txtDateOfManufacture => driver.FindElement(By.Id("dateofmanufacture"));
        public IWebElement selectNumberSeats => driver.FindElement(By.Id("numberofseats"));
        public IWebElement radioRightHandDriveYes => driver.FindElement(By.XPath("//input[@id='righthanddriveyes']/parent::*"));
        public IWebElement radioRightHandDriveNo => driver.FindElement(By.XPath("//input[@id='righthanddriveno']/parent::*"));
        public IWebElement selectNumberoSeatsMotorCycle => driver.FindElement(By.Id("numberofseatsmotorcycle"));
        public IWebElement selectFuelType => driver.FindElement(By.Id("fuel"));
        public IWebElement txtPayload => driver.FindElement(By.Id("payload"));
        public IWebElement txtTotalWeight => driver.FindElement(By.Id("totalweight"));
        public IWebElement txtListPrice => driver.FindElement(By.Id("listprice"));
        public IWebElement txtLicensePlateNumber => driver.FindElement(By.Id("licenseplatenumber"));
        public IWebElement txtAnnualMileage => driver.FindElement(By.Id("annualmileage"));
        public IWebElement btnNext => driver.FindElement(By.Id("nextenterinsurantdata"));

        public void PreencherCampo(string campo, string valor)
        {
            switch (campo)
            {
                case "Make":
                    WebUtils.SelecionarItemPorTexto(selectMake, valor);
                    break;
                case "Model":
                    WebUtils.SelecionarItemPorTexto(selectModel, valor);
                    break;
                case "Cylinder Capacity":
                    WebUtils.PreencherTexto(txtCylinderCapacity, valor);
                    break;
                case "Engine Performance":
                    WebUtils.PreencherTexto(txtEnginePerformance, valor);
                    break;
                case "Date of Manufacture":
                    WebUtils.PreencherTexto(txtDateOfManufacture, valor);
                    break;
                case "Number of Seats":
                    WebUtils.SelecionarItemPorTexto(selectNumberSeats, valor);
                    break;
                case "Right Hand Drive":
                    if (valor == "Yes")
                        radioRightHandDriveYes.Click();
                    else
                        radioRightHandDriveNo.Click();
                    break;
                case "Number of Seats Motorcycle":
                    WebUtils.SelecionarItemPorTexto(selectNumberoSeatsMotorCycle, valor);
                    break;
                case "Fuel Type":
                    WebUtils.SelecionarItemPorTexto(selectFuelType, valor);
                    break;
                case "Payload":
                    WebUtils.PreencherTexto(txtPayload, valor);
                    break;
                case "Total Weight":
                    WebUtils.PreencherTexto(txtTotalWeight, valor);
                    break;
                case "List Price":
                    WebUtils.PreencherTexto(txtListPrice, valor);
                    break;
                case "License Plate Number":
                    WebUtils.PreencherTexto(txtLicensePlateNumber, valor);
                    break;
                case "Annual Mileage":
                    WebUtils.PreencherTexto(txtAnnualMileage, valor);
                    break;
                default:
                    throw new Exception($"Campo {campo} não encontrado.");
            }
        }

        public string ObterMensagemAviso(string campo)
        {
            switch (campo)
            {
                case "Make":
                    return WebUtils.ObterMensagemAviso(selectMake);
                case "Model":
                    return WebUtils.ObterMensagemAviso(selectModel);
                case "Cylinder Capacity":
                    return WebUtils.ObterMensagemAviso(txtCylinderCapacity);
                case "Engine Performance":
                    return WebUtils.ObterMensagemAviso(txtEnginePerformance);
                case "Date of Manufacture":
                    return WebUtils.ObterMensagemAviso(txtDateOfManufacture);
                case "Number of Seats":
                    return WebUtils.ObterMensagemAviso(selectNumberSeats);
                case "Number of Seats Motorcycle":
                    return WebUtils.ObterMensagemAviso(selectNumberoSeatsMotorCycle);
                case "Fuel Type":
                    return WebUtils.ObterMensagemAviso(selectFuelType);
                case "Payload":
                    return WebUtils.ObterMensagemAviso(txtPayload);
                case "Total Weight":
                    return WebUtils.ObterMensagemAviso(txtTotalWeight);
                case "List Price":
                    return WebUtils.ObterMensagemAviso(txtListPrice);
                case "License Plate Number":
                    return WebUtils.ObterMensagemAviso(txtLicensePlateNumber);
                case "Annual Mileage":
                    return WebUtils.ObterMensagemAviso(txtAnnualMileage);
                default:
                    throw new Exception($"Campo {campo} não encontrado.");
            }
        }

        public void ClicarProximo()
        {
            btnNext.Click();
        }

        public bool ValidaAcessoMenu(string itemMenu)
        {
            string fontWeight = menuEnterInsurantData.GetCssValue("font-weight");
            return fontWeight == "bold" || fontWeight == "700";
        }
    }
}
