﻿namespace Timesheet.Test.E2EH;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

public class E2EHLoginTest
{

    [Test]
    public void TestLoginReturnsCorrectPage()
    {
        new DriverManager().SetUpDriver(new ChromeConfig());
        ChromeOptions options = new ChromeOptions();
        options.AddArguments("--whitelisted-ips=''");
        options.AddArguments("--headless=new");

        IWebDriver _webDriver = new ChromeDriver(options);

        _webDriver.Navigate().GoToUrl("http://localhost:8080");

        _webDriver.FindElement(By.Name("email")).SendKeys("admin@test.com");
        _webDriver.FindElement(By.Name("password")).SendKeys("password123");
        _webDriver.FindElement(By.CssSelector("button")).Click();

        WebDriverWait wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(10));
        wait.Until(drv => drv.FindElement(By.CssSelector(".card-title")));

        string title = _webDriver.FindElement(By.CssSelector(".card-title")).Text;

        Assert.That(title, Is.EqualTo("Projects"));

        _webDriver.Close();
        _webDriver.Quit();
    }

}