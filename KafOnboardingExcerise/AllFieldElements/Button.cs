using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafOnboardingExcerises.AllFieldElements
{
    public class Button : BaseElement
    {
        // Constructor with two string parameters
        public Button(string locAsString, string name) : base(locAsString, name)
        {
        }

       

        public void Click()
        {
            Console.WriteLine($"Button {Name} clicked.");
        }
    }

}
