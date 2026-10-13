namespace VP_Lab_6
{
    partial class Form6
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnShowDetails = new System.Windows.Forms.Button();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.radOptionA = new System.Windows.Forms.RadioButton();
            this.radOptionB = new System.Windows.Forms.RadioButton();
            this.chkFeature = new System.Windows.Forms.CheckBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lstCountry = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(81, 95);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(504, 26);
            this.txtName.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(45, 158);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(136, 46);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(264, 158);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(136, 44);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnShowDetails
            // 
            this.btnShowDetails.Location = new System.Drawing.Point(461, 158);
            this.btnShowDetails.Name = "btnShowDetails";
            this.btnShowDetails.Size = new System.Drawing.Size(136, 46);
            this.btnShowDetails.TabIndex = 3;
            this.btnShowDetails.Text = "Show Detalis";
            this.btnShowDetails.UseVisualStyleBackColor = true;
            this.btnShowDetails.Click += new System.EventHandler(this.btnShowDetails_Click);
            // 
            // cmbState
            // 
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Location = new System.Drawing.Point(440, 248);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(157, 28);
            this.cmbState.TabIndex = 5;
            // 
            // radOptionA
            // 
            this.radOptionA.AutoSize = true;
            this.radOptionA.Location = new System.Drawing.Point(105, 384);
            this.radOptionA.Name = "radOptionA";
            this.radOptionA.Size = new System.Drawing.Size(96, 24);
            this.radOptionA.TabIndex = 6;
            this.radOptionA.TabStop = true;
            this.radOptionA.Text = "Option A";
            this.radOptionA.UseVisualStyleBackColor = true;
            this.radOptionA.CheckedChanged += new System.EventHandler(this.radOptionA_CheckedChanged);
            // 
            // radOptionB
            // 
            this.radOptionB.AutoSize = true;
            this.radOptionB.Location = new System.Drawing.Point(283, 384);
            this.radOptionB.Name = "radOptionB";
            this.radOptionB.Size = new System.Drawing.Size(96, 24);
            this.radOptionB.TabIndex = 7;
            this.radOptionB.TabStop = true;
            this.radOptionB.Text = "Option B";
            this.radOptionB.UseVisualStyleBackColor = true;
            // 
            // chkFeature
            // 
            this.chkFeature.AutoSize = true;
            this.chkFeature.Location = new System.Drawing.Point(440, 385);
            this.chkFeature.Name = "chkFeature";
            this.chkFeature.Size = new System.Drawing.Size(145, 24);
            this.chkFeature.TabIndex = 8;
            this.chkFeature.Text = "Enable Feature";
            this.chkFeature.UseVisualStyleBackColor = true;
            this.chkFeature.CheckedChanged += new System.EventHandler(this.chkFeature_CheckedChanged);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(316, 447);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(51, 20);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "label1";
            // 
            // lstCountry
            // 
            this.lstCountry.FormattingEnabled = true;
            this.lstCountry.ItemHeight = 20;
            this.lstCountry.Location = new System.Drawing.Point(81, 248);
            this.lstCountry.Name = "lstCountry";
            this.lstCountry.Size = new System.Drawing.Size(298, 84);
            this.lstCountry.TabIndex = 10;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(710, 500);
            this.Controls.Add(this.lstCountry);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.chkFeature);
            this.Controls.Add(this.radOptionB);
            this.Controls.Add(this.radOptionA);
            this.Controls.Add(this.cmbState);
            this.Controls.Add(this.btnShowDetails);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtName);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnShowDetails;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.RadioButton radOptionA;
        private System.Windows.Forms.RadioButton radOptionB;
        private System.Windows.Forms.CheckBox chkFeature;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ListBox lstCountry;
    }
}