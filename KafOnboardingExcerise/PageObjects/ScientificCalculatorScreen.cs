using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafOnboardingExcerises.PageObjects
{
    public class ScientificCalculatorScreen : BaseCalculatorScreen

    {
        private static readonly By EulerNumberButton = By.Name("e");
        private static readonly By PiButton = By.Name("pi");
        private static readonly By AbsButton = By.Name("|x|");
        private static readonly By ExponentButton = By.Name("exp");
        private static readonly By ModuloButton = By.Name("mod");
        private static readonly By LogButton = By.Name("log");
        private static readonly By LnButton = By.Name("ln");
        private static readonly By FactorialButton = By.Name("fact");

        public ScientificCalculatorScreen(IWebDriver driver) : base(driver)
        {
        }

        public void ClickPiButton()
        {
            Driver.FindElement(PiButton).Click();
        }

    }
}
