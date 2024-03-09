using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextHelper
{
    public class PropertyHelper
    {
        public List<PropertyModel> Parser(List<string> lines)
        {
            var list = new List<PropertyModel>();
            string textAttribute = "";
            foreach(string s in lines)
            {
                if (s.Trim().StartsWith("["))
                {
                    textAttribute = s;
                }
                else
                {
                    string[] tokens = s.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    if (tokens != null && tokens.Length == 3)
                    {
                        var p = new PropertyModel() { DataType = tokens[1], Name = tokens[2].Replace(";", "") };

                        if (!string.IsNullOrEmpty(textAttribute))
                        {
                            p.Description = GetDisplay(textAttribute);
                            textAttribute = "";
                        }

                        list.Add(p);
                    }

                    if (tokens != null && tokens.Length == 2)
                    {
                        var p = new PropertyModel() { DataType = tokens[0], Name = tokens[1].Replace(";", "") };
                        if (!string.IsNullOrEmpty(textAttribute))
                        {
                            p.Description = GetDisplay(textAttribute);
                            textAttribute = "";
                        }
                        list.Add(p);
                    }

                    if (tokens != null && tokens.Length >= 4)
                    {
                        string definition = string.Join(" ", tokens.Skip(3));
                        var p = new PropertyModel() { Access = tokens[0], DataType = tokens[1], Name = tokens[2], Definition = definition };
                        if (!string.IsNullOrEmpty(textAttribute))
                        {
                            p.Description = GetDisplay(textAttribute);
                            textAttribute = "";
                        }
                        list.Add(p);
                    }
                }
               
            }
            return list;
        }

        private string GetDisplay(string linha)
        {
            string result = "";
            if (linha.Trim().StartsWith("[Display(Name"))
            {
                result = linha.Substring(linha.IndexOf("\"")+1);
                result = result.Substring(0, result.IndexOf("\""));
            }
            return result;
        }


        public string ToInstace(List<PropertyModel> list,string variableName,string typeName)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"var {variableName}2=new {typeName}(){{");
            sb.AppendLine();
            foreach (PropertyModel property in list)
            {
                sb.Append("\t");
                sb.AppendLine($"{property.Name}={variableName}.{property.Name},");
            }

            sb.AppendLine("};");
            return sb.ToString();
        }

        public string ToAssignment(List<PropertyModel> list, string variableName)
        {
            var sb = new StringBuilder();
            foreach (PropertyModel property in list)
            {
                sb.AppendLine($"{property.Name}={variableName}.{property.Name};");
            }

            return sb.ToString();
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


        public string ToMapClass(List<PropertyModel> list, string className)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"public class {className}Configuration : : IEntityTypeConfiguration<{className}>\r\n    {{");
            sb.AppendLine($"public void Configure(EntityTypeBuilder<{className}> builder) {{ ");
            sb.AppendLine($" builder.ToTable(\"{className}\");");
            sb.AppendLine(" builder.HasKey(t => t.Id);");
            foreach (PropertyModel property in list)
            {

                if (property.DataType.Contains("varchar"))
                {
                    sb.AppendLine($"builder.Property(b => b.{ToName(property.Name)}){(!property.Nullable ? ".IsRequired()" : "")}; ");
                }
                else if (property.DataType.Equals("Integer", StringComparison.InvariantCultureIgnoreCase) || property.DataType.Equals("Int", StringComparison.InvariantCultureIgnoreCase))
                {
                    sb.AppendLine($"builder.Property(b => b.{ToName(property.Name)}){(!property.Nullable ? ".IsRequired()" : "")}; ");
                }
                else if (property.DataType.Equals("Float", StringComparison.InvariantCultureIgnoreCase) || property.DataType.Equals("Numeric", StringComparison.InvariantCultureIgnoreCase))
                {
                    sb.AppendLine($"builder.Property(b => b.{ToName(property.Name)}){(!property.Nullable ? ".IsRequired()" : "")}; ");
                }
                else if (property.DataType.Equals("Boolean", StringComparison.InvariantCultureIgnoreCase) || property.DataType.Equals("bit", StringComparison.InvariantCultureIgnoreCase))
                {
                    sb.AppendLine($"builder.Property(b => b.{ToName(property.Name)}){(!property.Nullable ? ".IsRequired()" : "")}; ");
                }
                else if (property.DataType.Equals("datetime", StringComparison.InvariantCultureIgnoreCase) || property.DataType.Equals("Date", StringComparison.InvariantCultureIgnoreCase) || property.DataType.Equals("datetimeoffset", StringComparison.InvariantCultureIgnoreCase))
                {
                    sb.AppendLine($"builder.Property(b => b.{ToName(property.Name)}){(!property.Nullable ? ".IsRequired()" : "")}; ");
                }
                else
                {
                    sb.AppendLine($"builder.Property(b => b.{ToName(property.Name)}){(!property.Nullable ? ".IsRequired()" : "")}; ");
                }
                sb.AppendLine();
            }

            sb.AppendLine("}");
            sb.AppendLine("}");
            return sb.ToString();
        }
    }
}
