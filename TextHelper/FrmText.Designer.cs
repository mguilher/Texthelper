namespace TextHelper
{
    partial class FrmText
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmText));
            btnReplaceList = new System.Windows.Forms.Button();
            txtInput = new System.Windows.Forms.TextBox();
            txtOutput = new System.Windows.Forms.TextBox();
            txtSeparator = new System.Windows.Forms.TextBox();
            lblSeparator = new System.Windows.Forms.Label();
            txtReplaceToken = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            lblStat = new System.Windows.Forms.Label();
            txtStart = new System.Windows.Forms.TextBox();
            txtEnd = new System.Windows.Forms.TextBox();
            lblEnd = new System.Windows.Forms.Label();
            btnConcatenateList = new System.Windows.Forms.Button();
            btnConcatenateReplaceList = new System.Windows.Forms.Button();
            txtTemplate = new System.Windows.Forms.TextBox();
            lblInput = new System.Windows.Forms.Label();
            lblTemplate = new System.Windows.Forms.Label();
            lblOutput = new System.Windows.Forms.Label();
            btnSortByAz = new System.Windows.Forms.Button();
            btnSortByZa = new System.Windows.Forms.Button();
            btnSetOutToIn = new System.Windows.Forms.Button();
            btnSetOutToClipboard = new System.Windows.Forms.Button();
            btnSplitReplaceList = new System.Windows.Forms.Button();
            lblInnerSaparator = new System.Windows.Forms.Label();
            txtInnerSeparator = new System.Windows.Forms.TextBox();
            btnPropertiesToInstace = new System.Windows.Forms.Button();
            lblVariableName = new System.Windows.Forms.Label();
            txtVariableName = new System.Windows.Forms.TextBox();
            lblTypeName = new System.Windows.Forms.Label();
            txtTypeName = new System.Windows.Forms.TextBox();
            btnPropertiesToAssignment = new System.Windows.Forms.Button();
            tcOptions = new System.Windows.Forms.TabControl();
            tpReplace = new System.Windows.Forms.TabPage();
            label1 = new System.Windows.Forms.Label();
            btnReplicate = new System.Windows.Forms.Button();
            lblQuantityReplicate = new System.Windows.Forms.Label();
            txtQuantityReplicate = new System.Windows.Forms.TextBox();
            tpTemplate = new System.Windows.Forms.TabPage();
            tpToken = new System.Windows.Forms.TabPage();
            lbTokens = new System.Windows.Forms.ListBox();
            btnLoadTokens = new System.Windows.Forms.Button();
            btnClearTokens = new System.Windows.Forms.Button();
            lblTokensInfo = new System.Windows.Forms.Label();
            btnDeleteToken = new System.Windows.Forms.Button();
            btnAddToken = new System.Windows.Forms.Button();
            tpLoadList = new System.Windows.Forms.TabPage();
            llInfo = new System.Windows.Forms.LinkLabel();
            btnParserJson = new System.Windows.Forms.Button();
            txtXmlSelect = new System.Windows.Forms.TextBox();
            lblXmlSelect = new System.Windows.Forms.Label();
            txtJsonSelect = new System.Windows.Forms.TextBox();
            lblJsonSelect = new System.Windows.Forms.Label();
            btnLoadListXml = new System.Windows.Forms.Button();
            txtPathXml = new System.Windows.Forms.TextBox();
            lblPathXml = new System.Windows.Forms.Label();
            btnLoadListJson = new System.Windows.Forms.Button();
            txtPathJson = new System.Windows.Forms.TextBox();
            lblPathJson = new System.Windows.Forms.Label();
            btnLoadCsv = new System.Windows.Forms.Button();
            txtPathCsv = new System.Windows.Forms.TextBox();
            lblPathCsv = new System.Windows.Forms.Label();
            tpAction = new System.Windows.Forms.TabPage();
            btnTableToClassWithJP = new System.Windows.Forms.Button();
            txtClassName = new System.Windows.Forms.TextBox();
            lblClassName = new System.Windows.Forms.Label();
            btnClassToMap = new System.Windows.Forms.Button();
            btnPropertiesToListWithText = new System.Windows.Forms.Button();
            btnCheckSqlInsert = new System.Windows.Forms.Button();
            btnJsonToClass = new System.Windows.Forms.Button();
            btnPropertiesToList = new System.Windows.Forms.Button();
            btnTableSqlToClass = new System.Windows.Forms.Button();
            btnSortInputByZa = new System.Windows.Forms.Button();
            btnSortInputByAz = new System.Windows.Forms.Button();
            tcOptions.SuspendLayout();
            tpReplace.SuspendLayout();
            tpTemplate.SuspendLayout();
            tpToken.SuspendLayout();
            tpLoadList.SuspendLayout();
            tpAction.SuspendLayout();
            SuspendLayout();
            // 
            // btnReplaceList
            // 
            btnReplaceList.Location = new System.Drawing.Point(136, 8);
            btnReplaceList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnReplaceList.Name = "btnReplaceList";
            btnReplaceList.Size = new System.Drawing.Size(113, 29);
            btnReplaceList.TabIndex = 0;
            btnReplaceList.Text = "Replace List";
            btnReplaceList.UseVisualStyleBackColor = true;
            btnReplaceList.Click += BtnReplaceListClick;
            // 
            // txtInput
            // 
            txtInput.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtInput.Location = new System.Drawing.Point(10, 25);
            txtInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtInput.Size = new System.Drawing.Size(847, 199);
            txtInput.TabIndex = 1;
            // 
            // txtOutput
            // 
            txtOutput.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtOutput.Location = new System.Drawing.Point(10, 581);
            txtOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtOutput.Size = new System.Drawing.Size(848, 184);
            txtOutput.TabIndex = 2;
            // 
            // txtSeparator
            // 
            txtSeparator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            txtSeparator.Location = new System.Drawing.Point(67, 11);
            txtSeparator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtSeparator.Name = "txtSeparator";
            txtSeparator.Size = new System.Drawing.Size(63, 20);
            txtSeparator.TabIndex = 3;
            txtSeparator.Text = "\\n";
            // 
            // lblSeparator
            // 
            lblSeparator.AutoSize = true;
            lblSeparator.Location = new System.Drawing.Point(6, 15);
            lblSeparator.Name = "lblSeparator";
            lblSeparator.Size = new System.Drawing.Size(60, 15);
            lblSeparator.TabIndex = 4;
            lblSeparator.Text = "Separator:";
            // 
            // txtReplaceToken
            // 
            txtReplaceToken.Location = new System.Drawing.Point(106, 34);
            txtReplaceToken.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtReplaceToken.Name = "txtReplaceToken";
            txtReplaceToken.Size = new System.Drawing.Size(109, 23);
            txtReplaceToken.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(7, 36);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(85, 15);
            label2.TabIndex = 7;
            label2.Text = "Replace Token:";
            // 
            // lblStat
            // 
            lblStat.AutoSize = true;
            lblStat.Location = new System.Drawing.Point(6, 79);
            lblStat.Name = "lblStat";
            lblStat.Size = new System.Drawing.Size(34, 15);
            lblStat.TabIndex = 8;
            lblStat.Text = "Start:";
            // 
            // txtStart
            // 
            txtStart.Location = new System.Drawing.Point(48, 75);
            txtStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtStart.Name = "txtStart";
            txtStart.Size = new System.Drawing.Size(224, 23);
            txtStart.TabIndex = 9;
            // 
            // txtEnd
            // 
            txtEnd.Location = new System.Drawing.Point(318, 75);
            txtEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new System.Drawing.Size(224, 23);
            txtEnd.TabIndex = 11;
            // 
            // lblEnd
            // 
            lblEnd.AutoSize = true;
            lblEnd.Location = new System.Drawing.Point(279, 79);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new System.Drawing.Size(30, 15);
            lblEnd.TabIndex = 10;
            lblEnd.Text = "End:";
            // 
            // btnConcatenateList
            // 
            btnConcatenateList.Location = new System.Drawing.Point(554, 71);
            btnConcatenateList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnConcatenateList.Name = "btnConcatenateList";
            btnConcatenateList.Size = new System.Drawing.Size(113, 29);
            btnConcatenateList.TabIndex = 12;
            btnConcatenateList.Text = "Concatenate List";
            btnConcatenateList.UseVisualStyleBackColor = true;
            btnConcatenateList.Click += BtnConcatenateListClick;
            // 
            // btnConcatenateReplaceList
            // 
            btnConcatenateReplaceList.Location = new System.Drawing.Point(253, 8);
            btnConcatenateReplaceList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnConcatenateReplaceList.Name = "btnConcatenateReplaceList";
            btnConcatenateReplaceList.Size = new System.Drawing.Size(195, 29);
            btnConcatenateReplaceList.TabIndex = 13;
            btnConcatenateReplaceList.Text = "Concatenate and Replace List";
            btnConcatenateReplaceList.UseVisualStyleBackColor = true;
            btnConcatenateReplaceList.Click += BtnConcatenateReplaceListClick;
            // 
            // txtTemplate
            // 
            txtTemplate.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtTemplate.Location = new System.Drawing.Point(6, 23);
            txtTemplate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtTemplate.Multiline = true;
            txtTemplate.Name = "txtTemplate";
            txtTemplate.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtTemplate.Size = new System.Drawing.Size(831, 214);
            txtTemplate.TabIndex = 14;
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Location = new System.Drawing.Point(8, 8);
            lblInput.Name = "lblInput";
            lblInput.Size = new System.Drawing.Size(59, 15);
            lblInput.TabIndex = 15;
            lblInput.Text = "Input List:";
            // 
            // lblTemplate
            // 
            lblTemplate.AutoSize = true;
            lblTemplate.Location = new System.Drawing.Point(6, 4);
            lblTemplate.Name = "lblTemplate";
            lblTemplate.Size = new System.Drawing.Size(58, 15);
            lblTemplate.TabIndex = 16;
            lblTemplate.Text = "Template:";
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Location = new System.Drawing.Point(6, 561);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new System.Drawing.Size(48, 15);
            lblOutput.TabIndex = 17;
            lblOutput.Text = "Output:";
            // 
            // btnSortByAz
            // 
            btnSortByAz.Location = new System.Drawing.Point(13, 520);
            btnSortByAz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnSortByAz.Name = "btnSortByAz";
            btnSortByAz.Size = new System.Drawing.Size(122, 29);
            btnSortByAz.TabIndex = 18;
            btnSortByAz.Text = "Sort Output by AZ";
            btnSortByAz.UseVisualStyleBackColor = true;
            btnSortByAz.Click += BtnSortByAzClick;
            // 
            // btnSortByZa
            // 
            btnSortByZa.Location = new System.Drawing.Point(139, 520);
            btnSortByZa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnSortByZa.Name = "btnSortByZa";
            btnSortByZa.Size = new System.Drawing.Size(120, 29);
            btnSortByZa.TabIndex = 19;
            btnSortByZa.Text = "Sort Output by ZA";
            btnSortByZa.UseVisualStyleBackColor = true;
            btnSortByZa.Click += BtnSortByZaClick;
            // 
            // btnSetOutToIn
            // 
            btnSetOutToIn.Location = new System.Drawing.Point(496, 520);
            btnSetOutToIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnSetOutToIn.Name = "btnSetOutToIn";
            btnSetOutToIn.Size = new System.Drawing.Size(123, 29);
            btnSetOutToIn.TabIndex = 20;
            btnSetOutToIn.Text = "Set Output to Input";
            btnSetOutToIn.UseVisualStyleBackColor = true;
            btnSetOutToIn.Click += BtnSetOutToIn_Click;
            // 
            // btnSetOutToClipboard
            // 
            btnSetOutToClipboard.Location = new System.Drawing.Point(624, 520);
            btnSetOutToClipboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnSetOutToClipboard.Name = "btnSetOutToClipboard";
            btnSetOutToClipboard.Size = new System.Drawing.Size(148, 29);
            btnSetOutToClipboard.TabIndex = 21;
            btnSetOutToClipboard.Text = "Set Output to Clipboard";
            btnSetOutToClipboard.UseVisualStyleBackColor = true;
            btnSetOutToClipboard.Click += BtnSetOutToClipboard_Click;
            // 
            // btnSplitReplaceList
            // 
            btnSplitReplaceList.Location = new System.Drawing.Point(626, 8);
            btnSplitReplaceList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnSplitReplaceList.Name = "btnSplitReplaceList";
            btnSplitReplaceList.Size = new System.Drawing.Size(143, 29);
            btnSplitReplaceList.TabIndex = 22;
            btnSplitReplaceList.Text = "Split Replace List";
            btnSplitReplaceList.UseVisualStyleBackColor = true;
            btnSplitReplaceList.Click += BtnSplitReplaceList_Click;
            // 
            // lblInnerSaparator
            // 
            lblInnerSaparator.AutoSize = true;
            lblInnerSaparator.Location = new System.Drawing.Point(472, 15);
            lblInnerSaparator.Name = "lblInnerSaparator";
            lblInnerSaparator.Size = new System.Drawing.Size(90, 15);
            lblInnerSaparator.TabIndex = 24;
            lblInnerSaparator.Text = "Inner Separator:";
            // 
            // txtInnerSeparator
            // 
            txtInnerSeparator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            txtInnerSeparator.Location = new System.Drawing.Point(573, 11);
            txtInnerSeparator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtInnerSeparator.Name = "txtInnerSeparator";
            txtInnerSeparator.Size = new System.Drawing.Size(42, 20);
            txtInnerSeparator.TabIndex = 23;
            txtInnerSeparator.Text = ";";
            // 
            // btnPropertiesToInstace
            // 
            btnPropertiesToInstace.Location = new System.Drawing.Point(333, 196);
            btnPropertiesToInstace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnPropertiesToInstace.Name = "btnPropertiesToInstace";
            btnPropertiesToInstace.Size = new System.Drawing.Size(172, 29);
            btnPropertiesToInstace.TabIndex = 25;
            btnPropertiesToInstace.Text = "Properties To Instace";
            btnPropertiesToInstace.UseVisualStyleBackColor = true;
            btnPropertiesToInstace.Click += BtnPropertiesToInstace_Click;
            // 
            // lblVariableName
            // 
            lblVariableName.AutoSize = true;
            lblVariableName.Location = new System.Drawing.Point(16, 203);
            lblVariableName.Name = "lblVariableName";
            lblVariableName.Size = new System.Drawing.Size(86, 15);
            lblVariableName.TabIndex = 27;
            lblVariableName.Text = "Variable Name:";
            // 
            // txtVariableName
            // 
            txtVariableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            txtVariableName.Location = new System.Drawing.Point(113, 200);
            txtVariableName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtVariableName.Name = "txtVariableName";
            txtVariableName.Size = new System.Drawing.Size(59, 20);
            txtVariableName.TabIndex = 26;
            txtVariableName.Text = "obj";
            // 
            // lblTypeName
            // 
            lblTypeName.AutoSize = true;
            lblTypeName.Location = new System.Drawing.Point(177, 203);
            lblTypeName.Name = "lblTypeName";
            lblTypeName.Size = new System.Drawing.Size(69, 15);
            lblTypeName.TabIndex = 29;
            lblTypeName.Text = "Type Name:";
            // 
            // txtTypeName
            // 
            txtTypeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            txtTypeName.Location = new System.Drawing.Point(257, 200);
            txtTypeName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtTypeName.Name = "txtTypeName";
            txtTypeName.Size = new System.Drawing.Size(59, 20);
            txtTypeName.TabIndex = 28;
            txtTypeName.Text = "Entity";
            // 
            // btnPropertiesToAssignment
            // 
            btnPropertiesToAssignment.Location = new System.Drawing.Point(511, 196);
            btnPropertiesToAssignment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnPropertiesToAssignment.Name = "btnPropertiesToAssignment";
            btnPropertiesToAssignment.Size = new System.Drawing.Size(172, 29);
            btnPropertiesToAssignment.TabIndex = 30;
            btnPropertiesToAssignment.Text = "Properties To Assignment";
            btnPropertiesToAssignment.UseVisualStyleBackColor = true;
            btnPropertiesToAssignment.Click += btnPropertiesToAssignment_Click;
            // 
            // tcOptions
            // 
            tcOptions.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tcOptions.Controls.Add(tpReplace);
            tcOptions.Controls.Add(tpTemplate);
            tcOptions.Controls.Add(tpToken);
            tcOptions.Controls.Add(tpLoadList);
            tcOptions.Controls.Add(tpAction);
            tcOptions.Location = new System.Drawing.Point(11, 230);
            tcOptions.Margin = new System.Windows.Forms.Padding(4);
            tcOptions.Name = "tcOptions";
            tcOptions.SelectedIndex = 0;
            tcOptions.Size = new System.Drawing.Size(850, 285);
            tcOptions.TabIndex = 31;
            // 
            // tpReplace
            // 
            tpReplace.Controls.Add(label1);
            tpReplace.Controls.Add(btnReplicate);
            tpReplace.Controls.Add(lblQuantityReplicate);
            tpReplace.Controls.Add(txtQuantityReplicate);
            tpReplace.Controls.Add(btnConcatenateReplaceList);
            tpReplace.Controls.Add(btnReplaceList);
            tpReplace.Controls.Add(txtSeparator);
            tpReplace.Controls.Add(lblSeparator);
            tpReplace.Controls.Add(btnConcatenateList);
            tpReplace.Controls.Add(txtEnd);
            tpReplace.Controls.Add(lblEnd);
            tpReplace.Controls.Add(txtStart);
            tpReplace.Controls.Add(lblStat);
            tpReplace.Controls.Add(lblInnerSaparator);
            tpReplace.Controls.Add(btnSplitReplaceList);
            tpReplace.Controls.Add(txtInnerSeparator);
            tpReplace.Location = new System.Drawing.Point(4, 24);
            tpReplace.Margin = new System.Windows.Forms.Padding(4);
            tpReplace.Name = "tpReplace";
            tpReplace.Padding = new System.Windows.Forms.Padding(4);
            tpReplace.Size = new System.Drawing.Size(842, 257);
            tpReplace.TabIndex = 0;
            tpReplace.Text = "Options";
            tpReplace.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(32, 194);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(320, 15);
            label1.TabIndex = 34;
            label1.Text = "Use [N] to contact the index and [C] matches it in character";
            // 
            // btnReplicate
            // 
            btnReplicate.Location = new System.Drawing.Point(266, 164);
            btnReplicate.Margin = new System.Windows.Forms.Padding(4);
            btnReplicate.Name = "btnReplicate";
            btnReplicate.Size = new System.Drawing.Size(88, 26);
            btnReplicate.TabIndex = 33;
            btnReplicate.Text = "Replicate";
            btnReplicate.UseVisualStyleBackColor = true;
            btnReplicate.Click += btnReplicate_Click;
            // 
            // lblQuantityReplicate
            // 
            lblQuantityReplicate.AutoSize = true;
            lblQuantityReplicate.Location = new System.Drawing.Point(11, 171);
            lblQuantityReplicate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblQuantityReplicate.Name = "lblQuantityReplicate";
            lblQuantityReplicate.Size = new System.Drawing.Size(118, 15);
            lblQuantityReplicate.TabIndex = 32;
            lblQuantityReplicate.Text = "Quantity to Replicate";
            // 
            // txtQuantityReplicate
            // 
            txtQuantityReplicate.Location = new System.Drawing.Point(143, 167);
            txtQuantityReplicate.Margin = new System.Windows.Forms.Padding(4);
            txtQuantityReplicate.Name = "txtQuantityReplicate";
            txtQuantityReplicate.Size = new System.Drawing.Size(116, 23);
            txtQuantityReplicate.TabIndex = 31;
            // 
            // tpTemplate
            // 
            tpTemplate.Controls.Add(lblTemplate);
            tpTemplate.Controls.Add(txtTemplate);
            tpTemplate.Location = new System.Drawing.Point(4, 24);
            tpTemplate.Margin = new System.Windows.Forms.Padding(4);
            tpTemplate.Name = "tpTemplate";
            tpTemplate.Padding = new System.Windows.Forms.Padding(4);
            tpTemplate.Size = new System.Drawing.Size(842, 257);
            tpTemplate.TabIndex = 1;
            tpTemplate.Text = "Template";
            tpTemplate.UseVisualStyleBackColor = true;
            // 
            // tpToken
            // 
            tpToken.Controls.Add(lbTokens);
            tpToken.Controls.Add(btnLoadTokens);
            tpToken.Controls.Add(btnClearTokens);
            tpToken.Controls.Add(lblTokensInfo);
            tpToken.Controls.Add(btnDeleteToken);
            tpToken.Controls.Add(btnAddToken);
            tpToken.Controls.Add(txtReplaceToken);
            tpToken.Controls.Add(label2);
            tpToken.Location = new System.Drawing.Point(4, 24);
            tpToken.Margin = new System.Windows.Forms.Padding(4);
            tpToken.Name = "tpToken";
            tpToken.Padding = new System.Windows.Forms.Padding(4);
            tpToken.Size = new System.Drawing.Size(842, 257);
            tpToken.TabIndex = 2;
            tpToken.Text = "Tokens";
            tpToken.UseVisualStyleBackColor = true;
            // 
            // lbTokens
            // 
            lbTokens.FormattingEnabled = true;
            lbTokens.ItemHeight = 15;
            lbTokens.Location = new System.Drawing.Point(14, 62);
            lbTokens.Margin = new System.Windows.Forms.Padding(4);
            lbTokens.Name = "lbTokens";
            lbTokens.ScrollAlwaysVisible = true;
            lbTokens.Size = new System.Drawing.Size(616, 139);
            lbTokens.TabIndex = 23;
            // 
            // btnLoadTokens
            // 
            btnLoadTokens.Location = new System.Drawing.Point(638, 98);
            btnLoadTokens.Margin = new System.Windows.Forms.Padding(4);
            btnLoadTokens.Name = "btnLoadTokens";
            btnLoadTokens.Size = new System.Drawing.Size(70, 26);
            btnLoadTokens.TabIndex = 22;
            btnLoadTokens.Text = "Load";
            btnLoadTokens.UseVisualStyleBackColor = true;
            btnLoadTokens.Click += btnLoadTokens_Click;
            // 
            // btnClearTokens
            // 
            btnClearTokens.Location = new System.Drawing.Point(638, 65);
            btnClearTokens.Margin = new System.Windows.Forms.Padding(4);
            btnClearTokens.Name = "btnClearTokens";
            btnClearTokens.Size = new System.Drawing.Size(70, 26);
            btnClearTokens.TabIndex = 21;
            btnClearTokens.Text = "Clear";
            btnClearTokens.UseVisualStyleBackColor = true;
            btnClearTokens.Click += btnClearTokens_Click;
            // 
            // lblTokensInfo
            // 
            lblTokensInfo.AutoSize = true;
            lblTokensInfo.Location = new System.Drawing.Point(10, 205);
            lblTokensInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTokensInfo.Name = "lblTokensInfo";
            lblTokensInfo.Size = new System.Drawing.Size(628, 30);
            lblTokensInfo.TabIndex = 20;
            lblTokensInfo.Text = "The tokens are used by the index of the corresponding position in the data line, first token for the first item and so on; \r\nTo delete select from the list and use the button";
            // 
            // btnDeleteToken
            // 
            btnDeleteToken.Location = new System.Drawing.Point(638, 171);
            btnDeleteToken.Margin = new System.Windows.Forms.Padding(4);
            btnDeleteToken.Name = "btnDeleteToken";
            btnDeleteToken.Size = new System.Drawing.Size(70, 26);
            btnDeleteToken.TabIndex = 19;
            btnDeleteToken.Text = "Delete";
            btnDeleteToken.UseVisualStyleBackColor = true;
            btnDeleteToken.Click += btnDeleteToken_Click;
            // 
            // btnAddToken
            // 
            btnAddToken.Location = new System.Drawing.Point(221, 31);
            btnAddToken.Margin = new System.Windows.Forms.Padding(4);
            btnAddToken.Name = "btnAddToken";
            btnAddToken.Size = new System.Drawing.Size(52, 26);
            btnAddToken.TabIndex = 17;
            btnAddToken.Text = "Add";
            btnAddToken.UseVisualStyleBackColor = true;
            btnAddToken.Click += btnAddToken_Click;
            // 
            // tpLoadList
            // 
            tpLoadList.Controls.Add(llInfo);
            tpLoadList.Controls.Add(btnParserJson);
            tpLoadList.Controls.Add(txtXmlSelect);
            tpLoadList.Controls.Add(lblXmlSelect);
            tpLoadList.Controls.Add(txtJsonSelect);
            tpLoadList.Controls.Add(lblJsonSelect);
            tpLoadList.Controls.Add(btnLoadListXml);
            tpLoadList.Controls.Add(txtPathXml);
            tpLoadList.Controls.Add(lblPathXml);
            tpLoadList.Controls.Add(btnLoadListJson);
            tpLoadList.Controls.Add(txtPathJson);
            tpLoadList.Controls.Add(lblPathJson);
            tpLoadList.Controls.Add(btnLoadCsv);
            tpLoadList.Controls.Add(txtPathCsv);
            tpLoadList.Controls.Add(lblPathCsv);
            tpLoadList.Location = new System.Drawing.Point(4, 24);
            tpLoadList.Margin = new System.Windows.Forms.Padding(4);
            tpLoadList.Name = "tpLoadList";
            tpLoadList.Padding = new System.Windows.Forms.Padding(4);
            tpLoadList.Size = new System.Drawing.Size(842, 257);
            tpLoadList.TabIndex = 3;
            tpLoadList.Text = "Load List";
            tpLoadList.UseVisualStyleBackColor = true;
            // 
            // llInfo
            // 
            llInfo.AutoSize = true;
            llInfo.Location = new System.Drawing.Point(10, 125);
            llInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            llInfo.Name = "llInfo";
            llInfo.Size = new System.Drawing.Size(341, 15);
            llInfo.TabIndex = 36;
            llInfo.TabStop = true;
            llInfo.Text = "https://www.newtonsoft.com/json/help/html/SelectToken.htm";
            llInfo.LinkClicked += llInfo_LinkClicked;
            // 
            // btnParserJson
            // 
            btnParserJson.Location = new System.Drawing.Point(574, 96);
            btnParserJson.Margin = new System.Windows.Forms.Padding(4);
            btnParserJson.Name = "btnParserJson";
            btnParserJson.Size = new System.Drawing.Size(88, 26);
            btnParserJson.TabIndex = 35;
            btnParserJson.Text = "Parser Json";
            btnParserJson.UseVisualStyleBackColor = true;
            btnParserJson.Click += btnParserJson_Click;
            // 
            // txtXmlSelect
            // 
            txtXmlSelect.Location = new System.Drawing.Point(101, 202);
            txtXmlSelect.Margin = new System.Windows.Forms.Padding(4);
            txtXmlSelect.Name = "txtXmlSelect";
            txtXmlSelect.Size = new System.Drawing.Size(466, 23);
            txtXmlSelect.TabIndex = 12;
            // 
            // lblXmlSelect
            // 
            lblXmlSelect.AutoSize = true;
            lblXmlSelect.Location = new System.Drawing.Point(10, 205);
            lblXmlSelect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblXmlSelect.Name = "lblXmlSelect";
            lblXmlSelect.Size = new System.Drawing.Size(68, 15);
            lblXmlSelect.TabIndex = 11;
            lblXmlSelect.Text = "XML Select:";
            // 
            // txtJsonSelect
            // 
            txtJsonSelect.Location = new System.Drawing.Point(101, 98);
            txtJsonSelect.Margin = new System.Windows.Forms.Padding(4);
            txtJsonSelect.Name = "txtJsonSelect";
            txtJsonSelect.Size = new System.Drawing.Size(466, 23);
            txtJsonSelect.TabIndex = 10;
            // 
            // lblJsonSelect
            // 
            lblJsonSelect.AutoSize = true;
            lblJsonSelect.Location = new System.Drawing.Point(10, 101);
            lblJsonSelect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblJsonSelect.Name = "lblJsonSelect";
            lblJsonSelect.Size = new System.Drawing.Size(72, 15);
            lblJsonSelect.TabIndex = 9;
            lblJsonSelect.Text = "JSON Select:";
            // 
            // btnLoadListXml
            // 
            btnLoadListXml.Location = new System.Drawing.Point(574, 170);
            btnLoadListXml.Margin = new System.Windows.Forms.Padding(4);
            btnLoadListXml.Name = "btnLoadListXml";
            btnLoadListXml.Size = new System.Drawing.Size(88, 26);
            btnLoadListXml.TabIndex = 8;
            btnLoadListXml.Text = "Load XML";
            btnLoadListXml.UseVisualStyleBackColor = true;
            btnLoadListXml.Click += btnLoadListXml_Click;
            // 
            // txtPathXml
            // 
            txtPathXml.Location = new System.Drawing.Point(80, 172);
            txtPathXml.Margin = new System.Windows.Forms.Padding(4);
            txtPathXml.Name = "txtPathXml";
            txtPathXml.Size = new System.Drawing.Size(486, 23);
            txtPathXml.TabIndex = 7;
            // 
            // lblPathXml
            // 
            lblPathXml.AutoSize = true;
            lblPathXml.Location = new System.Drawing.Point(8, 175);
            lblPathXml.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPathXml.Name = "lblPathXml";
            lblPathXml.Size = new System.Drawing.Size(61, 15);
            lblPathXml.TabIndex = 6;
            lblPathXml.Text = "Path XML:";
            // 
            // btnLoadListJson
            // 
            btnLoadListJson.Location = new System.Drawing.Point(574, 62);
            btnLoadListJson.Margin = new System.Windows.Forms.Padding(4);
            btnLoadListJson.Name = "btnLoadListJson";
            btnLoadListJson.Size = new System.Drawing.Size(88, 26);
            btnLoadListJson.TabIndex = 5;
            btnLoadListJson.Text = "Load JSON";
            btnLoadListJson.UseVisualStyleBackColor = true;
            btnLoadListJson.Click += btnLoadListJson_Click;
            // 
            // txtPathJson
            // 
            txtPathJson.Location = new System.Drawing.Point(80, 68);
            txtPathJson.Margin = new System.Windows.Forms.Padding(4);
            txtPathJson.Name = "txtPathJson";
            txtPathJson.Size = new System.Drawing.Size(486, 23);
            txtPathJson.TabIndex = 4;
            // 
            // lblPathJson
            // 
            lblPathJson.AutoSize = true;
            lblPathJson.Location = new System.Drawing.Point(8, 71);
            lblPathJson.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPathJson.Name = "lblPathJson";
            lblPathJson.Size = new System.Drawing.Size(65, 15);
            lblPathJson.TabIndex = 3;
            lblPathJson.Text = "Path JSON:";
            // 
            // btnLoadCsv
            // 
            btnLoadCsv.Location = new System.Drawing.Point(574, 17);
            btnLoadCsv.Margin = new System.Windows.Forms.Padding(4);
            btnLoadCsv.Name = "btnLoadCsv";
            btnLoadCsv.Size = new System.Drawing.Size(88, 26);
            btnLoadCsv.TabIndex = 2;
            btnLoadCsv.Text = "Load CSV";
            btnLoadCsv.UseVisualStyleBackColor = true;
            btnLoadCsv.Click += btnLoadCsv_Click;
            // 
            // txtPathCsv
            // 
            txtPathCsv.Location = new System.Drawing.Point(80, 20);
            txtPathCsv.Margin = new System.Windows.Forms.Padding(4);
            txtPathCsv.Name = "txtPathCsv";
            txtPathCsv.Size = new System.Drawing.Size(486, 23);
            txtPathCsv.TabIndex = 1;
            // 
            // lblPathCsv
            // 
            lblPathCsv.AutoSize = true;
            lblPathCsv.Location = new System.Drawing.Point(8, 23);
            lblPathCsv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPathCsv.Name = "lblPathCsv";
            lblPathCsv.Size = new System.Drawing.Size(58, 15);
            lblPathCsv.TabIndex = 0;
            lblPathCsv.Text = "Path CSV:";
            // 
            // tpAction
            // 
            tpAction.Controls.Add(btnTableToClassWithJP);
            tpAction.Controls.Add(txtClassName);
            tpAction.Controls.Add(lblClassName);
            tpAction.Controls.Add(btnClassToMap);
            tpAction.Controls.Add(btnPropertiesToListWithText);
            tpAction.Controls.Add(btnCheckSqlInsert);
            tpAction.Controls.Add(lblTypeName);
            tpAction.Controls.Add(btnJsonToClass);
            tpAction.Controls.Add(btnPropertiesToList);
            tpAction.Controls.Add(btnPropertiesToAssignment);
            tpAction.Controls.Add(btnTableSqlToClass);
            tpAction.Controls.Add(txtTypeName);
            tpAction.Controls.Add(btnPropertiesToInstace);
            tpAction.Controls.Add(txtVariableName);
            tpAction.Controls.Add(lblVariableName);
            tpAction.Location = new System.Drawing.Point(4, 24);
            tpAction.Name = "tpAction";
            tpAction.Padding = new System.Windows.Forms.Padding(3);
            tpAction.Size = new System.Drawing.Size(842, 257);
            tpAction.TabIndex = 4;
            tpAction.Text = "Custom Actions";
            tpAction.UseVisualStyleBackColor = true;
            // 
            // btnTableToClassWithJP
            // 
            btnTableToClassWithJP.Location = new System.Drawing.Point(177, 71);
            btnTableToClassWithJP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnTableToClassWithJP.Name = "btnTableToClassWithJP";
            btnTableToClassWithJP.Size = new System.Drawing.Size(272, 29);
            btnTableToClassWithJP.TabIndex = 41;
            btnTableToClassWithJP.Text = "Table To Class With JSON Property";
            btnTableToClassWithJP.UseVisualStyleBackColor = true;
            btnTableToClassWithJP.Click += btnTableToClassWithJP_Click;
            // 
            // txtClassName
            // 
            txtClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            txtClassName.Location = new System.Drawing.Point(262, 129);
            txtClassName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtClassName.Name = "txtClassName";
            txtClassName.Size = new System.Drawing.Size(111, 20);
            txtClassName.TabIndex = 35;
            txtClassName.Text = "Class1";
            // 
            // lblClassName
            // 
            lblClassName.AutoSize = true;
            lblClassName.Location = new System.Drawing.Point(184, 130);
            lblClassName.Name = "lblClassName";
            lblClassName.Size = new System.Drawing.Size(72, 15);
            lblClassName.TabIndex = 36;
            lblClassName.Text = "Class Name:";
            // 
            // btnClassToMap
            // 
            btnClassToMap.Location = new System.Drawing.Point(23, 124);
            btnClassToMap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnClassToMap.Name = "btnClassToMap";
            btnClassToMap.Size = new System.Drawing.Size(143, 29);
            btnClassToMap.TabIndex = 40;
            btnClassToMap.Text = "Class To EF Map";
            btnClassToMap.UseVisualStyleBackColor = true;
            btnClassToMap.Click += btnClassToMap_Click;
            // 
            // btnPropertiesToListWithText
            // 
            btnPropertiesToListWithText.Location = new System.Drawing.Point(444, 22);
            btnPropertiesToListWithText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnPropertiesToListWithText.Name = "btnPropertiesToListWithText";
            btnPropertiesToListWithText.Size = new System.Drawing.Size(216, 29);
            btnPropertiesToListWithText.TabIndex = 37;
            btnPropertiesToListWithText.Text = "Properties To List With Text";
            btnPropertiesToListWithText.UseVisualStyleBackColor = true;
            btnPropertiesToListWithText.Click += btnPropertiesToListWithText_Click;
            // 
            // btnCheckSqlInsert
            // 
            btnCheckSqlInsert.Location = new System.Drawing.Point(23, 71);
            btnCheckSqlInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnCheckSqlInsert.Name = "btnCheckSqlInsert";
            btnCheckSqlInsert.Size = new System.Drawing.Size(143, 29);
            btnCheckSqlInsert.TabIndex = 35;
            btnCheckSqlInsert.Text = "Check Sql Insert";
            btnCheckSqlInsert.UseVisualStyleBackColor = true;
            btnCheckSqlInsert.Click += btnCheckSqlInsert_Click;
            // 
            // btnJsonToClass
            // 
            btnJsonToClass.Location = new System.Drawing.Point(171, 22);
            btnJsonToClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnJsonToClass.Name = "btnJsonToClass";
            btnJsonToClass.Size = new System.Drawing.Size(172, 29);
            btnJsonToClass.TabIndex = 38;
            btnJsonToClass.Text = "JSON To Class";
            btnJsonToClass.UseVisualStyleBackColor = true;
            btnJsonToClass.Click += btnJsonToClass_Click;
            // 
            // btnPropertiesToList
            // 
            btnPropertiesToList.Location = new System.Drawing.Point(665, 22);
            btnPropertiesToList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnPropertiesToList.Name = "btnPropertiesToList";
            btnPropertiesToList.Size = new System.Drawing.Size(172, 29);
            btnPropertiesToList.TabIndex = 36;
            btnPropertiesToList.Text = "Properties To List";
            btnPropertiesToList.UseVisualStyleBackColor = true;
            btnPropertiesToList.Click += btnPropertiesToList_Click;
            // 
            // btnTableSqlToClass
            // 
            btnTableSqlToClass.Location = new System.Drawing.Point(23, 22);
            btnTableSqlToClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnTableSqlToClass.Name = "btnTableSqlToClass";
            btnTableSqlToClass.Size = new System.Drawing.Size(143, 29);
            btnTableSqlToClass.TabIndex = 39;
            btnTableSqlToClass.Text = "Table To Class";
            btnTableSqlToClass.UseVisualStyleBackColor = true;
            btnTableSqlToClass.Click += btnTableSqlToClass_Click;
            // 
            // btnSortInputByZa
            // 
            btnSortInputByZa.Location = new System.Drawing.Point(382, 520);
            btnSortInputByZa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnSortInputByZa.Name = "btnSortInputByZa";
            btnSortInputByZa.Size = new System.Drawing.Size(109, 29);
            btnSortInputByZa.TabIndex = 33;
            btnSortInputByZa.Text = "Sort Input by ZA";
            btnSortInputByZa.UseVisualStyleBackColor = true;
            btnSortInputByZa.Click += btnSortInputByZa_Click;
            // 
            // btnSortInputByAz
            // 
            btnSortInputByAz.Location = new System.Drawing.Point(263, 520);
            btnSortInputByAz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnSortInputByAz.Name = "btnSortInputByAz";
            btnSortInputByAz.Size = new System.Drawing.Size(113, 29);
            btnSortInputByAz.TabIndex = 32;
            btnSortInputByAz.Text = "Sort Input by AZ";
            btnSortInputByAz.UseVisualStyleBackColor = true;
            btnSortInputByAz.Click += btnSortInputByAz_Click;
            // 
            // FrmText
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(872, 775);
            Controls.Add(btnSortInputByZa);
            Controls.Add(btnSortInputByAz);
            Controls.Add(tcOptions);
            Controls.Add(btnSetOutToClipboard);
            Controls.Add(btnSetOutToIn);
            Controls.Add(btnSortByZa);
            Controls.Add(btnSortByAz);
            Controls.Add(lblOutput);
            Controls.Add(lblInput);
            Controls.Add(txtOutput);
            Controls.Add(txtInput);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "FrmText";
            Text = resources.GetString("$this.Text");
            tcOptions.ResumeLayout(false);
            tpReplace.ResumeLayout(false);
            tpReplace.PerformLayout();
            tpTemplate.ResumeLayout(false);
            tpTemplate.PerformLayout();
            tpToken.ResumeLayout(false);
            tpToken.PerformLayout();
            tpLoadList.ResumeLayout(false);
            tpLoadList.PerformLayout();
            tpAction.ResumeLayout(false);
            tpAction.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnReplaceList;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtSeparator;
        private System.Windows.Forms.Label lblSeparator;
        private System.Windows.Forms.TextBox txtReplaceToken;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStat;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Button btnConcatenateList;
        private System.Windows.Forms.Button btnConcatenateReplaceList;
        private System.Windows.Forms.TextBox txtTemplate;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblTemplate;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnSortByAz;
        private System.Windows.Forms.Button btnSortByZa;
        private System.Windows.Forms.Button btnSetOutToIn;
        private System.Windows.Forms.Button btnSetOutToClipboard;
        private System.Windows.Forms.Button btnSplitReplaceList;
        private System.Windows.Forms.Label lblInnerSaparator;
        private System.Windows.Forms.TextBox txtInnerSeparator;
        private System.Windows.Forms.Button btnPropertiesToInstace;
        private System.Windows.Forms.Label lblVariableName;
        private System.Windows.Forms.TextBox txtVariableName;
        private System.Windows.Forms.Label lblTypeName;
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.Button btnPropertiesToAssignment;
        private System.Windows.Forms.TabControl tcOptions;
        private System.Windows.Forms.TabPage tpReplace;
        private System.Windows.Forms.TabPage tpTemplate;
        private System.Windows.Forms.Button btnSortInputByZa;
        private System.Windows.Forms.Button btnSortInputByAz;
        private System.Windows.Forms.Button btnAddToken;
        private System.Windows.Forms.TabPage tpToken;
        private System.Windows.Forms.Button btnReplicate;
        private System.Windows.Forms.Label lblQuantityReplicate;
        private System.Windows.Forms.TextBox txtQuantityReplicate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteToken;
        private System.Windows.Forms.Label lblTokensInfo;
        private System.Windows.Forms.Button btnLoadTokens;
        private System.Windows.Forms.Button btnClearTokens;
        private System.Windows.Forms.ListBox lbTokens;
        private System.Windows.Forms.TabPage tpLoadList;
        private System.Windows.Forms.TextBox txtXmlSelect;
        private System.Windows.Forms.Label lblXmlSelect;
        private System.Windows.Forms.TextBox txtJsonSelect;
        private System.Windows.Forms.Label lblJsonSelect;
        private System.Windows.Forms.Button btnLoadListXml;
        private System.Windows.Forms.TextBox txtPathXml;
        private System.Windows.Forms.Label lblPathXml;
        private System.Windows.Forms.Button btnLoadListJson;
        private System.Windows.Forms.TextBox txtPathJson;
        private System.Windows.Forms.Label lblPathJson;
        private System.Windows.Forms.Button btnLoadCsv;
        private System.Windows.Forms.TextBox txtPathCsv;
        private System.Windows.Forms.Label lblPathCsv;
        private System.Windows.Forms.Button btnParserJson;
        private System.Windows.Forms.LinkLabel llInfo;
        private System.Windows.Forms.Button btnCheckSqlInsert;
        private System.Windows.Forms.Button btnPropertiesToList;
        private System.Windows.Forms.Button btnPropertiesToListWithText;
        private System.Windows.Forms.Button btnJsonToClass;
        private System.Windows.Forms.Button btnTableSqlToClass;
        private System.Windows.Forms.TabPage tpAction;
        private System.Windows.Forms.Button btnClassToMap;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Button btnTableToClassWithJP;
    }
}

