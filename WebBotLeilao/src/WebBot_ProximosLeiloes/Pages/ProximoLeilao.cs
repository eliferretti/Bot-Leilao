using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBot_ProximosLeiloes.Pages
{
    public class ProximoLeilao
    {
        public void AcessaPagina() 
        {
            try
            {
                IWebDriver driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://www.rogeriomenezes.com.br");

                // fecha popup
                //IWebElement botaoFechaPopup = driver.FindElement(By.ClassName("popup-content"));
                //botaoFechaPopup.Click();
                            
                IWebElement botaoFechar = driver.FindElement(By.LinkText("Fechar vídeo"));
                botaoFechar.Click(); 
                Console.WriteLine("Fechou vídeo");

                botaoFechar = driver.FindElement(By.Id("consent-confirm"));
                botaoFechar.Click();
                Console.WriteLine("Aceitou cookies");

                IWebElement divCenter = driver.FindElement(By.ClassName("agenda-content"));

                // Localize a ul dentro da div
                IWebElement ulElement = divCenter.FindElement(By.ClassName("leiloes"));

                // Obtenha todos os elementos li dentro da ul
                IReadOnlyCollection<IWebElement> liElements = ulElement.FindElements(By.TagName("li"));

                // Criar uma lista para armazenar os textos dos elementos li
                List<string> listaElementos = new List<string>();

                // Iterar sobre os elementos li e extrair o texto
                foreach (IWebElement liElement in liElements)
                {
              
                    // Obtenha o texto do elemento li
                    string texto = liElement.Text;

                    if (texto.Contains("seguradora", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("A palavra 'seguradora' está presente neste elemento:");
                        Console.WriteLine(texto);
                        liElement.Click();

                        // Adicione um atraso opcional para que você possa ver a ação sendo realizada
                        System.Threading.Thread.Sleep(1000);
                        break;
                    }
                }

            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Elemento não encontrado.");
            }
        }
    }
}
