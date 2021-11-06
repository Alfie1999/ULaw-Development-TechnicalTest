using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace ULaw.ApplicationProcessor
{
  internal static class ExtensionMethods
  {
    public static string ToDescription(this Enum en)
    {
      Type type = en.GetType();

      MemberInfo[] memInfo = type.GetMember(en.ToString());

      if (memInfo?.Any() ?? false)
      {
        object[] attrs = memInfo[0].GetCustomAttributes(
                                      typeof(DescriptionAttribute),
                                      false);

        if (attrs?.Any() ?? false)
        {
          return (attrs[0] as DescriptionAttribute).Description;
        }
      }
      return en.ToString();
    }
  }

}
