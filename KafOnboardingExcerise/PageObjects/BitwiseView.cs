using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafOnboardingExcerises.PageObjects
{
    public class BitwiseView : BaseCalculatorScreen
    {
        private static readonly By BitwiseViewPopup = By.Name("Bitwise");
        private static readonly By BitwiseAndButton = By.Name("AND");
        private static readonly By BitwiseOrButton = By.Name("OR");
        private static readonly By BitwiseNotButton = By.Name("NOT");
        private static readonly By BitwiseNandButton = By.Name("NAND");
        private static readonly By BitwiseNorButton = By.Name("NOR");
        private static readonly By BitwiseXorButton = By.Name("XOR");



        public BitwiseView(IWebDriver driver) : base(driver)
        {
        }

        public void OpenBitWiseView()
        {
            Driver.FindElement(BitwiseAndButton).Click();
        }

    }
}
