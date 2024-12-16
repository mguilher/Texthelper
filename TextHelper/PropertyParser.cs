using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextHelper
{
    public class PropertyParser : BaseParser
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

                        if (p.DataType.EndsWith("?"))
                        {
                            p.DataType=p.DataType.Replace("?","");
                            p.Nullable = true;
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

                        if (p.DataType.EndsWith("?"))
                        {
                            p.DataType = p.DataType.Replace("?", "");
                            p.Nullable = true;
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

                        if (p.DataType.EndsWith("?"))
                        {
                            p.DataType = p.DataType.Replace("?", "");
                            p.Nullable = true;
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

        public string ToAttribution(List<PropertyModel> list, string end)
        {
            var sb = new StringBuilder();
            foreach (PropertyModel property in list)
            {
                sb.AppendLine($"{property.Name}={ToCamel(property.Name)}{end}");
            }

            return sb.ToString();
        }

        public string ToParameters(List<PropertyModel> list)
        {
            var sb = new StringBuilder();
            foreach (PropertyModel property in list)
            {
                sb.Append($"{property.DataType} {ToCamel(property.Name)},");
            }

            return sb.ToString();
        }

        public string ToState(List<PropertyModel> list)
        {
            var sb = new StringBuilder();
            foreach (PropertyModel property in list)
            {
                sb.AppendLine($"public {property.DataType} {property.Name} => _state.{property.Name};");
            }

            return sb.ToString();
        }

        public string ToTypescript(List<PropertyModel> list)
        {
            var sb = new StringBuilder();
            foreach (PropertyModel property in list)
            {
                sb.AppendLine($"{ToCamel(property.Name)}{(property.Nullable?"?":"")}: {MapCSharpTypeToTypeScript(property.DataType)};");
            }

            return sb.ToString();
        }

        public string ToMapClass(List<PropertyModel> list, string className)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"public class {className}Configuration : IEntityTypeConfiguration<{className}>\r\n    {{");
            sb.AppendLine($"public void Configure(EntityTypeBuilder<{className}> builder) {{ ");
            sb.AppendLine($" builder.ToTable(\"{className}\");");
            sb.AppendLine(" builder.HasKey(t => t.Id);");
            foreach (PropertyModel property in list)
            {

                if (property.DataType.Contains("varchar"))
                {
                    sb.AppendLine($"builder.Property(b => b.{ToName(property.Name)}).HasColumnName(\" {ToName(property.Name)} \"){(!property.Nullable ? ".IsRequired()" : "")}; ");
                }
                else if (property.DataType.Equals("Integer", StringComparison.InvariantCultureIgnoreCase) || property.DataType.Equals("Int", StringComparison.InvariantCultureIgnoreCase))
                {
                    sb.AppendLine($"builder.Property(b => b.{ToName(property.Name)}).HasColumnName(\"  {ToName(property.Name)}  \"){(!property.Nullable ? ".IsRequired()" : "")}; ");
                }
                else if (property.DataType.Equals("Float", StringComparison.InvariantCultureIgnoreCase) || property.DataType.Equals("Numeric", StringComparison.InvariantCultureIgnoreCase))
                {
                    sb.AppendLine($"builder.Property(b => b.{ToName(property.Name)}).HasColumnName(\" {ToName(property.Name)} \"){(!property.Nullable ? ".IsRequired()" : "")}; ");
                }
                else if (property.DataType.Equals("Boolean", StringComparison.InvariantCultureIgnoreCase) || property.DataType.Equals("bit", StringComparison.InvariantCultureIgnoreCase))
                {
                    sb.AppendLine($"builder.Property(b => b.{ToName(property.Name)}).HasColumnName(\"{ToName(property.Name)}\"){(!property.Nullable ? ".IsRequired()" : "")}; ");
                }
                else if (property.DataType.Equals("datetime", StringComparison.InvariantCultureIgnoreCase) || property.DataType.Equals("Date", StringComparison.InvariantCultureIgnoreCase) || property.DataType.Equals("datetimeoffset", StringComparison.InvariantCultureIgnoreCase))
                {
                    sb.AppendLine($"builder.Property(b => b.{ToName(property.Name)}).HasColumnName(\"{ToName(property.Name)}\"){(!property.Nullable ? ".IsRequired()" : "")}; ");
                }
                else
                {
                    sb.AppendLine($"builder.Property(b => b.{ToName(property.Name)}).HasColumnName(\" {ToName(property.Name)} \"){(!property.Nullable ? ".IsRequired()" : "")}; ");
                }
                sb.AppendLine();
            }

            sb.AppendLine("}");
            sb.AppendLine("}");
            return sb.ToString();
        }

        public string JsonToClass(string json)
        {
            JObject jobj = JObject.Parse(json);

            var properties = jobj.Properties();
            var sb = new StringBuilder();

            sb.AppendLine($"public class RootProxy\r\n    {{");
            sb.AppendLine();

            foreach (JProperty property in properties)
            {
                sb.AppendLine($"[JsonProperty(\"{property.Name}\")]");

                if (property.Value.Type == JTokenType.String)
                {
                    sb.AppendLine($"public string {ToName(property.Name)} {{ get; set; }}");
                }
                else if (property.Value.Type == JTokenType.Integer)
                {
                    sb.AppendLine($"public int {ToName(property.Name)} {{ get; set; }}");
                }
                else if (property.Value.Type == JTokenType.Float)
                {
                    sb.AppendLine($"public double {ToName(property.Name)} {{ get; set; }}");
                }
                else if (property.Value.Type == JTokenType.Boolean)
                {
                    sb.AppendLine($"public bool {ToName(property.Name)} {{ get; set; }}");
                }
                else if (property.Value.Type == JTokenType.Date)
                {
                    sb.AppendLine($"public DateTime {ToName(property.Name)} {{ get; set; }}");
                }
                else if (property.Value.Type == JTokenType.Array)
                {
                    sb.AppendLine($"public List<string> {ToName(property.Name)} {{ get; set; }}");
                }
                else if (property.Value.Type == JTokenType.Object)
                {
                    sb.AppendLine($"public object {ToName(property.Name)} {{ get; set; }}");
                }
                else
                {
                    sb.AppendLine($"public string {ToName(property.Name)} {{ get; set; }}");
                }
                sb.AppendLine();
            }


            sb.AppendLine("}");

            return sb.ToString();
        }
    }
}
