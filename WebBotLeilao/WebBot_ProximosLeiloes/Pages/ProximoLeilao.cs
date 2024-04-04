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
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("www.rogeriomenezes.com.br");
        }
    }
}
