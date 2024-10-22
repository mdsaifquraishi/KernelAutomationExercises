// See https://aka.ms/new-console-template for more information
using KafOnboardingExcerises;
using KafOnboardingExcerises.AllFieldElements;
using KafOnboardingExcerises.CustomAttribute;
using KafOnboardingExcerises.CustomExceptionHandling;
using KafOnboardingExcerises.PageObjects;
using KafOnboardingExcerises.TestData;
using OpenQA.Selenium.Chrome;
using System.Reflection;
//var driver = new ChromeDriver();
//var obj = new BaseCalculatorScreen(driver);
//var result= DictionaryTask.GetLocatorsAsDictionary(obj);
//var listResult = new List<object>(result.Values);
Console.WriteLine("Hello, World!");
//Exception handling
try
{
    PlayerData playerData = new PlayerData { PlayerId="abcdef", PlayerName = "Saif",GameAccountId = null };
    ValidatePlayer(playerData);
}
catch(InvalidPlayerDataException ex)
{
    Console.WriteLine("Exception is caught Successfully");
    Console.WriteLine($"Error: {ex.Message}");
}
 static void ValidatePlayer(PlayerData player)
{
    if (player.GameAccountId==(null)){
        throw new InvalidPlayerDataException("Game Account id can not be null", player);
    }
}

//Load data from Json
var dataLoader = new DataLoader();
var testDataObject = dataLoader.LoadTestData(new TestDataObject());
Console.WriteLine(testDataObject.Name);

//All Field Elements example
AllFieldModel allFieldModel = new AllFieldModel();
allFieldModel.SimulateInteractions();

//Factory pattern to create instance of fields throgh generics

var factory = new UIElementFactory();

//Button
var button = factory.CreateElement<Button>("btn1", "SubmitButton");
button.Click();

//Checkbox
var checkbox = factory.CreateElement<Checkbox>("chk1", "TermsCheckbox");
checkbox.Toggle();

//TextBox
var textBox = factory.CreateElement<TextBox>("txt1", "NameTextBox");
textBox.EnterText("John Doe");

//Image
var image = factory.CreateElement<Image>("img1", "Logo Image");
image.ClickImage();

//Utils without constructor just made it static
var randomNumber = UtilsTask.GenerateRandomNumber(10, 100);
UtilsTask.LogMessage($"Random number generated through Util class is : {randomNumber}");

//Extension method for string to calculate the number of new line in input string
var input = @"kbd
svasj
kchsbc";
var count = input.CountNumberOfLinesInString();
Console.WriteLine($"Number of new lines in input  string is: {count}");

//wait Implemntation
try
{
    UtilsTask.Wait(() =>
    {
        int num = UtilsTask.GenerateRandomNumber(1, 6);
        return num % 5 == 0;
    }, TimeSpan.FromSeconds(5));
}
catch (TimeoutException ex)
{
    Console.WriteLine($"Exception is caught with message: {ex.Message}");
}

//Custom Attribute
foreach(Direction direction in Enum.GetValues(typeof(Direction)))
{
    DirectionAttribute directionAttribute = DirectionHelper.GetDirectionAttribute(direction);
    Console.WriteLine($"{direction} has direction id {directionAttribute.Index} and direction name as {directionAttribute.Name}");

}
