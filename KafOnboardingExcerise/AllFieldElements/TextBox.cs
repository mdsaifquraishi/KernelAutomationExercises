using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafOnboardingExcerises.AllFieldElements
{
    public class TextBox : BaseElement
    {
        public string Text { get; set; }

        public TextBox(string locAsString, string name) : base(locAsString, name) { }

        public void EnterText(string text)
        {
            Text = text;
            Console.WriteLine($"Text entered into {Name}: {Text}");
        }

        public void ClearText()
        {
            Text = string.Empty;
            Console.WriteLine($"Text cleared from {Name}.");
        }
    }

}
