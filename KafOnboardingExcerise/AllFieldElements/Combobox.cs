using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafOnboardingExcerises.AllFieldElements
{
    using System.Collections.Generic;

    public class Combobox : BaseElement
    {
        public List<string> Options { get; set; }
        public string SelectedOption { get; set; }

        public Combobox(string locAsString, string name) : base(locAsString, name)
        {
            Options = new List<string> { "USA", "INDIA", "CANADA", "UK" };
        }

        public void SelectOption(string option)
        {
            if (Options.Contains(option))
            {
                SelectedOption = option;
                Console.WriteLine($"Combobox {Name} selected option: {SelectedOption}");
            }
            else
            {
                Console.WriteLine($"Option {option} not found in {Name}.");
            }
        }
    }

}
