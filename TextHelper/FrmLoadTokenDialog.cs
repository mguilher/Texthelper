using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TextHelper.Properties;

namespace TextHelper
{
    public partial class FrmLoadTokenDialog : Form
    {
        public FrmLoadTokenDialog(string innerSeparator)
        {
            InitializeComponent();
            _InnerSeparator = innerSeparator;
        }

        private string _InnerSeparator;

        public string Result { get; set; }

        private void btnLoadTokensCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnLoadTokensOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLoadTokens.Text))
            {
                MessageBox.Show(Resources.LoadTokensEmpty, Resources.Alert);
                return;
            }

            if (!txtLoadTokens.Text.Contains(_InnerSeparator))
            {
                MessageBox.Show(Resources.LoadTokensNotContainsSeparator, Resources.Alert);
                return;
            }
            Result = txtLoadTokens.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
