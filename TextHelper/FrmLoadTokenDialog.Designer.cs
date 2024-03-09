
namespace TextHelper
{
    partial class FrmLoadTokenDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtLoadTokens = new System.Windows.Forms.TextBox();
            this.lblLoadTokensInfo = new System.Windows.Forms.Label();
            this.btnLoadTokensCancel = new System.Windows.Forms.Button();
            this.btnLoadTokensOk = new System.Windows.Forms.Button();
            this.lblLoadTokens = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLoadTokens
            // 
            this.txtLoadTokens.Location = new System.Drawing.Point(67, 37);
            this.txtLoadTokens.Name = "txtLoadTokens";
            this.txtLoadTokens.Size = new System.Drawing.Size(393, 20);
            this.txtLoadTokens.TabIndex = 0;
            // 
            // lblLoadTokensInfo
            // 
            this.lblLoadTokensInfo.AutoSize = true;
            this.lblLoadTokensInfo.Location = new System.Drawing.Point(12, 9);
            this.lblLoadTokensInfo.Name = "lblLoadTokensInfo";
            this.lblLoadTokensInfo.Size = new System.Drawing.Size(407, 13);
            this.lblLoadTokensInfo.TabIndex = 1;
            this.lblLoadTokensInfo.Text = "Enter the line of tokens separated by the character configured field \"Inner Separ" +
    "ator\"";
            // 
            // btnLoadTokensCancel
            // 
            this.btnLoadTokensCancel.Location = new System.Drawing.Point(166, 63);
            this.btnLoadTokensCancel.Name = "btnLoadTokensCancel";
            this.btnLoadTokensCancel.Size = new System.Drawing.Size(75, 23);
            this.btnLoadTokensCancel.TabIndex = 2;
            this.btnLoadTokensCancel.Text = "&Cancel";
            this.btnLoadTokensCancel.UseVisualStyleBackColor = true;
            this.btnLoadTokensCancel.Click += new System.EventHandler(this.btnLoadTokensCancel_Click);
            // 
            // btnLoadTokensOk
            // 
            this.btnLoadTokensOk.Location = new System.Drawing.Point(247, 63);
            this.btnLoadTokensOk.Name = "btnLoadTokensOk";
            this.btnLoadTokensOk.Size = new System.Drawing.Size(75, 23);
            this.btnLoadTokensOk.TabIndex = 3;
            this.btnLoadTokensOk.Text = "Ok";
            this.btnLoadTokensOk.UseVisualStyleBackColor = true;
            this.btnLoadTokensOk.Click += new System.EventHandler(this.btnLoadTokensOk_Click);
            // 
            // lblLoadTokens
            // 
            this.lblLoadTokens.AutoSize = true;
            this.lblLoadTokens.Location = new System.Drawing.Point(15, 40);
            this.lblLoadTokens.Name = "lblLoadTokens";
            this.lblLoadTokens.Size = new System.Drawing.Size(46, 13);
            this.lblLoadTokens.TabIndex = 4;
            this.lblLoadTokens.Text = "Tokens:";
            // 
            // FrmLoadTokenDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 102);
            this.Controls.Add(this.lblLoadTokens);
            this.Controls.Add(this.btnLoadTokensOk);
            this.Controls.Add(this.btnLoadTokensCancel);
            this.Controls.Add(this.lblLoadTokensInfo);
            this.Controls.Add(this.txtLoadTokens);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLoadTokenDialog";
            this.Text = "Load Tokens";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLoadTokens;
        private System.Windows.Forms.Label lblLoadTokensInfo;
        private System.Windows.Forms.Button btnLoadTokensCancel;
        private System.Windows.Forms.Button btnLoadTokensOk;
        private System.Windows.Forms.Label lblLoadTokens;
    }
}