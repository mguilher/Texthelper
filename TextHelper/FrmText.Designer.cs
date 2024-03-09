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
            this.btnReplaceList = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtSeparator = new System.Windows.Forms.TextBox();
            this.lblSeparator = new System.Windows.Forms.Label();
            this.txtReplaceToken = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStat = new System.Windows.Forms.Label();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.lblEnd = new System.Windows.Forms.Label();
            this.btnConcatenateList = new System.Windows.Forms.Button();
            this.btnConcatenateReplaceList = new System.Windows.Forms.Button();
            this.txtTemplate = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblTemplate = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnSortByAz = new System.Windows.Forms.Button();
            this.btnSortByZa = new System.Windows.Forms.Button();
            this.btnSetOutToIn = new System.Windows.Forms.Button();
            this.btnSetOutToClipboard = new System.Windows.Forms.Button();
            this.btnSplitReplaceList = new System.Windows.Forms.Button();
            this.lblInnerSaparator = new System.Windows.Forms.Label();
            this.txtInnerSeparator = new System.Windows.Forms.TextBox();
            this.btnPropertiesToInstace = new System.Windows.Forms.Button();
            this.lblVariableName = new System.Windows.Forms.Label();
            this.txtVariableName = new System.Windows.Forms.TextBox();
            this.lblTypeName = new System.Windows.Forms.Label();
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.btnPropertiesToAssignment = new System.Windows.Forms.Button();
            this.tcOptions = new System.Windows.Forms.TabControl();
            this.tpReplace = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReplicate = new System.Windows.Forms.Button();
            this.lblQuantityReplicate = new System.Windows.Forms.Label();
            this.txtQuantityReplicate = new System.Windows.Forms.TextBox();
            this.tpTemplate = new System.Windows.Forms.TabPage();
            this.tpToken = new System.Windows.Forms.TabPage();
            this.lbTokens = new System.Windows.Forms.ListBox();
            this.btnLoadTokens = new System.Windows.Forms.Button();
            this.btnClearTokens = new System.Windows.Forms.Button();
            this.lblTokensInfo = new System.Windows.Forms.Label();
            this.btnDeleteToken = new System.Windows.Forms.Button();
            this.btnAddToken = new System.Windows.Forms.Button();
            this.tpLoadList = new System.Windows.Forms.TabPage();
            this.llInfo = new System.Windows.Forms.LinkLabel();
            this.btnParserJson = new System.Windows.Forms.Button();
            this.txtXmlSelect = new System.Windows.Forms.TextBox();
            this.lblXmlSelect = new System.Windows.Forms.Label();
            this.txtJsonSelect = new System.Windows.Forms.TextBox();
            this.lblJsonSelect = new System.Windows.Forms.Label();
            this.btnLoadListXml = new System.Windows.Forms.Button();
            this.txtPathXml = new System.Windows.Forms.TextBox();
            this.lblPathXml = new System.Windows.Forms.Label();
            this.btnLoadListJson = new System.Windows.Forms.Button();
            this.txtPathJson = new System.Windows.Forms.TextBox();
            this.lblPathJson = new System.Windows.Forms.Label();
            this.btnLoadCsv = new System.Windows.Forms.Button();
            this.txtPathCsv = new System.Windows.Forms.TextBox();
            this.lblPathCsv = new System.Windows.Forms.Label();
            this.tpAction = new System.Windows.Forms.TabPage();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.lblClassName = new System.Windows.Forms.Label();
            this.btnClassToMap = new System.Windows.Forms.Button();
            this.btnPropertiesToListWithText = new System.Windows.Forms.Button();
            this.btnCheckSqlInsert = new System.Windows.Forms.Button();
            this.btnJsonToClass = new System.Windows.Forms.Button();
            this.btnPropertiesToList = new System.Windows.Forms.Button();
            this.btnTableSqlToClass = new System.Windows.Forms.Button();
            this.btnSortInputByZa = new System.Windows.Forms.Button();
            this.btnSortInputByAz = new System.Windows.Forms.Button();
            this.tcOptions.SuspendLayout();
            this.tpReplace.SuspendLayout();
            this.tpTemplate.SuspendLayout();
            this.tpToken.SuspendLayout();
            this.tpLoadList.SuspendLayout();
            this.tpAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReplaceList
            // 
            this.btnReplaceList.Location = new System.Drawing.Point(155, 9);
            this.btnReplaceList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReplaceList.Name = "btnReplaceList";
            this.btnReplaceList.Size = new System.Drawing.Size(129, 31);
            this.btnReplaceList.TabIndex = 0;
            this.btnReplaceList.Text = "Replace List";
            this.btnReplaceList.UseVisualStyleBackColor = true;
            this.btnReplaceList.Click += new System.EventHandler(this.BtnReplaceListClick);
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.Location = new System.Drawing.Point(12, 27);
            this.txtInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput.Size = new System.Drawing.Size(967, 212);
            this.txtInput.TabIndex = 1;
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(12, 620);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(968, 196);
            this.txtOutput.TabIndex = 2;
            // 
            // txtSeparator
            // 
            this.txtSeparator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtSeparator.Location = new System.Drawing.Point(77, 12);
            this.txtSeparator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSeparator.Name = "txtSeparator";
            this.txtSeparator.Size = new System.Drawing.Size(71, 20);
            this.txtSeparator.TabIndex = 3;
            this.txtSeparator.Text = "\\n";
            // 
            // lblSeparator
            // 
            this.lblSeparator.AutoSize = true;
            this.lblSeparator.Location = new System.Drawing.Point(7, 16);
            this.lblSeparator.Name = "lblSeparator";
            this.lblSeparator.Size = new System.Drawing.Size(70, 16);
            this.lblSeparator.TabIndex = 4;
            this.lblSeparator.Text = "Separator:";
            // 
            // txtReplaceToken
            // 
            this.txtReplaceToken.Location = new System.Drawing.Point(121, 36);
            this.txtReplaceToken.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReplaceToken.Name = "txtReplaceToken";
            this.txtReplaceToken.Size = new System.Drawing.Size(124, 22);
            this.txtReplaceToken.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Replace Token:";
            // 
            // lblStat
            // 
            this.lblStat.AutoSize = true;
            this.lblStat.Location = new System.Drawing.Point(7, 84);
            this.lblStat.Name = "lblStat";
            this.lblStat.Size = new System.Drawing.Size(37, 16);
            this.lblStat.TabIndex = 8;
            this.lblStat.Text = "Start:";
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(55, 80);
            this.txtStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(255, 22);
            this.txtStart.TabIndex = 9;
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(363, 80);
            this.txtEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(255, 22);
            this.txtEnd.TabIndex = 11;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(319, 84);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(34, 16);
            this.lblEnd.TabIndex = 10;
            this.lblEnd.Text = "End:";
            // 
            // btnConcatenateList
            // 
            this.btnConcatenateList.Location = new System.Drawing.Point(633, 76);
            this.btnConcatenateList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConcatenateList.Name = "btnConcatenateList";
            this.btnConcatenateList.Size = new System.Drawing.Size(129, 31);
            this.btnConcatenateList.TabIndex = 12;
            this.btnConcatenateList.Text = "Concatenate List";
            this.btnConcatenateList.UseVisualStyleBackColor = true;
            this.btnConcatenateList.Click += new System.EventHandler(this.BtnConcatenateListClick);
            // 
            // btnConcatenateReplaceList
            // 
            this.btnConcatenateReplaceList.Location = new System.Drawing.Point(289, 9);
            this.btnConcatenateReplaceList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConcatenateReplaceList.Name = "btnConcatenateReplaceList";
            this.btnConcatenateReplaceList.Size = new System.Drawing.Size(223, 31);
            this.btnConcatenateReplaceList.TabIndex = 13;
            this.btnConcatenateReplaceList.Text = "Concatenate and Replace List";
            this.btnConcatenateReplaceList.UseVisualStyleBackColor = true;
            this.btnConcatenateReplaceList.Click += new System.EventHandler(this.BtnConcatenateReplaceListClick);
            // 
            // txtTemplate
            // 
            this.txtTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTemplate.Location = new System.Drawing.Point(7, 25);
            this.txtTemplate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTemplate.Multiline = true;
            this.txtTemplate.Name = "txtTemplate";
            this.txtTemplate.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTemplate.Size = new System.Drawing.Size(949, 228);
            this.txtTemplate.TabIndex = 14;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(9, 9);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(61, 16);
            this.lblInput.TabIndex = 15;
            this.lblInput.Text = "Input List:";
            // 
            // lblTemplate
            // 
            this.lblTemplate.AutoSize = true;
            this.lblTemplate.Location = new System.Drawing.Point(7, 4);
            this.lblTemplate.Name = "lblTemplate";
            this.lblTemplate.Size = new System.Drawing.Size(68, 16);
            this.lblTemplate.TabIndex = 16;
            this.lblTemplate.Text = "Template:";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(7, 598);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(48, 16);
            this.lblOutput.TabIndex = 17;
            this.lblOutput.Text = "Output:";
            // 
            // btnSortByAz
            // 
            this.btnSortByAz.Location = new System.Drawing.Point(15, 555);
            this.btnSortByAz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSortByAz.Name = "btnSortByAz";
            this.btnSortByAz.Size = new System.Drawing.Size(139, 31);
            this.btnSortByAz.TabIndex = 18;
            this.btnSortByAz.Text = "Sort Output by AZ";
            this.btnSortByAz.UseVisualStyleBackColor = true;
            this.btnSortByAz.Click += new System.EventHandler(this.BtnSortByAzClick);
            // 
            // btnSortByZa
            // 
            this.btnSortByZa.Location = new System.Drawing.Point(159, 555);
            this.btnSortByZa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSortByZa.Name = "btnSortByZa";
            this.btnSortByZa.Size = new System.Drawing.Size(137, 31);
            this.btnSortByZa.TabIndex = 19;
            this.btnSortByZa.Text = "Sort Output by ZA";
            this.btnSortByZa.UseVisualStyleBackColor = true;
            this.btnSortByZa.Click += new System.EventHandler(this.BtnSortByZaClick);
            // 
            // btnSetOutToIn
            // 
            this.btnSetOutToIn.Location = new System.Drawing.Point(567, 555);
            this.btnSetOutToIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSetOutToIn.Name = "btnSetOutToIn";
            this.btnSetOutToIn.Size = new System.Drawing.Size(141, 31);
            this.btnSetOutToIn.TabIndex = 20;
            this.btnSetOutToIn.Text = "Set Output to Input";
            this.btnSetOutToIn.UseVisualStyleBackColor = true;
            this.btnSetOutToIn.Click += new System.EventHandler(this.BtnSetOutToIn_Click);
            // 
            // btnSetOutToClipboard
            // 
            this.btnSetOutToClipboard.Location = new System.Drawing.Point(713, 555);
            this.btnSetOutToClipboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSetOutToClipboard.Name = "btnSetOutToClipboard";
            this.btnSetOutToClipboard.Size = new System.Drawing.Size(169, 31);
            this.btnSetOutToClipboard.TabIndex = 21;
            this.btnSetOutToClipboard.Text = "Set Output to Clipboard";
            this.btnSetOutToClipboard.UseVisualStyleBackColor = true;
            this.btnSetOutToClipboard.Click += new System.EventHandler(this.BtnSetOutToClipboard_Click);
            // 
            // btnSplitReplaceList
            // 
            this.btnSplitReplaceList.Location = new System.Drawing.Point(715, 9);
            this.btnSplitReplaceList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSplitReplaceList.Name = "btnSplitReplaceList";
            this.btnSplitReplaceList.Size = new System.Drawing.Size(163, 31);
            this.btnSplitReplaceList.TabIndex = 22;
            this.btnSplitReplaceList.Text = "Split Replace List";
            this.btnSplitReplaceList.UseVisualStyleBackColor = true;
            this.btnSplitReplaceList.Click += new System.EventHandler(this.BtnSplitReplaceList_Click);
            // 
            // lblInnerSaparator
            // 
            this.lblInnerSaparator.AutoSize = true;
            this.lblInnerSaparator.Location = new System.Drawing.Point(539, 16);
            this.lblInnerSaparator.Name = "lblInnerSaparator";
            this.lblInnerSaparator.Size = new System.Drawing.Size(102, 16);
            this.lblInnerSaparator.TabIndex = 24;
            this.lblInnerSaparator.Text = "Inner Separator:";
            // 
            // txtInnerSeparator
            // 
            this.txtInnerSeparator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInnerSeparator.Location = new System.Drawing.Point(655, 12);
            this.txtInnerSeparator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInnerSeparator.Name = "txtInnerSeparator";
            this.txtInnerSeparator.Size = new System.Drawing.Size(47, 20);
            this.txtInnerSeparator.TabIndex = 23;
            this.txtInnerSeparator.Text = ";";
            // 
            // btnPropertiesToInstace
            // 
            this.btnPropertiesToInstace.Location = new System.Drawing.Point(381, 209);
            this.btnPropertiesToInstace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPropertiesToInstace.Name = "btnPropertiesToInstace";
            this.btnPropertiesToInstace.Size = new System.Drawing.Size(197, 31);
            this.btnPropertiesToInstace.TabIndex = 25;
            this.btnPropertiesToInstace.Text = "Properties To Instace";
            this.btnPropertiesToInstace.UseVisualStyleBackColor = true;
            this.btnPropertiesToInstace.Click += new System.EventHandler(this.BtnPropertiesToInstace_Click);
            // 
            // lblVariableName
            // 
            this.lblVariableName.AutoSize = true;
            this.lblVariableName.Location = new System.Drawing.Point(18, 217);
            this.lblVariableName.Name = "lblVariableName";
            this.lblVariableName.Size = new System.Drawing.Size(101, 16);
            this.lblVariableName.TabIndex = 27;
            this.lblVariableName.Text = "Variable Name:";
            // 
            // txtVariableName
            // 
            this.txtVariableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVariableName.Location = new System.Drawing.Point(129, 213);
            this.txtVariableName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVariableName.Name = "txtVariableName";
            this.txtVariableName.Size = new System.Drawing.Size(67, 20);
            this.txtVariableName.TabIndex = 26;
            this.txtVariableName.Text = "obj";
            // 
            // lblTypeName
            // 
            this.lblTypeName.AutoSize = true;
            this.lblTypeName.Location = new System.Drawing.Point(202, 217);
            this.lblTypeName.Name = "lblTypeName";
            this.lblTypeName.Size = new System.Drawing.Size(82, 16);
            this.lblTypeName.TabIndex = 29;
            this.lblTypeName.Text = "Type Name:";
            // 
            // txtTypeName
            // 
            this.txtTypeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeName.Location = new System.Drawing.Point(294, 213);
            this.txtTypeName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(67, 20);
            this.txtTypeName.TabIndex = 28;
            this.txtTypeName.Text = "Entity";
            // 
            // btnPropertiesToAssignment
            // 
            this.btnPropertiesToAssignment.Location = new System.Drawing.Point(584, 209);
            this.btnPropertiesToAssignment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPropertiesToAssignment.Name = "btnPropertiesToAssignment";
            this.btnPropertiesToAssignment.Size = new System.Drawing.Size(197, 31);
            this.btnPropertiesToAssignment.TabIndex = 30;
            this.btnPropertiesToAssignment.Text = "Properties To Assignment";
            this.btnPropertiesToAssignment.UseVisualStyleBackColor = true;
            this.btnPropertiesToAssignment.Click += new System.EventHandler(this.btnPropertiesToAssignment_Click);
            // 
            // tcOptions
            // 
            this.tcOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcOptions.Controls.Add(this.tpReplace);
            this.tcOptions.Controls.Add(this.tpTemplate);
            this.tcOptions.Controls.Add(this.tpToken);
            this.tcOptions.Controls.Add(this.tpLoadList);
            this.tcOptions.Controls.Add(this.tpAction);
            this.tcOptions.Location = new System.Drawing.Point(13, 245);
            this.tcOptions.Margin = new System.Windows.Forms.Padding(4);
            this.tcOptions.Name = "tcOptions";
            this.tcOptions.SelectedIndex = 0;
            this.tcOptions.Size = new System.Drawing.Size(971, 304);
            this.tcOptions.TabIndex = 31;
            // 
            // tpReplace
            // 
            this.tpReplace.Controls.Add(this.label1);
            this.tpReplace.Controls.Add(this.btnReplicate);
            this.tpReplace.Controls.Add(this.lblQuantityReplicate);
            this.tpReplace.Controls.Add(this.txtQuantityReplicate);
            this.tpReplace.Controls.Add(this.btnConcatenateReplaceList);
            this.tpReplace.Controls.Add(this.btnReplaceList);
            this.tpReplace.Controls.Add(this.txtSeparator);
            this.tpReplace.Controls.Add(this.lblSeparator);
            this.tpReplace.Controls.Add(this.btnConcatenateList);
            this.tpReplace.Controls.Add(this.txtEnd);
            this.tpReplace.Controls.Add(this.lblEnd);
            this.tpReplace.Controls.Add(this.txtStart);
            this.tpReplace.Controls.Add(this.lblStat);
            this.tpReplace.Controls.Add(this.lblInnerSaparator);
            this.tpReplace.Controls.Add(this.btnSplitReplaceList);
            this.tpReplace.Controls.Add(this.txtInnerSeparator);
            this.tpReplace.Location = new System.Drawing.Point(4, 25);
            this.tpReplace.Margin = new System.Windows.Forms.Padding(4);
            this.tpReplace.Name = "tpReplace";
            this.tpReplace.Padding = new System.Windows.Forms.Padding(4);
            this.tpReplace.Size = new System.Drawing.Size(963, 275);
            this.tpReplace.TabIndex = 0;
            this.tpReplace.Text = "Options";
            this.tpReplace.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 207);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Use [N] to contact the index and [C] matches it in character";
            // 
            // btnReplicate
            // 
            this.btnReplicate.Location = new System.Drawing.Point(304, 175);
            this.btnReplicate.Margin = new System.Windows.Forms.Padding(4);
            this.btnReplicate.Name = "btnReplicate";
            this.btnReplicate.Size = new System.Drawing.Size(100, 28);
            this.btnReplicate.TabIndex = 33;
            this.btnReplicate.Text = "Replicate";
            this.btnReplicate.UseVisualStyleBackColor = true;
            this.btnReplicate.Click += new System.EventHandler(this.btnReplicate_Click);
            // 
            // lblQuantityReplicate
            // 
            this.lblQuantityReplicate.AutoSize = true;
            this.lblQuantityReplicate.Location = new System.Drawing.Point(13, 182);
            this.lblQuantityReplicate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantityReplicate.Name = "lblQuantityReplicate";
            this.lblQuantityReplicate.Size = new System.Drawing.Size(130, 16);
            this.lblQuantityReplicate.TabIndex = 32;
            this.lblQuantityReplicate.Text = "Quantity to Replicate";
            // 
            // txtQuantityReplicate
            // 
            this.txtQuantityReplicate.Location = new System.Drawing.Point(163, 178);
            this.txtQuantityReplicate.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantityReplicate.Name = "txtQuantityReplicate";
            this.txtQuantityReplicate.Size = new System.Drawing.Size(132, 22);
            this.txtQuantityReplicate.TabIndex = 31;
            // 
            // tpTemplate
            // 
            this.tpTemplate.Controls.Add(this.lblTemplate);
            this.tpTemplate.Controls.Add(this.txtTemplate);
            this.tpTemplate.Location = new System.Drawing.Point(4, 25);
            this.tpTemplate.Margin = new System.Windows.Forms.Padding(4);
            this.tpTemplate.Name = "tpTemplate";
            this.tpTemplate.Padding = new System.Windows.Forms.Padding(4);
            this.tpTemplate.Size = new System.Drawing.Size(963, 275);
            this.tpTemplate.TabIndex = 1;
            this.tpTemplate.Text = "Template";
            this.tpTemplate.UseVisualStyleBackColor = true;
            // 
            // tpToken
            // 
            this.tpToken.Controls.Add(this.lbTokens);
            this.tpToken.Controls.Add(this.btnLoadTokens);
            this.tpToken.Controls.Add(this.btnClearTokens);
            this.tpToken.Controls.Add(this.lblTokensInfo);
            this.tpToken.Controls.Add(this.btnDeleteToken);
            this.tpToken.Controls.Add(this.btnAddToken);
            this.tpToken.Controls.Add(this.txtReplaceToken);
            this.tpToken.Controls.Add(this.label2);
            this.tpToken.Location = new System.Drawing.Point(4, 25);
            this.tpToken.Margin = new System.Windows.Forms.Padding(4);
            this.tpToken.Name = "tpToken";
            this.tpToken.Padding = new System.Windows.Forms.Padding(4);
            this.tpToken.Size = new System.Drawing.Size(963, 275);
            this.tpToken.TabIndex = 2;
            this.tpToken.Text = "Tokens";
            this.tpToken.UseVisualStyleBackColor = true;
            // 
            // lbTokens
            // 
            this.lbTokens.FormattingEnabled = true;
            this.lbTokens.ItemHeight = 16;
            this.lbTokens.Location = new System.Drawing.Point(16, 66);
            this.lbTokens.Margin = new System.Windows.Forms.Padding(4);
            this.lbTokens.Name = "lbTokens";
            this.lbTokens.ScrollAlwaysVisible = true;
            this.lbTokens.Size = new System.Drawing.Size(704, 148);
            this.lbTokens.TabIndex = 23;
            // 
            // btnLoadTokens
            // 
            this.btnLoadTokens.Location = new System.Drawing.Point(729, 105);
            this.btnLoadTokens.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadTokens.Name = "btnLoadTokens";
            this.btnLoadTokens.Size = new System.Drawing.Size(80, 28);
            this.btnLoadTokens.TabIndex = 22;
            this.btnLoadTokens.Text = "Load";
            this.btnLoadTokens.UseVisualStyleBackColor = true;
            this.btnLoadTokens.Click += new System.EventHandler(this.btnLoadTokens_Click);
            // 
            // btnClearTokens
            // 
            this.btnClearTokens.Location = new System.Drawing.Point(729, 69);
            this.btnClearTokens.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearTokens.Name = "btnClearTokens";
            this.btnClearTokens.Size = new System.Drawing.Size(80, 28);
            this.btnClearTokens.TabIndex = 21;
            this.btnClearTokens.Text = "Clear";
            this.btnClearTokens.UseVisualStyleBackColor = true;
            this.btnClearTokens.Click += new System.EventHandler(this.btnClearTokens_Click);
            // 
            // lblTokensInfo
            // 
            this.lblTokensInfo.AutoSize = true;
            this.lblTokensInfo.Location = new System.Drawing.Point(12, 219);
            this.lblTokensInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTokensInfo.Name = "lblTokensInfo";
            this.lblTokensInfo.Size = new System.Drawing.Size(687, 32);
            this.lblTokensInfo.TabIndex = 20;
            this.lblTokensInfo.Text = "The tokens are used by the index of the corresponding position in the data line, " +
    "first token for the first item and so on; \r\nTo delete select from the list and u" +
    "se the button";
            // 
            // btnDeleteToken
            // 
            this.btnDeleteToken.Location = new System.Drawing.Point(729, 182);
            this.btnDeleteToken.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteToken.Name = "btnDeleteToken";
            this.btnDeleteToken.Size = new System.Drawing.Size(80, 28);
            this.btnDeleteToken.TabIndex = 19;
            this.btnDeleteToken.Text = "Delete";
            this.btnDeleteToken.UseVisualStyleBackColor = true;
            this.btnDeleteToken.Click += new System.EventHandler(this.btnDeleteToken_Click);
            // 
            // btnAddToken
            // 
            this.btnAddToken.Location = new System.Drawing.Point(253, 33);
            this.btnAddToken.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddToken.Name = "btnAddToken";
            this.btnAddToken.Size = new System.Drawing.Size(60, 28);
            this.btnAddToken.TabIndex = 17;
            this.btnAddToken.Text = "Add";
            this.btnAddToken.UseVisualStyleBackColor = true;
            this.btnAddToken.Click += new System.EventHandler(this.btnAddToken_Click);
            // 
            // tpLoadList
            // 
            this.tpLoadList.Controls.Add(this.llInfo);
            this.tpLoadList.Controls.Add(this.btnParserJson);
            this.tpLoadList.Controls.Add(this.txtXmlSelect);
            this.tpLoadList.Controls.Add(this.lblXmlSelect);
            this.tpLoadList.Controls.Add(this.txtJsonSelect);
            this.tpLoadList.Controls.Add(this.lblJsonSelect);
            this.tpLoadList.Controls.Add(this.btnLoadListXml);
            this.tpLoadList.Controls.Add(this.txtPathXml);
            this.tpLoadList.Controls.Add(this.lblPathXml);
            this.tpLoadList.Controls.Add(this.btnLoadListJson);
            this.tpLoadList.Controls.Add(this.txtPathJson);
            this.tpLoadList.Controls.Add(this.lblPathJson);
            this.tpLoadList.Controls.Add(this.btnLoadCsv);
            this.tpLoadList.Controls.Add(this.txtPathCsv);
            this.tpLoadList.Controls.Add(this.lblPathCsv);
            this.tpLoadList.Location = new System.Drawing.Point(4, 25);
            this.tpLoadList.Margin = new System.Windows.Forms.Padding(4);
            this.tpLoadList.Name = "tpLoadList";
            this.tpLoadList.Padding = new System.Windows.Forms.Padding(4);
            this.tpLoadList.Size = new System.Drawing.Size(963, 275);
            this.tpLoadList.TabIndex = 3;
            this.tpLoadList.Text = "Load List";
            this.tpLoadList.UseVisualStyleBackColor = true;
            // 
            // llInfo
            // 
            this.llInfo.AutoSize = true;
            this.llInfo.Location = new System.Drawing.Point(12, 133);
            this.llInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llInfo.Name = "llInfo";
            this.llInfo.Size = new System.Drawing.Size(360, 16);
            this.llInfo.TabIndex = 36;
            this.llInfo.TabStop = true;
            this.llInfo.Text = "https://www.newtonsoft.com/json/help/html/SelectToken.htm";
            this.llInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llInfo_LinkClicked);
            // 
            // btnParserJson
            // 
            this.btnParserJson.Location = new System.Drawing.Point(656, 102);
            this.btnParserJson.Margin = new System.Windows.Forms.Padding(4);
            this.btnParserJson.Name = "btnParserJson";
            this.btnParserJson.Size = new System.Drawing.Size(100, 28);
            this.btnParserJson.TabIndex = 35;
            this.btnParserJson.Text = "Parser Json";
            this.btnParserJson.UseVisualStyleBackColor = true;
            this.btnParserJson.Click += new System.EventHandler(this.btnParserJson_Click);
            // 
            // txtXmlSelect
            // 
            this.txtXmlSelect.Location = new System.Drawing.Point(115, 215);
            this.txtXmlSelect.Margin = new System.Windows.Forms.Padding(4);
            this.txtXmlSelect.Name = "txtXmlSelect";
            this.txtXmlSelect.Size = new System.Drawing.Size(532, 22);
            this.txtXmlSelect.TabIndex = 12;
            // 
            // lblXmlSelect
            // 
            this.lblXmlSelect.AutoSize = true;
            this.lblXmlSelect.Location = new System.Drawing.Point(12, 219);
            this.lblXmlSelect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblXmlSelect.Name = "lblXmlSelect";
            this.lblXmlSelect.Size = new System.Drawing.Size(77, 16);
            this.lblXmlSelect.TabIndex = 11;
            this.lblXmlSelect.Text = "XML Select:";
            // 
            // txtJsonSelect
            // 
            this.txtJsonSelect.Location = new System.Drawing.Point(115, 105);
            this.txtJsonSelect.Margin = new System.Windows.Forms.Padding(4);
            this.txtJsonSelect.Name = "txtJsonSelect";
            this.txtJsonSelect.Size = new System.Drawing.Size(532, 22);
            this.txtJsonSelect.TabIndex = 10;
            // 
            // lblJsonSelect
            // 
            this.lblJsonSelect.AutoSize = true;
            this.lblJsonSelect.Location = new System.Drawing.Point(12, 108);
            this.lblJsonSelect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJsonSelect.Name = "lblJsonSelect";
            this.lblJsonSelect.Size = new System.Drawing.Size(87, 16);
            this.lblJsonSelect.TabIndex = 9;
            this.lblJsonSelect.Text = "JSON Select:";
            // 
            // btnLoadListXml
            // 
            this.btnLoadListXml.Location = new System.Drawing.Point(656, 181);
            this.btnLoadListXml.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadListXml.Name = "btnLoadListXml";
            this.btnLoadListXml.Size = new System.Drawing.Size(100, 28);
            this.btnLoadListXml.TabIndex = 8;
            this.btnLoadListXml.Text = "Load XML";
            this.btnLoadListXml.UseVisualStyleBackColor = true;
            this.btnLoadListXml.Click += new System.EventHandler(this.btnLoadListXml_Click);
            // 
            // txtPathXml
            // 
            this.txtPathXml.Location = new System.Drawing.Point(92, 183);
            this.txtPathXml.Margin = new System.Windows.Forms.Padding(4);
            this.txtPathXml.Name = "txtPathXml";
            this.txtPathXml.Size = new System.Drawing.Size(555, 22);
            this.txtPathXml.TabIndex = 7;
            // 
            // lblPathXml
            // 
            this.lblPathXml.AutoSize = true;
            this.lblPathXml.Location = new System.Drawing.Point(9, 187);
            this.lblPathXml.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPathXml.Name = "lblPathXml";
            this.lblPathXml.Size = new System.Drawing.Size(66, 16);
            this.lblPathXml.TabIndex = 6;
            this.lblPathXml.Text = "Path XML:";
            // 
            // btnLoadListJson
            // 
            this.btnLoadListJson.Location = new System.Drawing.Point(656, 66);
            this.btnLoadListJson.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadListJson.Name = "btnLoadListJson";
            this.btnLoadListJson.Size = new System.Drawing.Size(100, 28);
            this.btnLoadListJson.TabIndex = 5;
            this.btnLoadListJson.Text = "Load JSON";
            this.btnLoadListJson.UseVisualStyleBackColor = true;
            this.btnLoadListJson.Click += new System.EventHandler(this.btnLoadListJson_Click);
            // 
            // txtPathJson
            // 
            this.txtPathJson.Location = new System.Drawing.Point(92, 73);
            this.txtPathJson.Margin = new System.Windows.Forms.Padding(4);
            this.txtPathJson.Name = "txtPathJson";
            this.txtPathJson.Size = new System.Drawing.Size(555, 22);
            this.txtPathJson.TabIndex = 4;
            // 
            // lblPathJson
            // 
            this.lblPathJson.AutoSize = true;
            this.lblPathJson.Location = new System.Drawing.Point(9, 76);
            this.lblPathJson.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPathJson.Name = "lblPathJson";
            this.lblPathJson.Size = new System.Drawing.Size(76, 16);
            this.lblPathJson.TabIndex = 3;
            this.lblPathJson.Text = "Path JSON:";
            // 
            // btnLoadCsv
            // 
            this.btnLoadCsv.Location = new System.Drawing.Point(656, 18);
            this.btnLoadCsv.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadCsv.Name = "btnLoadCsv";
            this.btnLoadCsv.Size = new System.Drawing.Size(100, 28);
            this.btnLoadCsv.TabIndex = 2;
            this.btnLoadCsv.Text = "Load CSV";
            this.btnLoadCsv.UseVisualStyleBackColor = true;
            this.btnLoadCsv.Click += new System.EventHandler(this.btnLoadCsv_Click);
            // 
            // txtPathCsv
            // 
            this.txtPathCsv.Location = new System.Drawing.Point(92, 21);
            this.txtPathCsv.Margin = new System.Windows.Forms.Padding(4);
            this.txtPathCsv.Name = "txtPathCsv";
            this.txtPathCsv.Size = new System.Drawing.Size(555, 22);
            this.txtPathCsv.TabIndex = 1;
            // 
            // lblPathCsv
            // 
            this.lblPathCsv.AutoSize = true;
            this.lblPathCsv.Location = new System.Drawing.Point(9, 25);
            this.lblPathCsv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPathCsv.Name = "lblPathCsv";
            this.lblPathCsv.Size = new System.Drawing.Size(67, 16);
            this.lblPathCsv.TabIndex = 0;
            this.lblPathCsv.Text = "Path CSV:";
            // 
            // tpAction
            // 
            this.tpAction.Controls.Add(this.txtClassName);
            this.tpAction.Controls.Add(this.lblClassName);
            this.tpAction.Controls.Add(this.btnClassToMap);
            this.tpAction.Controls.Add(this.btnPropertiesToListWithText);
            this.tpAction.Controls.Add(this.btnCheckSqlInsert);
            this.tpAction.Controls.Add(this.lblTypeName);
            this.tpAction.Controls.Add(this.btnJsonToClass);
            this.tpAction.Controls.Add(this.btnPropertiesToList);
            this.tpAction.Controls.Add(this.btnPropertiesToAssignment);
            this.tpAction.Controls.Add(this.btnTableSqlToClass);
            this.tpAction.Controls.Add(this.txtTypeName);
            this.tpAction.Controls.Add(this.btnPropertiesToInstace);
            this.tpAction.Controls.Add(this.txtVariableName);
            this.tpAction.Controls.Add(this.lblVariableName);
            this.tpAction.Location = new System.Drawing.Point(4, 25);
            this.tpAction.Name = "tpAction";
            this.tpAction.Padding = new System.Windows.Forms.Padding(3);
            this.tpAction.Size = new System.Drawing.Size(963, 275);
            this.tpAction.TabIndex = 4;
            this.tpAction.Text = "Custom Actions";
            this.tpAction.UseVisualStyleBackColor = true;
            // 
            // txtClassName
            // 
            this.txtClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassName.Location = new System.Drawing.Point(300, 138);
            this.txtClassName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(126, 20);
            this.txtClassName.TabIndex = 35;
            this.txtClassName.Text = "Class1";
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Location = new System.Drawing.Point(210, 139);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(84, 16);
            this.lblClassName.TabIndex = 36;
            this.lblClassName.Text = "Class Name:";
            // 
            // btnClassToMap
            // 
            this.btnClassToMap.Location = new System.Drawing.Point(26, 132);
            this.btnClassToMap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClassToMap.Name = "btnClassToMap";
            this.btnClassToMap.Size = new System.Drawing.Size(163, 31);
            this.btnClassToMap.TabIndex = 40;
            this.btnClassToMap.Text = "Class To EF Map";
            this.btnClassToMap.UseVisualStyleBackColor = true;
            this.btnClassToMap.Click += new System.EventHandler(this.btnClassToMap_Click);
            // 
            // btnPropertiesToListWithText
            // 
            this.btnPropertiesToListWithText.Location = new System.Drawing.Point(507, 24);
            this.btnPropertiesToListWithText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPropertiesToListWithText.Name = "btnPropertiesToListWithText";
            this.btnPropertiesToListWithText.Size = new System.Drawing.Size(247, 31);
            this.btnPropertiesToListWithText.TabIndex = 37;
            this.btnPropertiesToListWithText.Text = "Properties To List With Text";
            this.btnPropertiesToListWithText.UseVisualStyleBackColor = true;
            this.btnPropertiesToListWithText.Click += new System.EventHandler(this.btnPropertiesToListWithText_Click);
            // 
            // btnCheckSqlInsert
            // 
            this.btnCheckSqlInsert.Location = new System.Drawing.Point(26, 76);
            this.btnCheckSqlInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheckSqlInsert.Name = "btnCheckSqlInsert";
            this.btnCheckSqlInsert.Size = new System.Drawing.Size(163, 31);
            this.btnCheckSqlInsert.TabIndex = 35;
            this.btnCheckSqlInsert.Text = "Check Sql Insert";
            this.btnCheckSqlInsert.UseVisualStyleBackColor = true;
            this.btnCheckSqlInsert.Click += new System.EventHandler(this.btnCheckSqlInsert_Click);
            // 
            // btnJsonToClass
            // 
            this.btnJsonToClass.Location = new System.Drawing.Point(195, 24);
            this.btnJsonToClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJsonToClass.Name = "btnJsonToClass";
            this.btnJsonToClass.Size = new System.Drawing.Size(196, 31);
            this.btnJsonToClass.TabIndex = 38;
            this.btnJsonToClass.Text = "JSON To Class";
            this.btnJsonToClass.UseVisualStyleBackColor = true;
            this.btnJsonToClass.Click += new System.EventHandler(this.btnJsonToClass_Click);
            // 
            // btnPropertiesToList
            // 
            this.btnPropertiesToList.Location = new System.Drawing.Point(760, 24);
            this.btnPropertiesToList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPropertiesToList.Name = "btnPropertiesToList";
            this.btnPropertiesToList.Size = new System.Drawing.Size(197, 31);
            this.btnPropertiesToList.TabIndex = 36;
            this.btnPropertiesToList.Text = "Properties To List";
            this.btnPropertiesToList.UseVisualStyleBackColor = true;
            this.btnPropertiesToList.Click += new System.EventHandler(this.btnPropertiesToList_Click);
            // 
            // btnTableSqlToClass
            // 
            this.btnTableSqlToClass.Location = new System.Drawing.Point(26, 24);
            this.btnTableSqlToClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTableSqlToClass.Name = "btnTableSqlToClass";
            this.btnTableSqlToClass.Size = new System.Drawing.Size(163, 31);
            this.btnTableSqlToClass.TabIndex = 39;
            this.btnTableSqlToClass.Text = "Table To Class";
            this.btnTableSqlToClass.UseVisualStyleBackColor = true;
            this.btnTableSqlToClass.Click += new System.EventHandler(this.btnTableSqlToClass_Click);
            // 
            // btnSortInputByZa
            // 
            this.btnSortInputByZa.Location = new System.Drawing.Point(436, 555);
            this.btnSortInputByZa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSortInputByZa.Name = "btnSortInputByZa";
            this.btnSortInputByZa.Size = new System.Drawing.Size(125, 31);
            this.btnSortInputByZa.TabIndex = 33;
            this.btnSortInputByZa.Text = "Sort Input by ZA";
            this.btnSortInputByZa.UseVisualStyleBackColor = true;
            this.btnSortInputByZa.Click += new System.EventHandler(this.btnSortInputByZa_Click);
            // 
            // btnSortInputByAz
            // 
            this.btnSortInputByAz.Location = new System.Drawing.Point(301, 555);
            this.btnSortInputByAz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSortInputByAz.Name = "btnSortInputByAz";
            this.btnSortInputByAz.Size = new System.Drawing.Size(129, 31);
            this.btnSortInputByAz.TabIndex = 32;
            this.btnSortInputByAz.Text = "Sort Input by AZ";
            this.btnSortInputByAz.UseVisualStyleBackColor = true;
            this.btnSortInputByAz.Click += new System.EventHandler(this.btnSortInputByAz_Click);
            // 
            // FrmText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 827);
            this.Controls.Add(this.btnSortInputByZa);
            this.Controls.Add(this.btnSortInputByAz);
            this.Controls.Add(this.tcOptions);
            this.Controls.Add(this.btnSetOutToClipboard);
            this.Controls.Add(this.btnSetOutToIn);
            this.Controls.Add(this.btnSortByZa);
            this.Controls.Add(this.btnSortByAz);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmText";
            this.Text = resources.GetString("$this.Text");
            this.tcOptions.ResumeLayout(false);
            this.tpReplace.ResumeLayout(false);
            this.tpReplace.PerformLayout();
            this.tpTemplate.ResumeLayout(false);
            this.tpTemplate.PerformLayout();
            this.tpToken.ResumeLayout(false);
            this.tpToken.PerformLayout();
            this.tpLoadList.ResumeLayout(false);
            this.tpLoadList.PerformLayout();
            this.tpAction.ResumeLayout(false);
            this.tpAction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

