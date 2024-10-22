using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KafOnboardingExcerises.AllFieldElements
{
    public class BaseElement 
    {
        public string LocAsString {  get; set; }
        public string Name { get; set; }

        public BaseElement(string locAsString, string name)
        {
            LocAsString = locAsString;
            Name = name;
        }
        public virtual void Click()
        {
            Console.WriteLine($"{Name} clicked.");
        }

    }
}
