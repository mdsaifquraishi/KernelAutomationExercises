using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafOnboardingExcerises.AllFieldElements
{
    public class Label : BaseElement
    {
        public string Text { get; set; }

        public Label(string locAsString, string name) : base(locAsString, name)
        {
        }

        public void UpdateText(string text)
        {
            Text = text;
            Console.WriteLine($"Label {Name} text updated: {Text}");
        }
    }

}
