namespace VP_Lab_6
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
            this.lblDisplay = new System.Windows.Forms.Label();
            this.grpColor = new System.Windows.Forms.GroupBox();
            this.radRed = new System.Windows.Forms.RadioButton();
            this.radGreen = new System.Windows.Forms.RadioButton();
            this.radBlue = new System.Windows.Forms.RadioButton();
            this.grpSize = new System.Windows.Forms.GroupBox();
            this.radSmall = new System.Windows.Forms.RadioButton();
            this.radMedium = new System.Windows.Forms.RadioButton();
            this.radLarge = new System.Windows.Forms.RadioButton();
            this.cmbExtraOptions = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpColor.SuspendLayout();
            this.grpSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(643, 255);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(134, 25);
            this.lblDisplay.TabIndex = 0;
            this.lblDisplay.Text = "Sample Text";
            this.lblDisplay.Click += new System.EventHandler(this.lblDisplay_Click);
            // 
            // grpColor
            // 
            this.grpColor.Controls.Add(this.radRed);
            this.grpColor.Controls.Add(this.radBlue);
            this.grpColor.Controls.Add(this.radGreen);
            this.grpColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpColor.Location = new System.Drawing.Point(65, 95);
            this.grpColor.Name = "grpColor";
            this.grpColor.Size = new System.Drawing.Size(387, 107);
            this.grpColor.TabIndex = 1;
            this.grpColor.TabStop = false;
            this.grpColor.Text = "Select Color";
            // 
            // radRed
            // 
            this.radRed.AutoSize = true;
            this.radRed.Location = new System.Drawing.Point(6, 58);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(75, 29);
            this.radRed.TabIndex = 2;
            this.radRed.TabStop = true;
            this.radRed.Text = "Red";
            this.radRed.UseVisualStyleBackColor = true;
            this.radRed.CheckedChanged += new System.EventHandler(this.radRed_CheckedChanged);
            // 
            // radGreen
            // 
            this.radGreen.AutoSize = true;
            this.radGreen.Location = new System.Drawing.Point(246, 58);
            this.radGreen.Name = "radGreen";
            this.radGreen.Size = new System.Drawing.Size(96, 29);
            this.radGreen.TabIndex = 3;
            this.radGreen.TabStop = true;
            this.radGreen.Text = "Green";
            this.radGreen.UseVisualStyleBackColor = true;
            this.radGreen.CheckedChanged += new System.EventHandler(this.radGreen_CheckedChanged);
            // 
            // radBlue
            // 
            this.radBlue.AutoSize = true;
            this.radBlue.Location = new System.Drawing.Point(134, 58);
            this.radBlue.Name = "radBlue";
            this.radBlue.Size = new System.Drawing.Size(80, 29);
            this.radBlue.TabIndex = 4;
            this.radBlue.TabStop = true;
            this.radBlue.Text = "Blue";
            this.radBlue.UseVisualStyleBackColor = true;
            this.radBlue.CheckedChanged += new System.EventHandler(this.radBlue_CheckedChanged);
            // 
            // grpSize
            // 
            this.grpSize.Controls.Add(this.radSmall);
            this.grpSize.Controls.Add(this.radMedium);
            this.grpSize.Controls.Add(this.radLarge);
            this.grpSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSize.Location = new System.Drawing.Point(505, 102);
            this.grpSize.Name = "grpSize";
            this.grpSize.Size = new System.Drawing.Size(458, 100);
            this.grpSize.TabIndex = 5;
            this.grpSize.TabStop = false;
            this.grpSize.Text = "Select Size";
            // 
            // radSmall
            // 
            this.radSmall.AutoSize = true;
            this.radSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSmall.Location = new System.Drawing.Point(20, 51);
            this.radSmall.Name = "radSmall";
            this.radSmall.Size = new System.Drawing.Size(115, 24);
            this.radSmall.TabIndex = 6;
            this.radSmall.TabStop = true;
            this.radSmall.Text = "Small (10)";
            this.radSmall.UseVisualStyleBackColor = true;
            this.radSmall.CheckedChanged += new System.EventHandler(this.radSmall_CheckedChanged);
            // 
            // radMedium
            // 
            this.radMedium.AutoSize = true;
            this.radMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMedium.Location = new System.Drawing.Point(163, 51);
            this.radMedium.Name = "radMedium";
            this.radMedium.Size = new System.Drawing.Size(133, 24);
            this.radMedium.TabIndex = 7;
            this.radMedium.TabStop = true;
            this.radMedium.Text = "Medium (14)";
            this.radMedium.UseVisualStyleBackColor = true;
            this.radMedium.CheckedChanged += new System.EventHandler(this.radMedium_CheckedChanged);
            // 
            // radLarge
            // 
            this.radLarge.AutoSize = true;
            this.radLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLarge.Location = new System.Drawing.Point(316, 51);
            this.radLarge.Name = "radLarge";
            this.radLarge.Size = new System.Drawing.Size(117, 24);
            this.radLarge.TabIndex = 8;
            this.radLarge.TabStop = true;
            this.radLarge.Text = "Large (20)";
            this.radLarge.UseVisualStyleBackColor = true;
            this.radLarge.CheckedChanged += new System.EventHandler(this.radLarge_CheckedChanged);
            // 
            // cmbExtraOptions
            // 
            this.cmbExtraOptions.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbExtraOptions.FormattingEnabled = true;
            this.cmbExtraOptions.Items.AddRange(new object[] {
            "Bold",
            "Italic",
            "Underline"});
            this.cmbExtraOptions.Location = new System.Drawing.Point(112, 256);
            this.cmbExtraOptions.Name = "cmbExtraOptions";
            this.cmbExtraOptions.Size = new System.Drawing.Size(216, 28);
            this.cmbExtraOptions.TabIndex = 9;
            this.cmbExtraOptions.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(421, 256);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(134, 37);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1006, 359);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cmbExtraOptions);
            this.Controls.Add(this.grpSize);
            this.Controls.Add(this.grpColor);
            this.Controls.Add(this.lblDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpColor.ResumeLayout(false);
            this.grpColor.PerformLayout();
            this.grpSize.ResumeLayout(false);
            this.grpSize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.GroupBox grpColor;
        private System.Windows.Forms.RadioButton radRed;
        private System.Windows.Forms.RadioButton radGreen;
        private System.Windows.Forms.RadioButton radBlue;
        private System.Windows.Forms.GroupBox grpSize;
        private System.Windows.Forms.RadioButton radSmall;
        private System.Windows.Forms.RadioButton radMedium;
        private System.Windows.Forms.RadioButton radLarge;
        private System.Windows.Forms.ComboBox cmbExtraOptions;
        private System.Windows.Forms.Button btnReset;
    }
}

