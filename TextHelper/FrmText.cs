﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using TextHelper.Properties;

namespace TextHelper
{
    public partial class FrmText : Form
    {

        private List<string> _tokens;
        public FrmText()
        {
            InitializeComponent();
            _tokens = new List<string>();
        }

        public List<string> GetList()
        {
            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                MessageBox.Show(Resources.NoInputValue, Resources.Alert);
                return null;
            }

            if (string.IsNullOrWhiteSpace(txtSeparator.Text))
            {
                MessageBox.Show(Resources.NoSeparatorValue, Resources.Alert);
                return null;
            }
            string separator = (txtSeparator.Text == "\\n" ? Environment.NewLine : txtSeparator.Text);
            return txtInput.Text.Split(separator.ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        public List<string> GetListOutput()
        {
            if (string.IsNullOrWhiteSpace(txtOutput.Text))
            {
                MessageBox.Show(Resources.NoOutputValue, Resources.Alert);
                return null;
            }

            if (string.IsNullOrWhiteSpace(txtSeparator.Text))
            {
                MessageBox.Show(Resources.NoSeparatorValue, Resources.Alert);
                return null;
            }
            string separator = (txtSeparator.Text == "\\n" ? Environment.NewLine : txtSeparator.Text);
            return txtOutput.Text.Split(separator.ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        public string ReplaceList(List<string> list)
        {
            if (list == null || list.Count == 0)
            {
                MessageBox.Show(Resources.NoInputValue, Resources.Alert);
                return null;
            }

            if (string.IsNullOrWhiteSpace(txtTemplate.Text))
            {
                MessageBox.Show(Resources.NoTemplateData, Resources.Alert);
                return null;
            }

            if (_tokens.Count == 0)
            {
                MessageBox.Show(Resources.NoReplaceToken, Resources.Alert);
                return null;
            }

            string template = txtTemplate.Text;
            string toke = _tokens[0];
            var sb = new StringBuilder();
            foreach (string s in list)
            {
                sb.AppendLine(template.Replace(toke, s));
            }

            return sb.ToString();
        }

        public List<List<string>> GetMultList()
        {
            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                MessageBox.Show(Resources.NoInputValue, Resources.Alert);
                return null;
            }

            if (string.IsNullOrWhiteSpace(txtSeparator.Text))
            {
                MessageBox.Show(Resources.NoSeparatorValue, Resources.Alert);
                return null;
            }

            if (string.IsNullOrWhiteSpace(txtInnerSeparator.Text))
            {
                MessageBox.Show(Resources.NoSeparatorValue, Resources.Alert);
                return null;
            }

            string separator = (txtSeparator.Text == "\\n" ? Environment.NewLine : txtSeparator.Text);
            string innerSeparator = (txtInnerSeparator.Text == "\\n" ? Environment.NewLine : txtInnerSeparator.Text);
            var list = new List<List<string>>();

            foreach (string s in txtInput.Text.Split(separator.ToCharArray(), StringSplitOptions.RemoveEmptyEntries))
            {
                list.Add(s.Split(innerSeparator.ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList());
            }

            return list;
        }

        public string SplitReplaceList(List<List<string>> list)
        {
            if (list == null || list.Count == 0)
            {
                MessageBox.Show(Resources.NoInputValue, Resources.Alert);
                return null;
            }

            if (string.IsNullOrWhiteSpace(txtTemplate.Text))
            {
                MessageBox.Show(Resources.NoTemplateData, Resources.Alert);
                return null;
            }

            if (_tokens.Count == 0)
            {
                MessageBox.Show(Resources.NoReplaceToken, Resources.Alert);
                return null;
            }

            if (list[0].Count != _tokens.Count)
            {
                MessageBox.Show(Resources.NumberDifferentReplaceToken, Resources.Alert);
                return null;
            }


            string template = txtTemplate.Text;

            var sb = new StringBuilder();
            foreach (List<string> l in list)
            {
                int i = 0;
                string temp = template;
                foreach (string s in l)
                {
                    if (_tokens.Count > i)
                    {
                        temp = temp.Replace(_tokens[i], s);
                    }
                    i++;
                }
                sb.AppendLine(temp);
            }

            return sb.ToString();
        }

        public string ConcatenateList(List<string> list)
        {
            if (list == null || list.Count == 0)
            {
                MessageBox.Show(Resources.NoInputValue, Resources.Alert);
                return null;
            }

            if (string.IsNullOrWhiteSpace(txtStart.Text))
            {
                MessageBox.Show(Resources.NoStartValue, Resources.Alert);
                return null;
            }

            if (string.IsNullOrWhiteSpace(txtEnd.Text))
            {
                MessageBox.Show(Resources.NoEndValue, Resources.Alert);
                return null;
            }
            string start = txtStart.Text;
            string end = txtEnd.Text;
            var sb = new StringBuilder();
            foreach (string s in list)
            {
                sb.AppendLine(string.Format("{0}{1}{2}", start, s, end));
            }

            return sb.ToString();
        }

        public string ConcatenateReplaceList(List<string> list)
        {
            if (list == null || list.Count == 0)
            {
                MessageBox.Show(Resources.NoInputValue, Resources.Alert);
                return null;
            }

            if (string.IsNullOrWhiteSpace(txtStart.Text))
            {
                MessageBox.Show(Resources.NoStartValue, Resources.Alert);
                return null;
            }

            if (string.IsNullOrWhiteSpace(txtEnd.Text))
            {
                MessageBox.Show(Resources.NoEndValue, Resources.Alert);
                return null;
            }
            if (string.IsNullOrWhiteSpace(txtTemplate.Text))
            {
                MessageBox.Show(Resources.NoTemplateData, Resources.Alert);
                return null;
            }

            if (string.IsNullOrWhiteSpace(txtReplaceToken.Text) && _tokens.Count == 0)
            {
                MessageBox.Show(Resources.NoReplaceToken, Resources.Alert);
                return null;
            }
            string template = txtTemplate.Text;
            string toke = txtReplaceToken.Text;

            if (string.IsNullOrWhiteSpace(toke) && _tokens.Count > 0)
            {
                toke = _tokens[0];
            }
            string start = txtStart.Text;
            string end = txtEnd.Text;
            var sb = new StringBuilder();
            foreach (string s in list)
            {
                sb.AppendLine(string.Format("{0}{1}{2}", start, template.Replace(toke, s), end));
            }

            return sb.ToString();
        }

        public string SortList(List<string> list, bool isAz)
        {
            if (list == null || list.Count == 0)
            {
                MessageBox.Show(Resources.NoInputValue, Resources.Alert);
                return null;
            }

            var sb = new StringBuilder();
            list.Sort();

            if (!isAz)
            {
                list.Reverse();
            }

            foreach (string s in list)
            {
                sb.AppendLine(s);
            }

            return sb.ToString();
        }



        private void BtnReplaceListClick(object sender, EventArgs e)
        {
            var list = GetList();
            if (list != null)
            {
                string result = ReplaceList(list);
                txtOutput.Text = result;
            }
        }

        private void BtnConcatenateListClick(object sender, EventArgs e)
        {
            try
            {
                var list = GetList();
                if (list != null)
                {
                    string result = ConcatenateList(list);
                    txtOutput.Text = result;
                }
            }
            catch (Exception ex)
            {
                txtOutput.Text = ex.ToString();
            }
        }

        private void BtnConcatenateReplaceListClick(object sender, EventArgs e)
        {
            try
            {
                var list = GetList();
                if (list != null)
                {
                    string result = ConcatenateReplaceList(list);
                    txtOutput.Text = result;
                }
            }
            catch (Exception ex)
            {
                txtOutput.Text = ex.ToString();
            }
        }

        private void BtnSortByAzClick(object sender, EventArgs e)
        {
            try
            {
                var list = GetListOutput();
                if (list != null)
                {
                    string result = SortList(list, true);
                    txtOutput.Text = result;
                }
            }
            catch (Exception ex)
            {
                txtOutput.Text = ex.ToString();
            }
        }

        private void BtnSortByZaClick(object sender, EventArgs e)
        {
            try
            {
                var list = GetListOutput();
                if (list != null)
                {
                    string result = SortList(list, false);
                    txtOutput.Text = result;
                }
            }
            catch (Exception ex)
            {
                txtOutput.Text = ex.ToString();
            }
        }

        private void BtnSetOutToIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtOutput.Text))
                {
                    MessageBox.Show(Resources.NoOutputValue, Resources.Alert);
                }
                else
                {
                    txtInput.Text = txtOutput.Text;
                }
            }
            catch (Exception ex)
            {
                txtOutput.Text = ex.ToString();
            }
        }

