using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextHelper
{
    public class BaseParser
    {
        public string ToPascal(string name)
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

                return $"{ToPascal(p1)}{ToPascal(p2)}";
            }

            return ToPascal(name);
        }


        public string ToCamel(string name)
        {
            if (string.IsNullOrEmpty(name)) return name;

            // Usar Regex para separar por espaços, sublinhados, hífens ou maiúsculas
            var words = System.Text.RegularExpressions.Regex.Split(name, @"[ _\-]|(?=[A-Z])")
                        .Where(word => !string.IsNullOrEmpty(word)) // Remove palavras em branco
                        .ToArray();

            // Converte a primeira palavra para minúscula e as demais para Pascal case
            for (int i = 0; i < words.Length; i++)
            {
                if (i == 0)
                {
                    // A primeira palavra fica em minúsculo
                    words[i] = words[i].ToLower();
                }
                else
                {
                    // As demais palavras começam com maiúscula
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
                }
            }

            // Junta as palavras em uma única string
            return string.Join("", words);
        }



        private readonly Dictionary<string, string> typeMap = new Dictionary<string, string>
            {
                { "int", "number" },
                { "long", "number" },
                { "float", "number" },
                { "double", "number" },
                { "decimal", "number" },
                { "string", "string" },
                { "bool", "boolean" },
                { "char", "string" },
                { "object", "any" },
                { "void", "void" },
                { "datetimeoffset", "Date" },
                { "datetimeoffset?", "Date" },
                { "int64", "number" },
                { "boolean", "boolean" },
            };

        public string MapCSharpTypeToTypeScript(string csharpType)
        {
            if (typeMap.TryGetValue(csharpType.ToLower(), out string typescriptType))
            {
                return typescriptType;
            }
            else
            {
                return "object";
            }
        }

        public string ToUnderline(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            var result = new StringBuilder();

            foreach (char c in input)
            {
                if (char.IsUpper(c))
                {
                    if (result.Length > 0)
                    {
                        result.Append('_');
                    }
                    result.Append(char.ToLower(c));
                }
                else
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
    }


}
