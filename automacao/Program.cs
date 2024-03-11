using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

EdgeDriverService service = EdgeDriverService.CreateDefaultService();
service.HideCommandPromptWindow = true;
EdgeOptions options = new();

IWebDriver driver = new EdgeDriver(service, options);

driver.Navigate().GoToUrl("https://youtube.com/");

Console.WriteLine("Teste.");
Console.ReadLine();

IWebElement searchBox = driver.FindElement(By.Id("search"));

searchBox.SendKeys("Canal do Mano Fábio, Youtube Pesquisar");

IWebElement searchBtn = driver.FindElement(By.Id("search-icon-legacy"));

searchBtn.Click();

driver.Quit();