﻿namespace GB_lesson_forms
{
	partial class MainForm
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
			this.MainMenu = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.notepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.insertDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.insertTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.counterLabel = new System.Windows.Forms.Label();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnMinus = new System.Windows.Forms.Button();
			this.btnPlus = new System.Windows.Forms.Button();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.generatorHistory = new System.Windows.Forms.TextBox();
			this.generatorUniques = new System.Windows.Forms.TextBox();
			this.genBtnCopy = new System.Windows.Forms.Button();
			this.genbtnClear = new System.Windows.Forms.Button();
			this.udGenMin = new System.Windows.Forms.NumericUpDown();
			this.udGenMax = new System.Windows.Forms.NumericUpDown();
			this.generatorLabel = new System.Windows.Forms.Label();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.notepad = new System.Windows.Forms.RichTextBox();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.pwgenOpts = new System.Windows.Forms.CheckedListBox();
			this.pwgenLen = new System.Windows.Forms.NumericUpDown();
			this.pwgenPass = new System.Windows.Forms.TextBox();
			this.pwgenBtnDo = new System.Windows.Forms.Button();
			this.convFromCombo = new System.Windows.Forms.ComboBox();
			this.convToCombo = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.convTextFrom = new System.Windows.Forms.TextBox();
			this.convTextTo = new System.Windows.Forms.TextBox();
			this.convButtonGo = new System.Windows.Forms.Button();
			this.convBtnSwap = new System.Windows.Forms.Button();
			this.convType = new System.Windows.Forms.ComboBox();
			this.MainMenu.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.udGenMin)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.udGenMax)).BeginInit();
			this.tabPage3.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.tabPage5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pwgenLen)).BeginInit();
			this.SuspendLayout();
			// 
			// MainMenu
			// 
			this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.notepadToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.MainMenu.Location = new System.Drawing.Point(0, 0);
			this.MainMenu.Name = "MainMenu";
			this.MainMenu.Size = new System.Drawing.Size(506, 24);
			this.MainMenu.TabIndex = 0;
			this.MainMenu.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// notepadToolStripMenuItem
			// 
			this.notepadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertDateToolStripMenuItem,
            this.insertTimeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
			this.notepadToolStripMenuItem.Name = "notepadToolStripMenuItem";
			this.notepadToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
			this.notepadToolStripMenuItem.Text = "Notepad";
			// 
			// insertDateToolStripMenuItem
			// 
			this.insertDateToolStripMenuItem.Name = "insertDateToolStripMenuItem";
			this.insertDateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
			this.insertDateToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
			this.insertDateToolStripMenuItem.Text = "Insert Date";
			this.insertDateToolStripMenuItem.Click += new System.EventHandler(this.insertDateToolStripMenuItem_Click);
			// 
			// insertTimeToolStripMenuItem
			// 
			this.insertTimeToolStripMenuItem.Name = "insertTimeToolStripMenuItem";
			this.insertTimeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
			this.insertTimeToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
			this.insertTimeToolStripMenuItem.Text = "Insert Time";
			this.insertTimeToolStripMenuItem.Click += new System.EventHandler(this.insertTimeToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.aboutToolStripMenuItem.Text = "About...";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Controls.Add(this.tabPage5);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 24);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(506, 301);
			this.tabControl1.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.counterLabel);
			this.tabPage1.Controls.Add(this.btnReset);
			this.tabPage1.Controls.Add(this.btnMinus);
			this.tabPage1.Controls.Add(this.btnPlus);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(498, 275);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Counter";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// counterLabel
			// 
			this.counterLabel.AutoSize = true;
			this.counterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.counterLabel.Location = new System.Drawing.Point(126, 15);
			this.counterLabel.Name = "counterLabel";
			this.counterLabel.Size = new System.Drawing.Size(68, 73);
			this.counterLabel.TabIndex = 3;
			this.counterLabel.Text = "0";
			this.counterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(8, 65);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(75, 23);
			this.btnReset.TabIndex = 2;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// btnMinus
			// 
			this.btnMinus.Location = new System.Drawing.Point(8, 35);
			this.btnMinus.Name = "btnMinus";
			this.btnMinus.Size = new System.Drawing.Size(75, 23);
			this.btnMinus.TabIndex = 1;
			this.btnMinus.Text = "-";
			this.btnMinus.UseVisualStyleBackColor = true;
			this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
			// 
			// btnPlus
			// 
			this.btnPlus.Location = new System.Drawing.Point(8, 6);
			this.btnPlus.Name = "btnPlus";
			this.btnPlus.Size = new System.Drawing.Size(75, 23);
			this.btnPlus.TabIndex = 0;
			this.btnPlus.Text = "+";
			this.btnPlus.UseVisualStyleBackColor = true;
			this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.splitContainer1);
			this.tabPage2.Controls.Add(this.genBtnCopy);
			this.tabPage2.Controls.Add(this.genbtnClear);
			this.tabPage2.Controls.Add(this.udGenMin);
			this.tabPage2.Controls.Add(this.udGenMax);
			this.tabPage2.Controls.Add(this.generatorLabel);
			this.tabPage2.Controls.Add(this.btnGenerate);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(498, 275);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Generator";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.IsSplitterFixed = true;
			this.splitContainer1.Location = new System.Drawing.Point(8, 87);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.generatorHistory);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.generatorUniques);
			this.splitContainer1.Size = new System.Drawing.Size(482, 180);
			this.splitContainer1.SplitterDistance = 241;
			this.splitContainer1.TabIndex = 0;
			// 
			// generatorHistory
			// 
			this.generatorHistory.Dock = System.Windows.Forms.DockStyle.Fill;
			this.generatorHistory.Location = new System.Drawing.Point(0, 0);
			this.generatorHistory.Multiline = true;
			this.generatorHistory.Name = "generatorHistory";
			this.generatorHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.generatorHistory.Size = new System.Drawing.Size(241, 180);
			this.generatorHistory.TabIndex = 4;
			// 
			// generatorUniques
			// 
			this.generatorUniques.Dock = System.Windows.Forms.DockStyle.Fill;
			this.generatorUniques.Location = new System.Drawing.Point(0, 0);
			this.generatorUniques.Multiline = true;
			this.generatorUniques.Name = "generatorUniques";
			this.generatorUniques.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.generatorUniques.Size = new System.Drawing.Size(237, 180);
			this.generatorUniques.TabIndex = 7;
			// 
			// genBtnCopy
			// 
			this.genBtnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.genBtnCopy.Location = new System.Drawing.Point(334, 58);
			this.genBtnCopy.Name = "genBtnCopy";
			this.genBtnCopy.Size = new System.Drawing.Size(75, 23);
			this.genBtnCopy.TabIndex = 6;
			this.genBtnCopy.Text = "Copy";
			this.genBtnCopy.UseVisualStyleBackColor = true;
			this.genBtnCopy.Click += new System.EventHandler(this.genBtnCopy_Click);
			// 
			// genbtnClear
			// 
			this.genbtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.genbtnClear.Location = new System.Drawing.Point(415, 58);
			this.genbtnClear.Name = "genbtnClear";
			this.genbtnClear.Size = new System.Drawing.Size(75, 23);
			this.genbtnClear.TabIndex = 5;
			this.genbtnClear.Text = "Reset";
			this.genbtnClear.UseVisualStyleBackColor = true;
			this.genbtnClear.Click += new System.EventHandler(this.genbtnClear_Click);
			// 
			// udGenMin
			// 
			this.udGenMin.Location = new System.Drawing.Point(8, 32);
			this.udGenMin.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
			this.udGenMin.Name = "udGenMin";
			this.udGenMin.Size = new System.Drawing.Size(75, 20);
			this.udGenMin.TabIndex = 3;
			// 
			// udGenMax
			// 
			this.udGenMax.Location = new System.Drawing.Point(8, 6);
			this.udGenMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.udGenMax.Name = "udGenMax";
			this.udGenMax.Size = new System.Drawing.Size(75, 20);
			this.udGenMax.TabIndex = 2;
			this.udGenMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// generatorLabel
			// 
			this.generatorLabel.AutoSize = true;
			this.generatorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.generatorLabel.Location = new System.Drawing.Point(124, 8);
			this.generatorLabel.Name = "generatorLabel";
			this.generatorLabel.Size = new System.Drawing.Size(68, 73);
			this.generatorLabel.TabIndex = 1;
			this.generatorLabel.Text = "0";
			// 
			// btnGenerate
			// 
			this.btnGenerate.Location = new System.Drawing.Point(8, 58);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(75, 23);
			this.btnGenerate.TabIndex = 0;
			this.btnGenerate.Text = "Go";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.convType);
			this.tabPage3.Controls.Add(this.convBtnSwap);
			this.tabPage3.Controls.Add(this.convButtonGo);
			this.tabPage3.Controls.Add(this.convTextTo);
			this.tabPage3.Controls.Add(this.convTextFrom);
			this.tabPage3.Controls.Add(this.label2);
			this.tabPage3.Controls.Add(this.label1);
			this.tabPage3.Controls.Add(this.convToCombo);
			this.tabPage3.Controls.Add(this.convFromCombo);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(498, 275);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Converter";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.notepad);
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(498, 275);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Notepad";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// notepad
			// 
			this.notepad.Dock = System.Windows.Forms.DockStyle.Fill;
			this.notepad.Location = new System.Drawing.Point(0, 0);
			this.notepad.Name = "notepad";
			this.notepad.Size = new System.Drawing.Size(498, 275);
			this.notepad.TabIndex = 0;
			this.notepad.Text = "";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(203, 6);
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.openToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// tabPage5
			// 
			this.tabPage5.Controls.Add(this.pwgenBtnDo);
			this.tabPage5.Controls.Add(this.pwgenPass);
			this.tabPage5.Controls.Add(this.pwgenLen);
			this.tabPage5.Controls.Add(this.pwgenOpts);
			this.tabPage5.Location = new System.Drawing.Point(4, 22);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage5.Size = new System.Drawing.Size(498, 275);
			this.tabPage5.TabIndex = 4;
			this.tabPage5.Text = "Pwgen";
			this.tabPage5.UseVisualStyleBackColor = true;
			// 
			// pwgenOpts
			// 
			this.pwgenOpts.CheckOnClick = true;
			this.pwgenOpts.FormattingEnabled = true;
			this.pwgenOpts.Items.AddRange(new object[] {
            "Numbers",
            "Lowercase",
            "Uppercase",
            "Specials"});
			this.pwgenOpts.Location = new System.Drawing.Point(8, 6);
			this.pwgenOpts.Name = "pwgenOpts";
			this.pwgenOpts.Size = new System.Drawing.Size(124, 64);
			this.pwgenOpts.TabIndex = 0;
			// 
			// pwgenLen
			// 
			this.pwgenLen.Location = new System.Drawing.Point(8, 76);
			this.pwgenLen.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
			this.pwgenLen.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
			this.pwgenLen.Name = "pwgenLen";
			this.pwgenLen.Size = new System.Drawing.Size(124, 20);
			this.pwgenLen.TabIndex = 1;
			this.pwgenLen.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
			// 
			// pwgenPass
			// 
			this.pwgenPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pwgenPass.Location = new System.Drawing.Point(8, 102);
			this.pwgenPass.Name = "pwgenPass";
			this.pwgenPass.Size = new System.Drawing.Size(482, 20);
			this.pwgenPass.TabIndex = 2;
			// 
			// pwgenBtnDo
			// 
			this.pwgenBtnDo.Location = new System.Drawing.Point(138, 6);
			this.pwgenBtnDo.Name = "pwgenBtnDo";
			this.pwgenBtnDo.Size = new System.Drawing.Size(75, 23);
			this.pwgenBtnDo.TabIndex = 3;
			this.pwgenBtnDo.Text = "Go";
			this.pwgenBtnDo.UseVisualStyleBackColor = true;
			this.pwgenBtnDo.Click += new System.EventHandler(this.pwgenBtnDo_Click);
			// 
			// convFromCombo
			// 
			this.convFromCombo.FormattingEnabled = true;
			this.convFromCombo.Items.AddRange(new object[] {
            "mm",
            "cm",
            "dm",
            "m",
            "km",
            "mile"});
			this.convFromCombo.Location = new System.Drawing.Point(47, 3);
			this.convFromCombo.Name = "convFromCombo";
			this.convFromCombo.Size = new System.Drawing.Size(156, 21);
			this.convFromCombo.TabIndex = 0;
			this.convFromCombo.Text = "mm";
			// 
			// convToCombo
			// 
			this.convToCombo.FormattingEnabled = true;
			this.convToCombo.Items.AddRange(new object[] {
            "mm",
            "cm",
            "dm",
            "m",
            "km",
            "mile"});
			this.convToCombo.Location = new System.Drawing.Point(238, 3);
			this.convToCombo.Name = "convToCombo";
			this.convToCombo.Size = new System.Drawing.Size(156, 21);
			this.convToCombo.TabIndex = 1;
			this.convToCombo.Text = "km";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "From:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(209, 6);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(23, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "To:";
			// 
			// convTextFrom
			// 
			this.convTextFrom.Location = new System.Drawing.Point(103, 30);
			this.convTextFrom.Name = "convTextFrom";
			this.convTextFrom.Size = new System.Drawing.Size(100, 20);
			this.convTextFrom.TabIndex = 4;
			this.convTextFrom.Text = "1";
			// 
			// convTextTo
			// 
			this.convTextTo.Location = new System.Drawing.Point(238, 30);
			this.convTextTo.Name = "convTextTo";
			this.convTextTo.ReadOnly = true;
			this.convTextTo.Size = new System.Drawing.Size(100, 20);
			this.convTextTo.TabIndex = 5;
			// 
			// convButtonGo
			// 
			this.convButtonGo.Location = new System.Drawing.Point(238, 56);
			this.convButtonGo.Name = "convButtonGo";
			this.convButtonGo.Size = new System.Drawing.Size(75, 23);
			this.convButtonGo.TabIndex = 6;
			this.convButtonGo.Text = "Go";
			this.convButtonGo.UseVisualStyleBackColor = true;
			this.convButtonGo.Click += new System.EventHandler(this.convButtonGo_Click);
			// 
			// convBtnSwap
			// 
			this.convBtnSwap.Location = new System.Drawing.Point(128, 56);
			this.convBtnSwap.Name = "convBtnSwap";
			this.convBtnSwap.Size = new System.Drawing.Size(75, 23);
			this.convBtnSwap.TabIndex = 7;
			this.convBtnSwap.Text = "Swap";
			this.convBtnSwap.UseVisualStyleBackColor = true;
			this.convBtnSwap.Click += new System.EventHandler(this.convBtnSwap_Click);
			// 
			// convType
			// 
			this.convType.FormattingEnabled = true;
			this.convType.Items.AddRange(new object[] {
            "Length",
            "Weight"});
			this.convType.Location = new System.Drawing.Point(159, 85);
			this.convType.Name = "convType";
			this.convType.Size = new System.Drawing.Size(121, 21);
			this.convType.TabIndex = 8;
			this.convType.Text = "Length";
			this.convType.SelectedIndexChanged += new System.EventHandler(this.convType_SelectedIndexChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(506, 325);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.MainMenu);
			this.MainMenuStrip = this.MainMenu;
			this.Name = "MainForm";
			this.Text = "GB-lesson-forms";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.MainMenu.ResumeLayout(false);
			this.MainMenu.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.udGenMin)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.udGenMax)).EndInit();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.tabPage4.ResumeLayout(false);
			this.tabPage5.ResumeLayout(false);
			this.tabPage5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pwgenLen)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip MainMenu;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.Label counterLabel;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnMinus;
		private System.Windows.Forms.Button btnPlus;
		private System.Windows.Forms.NumericUpDown udGenMin;
		private System.Windows.Forms.NumericUpDown udGenMax;
		private System.Windows.Forms.Label generatorLabel;
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.TextBox generatorHistory;
		private System.Windows.Forms.Button genbtnClear;
		private System.Windows.Forms.Button genBtnCopy;
		private System.Windows.Forms.TextBox generatorUniques;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.RichTextBox notepad;
		private System.Windows.Forms.ToolStripMenuItem notepadToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem insertDateToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem insertTimeToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.TabPage tabPage5;
		private System.Windows.Forms.CheckedListBox pwgenOpts;
		private System.Windows.Forms.NumericUpDown pwgenLen;
		private System.Windows.Forms.Button pwgenBtnDo;
		private System.Windows.Forms.TextBox pwgenPass;
		private System.Windows.Forms.Button convButtonGo;
		private System.Windows.Forms.TextBox convTextTo;
		private System.Windows.Forms.TextBox convTextFrom;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox convToCombo;
		private System.Windows.Forms.ComboBox convFromCombo;
		private System.Windows.Forms.Button convBtnSwap;
		private System.Windows.Forms.ComboBox convType;
	}
}

