using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextHelper
{
    public class BaseParser
    {
        public string ToCarmel(string name)
        {
            if (string.IsNullOrEmpty(name)) return name;
            string result = "";
            char[] carateres = name.ToCharArray();
            for (int i = 0; i < carateres.Length; i++)
            {
                char s = carateres[i];
                if (i == 0 && s >= 97 && s <= 122)
                {
                    s = (char)(s - 32);
                }
                result = result + s;
            }
            return result;
        }

        public string ToName(string name)
        {
            if (string.IsNullOrEmpty(name)) return name;

            if (name.Contains("_"))
            {
                string p1 = name.Substring(0, name.IndexOf("_"));
                string p2 = name.Substring(name.IndexOf("_") + 1);

                return $"{ToCarmel(p1)}{ToCarmel(p2)}";
            }

            return ToCarmel(name);
        }


       
    }
}
