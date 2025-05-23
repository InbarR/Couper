﻿using BrightIdeasSoftware;

namespace Couper
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSelectAll = new System.Windows.Forms.ToolStripButton();
            this.btnCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.txtFolder = new System.Windows.Forms.ToolStripTextBox();
            this.lnkFolder = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.txtDays = new System.Windows.Forms.ToolStripTextBox();
            this.btnGo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.lblSum = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsProg = new System.Windows.Forms.ToolStripProgressBar();
            this.tsSync = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lstResults = new BrightIdeasSoftware.ObjectListView();
            this.lstLog = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsOneNote = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.tsNotebook = new System.Windows.Forms.ToolStripTextBox();
            this.lnkOneNote = new System.Windows.Forms.ToolStripLabel();
            this.chkHideUsed = new System.Windows.Forms.CheckBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstResults)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSelectAll,
            this.btnCopy,
            this.toolStripSeparator3,
            this.toolStripLabel4,
            this.txtFolder,
            this.lnkFolder,
            this.toolStripLabel2,
            this.txtDays,
            this.btnGo,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.lblSum,
            this.toolStripLabel3,
            this.toolStripSeparator1,
            this.tsProg});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1537, 38);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectAll.Image")));
            this.btnSelectAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(111, 33);
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Image = global::Couper.Properties.Resources.Copy;
            this.btnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(82, 33);
            this.btnCopy.Text = "Copy";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(104, 33);
            this.toolStripLabel4.Text = "Mail Folder:";
            // 
            // txtFolder
            // 
            this.txtFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFolder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(100, 38);
            this.txtFolder.Text = "Cibus";
            this.txtFolder.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lnkFolder
            // 
            this.lnkFolder.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lnkFolder.IsLink = true;
            this.lnkFolder.Name = "lnkFolder";
            this.lnkFolder.Size = new System.Drawing.Size(20, 33);
            this.lnkFolder.Text = "?";
            this.lnkFolder.Click += new System.EventHandler(this.lnkFolder_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(96, 33);
            this.toolStripLabel2.Text = "Days Back:";
            // 
            // txtDays
            // 
            this.txtDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDays.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(50, 38);
            this.txtDays.Text = "30";
            this.txtDays.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGo
            // 
            this.btnGo.Image = ((System.Drawing.Image)(resources.GetObject("btnGo.Image")));
            this.btnGo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(154, 33);
            this.btnGo.Text = "Go (Enter \\ F5)";
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(52, 33);
            this.toolStripLabel1.Text = "Sum:";
            // 
            // lblSum
            // 
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(22, 33);
            this.lblSum.Text = "0";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(139, 33);
            this.toolStripLabel3.Text = "© Inbar Rotem";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // tsProg
            // 
            this.tsProg.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsProg.Name = "tsProg";
            this.tsProg.Size = new System.Drawing.Size(112, 33);
            // 
            // tsSync
            // 
            this.tsSync.Image = ((System.Drawing.Image)(resources.GetObject("tsSync.Image")));
            this.tsSync.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSync.Name = "tsSync";
            this.tsSync.Size = new System.Drawing.Size(72, 33);
            this.tsSync.Text = "Sync";
            this.tsSync.Click += new System.EventHandler(this.tsSync_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 76);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lstResults);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lstLog);
            this.splitContainer1.Size = new System.Drawing.Size(1537, 554);
            this.splitContainer1.SplitterDistance = 317;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 5;
            // 
            // lstResults
            // 
            this.lstResults.CellEditUseWholeCell = false;
            this.lstResults.CheckBoxes = true;
            this.lstResults.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstResults.GridLines = true;
            this.lstResults.HideSelection = false;
            this.lstResults.Location = new System.Drawing.Point(0, 0);
            this.lstResults.Name = "lstResults";
            this.lstResults.ShowGroups = false;
            this.lstResults.Size = new System.Drawing.Size(1537, 317);
            this.lstResults.TabIndex = 0;
            this.lstResults.UseCompatibleStateImageBehavior = false;
            this.lstResults.View = System.Windows.Forms.View.Details;
            this.lstResults.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lstResults_ItemChecked);
            // 
            // lstLog
            // 
            this.lstLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstLog.GridLines = true;
            this.lstLog.HideSelection = false;
            this.lstLog.Location = new System.Drawing.Point(0, 0);
            this.lstLog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(1537, 232);
            this.lstLog.TabIndex = 0;
            this.lstLog.UseCompatibleStateImageBehavior = false;
            this.lstLog.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Time";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Message";
            this.columnHeader2.Width = 500;
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsOneNote,
            this.toolStripLabel5,
            this.tsNotebook,
            this.tsSync,
            this.lnkOneNote});
            this.toolStrip2.Location = new System.Drawing.Point(0, 38);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1537, 38);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsOneNote
            // 
            this.tsOneNote.Image = ((System.Drawing.Image)(resources.GetObject("tsOneNote.Image")));
            this.tsOneNote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsOneNote.Name = "tsOneNote";
            this.tsOneNote.Size = new System.Drawing.Size(108, 33);
            this.tsOneNote.Text = "OneNote";
            this.tsOneNote.Click += new System.EventHandler(this.tsOneNote_Click);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(97, 33);
            this.toolStripLabel5.Text = "Notebook:";
            // 
            // tsNotebook
            // 
            this.tsNotebook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tsNotebook.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsNotebook.Name = "tsNotebook";
            this.tsNotebook.Size = new System.Drawing.Size(188, 38);
            this.tsNotebook.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lnkOneNote
            // 
            this.lnkOneNote.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lnkOneNote.IsLink = true;
            this.lnkOneNote.Name = "lnkOneNote";
            this.lnkOneNote.Size = new System.Drawing.Size(20, 33);
            this.lnkOneNote.Text = "?";
            this.lnkOneNote.Click += new System.EventHandler(this.lnkOneNote_Click);
            // 
            // chkHideUsed
            // 
            this.chkHideUsed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkHideUsed.AutoSize = true;
            this.chkHideUsed.Location = new System.Drawing.Point(1135, 7);
            this.chkHideUsed.Name = "chkHideUsed";
            this.chkHideUsed.Size = new System.Drawing.Size(110, 24);
            this.chkHideUsed.TabIndex = 6;
            this.chkHideUsed.Text = "Hide Used";
            this.chkHideUsed.UseVisualStyleBackColor = true;
            this.chkHideUsed.CheckedChanged += new System.EventHandler(this.chkHideUsed_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1537, 630);
            this.Controls.Add(this.chkHideUsed);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Couper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstResults)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel lblSum;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox txtDays;
        private System.Windows.Forms.ToolStripButton btnGo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox txtFolder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnSelectAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnCopy;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripButton tsSync;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripTextBox tsNotebook;
        private System.Windows.Forms.ListView lstLog;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ToolStripProgressBar tsProg;
        private System.Windows.Forms.ToolStripLabel lnkOneNote;
        private ObjectListView lstResults;
        private System.Windows.Forms.ToolStripButton tsOneNote;
        private System.Windows.Forms.ToolStripLabel lnkFolder;
        private System.Windows.Forms.CheckBox chkHideUsed;
    }
}

