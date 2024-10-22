using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafOnboardingExcerises.AllFieldElements
{
    public class UIElementFactory
    {
        public T CreateElement<T>(string locAsString, string name) where T : BaseElement
        {
            return (T)Activator.CreateInstance(typeof(T), new object[] { locAsString, name });
        }
    }

}
