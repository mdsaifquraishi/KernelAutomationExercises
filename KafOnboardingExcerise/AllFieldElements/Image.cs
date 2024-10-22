using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafOnboardingExcerises.AllFieldElements
{
    public class Image : BaseElement
    {

        public Image(string locAsString, string name) : base(locAsString, name)
        {
        }

        public void ClickImage()
        {
            Console.WriteLine($"Clicking image {Name}");
        }
    }

}
