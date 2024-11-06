using System.Runtime.Serialization;
using System;
using System.ComponentModel;
using System.Reflection;

namespace iLoveIMG.Model.Enums
{
    public static class EnumExtension
    {
        public static string GetEnumMemberValue(this Enum enumValue)
        {
            var type = enumValue.GetType();
            var memberInfo = type.GetMember(enumValue.ToString());
            if (memberInfo.Length > 0)
            {
                var attrs = memberInfo[0].GetCustomAttributes(typeof(EnumMemberAttribute), false);
                if (attrs.Length > 0)
                {
                    return ((EnumMemberAttribute)attrs[0]).Value;
                }
            }
            return enumValue.ToString();
        }
    }
}
