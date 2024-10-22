using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafOnboardingExcerises.PageObjects
{
    public class DefaultCalculatorScreen : BaseCalculatorScreen
    {
        private static readonly By PercentageButton = By.Name("%");
        public DefaultCalculatorScreen(IWebDriver driver) : base(driver)
        {
        }
        public void ClickPercentageButton()
        {
            Driver.FindElement(PercentageButton).Click();
        }

    }
}
