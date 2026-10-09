namespace VP_LAB_7
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
            this.components = new System.ComponentModel.Container();
            this.displayLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courierMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comicMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.boldMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italicMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxBold = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxItalic = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxUnderline = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxReset = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.labelContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayLabel
            // 
            this.displayLabel.AutoSize = true;
            this.displayLabel.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayLabel.Location = new System.Drawing.Point(122, 70);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(532, 34);
            this.displayLabel.TabIndex = 0;
            this.displayLabel.Text = "Welcome Visual Programming Lab 7";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timesMenuItem,
            this.courierMenuItem,
            this.comicMenuItem,
            this.toolStripMenuItem1,
            this.boldMenuItem,
            this.italicMenuItem});
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(64, 32);
            this.fontToolStripMenuItem.Text = "&Font";
            // 
            // timesMenuItem
            // 
            this.timesMenuItem.Name = "timesMenuItem";
            this.timesMenuItem.Size = new System.Drawing.Size(253, 34);
            this.timesMenuItem.Text = "Time New Roman";
            this.timesMenuItem.Click += new System.EventHandler(this.timesMenuItem_Click);
            // 
            // courierMenuItem
            // 
            this.courierMenuItem.Name = "courierMenuItem";
            this.courierMenuItem.Size = new System.Drawing.Size(253, 34);
            this.courierMenuItem.Text = "Courier New";
            this.courierMenuItem.Click += new System.EventHandler(this.courierMenuItem_Click);
            // 
            // comicMenuItem
            // 
            this.comicMenuItem.Name = "comicMenuItem";
            this.comicMenuItem.Size = new System.Drawing.Size(253, 34);
            this.comicMenuItem.Text = "Comic Sans MS";
            this.comicMenuItem.Click += new System.EventHandler(this.comicMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(250, 6);
            // 
            // boldMenuItem
            // 
            this.boldMenuItem.Name = "boldMenuItem";
            this.boldMenuItem.Size = new System.Drawing.Size(253, 34);
            this.boldMenuItem.Text = "Bold";
            this.boldMenuItem.Click += new System.EventHandler(this.boldMenuItem_Click);
            // 
            // italicMenuItem
            // 
            this.italicMenuItem.Name = "italicMenuItem";
            this.italicMenuItem.Size = new System.Drawing.Size(253, 34);
            this.italicMenuItem.Text = "Italic";
            this.italicMenuItem.Click += new System.EventHandler(this.italicMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blackMenuItem,
            this.blueMenuItem,
            this.redMenuItem,
            this.greenMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(71, 32);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // blackMenuItem
            // 
            this.blackMenuItem.Name = "blackMenuItem";
            this.blackMenuItem.Size = new System.Drawing.Size(160, 34);
            this.blackMenuItem.Text = "Black";
            this.blackMenuItem.Click += new System.EventHandler(this.blackMenuItem_Click);
            // 
            // blueMenuItem
            // 
            this.blueMenuItem.Name = "blueMenuItem";
            this.blueMenuItem.Size = new System.Drawing.Size(160, 34);
            this.blueMenuItem.Text = "Blue";
            this.blueMenuItem.Click += new System.EventHandler(this.blueMenuItem_Click);
            // 
            // redMenuItem
            // 
            this.redMenuItem.Name = "redMenuItem";
            this.redMenuItem.Size = new System.Drawing.Size(160, 34);
            this.redMenuItem.Text = "Red";
            this.redMenuItem.Click += new System.EventHandler(this.redMenuItem_Click);
            // 
            // greenMenuItem
            // 
            this.greenMenuItem.Name = "greenMenuItem";
            this.greenMenuItem.Size = new System.Drawing.Size(160, 34);
            this.greenMenuItem.Text = "Green";
            this.greenMenuItem.Click += new System.EventHandler(this.greenMenuItem_Click);
            // 
            // labelContextMenu
            // 
            this.labelContextMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.labelContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxBold,
            this.ctxItalic,
            this.ctxUnderline,
            this.toolStripMenuItem2,
            this.ctxReset});
            this.labelContextMenu.Name = "contextMenuStrip1";
            this.labelContextMenu.Size = new System.Drawing.Size(168, 138);
            this.labelContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.labelContextMenu_Opening);
            // 
            // ctxBold
            // 
            this.ctxBold.Name = "ctxBold";
            this.ctxBold.Size = new System.Drawing.Size(240, 32);
            this.ctxBold.Text = "&Bold";
            this.ctxBold.Click += new System.EventHandler(this.ctxBold_Click);
            // 
            // ctxItalic
            // 
            this.ctxItalic.Name = "ctxItalic";
            this.ctxItalic.Size = new System.Drawing.Size(240, 32);
            this.ctxItalic.Text = " &Italic";
            this.ctxItalic.Click += new System.EventHandler(this.ctxItalic_Click);
            // 
            // ctxUnderline
            // 
            this.ctxUnderline.Name = "ctxUnderline";
            this.ctxUnderline.Size = new System.Drawing.Size(240, 32);
            this.ctxUnderline.Text = "&Underline";
            this.ctxUnderline.Click += new System.EventHandler(this.ctxUnderline_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(237, 6);
            // 
            // ctxReset
            // 
            this.ctxReset.Name = "ctxReset";
            this.ctxReset.Size = new System.Drawing.Size(240, 32);
            this.ctxReset.Text = "&Reset Font";
            this.ctxReset.Click += new System.EventHandler(this.ctxReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.labelContextMenu;
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.labelContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courierMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comicMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem boldMenuItem;
        private System.Windows.Forms.ToolStripMenuItem italicMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenMenuItem;
        private System.Windows.Forms.ContextMenuStrip labelContextMenu;
        private System.Windows.Forms.ToolStripMenuItem ctxBold;
        private System.Windows.Forms.ToolStripMenuItem ctxItalic;
        private System.Windows.Forms.ToolStripMenuItem ctxUnderline;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ctxReset;
    }
}

