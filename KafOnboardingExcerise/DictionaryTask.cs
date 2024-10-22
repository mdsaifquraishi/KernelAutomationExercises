using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace KafOnboardingExcerises
{
    public  class DictionaryTask
    {
        public static Dictionary<string, object> GetLocatorsAsDictionary(object obj)

        {

            Type type = obj.GetType();
            FieldInfo[] fields = type.GetFields();
            Dictionary<string, object> dictionaryOfFields = new Dictionary<string, object>();


            PropertyInfo[] properties = type.GetProperties();

            foreach (var field in fields)
            {
                dictionaryOfFields.Add(field.Name, field.GetValue(obj));

            }
            return dictionaryOfFields;
        }
    }
}
