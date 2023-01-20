
namespace WindowsFormsApp1
{
    partial class TextEditor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.openTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.copyTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newTSBtn = new System.Windows.Forms.ToolStripButton();
            this.openTSBtn = new System.Windows.Forms.ToolStripButton();
            this.saveTSBtn = new System.Windows.Forms.ToolStripButton();
            this.saveAsTSBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.boldTSBtn = new System.Windows.Forms.ToolStripButton();
            this.italicTSBtn = new System.Windows.Forms.ToolStripButton();
            this.underlineTSBtn = new System.Windows.Forms.ToolStripButton();
            this.fontSizeTSCB = new System.Windows.Forms.ToolStripComboBox();
            this.usernameTSL = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.cutLeftTSBtn = new System.Windows.Forms.ToolStripButton();
            this.copyLeftTSBtn = new System.Windows.Forms.ToolStripButton();
            this.pasteLeftTSBtn = new System.Windows.Forms.ToolStripButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.newTT = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTSMI,
            this.openTSMI,
            this.saveTSMI,
            this.saveAsTSMI,
            this.logoutTSMI});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newTSMI
            // 
            this.newTSMI.Image = ((System.Drawing.Image)(resources.GetObject("newTSMI.Image")));
            this.newTSMI.Name = "newTSMI";
            this.newTSMI.Size = new System.Drawing.Size(224, 26);
            this.newTSMI.Text = "New";
            this.newTSMI.Click += new System.EventHandler(this.NewTSMI_Click);
            // 
            // openTSMI
            // 
            this.openTSMI.Image = ((System.Drawing.Image)(resources.GetObject("openTSMI.Image")));
            this.openTSMI.Name = "openTSMI";
            this.openTSMI.Size = new System.Drawing.Size(224, 26);
            this.openTSMI.Text = "Open";
            this.openTSMI.Click += new System.EventHandler(this.OpenTSMI_Click);
            // 
            // saveTSMI
            // 
            this.saveTSMI.Image = ((System.Drawing.Image)(resources.GetObject("saveTSMI.Image")));
            this.saveTSMI.Name = "saveTSMI";
            this.saveTSMI.Size = new System.Drawing.Size(224, 26);
            this.saveTSMI.Text = "Save";
            this.saveTSMI.Click += new System.EventHandler(this.SaveTSMI_Click);
            // 
            // saveAsTSMI
            // 
            this.saveAsTSMI.Image = ((System.Drawing.Image)(resources.GetObject("saveAsTSMI.Image")));
            this.saveAsTSMI.Name = "saveAsTSMI";
            this.saveAsTSMI.Size = new System.Drawing.Size(224, 26);
            this.saveAsTSMI.Text = "Save As";
            this.saveAsTSMI.Click += new System.EventHandler(this.SaveAsTSMI_Click);
            // 
            // logoutTSMI
            // 
            this.logoutTSMI.Image = ((System.Drawing.Image)(resources.GetObject("logoutTSMI.Image")));
            this.logoutTSMI.Name = "logoutTSMI";
            this.logoutTSMI.Size = new System.Drawing.Size(224, 26);
            this.logoutTSMI.Text = "Logout";
            this.logoutTSMI.Click += new System.EventHandler(this.LogoutTSMI_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutTSMI,
            this.copyTSMI,
            this.pasteTSMI});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // cutTSMI
            // 
            this.cutTSMI.Image = ((System.Drawing.Image)(resources.GetObject("cutTSMI.Image")));
            this.cutTSMI.Name = "cutTSMI";
            this.cutTSMI.Size = new System.Drawing.Size(224, 26);
            this.cutTSMI.Text = "Cut";
            this.cutTSMI.Click += new System.EventHandler(this.CutTSMI_Click);
            // 
            // copyTSMI
            // 
            this.copyTSMI.Image = ((System.Drawing.Image)(resources.GetObject("copyTSMI.Image")));
            this.copyTSMI.Name = "copyTSMI";
            this.copyTSMI.Size = new System.Drawing.Size(224, 26);
            this.copyTSMI.Text = "Copy";
            this.copyTSMI.Click += new System.EventHandler(this.CopyTSMI_Click);
            // 
            // pasteTSMI
            // 
            this.pasteTSMI.Image = ((System.Drawing.Image)(resources.GetObject("pasteTSMI.Image")));
            this.pasteTSMI.Name = "pasteTSMI";
            this.pasteTSMI.Size = new System.Drawing.Size(224, 26);
            this.pasteTSMI.Text = "Paste";
            this.pasteTSMI.Click += new System.EventHandler(this.PasteTSMI_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutTSMI});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutTSMI
            // 
            this.aboutTSMI.Name = "aboutTSMI";
            this.aboutTSMI.Size = new System.Drawing.Size(142, 26);
            this.aboutTSMI.Text = "About...";
            this.aboutTSMI.Click += new System.EventHandler(this.AboutTSMI_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTSBtn,
            this.openTSBtn,
            this.saveTSBtn,
            this.saveAsTSBtn,
            this.toolStripSeparator1,
            this.boldTSBtn,
            this.italicTSBtn,
            this.underlineTSBtn,
            this.fontSizeTSCB,
            this.usernameTSL});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 28);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newTSBtn
            // 
            this.newTSBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newTSBtn.Image = ((System.Drawing.Image)(resources.GetObject("newTSBtn.Image")));
            this.newTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newTSBtn.Name = "newTSBtn";
            this.newTSBtn.Size = new System.Drawing.Size(29, 25);
            this.newTSBtn.Text = "New";
            this.newTSBtn.ToolTipText = "New";
            this.newTSBtn.Click += new System.EventHandler(this.NewTSBtn_Click);
            // 
            // openTSBtn
            // 
            this.openTSBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openTSBtn.Image = ((System.Drawing.Image)(resources.GetObject("openTSBtn.Image")));
            this.openTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openTSBtn.Name = "openTSBtn";
            this.openTSBtn.Size = new System.Drawing.Size(29, 25);
            this.openTSBtn.Text = "Open";
            this.openTSBtn.Click += new System.EventHandler(this.OpenTSBtn_Click);
            // 
            // saveTSBtn
            // 
            this.saveTSBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveTSBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveTSBtn.Image")));
            this.saveTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveTSBtn.Name = "saveTSBtn";
            this.saveTSBtn.Size = new System.Drawing.Size(29, 25);
            this.saveTSBtn.Text = "Save";
            this.saveTSBtn.Click += new System.EventHandler(this.SaveTSBtn_Click);
            // 
            // saveAsTSBtn
            // 
            this.saveAsTSBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveAsTSBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveAsTSBtn.Image")));
            this.saveAsTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveAsTSBtn.Name = "saveAsTSBtn";
            this.saveAsTSBtn.Size = new System.Drawing.Size(29, 25);
            this.saveAsTSBtn.Text = "Save As";
            this.saveAsTSBtn.Click += new System.EventHandler(this.SaveAsTSBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // boldTSBtn
            // 
            this.boldTSBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.boldTSBtn.Image = ((System.Drawing.Image)(resources.GetObject("boldTSBtn.Image")));
            this.boldTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.boldTSBtn.Name = "boldTSBtn";
            this.boldTSBtn.Size = new System.Drawing.Size(29, 25);
            this.boldTSBtn.Text = "Bold";
            this.boldTSBtn.Click += new System.EventHandler(this.BoldTSBtn_Click);
            // 
            // italicTSBtn
            // 
            this.italicTSBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.italicTSBtn.Image = ((System.Drawing.Image)(resources.GetObject("italicTSBtn.Image")));
            this.italicTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.italicTSBtn.Name = "italicTSBtn";
            this.italicTSBtn.Size = new System.Drawing.Size(29, 25);
            this.italicTSBtn.Text = "Italics";
            this.italicTSBtn.Click += new System.EventHandler(this.ItalicTSBtn_Click);
            // 
            // underlineTSBtn
            // 
            this.underlineTSBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.underlineTSBtn.Image = ((System.Drawing.Image)(resources.GetObject("underlineTSBtn.Image")));
            this.underlineTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.underlineTSBtn.Name = "underlineTSBtn";
            this.underlineTSBtn.Size = new System.Drawing.Size(29, 25);
            this.underlineTSBtn.Text = "Underline";
            this.underlineTSBtn.Click += new System.EventHandler(this.UnderlineTSBtn_Click);
            // 
            // fontSizeTSCB
            // 
            this.fontSizeTSCB.Items.AddRange(new object[] {
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20"});
            this.fontSizeTSCB.Name = "fontSizeTSCB";
            this.fontSizeTSCB.Size = new System.Drawing.Size(121, 28);
            this.fontSizeTSCB.SelectedIndexChanged += new System.EventHandler(this.fontSizeTSCB_SelectedIndexChanged);
            // 
            // usernameTSL
            // 
            this.usernameTSL.Name = "usernameTSL";
            this.usernameTSL.Size = new System.Drawing.Size(111, 25);
            this.usernameTSL.Text = "toolStripLabel1";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutLeftTSBtn,
            this.copyLeftTSBtn,
            this.pasteLeftTSBtn});
            this.toolStrip2.Location = new System.Drawing.Point(0, 56);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(40, 394);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // cutLeftTSBtn
            // 
            this.cutLeftTSBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutLeftTSBtn.Image = ((System.Drawing.Image)(resources.GetObject("cutLeftTSBtn.Image")));
            this.cutLeftTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutLeftTSBtn.Name = "cutLeftTSBtn";
            this.cutLeftTSBtn.Size = new System.Drawing.Size(37, 24);
            this.cutLeftTSBtn.Text = "Cut";
            this.cutLeftTSBtn.Click += new System.EventHandler(this.CutLeftTSBtn_Click);
            // 
            // copyLeftTSBtn
            // 
            this.copyLeftTSBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyLeftTSBtn.Image = ((System.Drawing.Image)(resources.GetObject("copyLeftTSBtn.Image")));
            this.copyLeftTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyLeftTSBtn.Name = "copyLeftTSBtn";
            this.copyLeftTSBtn.Size = new System.Drawing.Size(37, 24);
            this.copyLeftTSBtn.Text = "Copy";
            this.copyLeftTSBtn.Click += new System.EventHandler(this.CopyLeftTSBtn_Click);
            // 
            // pasteLeftTSBtn
            // 
            this.pasteLeftTSBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteLeftTSBtn.Image = ((System.Drawing.Image)(resources.GetObject("pasteLeftTSBtn.Image")));
            this.pasteLeftTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteLeftTSBtn.Name = "pasteLeftTSBtn";
            this.pasteLeftTSBtn.Size = new System.Drawing.Size(37, 24);
            this.pasteLeftTSBtn.Text = "Paste";
            this.pasteLeftTSBtn.Click += new System.EventHandler(this.PasteLeftTSBtn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(33, 59);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(755, 379);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "TextEditor";
            this.Text = "TextEditor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTSMI;
        private System.Windows.Forms.ToolStripMenuItem openTSMI;
        private System.Windows.Forms.ToolStripMenuItem saveTSMI;
        private System.Windows.Forms.ToolStripMenuItem saveAsTSMI;
        private System.Windows.Forms.ToolStripMenuItem logoutTSMI;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutTSMI;
        private System.Windows.Forms.ToolStripMenuItem copyTSMI;
        private System.Windows.Forms.ToolStripMenuItem pasteTSMI;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutTSMI;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newTSBtn;
        private System.Windows.Forms.ToolStripButton openTSBtn;
        private System.Windows.Forms.ToolStripButton saveTSBtn;
        private System.Windows.Forms.ToolStripButton saveAsTSBtn;
        private System.Windows.Forms.ToolStripButton boldTSBtn;
        private System.Windows.Forms.ToolStripButton italicTSBtn;
        private System.Windows.Forms.ToolStripButton underlineTSBtn;
        private System.Windows.Forms.ToolStripComboBox fontSizeTSCB;
        private System.Windows.Forms.ToolStripLabel usernameTSL;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton cutLeftTSBtn;
        private System.Windows.Forms.ToolStripButton copyLeftTSBtn;
        private System.Windows.Forms.ToolStripButton pasteLeftTSBtn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolTip newTT;
    }
}