        private void BtnSetOutToClipboard_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtOutput.Text))
                {
                    MessageBox.Show(Resources.NoOutputValue, Resources.Alert);
                }
                else
                {
                    Clipboard.SetText(txtOutput.Text, TextDataFormat.Text);
                }
            }
            catch (Exception ex)
            {
                txtOutput.Text = ex.ToString();
            }
        }

        private void BtnSplitReplaceList_Click(object sender, EventArgs e)
        {
            try
            {
                var list = GetMultList();
                if (list != null)
                {
                    string result = SplitReplaceList(list);
                    txtOutput.Text = result;
                }
            }
            catch (Exception ex)
            {
                txtOutput.Text = ex.ToString();
            }
        }

        private void BtnPropertiesToInstace_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtVariableName.Text))
            {
                MessageBox.Show(Resources.NoVariableNameData, Resources.Alert);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTypeName.Text))
            {
                MessageBox.Show(Resources.NoTypeNameData, Resources.Alert);
                return;
            }

            try
            {
                List<string> list = GetList();
                var helper = new PropertyHelper();
                if (list != null)
                {
                    string result = helper.ToInstace(helper.Parser(list), txtVariableName.Text, txtTypeName.Text);
                    txtOutput.Text = result;
                }
            }
            catch (Exception ex)
            {
                txtOutput.Text = ex.ToString();
            }
        }

        private void btnPropertiesToAssignment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtVariableName.Text))
            {
                MessageBox.Show(Resources.NoVariableNameData, Resources.Alert);
                return;
            }

            try
            {
                List<string> list = GetList();
                var helper = new PropertyHelper();
                if (list != null)
                {
                    string result = helper.ToAssignment(helper.Parser(list), txtVariableName.Text);
                    txtOutput.Text = result;
                }
            }
            catch (Exception ex)
            {
                txtOutput.Text = ex.ToString();
            }
        }

        private void btnAddToken_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtReplaceToken.Text))
            {
                MessageBox.Show(Resources.NoReplaceToken, Resources.Alert);
                return;
            }

            try
            {
                if (_tokens.Count > 0)
                {
                    var item = _tokens.FirstOrDefault(a => a.Equals(txtReplaceToken.Text));
                    if (string.IsNullOrWhiteSpace(item))
                    {
                        _tokens.Add(txtReplaceToken.Text);
                        txtReplaceToken.Clear();
                    }
                    else
                    {
                        MessageBox.Show(Resources.ReplaceTokenAlready, Resources.Alert);
                    }

                }
                else
                {
                    _tokens.Add(txtReplaceToken.Text);
                    txtReplaceToken.Clear();
                }

                lbTokens.Items.Clear();
                lbTokens.Items.AddRange(_tokens.ToArray());
            }
            catch (Exception ex)
            {
                txtOutput.Text = ex.ToString();
            }
        }

        private void btnSortInputByAz_Click(object sender, EventArgs e)
        {
            try
            {
                var list = GetList();
                if (list != null)
                {
                    string result = SortList(list, false);
                    txtInput.Text = result;
                }
            }
            catch (Exception ex)
            {
                txtOutput.Text = ex.ToString();
            }
        }

        private void btnSortInputByZa_Click(object sender, EventArgs e)
        {
            try
            {
                var list = GetList();
                if (list != null)
                {
                    string result = SortList(list, true);
                    txtInput.Text = result;
                }
            }
            catch (Exception ex)
            {
                txtOutput.Text = ex.ToString();
            }
        }

        private void btnReplicate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQuantityReplicate.Text))
            {
                MessageBox.Show(Resources.NoQuantityToReplicate, Resources.Alert);
                return;
            }


            if (!int.TryParse(txtQuantityReplicate.Text, out int quantity))
            {
                MessageBox.Show(Resources.QuantityToReplicateInt, Resources.Alert);
                return;
            }

            try
            {
                var sb = new StringBuilder();
                char character = 'A';
                for (int i = 0; i < quantity; i++)
                {
                    sb.AppendLine(txtInput.Text.Replace("[N]", i.ToString()).Replace("[C]", (character++).ToString()));
                }
                txtOutput.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                txtOutput.Text = ex.ToString();
            }
        }

        private void btnDeleteToken_Click(object sender, EventArgs e)
        {
            if (_tokens.Count == 0)
            {
                MessageBox.Show(Resources.NoReplaceToken, Resources.Alert);
                return;
            }

            if (lbTokens.SelectedItems.Count == 0)
            {
                MessageBox.Show(Resources.NoReplaceToken, Resources.Alert);
                return;
            }

            try
            {
                foreach (ListViewItem item in lbTokens.SelectedItems)
                {
                    _tokens.Remove(item.Text);
                }

                lbTokens.Items.Clear();
                lbTokens.Items.AddRange(_tokens.ToArray());
            }
            catch (Exception ex)
            {
                txtOutput.Text = ex.ToString();
            }
        }

        private void btnClearTokens_Click(object sender, EventArgs e)
        {
            lbTokens.Items.Clear();
            _tokens.Clear();
        }

        private void btnLoadTokens_Click(object sender, EventArgs e)
        {
            string innerSeparator = txtInnerSeparator.Text;
            if (string.IsNullOrWhiteSpace(innerSeparator))
            {
                MessageBox.Show(Resources.NoSeparatorValue, Resources.Alert);
                return;
            }
            var frm = new FrmLoadTokenDialog(innerSeparator);
            var result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                var tokens = frm.Result;
                _tokens = tokens.Split(innerSeparator.ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
                lbTokens.Items.Clear();
                lbTokens.Items.AddRange(_tokens.ToArray());
            }

        }

        private void btnLoadCsv_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPathCsv.Text))
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "txt files (*.txt)|*.txt|CSV files (*.csv)|*.csv";
                dlg.FilterIndex = 2;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtPathCsv.Text = dlg.FileName;
                }
            }

            if (!string.IsNullOrEmpty(txtPathCsv.Text))
            {
                txtInput.Text = File.ReadAllText(txtPathCsv.Text);
            }
        }

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
        private string ParserJson(string data, string query)
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
                    if (!string.IsNullOrEmpty(query))
                    {
                        var tokens = jobj.SelectTokens(query);
                        return ParserJsonArray(tokens);
                    }

                }
                else if (data.StartsWith("["))
                {
                    JArray jarray = JArray.Parse(data);
                    if (!string.IsNullOrEmpty(query))
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

        private void btnLoadListJson_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPathJson.Text))
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "txt files (*.txt)|*.txt|Json files (*.json)|*.json";
                dlg.FilterIndex = 2;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtPathJson.Text = dlg.FileName;
                }
            }

            if (!string.IsNullOrEmpty(txtPathJson.Text))
            {
                string data = File.ReadAllText(txtPathJson.Text);
                string query = txtJsonSelect.Text;
                txtInput.Text = ParserJson(data, query);
            }
        }

        private void btnLoadListXml_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPathXml.Text))
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "txt files (*.txt)|*.txt|Json files (*.xml)|*.xml";
                dlg.FilterIndex = 2;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtPathXml.Text = dlg.FileName;
                }
            }

            if (!string.IsNullOrEmpty(txtPathXml.Text))
            {
                string data = File.ReadAllText(txtPathXml.Text);
                string query = txtXmlSelect.Text;
                txtInput.Text = ParserXml(data, query);
            }
        }

        private string ParserXml(string data, string query)
        {
            throw new NotImplementedException();
        }

        private void btnParserJson_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                MessageBox.Show(Resources.NoInputValue, Resources.Alert);
                return;
            }

            string query = txtJsonSelect.Text;

            txtOutput.Text = ParserJson(txtInput.Text, query);
        }

        private void llInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(((LinkLabel)sender).Text);
        }

        private void btnCheckSqlInsert_Click(object sender, EventArgs e)
        {
            string txt = txtInput.Text;

            if (!string.IsNullOrEmpty(txt))
            {
                int inedexFieldsStart = txt.IndexOf("(") + 1;
                int inedexFieldsEnd = txt.IndexOf(")");
                string fields = txt.Substring(inedexFieldsStart, inedexFieldsEnd - inedexFieldsStart);
                txt = txt.Substring(inedexFieldsEnd + 1);
                int inedexValuesStart = txt.IndexOf("(") + 1;
                int inedexValuesEnd = txt.IndexOf(")");
                string values = txt.Substring(inedexValuesStart, inedexValuesEnd - inedexValuesStart);

                var fieldsList = fields.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                var valuesList = values.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                var sb = new StringBuilder();
                for (int i = 0; i < fieldsList.Length; i++)
                {
                    sb.AppendLine($"{fieldsList[i]}={valuesList[i]}");
                }

                txtOutput.Text = sb.ToString();
            }

        }

        private void btnPropertiesToList_Click(object sender, EventArgs e)
        {

            try
            {
                List<string> list = GetList();
                var helper = new PropertyHelper();
                if (list != null)
                {
                    var properties = helper.Parser(list);

                    var sb = new StringBuilder();
                    foreach (PropertyModel property in properties)
                    {
                        sb.AppendLine(property.Name);
                    }

                    txtOutput.Text = sb.ToString();
                }
            }
            catch (Exception ex)
            {
                txtOutput.Text = ex.ToString();
            }
        }

        private void btnPropertiesToListWithText_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> list = GetList();
                var helper = new PropertyHelper();
                if (list != null)
                {
                    var properties = helper.Parser(list);

                    var sb = new StringBuilder();
                    foreach (PropertyModel property in properties)
                    {
                        sb.AppendLine($"{property.Name};{property.Description}");
                    }

                    txtOutput.Text = sb.ToString();
                }
            }
            catch (Exception ex)
            {
                txtOutput.Text = ex.ToString();
            }
        }

        public string ToCarmel(string name)
        {
            if (string.IsNullOrEmpty(name)) return name;
            string result = "";
            char[] carateres = name.ToCharArray();
            for (int i = 0; i < carateres.Length; i++)
            {
                char s = carateres[i];
                if (i == 0 && s>=97 && s<=122)
                {
                    s =(char)(s - 32);
                }
                result= result + s;
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

        private void btnJsonToClass_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtInput.Text))
                {
                    MessageBox.Show(Resources.NoInputValue, Resources.Alert);
                    return;
                }
                JObject jobj = JObject.Parse(txtInput.Text);

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

                txtOutput.Text = sb.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Erro");
            }
        }

        private void btnTableSqlToClass_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> list = GetList();
                var helper = new TableSqlParser();
                if (list != null)
                {
                    var properties = helper.Parser(list);

                    txtOutput.Text = helper.ToClass(properties);
                }
            }
            catch (Exception ex)
            {
                txtOutput.Text = ex.ToString();
            }
        }

        private void btnClassToMap_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtClassName.Text))
                {
                    MessageBox.Show(Resources.NoClassNameValue, Resources.Alert);
                    return;
                }

                List<string> list = GetList();
                var helper = new PropertyHelper();
                if (list != null)
                {
                    var properties = helper.Parser(list);                   

                    txtOutput.Text = helper.ToMapClass(properties,txtClassName.Text);
                }
            }
            catch (Exception ex)
            {
                txtOutput.Text = ex.ToString();
            }
        }
    }
}
