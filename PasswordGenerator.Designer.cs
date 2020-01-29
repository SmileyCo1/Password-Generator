namespace PasswordGenerator
{
    partial class PasswordGenerator
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
            this.BtnPasswordGen = new System.Windows.Forms.Button();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.ChkUpper = new System.Windows.Forms.CheckBox();
            this.ChkLower = new System.Windows.Forms.CheckBox();
            this.ChkNum = new System.Windows.Forms.CheckBox();
            this.ChkSpecial = new System.Windows.Forms.CheckBox();
            this.ChkGroup = new System.Windows.Forms.GroupBox();
            this.ListLength = new System.Windows.Forms.ComboBox();
            this.ChkGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnPasswordGen
            // 
            this.BtnPasswordGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPasswordGen.Location = new System.Drawing.Point(61, 251);
            this.BtnPasswordGen.Name = "BtnPasswordGen";
            this.BtnPasswordGen.Size = new System.Drawing.Size(260, 52);
            this.BtnPasswordGen.TabIndex = 0;
            this.BtnPasswordGen.Text = "Generator A Password";
            this.BtnPasswordGen.UseVisualStyleBackColor = true;
            this.BtnPasswordGen.Click += new System.EventHandler(this.BtnPasswordGen_Click);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(61, 11);
            this.TxtPassword.Multiline = true;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.ReadOnly = true;
            this.TxtPassword.Size = new System.Drawing.Size(260, 37);
            this.TxtPassword.TabIndex = 1;
            // 
            // ChkUpper
            // 
            this.ChkUpper.AutoSize = true;
            this.ChkUpper.Location = new System.Drawing.Point(6, 21);
            this.ChkUpper.Name = "ChkUpper";
            this.ChkUpper.Size = new System.Drawing.Size(169, 21);
            this.ChkUpper.TabIndex = 2;
            this.ChkUpper.Text = "Use: A-Z (Uppercase)";
            this.ChkUpper.UseVisualStyleBackColor = true;
            // 
            // ChkLower
            // 
            this.ChkLower.AutoSize = true;
            this.ChkLower.Location = new System.Drawing.Point(6, 48);
            this.ChkLower.Name = "ChkLower";
            this.ChkLower.Size = new System.Drawing.Size(165, 21);
            this.ChkLower.TabIndex = 3;
            this.ChkLower.Text = "Use: a-z (Lowercase)";
            this.ChkLower.UseVisualStyleBackColor = true;
            // 
            // ChkNum
            // 
            this.ChkNum.AutoSize = true;
            this.ChkNum.Location = new System.Drawing.Point(6, 73);
            this.ChkNum.Name = "ChkNum";
            this.ChkNum.Size = new System.Drawing.Size(155, 21);
            this.ChkNum.TabIndex = 4;
            this.ChkNum.Text = "Use: 0-9 (Numbers)";
            this.ChkNum.UseVisualStyleBackColor = true;
            // 
            // ChkSpecial
            // 
            this.ChkSpecial.AutoSize = true;
            this.ChkSpecial.Location = new System.Drawing.Point(6, 100);
            this.ChkSpecial.Name = "ChkSpecial";
            this.ChkSpecial.Size = new System.Drawing.Size(241, 21);
            this.ChkSpecial.TabIndex = 5;
            this.ChkSpecial.Text = "Use: !@#$% (Special Characters)";
            this.ChkSpecial.UseVisualStyleBackColor = true;
            // 
            // ChkGroup
            // 
            this.ChkGroup.Controls.Add(this.ChkUpper);
            this.ChkGroup.Controls.Add(this.ChkLower);
            this.ChkGroup.Controls.Add(this.ChkNum);
            this.ChkGroup.Controls.Add(this.ChkSpecial);
            this.ChkGroup.Location = new System.Drawing.Point(61, 54);
            this.ChkGroup.Name = "ChkGroup";
            this.ChkGroup.Size = new System.Drawing.Size(260, 130);
            this.ChkGroup.TabIndex = 11;
            this.ChkGroup.TabStop = false;
            this.ChkGroup.Text = "Password Options";
            // 
            // ListLength
            // 
            this.ListLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListLength.FormattingEnabled = true;
            this.ListLength.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.ListLength.Location = new System.Drawing.Point(61, 190);
            this.ListLength.MaxDropDownItems = 34;
            this.ListLength.Name = "ListLength";
            this.ListLength.Size = new System.Drawing.Size(260, 24);
            this.ListLength.TabIndex = 12;
            // 
            // PasswordGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 315);
            this.Controls.Add(this.ListLength);
            this.Controls.Add(this.ChkGroup);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.BtnPasswordGen);
            this.Name = "PasswordGenerator";
            this.Text = "Password Generator";
            this.Load += new System.EventHandler(this.PasswordGenerator_Load);
            this.ChkGroup.ResumeLayout(false);
            this.ChkGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPasswordGen;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.CheckBox ChkUpper;
        private System.Windows.Forms.CheckBox ChkLower;
        private System.Windows.Forms.CheckBox ChkNum;
        private System.Windows.Forms.CheckBox ChkSpecial;
        private System.Windows.Forms.GroupBox ChkGroup;
        private System.Windows.Forms.ComboBox ListLength;
    }
}

