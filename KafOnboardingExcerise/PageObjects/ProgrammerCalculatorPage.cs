using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafOnboardingExcerises.PageObjects
{
    public class ProgrammerCalculatorPage : BaseCalculatorScreen
    {
        private static readonly By RightShiftButton = By.Name(">>");
        private static readonly By LeftShiftButton = By.Name("<<");
        private static readonly By ModuloButton = By.Name("%");
        private static readonly By HexNumberButton = By.Name("HEX");
        private static readonly By DecimalNumberButton = By.Name("Dec");
        private static readonly By OctalNumberButton = By.Name("OCT");
        private static readonly By BinaryNumberButton = By.Name("BIN");
        private static readonly By HexNumberAButton = By.Name("A");
        private static readonly By HexNumberBButton = By.Name("B");
        private static readonly By HexNumberCButton = By.Name("C");
        private static readonly By HexNumberDButton = By.Name("D");
        private static readonly By HexNumberEButton = By.Name("E");
        private static readonly By HexNumberFButton = By.Name("F");

        public ProgrammerCalculatorPage(IWebDriver driver) : base(driver)
        {
        }

        public void ClickRightShiftButton()
        {
            Driver.FindElement(RightShiftButton).Click();
        }

    }
}
