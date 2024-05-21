// See https://aka.ms/new-console-template for more information
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SS.PruebaCLI.Bissn;

EdgeDriver driver = new EdgeDriver();
driver.Url = "https://www.google.com.mx";
driver.FindElement(By.Name("q")).SendKeys("webdriver" + Keys.Return);
Console.WriteLine(driver.Title);
driver.Quit();

var i = 1;

var x = 3;
