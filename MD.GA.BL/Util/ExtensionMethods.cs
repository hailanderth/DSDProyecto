using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.GA.BL.Util
{
    public static class ExtensionMethods
    {
        public static bool IsNullOrEmpty(this string value)
        {
            if (value == null)
                return true;
            if (value.ToUpper().Trim().Equals(String.Empty))
                return true;
            return false;
        }
        public static bool HasDefaultValue(this int value)
        {
            if (value == default(int))
                return true;
            return false;
        }
    }
}
