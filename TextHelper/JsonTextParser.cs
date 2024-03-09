using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TextHelper.Properties;

namespace TextHelper
{
    public class JsonTextParser
    {
        private string ParserJsonObject(JToken jtoken)
        {
            var sb = new StringBuilder();
            foreach (JToken item in jtoken.Children())
            {
                if (item.Type == JTokenType.Property)
                {
                    foreach (JToken jt1 in item.Values())
                    {
                        if (jt1.Type == JTokenType.String)
                        {
                            sb.Append(jt1.Value<string>());
                            sb.Append(";");
                        }
                        else if (jt1.Type == JTokenType.Integer)
                        {
                            sb.Append(jt1.Value<int>());
                            sb.Append(";");
                        }
                        else if (jt1.Type == JTokenType.Float)
                        {
                            sb.Append(jt1.Value<double>());
                            sb.Append(";");
                        }
                        else if (jt1.Type == JTokenType.Boolean)
                        {
                            sb.Append(jt1.Value<bool>());
                            sb.Append(";");
                        }
                        else if (jt1.Type == JTokenType.Date)
                        {
                            sb.Append(jt1.Value<DateTime>());
                            sb.Append(";");
                        }
                    }
                }
            }
            return sb.ToString();
        }

        private string ParserJsonArray(IEnumerable<JToken> tokens)
        {
            var sb = new StringBuilder();

            foreach (JToken item in tokens)
            {
                if (item.Type == JTokenType.Object)
                {
                    sb.AppendLine(ParserJsonObject(item));
                }
                else if (item.Type == JTokenType.Array)
                {
                    sb.AppendLine(ParserJsonArray(item.Values()));
                }
                else if (item.Type == JTokenType.Property)
                {
                    JProperty property = (JProperty)item;

                    if (property.Value.Type == JTokenType.String)
                    {
                        sb.Append(property.Value.Value<string>());
                        sb.Append(";");
                    }
                    else if (property.Value.Type == JTokenType.Integer)
                    {
                        sb.Append(property.Value.Value<int>());
                        sb.Append(";");
                    }
                    else if (property.Value.Type == JTokenType.Float)
                    {
                        sb.Append(property.Value.Value<double>());
                        sb.Append(";");
                    }
                    else if (property.Value.Type == JTokenType.Boolean)
                    {
                        sb.Append(property.Value.Value<bool>());
                        sb.Append(";");
                    }
                    else if (property.Value.Type == JTokenType.Date)
                    {
                        sb.Append(property.Value.Value<DateTime>());
                        sb.Append(";");
                    }
                    else if (property.Value.Type == JTokenType.Array)
                    {
                        sb.AppendLine(ParserJsonArray(property.Value.Values()));
                    }
                    else if (property.Value.Type == JTokenType.Object)
                    {
                        sb.AppendLine(ParserJsonObject(property.Value));
                    }
                    else
                    {
                        sb.Append(property.Value);
                        sb.Append(";");
                    }
                }
                else
                {
                    sb.AppendLine(item.Value<string>());
                }

            }

            return sb.ToString();
        }

        public string ParserJson(string data, string query)
        {
            var sb = new StringBuilder();


            if (string.IsNullOrEmpty(query) && data.StartsWith("{"))
            {
                MessageBox.Show(Resources.ParserJsonNoQuery, Resources.Alert);
                return string.Empty;
            }

            if (!string.IsNullOrEmpty(query))
            {
                if (data.StartsWith("{"))
                {
                    JObject jobj = JObject.Parse(data);
                    if (jobj != null)
                    {
                        var tokens = jobj.SelectTokens(query);
                        return ParserJsonArray(tokens);
                    }

                }
                else if (data.StartsWith("["))
                {
                    JArray jarray = JArray.Parse(data);
                    if (jarray != null)
                    {
                        var tokens = jarray.SelectTokens(query);
                        return ParserJsonArray(tokens);
                    }
                }
            }
            else
            {
                if (data.StartsWith("["))
                {
                    JArray jarray = JArray.Parse(data);
                    var tokens = jarray.Children();
                    return ParserJsonArray(tokens);
                }
                else
                {
                    MessageBox.Show(Resources.ParserJsonNoQuery, Resources.Alert);
                    return string.Empty;
                }
            }


            return sb.ToString();
        }
    }
}
