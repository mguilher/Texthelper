﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextHelper
{
    public class TableSqlParser
    {
        public string TableName { get; set; }
        public List<PropertyModel> Parser(List<string> lines)
        {
            var list = new List<PropertyModel>();

            foreach (string s in lines)
            {
                if (s.Trim().StartsWith("["))
                {
                    string[] tokens = s.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    if (tokens != null && tokens.Length == 3)
                    {
                        var p = new PropertyModel() { DataType = tokens[1].Replace("[", "").Replace("]", ""), Name = tokens[0].Trim().Replace("[", "").Replace("]", ""), Nullable = true };
                        list.Add(p);
                    }

                    if (tokens != null && tokens.Length >= 4)
                    {
                        var p = new PropertyModel() { DataType = tokens[1].Replace("[", "").Replace("]", ""), Name = tokens[0].Trim().Replace("[", "").Replace("]", ""), Nullable = false };
                        list.Add(p);
                    }
                }
                else if (s.Trim().StartsWith("CREATE TABLE"))
                {
                    TableName = s.Replace("CREATE TABLE", "").Replace("[", "").Replace("]", "").Replace("dbo.", "").Replace("(", "").Replace(")", "").Trim();
                }

            }
            return list;
        }


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

        public string ToClass(List<PropertyModel> list)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"public class {TableName}\r\n    {{");
            sb.AppendLine();

            foreach (PropertyModel property in list)
            {
                sb.AppendLine($"[JsonProperty(\"{property.Name}\")]");

                if (property.DataType.Contains("varchar"))
                {
                    sb.AppendLine($"public string{(property.Nullable ? "?" : "")} {ToName(property.Name)} {{ get; set; }}");
                }
                else if (property.DataType.Equals("Integer", StringComparison.InvariantCultureIgnoreCase) || property.DataType.Equals("Int", StringComparison.InvariantCultureIgnoreCase))
                {
                    sb.AppendLine($"public int{(property.Nullable ? "?" : "")} {ToName(property.Name)} {{ get; set; }}");
                }
                else if (property.DataType.Equals("Float", StringComparison.InvariantCultureIgnoreCase) || property.DataType.Equals("Numeric", StringComparison.InvariantCultureIgnoreCase))
                {
                    sb.AppendLine($"public double{(property.Nullable ? "?" : "")} {ToName(property.Name)} {{ get; set; }}");
                }
                else if (property.DataType.Equals("Boolean", StringComparison.InvariantCultureIgnoreCase) || property.DataType.Equals("bit", StringComparison.InvariantCultureIgnoreCase))
                {
                    sb.AppendLine($"public bool{(property.Nullable ? "?" : "")} {ToName(property.Name)} {{ get; set; }}");
                }
                else if (property.DataType.Equals("datetime", StringComparison.InvariantCultureIgnoreCase) || property.DataType.Equals("Date", StringComparison.InvariantCultureIgnoreCase) || property.DataType.Equals("datetimeoffset", StringComparison.InvariantCultureIgnoreCase))
                {
                    sb.AppendLine($"public DateTime{(property.Nullable ? "?" : "")} {ToName(property.Name)} {{ get; set; }}");
                }
                else
                {
                    sb.AppendLine($"public string{(property.Nullable ? "?" : "")} {ToName(property.Name)} {{ get; set; }}");
                }
                sb.AppendLine();
            }


            sb.AppendLine("}");
            return sb.ToString();
        }
    }
}
