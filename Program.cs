using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = ("https://gmail.com");
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);

            IWebElement emaillogin = driver.FindElement(By.Id("identifierId"));
            emaillogin.SendKeys("qatestcodeteam6");

            driver.FindElement(By.XPath("//div[@id='identifierNext']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            IWebElement password = driver.FindElement(By.CssSelector("body.nyoS7c.UzCXuf.EIlDfe:nth-child(2) div.H2SoFe.LZgQXe.TFhTPc:nth-child(1) div.RAYh1e.LZgQXe div.xkfVF div.JhUD8d.SQNfcc.vLGJgb div.zWl5kd div.DRS7Fe.bxPAYd.k6Zj8d div.pwWryf.bxPAYd:nth-child(2) div.Wxwduf.Us7fWe.JhUD8d div.WEQkZc div.bCAAsb section.TgkVnd div.dMArKd.bxPAYd.k6Zj8d div.cDSmF.s5Ip0c:nth-child(3) div.rFrNMe.KSczvd.uyaebd.BlbNGe.zKHdkd.sdJrJc.Tyc9J div.aCsJod.oJeWuf div.aXBtI.I0VJ4d.Wic03c div.Xb9hP > input.whsOnd.zHQkBf"));
            password.SendKeys("qatest1!");

            driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

            IWebElement compose = driver.FindElement(By.XPath("/html[1]/body[1]/div[7]/div[3]/div[1]/div[2]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]"));
            compose.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            IWebElement to = driver.FindElement(By.Name("to"));
            to.SendKeys("k.y609866@gmail.com");

            IWebElement subject = driver.FindElement(By.Name("subjectbox"));
            subject.SendKeys("test");

            IWebElement textfield = driver.FindElement(By.XPath("/html[1]/body[1]/div[27]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/div[1]/div[4]/table[1]/tbody[1]/tr[1]/td[2]/table[1]/tbody[1]/tr[1]/td[1]/div[1]/div[1]/div[2]/div[1]/div[1]/table[1]/tbody[1]/tr[1]/td[2]/div[2]/div[1]"));
            textfield.SendKeys("If you run this test, you will notice that it passes successfully because we have explicitly told it to wait for a certain amount of time before continuing.");

            IWebElement send = driver.FindElement(By.XPath("/html[1]/body[1]/div[27]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/div[1]/div[4]/table[1]/tbody[1]/tr[1]/td[2]/table[1]/tbody[1]/tr[2]/td[1]/div[1]/div[1]/div[4]/table[1]/tbody[1]/tr[1]/td[1]/div[1]/div[2]"));
            send.Click();
            
            System.Threading.Thread.Sleep(5000);
            driver.Quit();
        }
    }
}
