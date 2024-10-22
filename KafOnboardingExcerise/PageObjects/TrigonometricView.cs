using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafOnboardingExcerises.PageObjects
{
    internal class TrigonometricView : BaseCalculatorScreen
    {
        private static readonly By TrigonometricViewPopup = By.Name("Trigonometry");
        private static readonly By SinButton = By.Name("sin");
        private static readonly By CosecButton = By.Name("csc");
        private static readonly By CosButton = By.Name("cos");
        private static readonly By SecButton = By.Name("sec");
        private static readonly By TanButton = By.Name("tan");
        private static readonly By CotButton = By.Name("cot");


        public TrigonometricView(IWebDriver driver) : base(driver)
        {
        }
        public void OpenTrigonometricView()
        {
            Driver.FindElement(TrigonometricViewPopup).Click();
        }
    }
}
