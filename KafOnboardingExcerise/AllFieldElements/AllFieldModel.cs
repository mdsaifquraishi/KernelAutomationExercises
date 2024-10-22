using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafOnboardingExcerises.AllFieldElements
{
    public class AllFieldModel
    {
        public Button SubmitButton { get; set; }
        public Checkbox TermsCheckbox { get; set; }
        public TextBox NameTextBox { get; set; }
        public Label GreetingLabel { get; set; }
        public Combobox CountryCombobox { get; set; }
        public Image ProfileImage { get; set; }
        public Link HomePageLink { get; set; }

        public AllFieldModel()
        {
            // Initialize elements with sample data
            SubmitButton = new Button("btn1", "Submit");
            TermsCheckbox = new Checkbox("chk1", "Terms and Conditions");
            NameTextBox = new TextBox("txt1", "Name");
            GreetingLabel = new Label("lbl1", "Greeting");
            CountryCombobox = new Combobox("cmb1", "Country");
            ProfileImage = new Image("img1", "Profile Picture");
            HomePageLink = new Link("lnk1", "Home Page");
        }

        // Method to simulate interaction with the page
        public void SimulateInteractions()
        {
            SubmitButton.Click();
            TermsCheckbox.Click();
            NameTextBox.EnterText("John Doe");
            GreetingLabel.UpdateText("Welcome, John Doe!");
            CountryCombobox.SelectOption("Canada");
            ProfileImage.ClickImage();
            HomePageLink.Click();
        }
    }

}
