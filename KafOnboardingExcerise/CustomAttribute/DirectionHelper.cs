using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace KafOnboardingExcerises.CustomAttribute
{
    public static class DirectionHelper
    {
    public static DirectionAttribute GetDirectionAttribute(Direction direction)
        {
            Type type = direction.GetType();
            var memberInfo  = type.GetMember(direction.ToString());
            return memberInfo[0].GetCustomAttribute<DirectionAttribute>();

        }
    }
}
