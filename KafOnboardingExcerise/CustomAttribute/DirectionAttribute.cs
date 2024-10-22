using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafOnboardingExcerises.CustomAttribute
{
    [AttributeUsage(AttributeTargets.Field)]
    public class DirectionAttribute :Attribute
    {
        public int Index {  get;  }
        public string Name { get; }

        public DirectionAttribute(int index, string name)
        {
            Index = index;
            Name = name;
        }
    }
}
