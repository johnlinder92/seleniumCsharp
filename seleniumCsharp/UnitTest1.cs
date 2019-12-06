using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
namespace MySeleniumProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ChromeDriver Driver = new ChromeDriver();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://www.hm.se");
            /*driver.manage().timeouts().implicitlyWait(20, TimeUnit.SECONDS);*/
            IWebElement SearchFunction = Driver.FindElementById("main-search");
            SearchFunction.Click();
            Driver.FindElementById("main-search").SendKeys("kofta");
            Driver.FindElementByClassName("menu__search_submit").Click();
            Driver.FindElementByXPath("//button[@class='close icon-close-white js-close']").Click();
            Driver.FindElementByClassName("item-image").Click(); //första koftan

            Driver.FindElementByXPath("//button[contains(@class,'picker-trigger js-picker-trigger small notify-if-back')]//span[contains(@class,'value')][contains(text(),'Välj storlek')]").Click();
            Driver.FindElementByXPath("//ul/li[2]/div/button/span").Click(); //XS 
                                                                             //Driver.FindElementByXPath("#main-content > div.product.parbase > div.layout.pdp-wrapper.product-detail.sticky-footer-wrapper.js-reviews > div.module.product-description.sticky-wrapper > div.sub-content.product-detail-info.inner.sticky-on-scroll.semi-sticky > div > div.product-item-buttons > div.product-button-wrapper > button").Click();
            /*  Actions action = new Actions(Driver);
              ChromeWebElement mobileElement = Driver.FindElementByCssSelector(".icon-shopping-bag-white");
              Action.moveToElement(mobileElement).build().perform();*/
            Driver.FindElementByCssSelector(".icon-shopping-bag-white").Click();
            Driver.Close();
            Driver.Quit();
            /*Actions action = new Actions(Driver);
            WebElement mobileElement = Driver.findElement(By.linkText("Mobile & Accessories"));
            action.moveToElement(mobileElement).build().perform();*/
        }
    }
}