using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafOnboardingExcerises.AllFieldElements
{
    public class Checkbox : BaseElement
    {
        public bool IsChecked { get; private set; }

        public Checkbox(string locAsString, string name) : base(locAsString, name) { }

        public void Toggle()
        {
            IsChecked = !IsChecked;
            Console.WriteLine($"Checkbox {Name} is now {(IsChecked ? "checked" : "unchecked")}.");
        }

        public override void Click()
        {
            Toggle();
        }
    }

}
