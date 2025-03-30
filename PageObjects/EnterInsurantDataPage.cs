using System.IO;
using OpenQA.Selenium;
using TesteVericode.Support;

namespace TesteVericode.PageObjects
{
    public class EnterInsurantDataPage
    {
        // Driver do Selenium WebDriver
        private readonly IWebDriver driver;

        // Construtor que inicializa o driver
        public EnterInsurantDataPage(IWebDriver _driver)
        {
            driver = _driver;
        }

        // Campos do formulário
        public IWebElement selectFirstName => driver.FindElement(By.Id("firstname")); // Campo de entrada para o primeiro nome
        public IWebElement selectLastName => driver.FindElement(By.Id("lastname")); // Campo de entrada para o sobrenome
        public IWebElement txtBirthDate => driver.FindElement(By.Id("birthdate")); // Campo de entrada para a data de nascimento
        public IWebElement txtStreetAddress => driver.FindElement(By.Id("streetaddress")); // Campo de entrada para o endereço
        public IWebElement selectCountry => driver.FindElement(By.Id("country")); // Campo de seleção para o país
        public IWebElement txtZipCode => driver.FindElement(By.Id("zipcode")); // Campo de entrada para o código postal
        public IWebElement txtCity => driver.FindElement(By.Id("city")); // Campo de entrada para a cidade
        public IWebElement selectOccupation => driver.FindElement(By.Id("occupation")); // Campo de seleção para a ocupação
        public IWebElement txtWebsite => driver.FindElement(By.Id("website")); // Campo de entrada para o website

        // Radio Buttons
        public IWebElement radioGenderMale => driver.FindElement(By.XPath("//input[@id='gendermale']/parent::*")); // Radio button para gênero masculino
        public IWebElement radioGenderFemale => driver.FindElement(By.XPath("//input[@id='genderfemale']/parent::*")); // Radio button para gênero feminino
        public IWebElement radioHobbiesSpeeding => driver.FindElement(By.XPath("//input[@id='speeding']/parent::*")); // Radio button para hobby "Speeding"
        public IWebElement radioHobbiesBungeeJumping => driver.FindElement(By.XPath("//input[@id='bungeejumping']/parent::*")); // Radio button para hobby "Bungee Jumping"
        public IWebElement radioHobbiesCliffDiving => driver.FindElement(By.XPath("//input[@id='cliffdiving']/parent::*")); // Radio button para hobby "Cliff Diving"
        public IWebElement radioHobbiesSkydiving => driver.FindElement(By.XPath("//input[@id='skydiving']/parent::*")); // Radio button para hobby "Skydiving"
        public IWebElement radioHobbiesOther => driver.FindElement(By.XPath("//input[@id='other']/parent::*")); // Radio button para hobby "Other"

        // Botões
        public IWebElement btnOpenPicture => driver.FindElement(By.Id("open")); // Botão para abrir a janela de seleção de imagem
        public IWebElement inputFile => driver.FindElement(By.Id("picturecontainer")); // Campo de entrada para o arquivo de imagem
        public IWebElement btnNext => driver.FindElement(By.Id("nextenterproductdata")); // Botão para ir para o próximo formulário

        // Método para preencher os campos do formulário com base no nome do campo
        public void PreencherCampo(string campo, string valor)
        {
            switch (campo)
            {
                case "First Name":
                    WebUtils.PreencherTexto(selectFirstName, valor);
                    break;
                case "Last Name":
                    WebUtils.PreencherTexto(selectLastName, valor);
                    break;
                case "Date of Birth":
                    WebUtils.PreencherTexto(txtBirthDate, valor);
                    break;
                case "Gender":
                    if (valor == "Male")
                        radioGenderMale.Click();
                    else
                        radioGenderFemale.Click();
                    break;
                case "Street Address":
                    WebUtils.PreencherTexto(txtStreetAddress, valor);
                    break;
                case "Country":
                    WebUtils.SelecionarItemPorTexto(selectCountry, valor);
                    break;
                case "Zip Code":
                    WebUtils.PreencherTexto(txtZipCode, valor);
                    break;
                case "City":
                    WebUtils.PreencherTexto(txtCity, valor);
                    break;
                case "Occupation":
                    WebUtils.SelecionarItemPorTexto(selectOccupation, valor);
                    break;
                case "Hobbies":
                    switch (valor)
                    {
                        case "Speeding":
                            radioHobbiesSpeeding.Click();
                            break;
                        case "Bungee Jumping":
                            radioHobbiesBungeeJumping.Click();
                            break;
                        case "Cliff Diving":
                            radioHobbiesCliffDiving.Click();
                            break;
                        case "Skydiving":
                            radioHobbiesSkydiving.Click();
                            break;
                        case "Other":
                            radioHobbiesOther.Click();
                            break;
                        default:
                            throw new Exception($"Hobbies {valor} não encontrado");
                    }
                    break;
                case "Website":
                    WebUtils.PreencherTexto(txtWebsite, valor);
                    break;
                case "Picture":
                    AbrirESelecionarImagem(valor);
                    break;
                default:
                    throw new Exception($"Campo {campo} não encontrado");
            }
        }

        // Método para selecionar uma imagem a partir do caminho fornecido
        private void SelecionarImagem(string nomeImagem)
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string parentDirectory = Directory.GetParent(baseDirectory).Parent.Parent.Parent.FullName;
            string caminhoImagem = Path.Combine(parentDirectory, "Images", nomeImagem);
            inputFile.SendKeys(caminhoImagem);
        }

        // Método para abrir a janela de seleção de arquivo
        private void AbrirJanelaSelecaoArquivo()
        {
            btnOpenPicture.Click();
        }

        // Método para abrir a janela de seleção de arquivo e selecionar a imagem
        private void AbrirESelecionarImagem(string caminhoImagem)
        {
            AbrirJanelaSelecaoArquivo();
            SelecionarImagem(caminhoImagem);
        }
    }
}

