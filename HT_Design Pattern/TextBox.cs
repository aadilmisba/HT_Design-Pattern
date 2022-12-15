using HT_Design_Pattern.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT_Design_Pattern
{
    public class TextBox:BasePage
    {
        private IWebElement element;
        private WebDriver driver;

        public TextBox(IWebElement el):base("")
        {
            element = el;
            //this.driver = driver;
        }

        public void Click()
        {
            element.Click();
        }

        public string GetText()
        {
            return element.Text;
        }
        public void SendKeys(string text) 
        { 
            this.element.SendKeys(text);
        }
    }
}
