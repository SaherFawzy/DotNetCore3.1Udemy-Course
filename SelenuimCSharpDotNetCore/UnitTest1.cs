using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SelenuimCSharpDotNetCore
{
    public class Tests
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            System.Console.WriteLine("Setup");
            driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");
            System.Console.WriteLine("Test1");
            driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")).Click();
            IWebElement comboBox = driver.FindElement(By.XPath("//input[@id='ContentPlaceHolder1_AllMealsCombo-awed']"));
            comboBox.Clear();
            comboBox.SendKeys("Mango");
            Assert.Pass();
        }
    }
}