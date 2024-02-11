namespace lab2_q2
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
            this.usernameField = new System.Windows.Forms.TextBox();
            this.passField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.startInDropdown = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameField
            // 
            this.usernameField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameField.Location = new System.Drawing.Point(148, 38);
            this.usernameField.Margin = new System.Windows.Forms.Padding(4);
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(176, 22);
            this.usernameField.TabIndex = 0;
            this.usernameField.Text = "sam";
            // 
            // passField
            // 
            this.passField.Location = new System.Drawing.Point(148, 105);
            this.passField.Margin = new System.Windows.Forms.Padding(4);
            this.passField.Name = "passField";
            this.passField.PasswordChar = '*';
            this.passField.Size = new System.Drawing.Size(176, 22);
            this.passField.TabIndex = 1;
            this.passField.Text = "sam";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(224, 230);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(100, 28);
            this.submitBtn.TabIndex = 4;
            this.submitBtn.Text = "SUBMIT";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(45, 230);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(4);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(100, 28);
            this.resetBtn.TabIndex = 3;
            this.resetBtn.Text = "RESET";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // startInDropdown
            // 
            this.startInDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startInDropdown.FormattingEnabled = true;
            this.startInDropdown.Location = new System.Drawing.Point(148, 168);
            this.startInDropdown.Margin = new System.Windows.Forms.Padding(4);
            this.startInDropdown.Name = "startInDropdown";
            this.startInDropdown.Size = new System.Drawing.Size(176, 24);
            this.startInDropdown.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Start In";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 300);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startInDropdown);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passField);
            this.Controls.Add(this.usernameField);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Banking App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameField;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.ComboBox startInDropdown;
        private System.Windows.Forms.Label label3;
    }
}

