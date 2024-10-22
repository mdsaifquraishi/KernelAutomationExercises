using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace KafOnboardingExcerises.TestData
{
    public class DataLoader
    {
        public TestDataObject LoadTestData(object className)
        {
            string name = className.GetType().Name;
            string filePath= "C:\\Users\\I7243\\source\\repos\\KafOnboardingExcerises\\TestData\\"+ $"{name} .json";

            string fileName = $"TestDataObject.json";
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"The file {filePath} could not be found.");
            }
            string jsonContent = File.ReadAllText(filePath);

            var testDataObject = JsonSerializer.Deserialize<TestDataObject>(jsonContent);
            return testDataObject;

        }
    }
}
