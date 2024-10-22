using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafOnboardingExcerises.AllFieldElements
{
    public class Link : BaseElement
    {

        public Link(string locAsString, string name) : base(locAsString, name)
        {
        }

        public override void Click()
        {
            Console.WriteLine($"Navigating to URL: {Name}");
        }
    }

}
