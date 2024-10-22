using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafOnboardingExcerises.PageObjects
{
    public class BaseCalculatorScreen
    {
        protected IWebDriver Driver;
        // Locators for common elements
        public static  By NumberButton(string number) => By.Name($"{number}");
        public static readonly By AddButton = By.Name("+");
        public static readonly By SubtractButton = By.Name("-");
        public static readonly By MultiplyButton = By.Name("*");
        public static readonly By DivisionButton = By.Name("/");
        public static readonly By ReciprocalButton = By.Name("1/x");
        public static readonly By SquareButton = By.Name("x^2");
        public static readonly By SquareRootButton = By.Name("2rootx");
        public static readonly By DecialButton = By.Name(".");
        public static readonly By EqualsButton = By.Name("=");
        public static readonly By ResultButton = By.Id("result");
        public static readonly By ClearButton = By.Id("clear");
        public static readonly By SBackSpaceButton = By.Id("backSpace");


        public BaseCalculatorScreen(IWebDriver driver)
        {
            Driver = driver;
        }
        public void EnterNumber(string number)
        {
            Driver.FindElement(NumberButton(number)).Click();
        }
        public void ClickAdd()
        {
            Driver.FindElement(AddButton).Click();
        }

        public void ClickClear()
        {
            Driver.FindElement(ClearButton).Click();
        }

        public void Clickresult()
        {
            Driver.FindElement(ResultButton).Click();
        }
        public void ClickNumber(int num)
        {
            Driver.FindElement(NumberButton(num.ToString())).Click();
        }

    }
}
