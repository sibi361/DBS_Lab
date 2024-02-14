namespace lab2_q2
{
    partial class MoneyTransferForm
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
            this.logoutBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.amtLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.TextBox();
            this.headerLbl = new System.Windows.Forms.Label();
            this.unameLbl = new System.Windows.Forms.Label();
            this.balanceLbl = new System.Windows.Forms.Label();
            this.accnoLabel = new System.Windows.Forms.Label();
            this.amtField = new System.Windows.Forms.TextBox();
            this.accnoField = new System.Windows.Forms.TextBox();
            this.dashboardBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(41, 363);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(100, 28);
            this.logoutBtn.TabIndex = 2;
            this.logoutBtn.Text = "LOGOUT";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(41, 302);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(4);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(100, 28);
            this.resetBtn.TabIndex = 3;
            this.resetBtn.Text = "RESET";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(236, 302);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(128, 28);
            this.submitBtn.TabIndex = 0;
            this.submitBtn.Text = "SUBMIT";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // amtLbl
            // 
            this.amtLbl.AutoSize = true;
            this.amtLbl.Location = new System.Drawing.Point(38, 248);
            this.amtLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.amtLbl.Name = "amtLbl";
            this.amtLbl.Size = new System.Drawing.Size(52, 16);
            this.amtLbl.TabIndex = 11;
            this.amtLbl.Text = "Amount";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(38, 152);
            this.nameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(114, 16);
            this.nameLbl.TabIndex = 10;
            this.nameLbl.Text = "Beneficiary Name";
            // 
            // nameField
            // 
            this.nameField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameField.Location = new System.Drawing.Point(236, 149);
            this.nameField.Margin = new System.Windows.Forms.Padding(4);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(176, 22);
            this.nameField.TabIndex = 5;
            // 
            // headerLbl
            // 
            this.headerLbl.AutoSize = true;
            this.headerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLbl.Location = new System.Drawing.Point(37, 35);
            this.headerLbl.Name = "headerLbl";
            this.headerLbl.Size = new System.Drawing.Size(181, 29);
            this.headerLbl.TabIndex = 16;
            this.headerLbl.Text = "Money Transfer";
            // 
            // unameLbl
            // 
            this.unameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.unameLbl.AutoSize = true;
            this.unameLbl.BackColor = System.Drawing.Color.White;
            this.unameLbl.Location = new System.Drawing.Point(38, 100);
            this.unameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unameLbl.Name = "unameLbl";
            this.unameLbl.Size = new System.Drawing.Size(65, 16);
            this.unameLbl.TabIndex = 17;
            this.unameLbl.Text = "Welcome";
            // 
            // balanceLbl
            // 
            this.balanceLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balanceLbl.AutoSize = true;
            this.balanceLbl.BackColor = System.Drawing.Color.White;
            this.balanceLbl.Location = new System.Drawing.Point(233, 100);
            this.balanceLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.balanceLbl.Name = "balanceLbl";
            this.balanceLbl.Size = new System.Drawing.Size(63, 16);
            this.balanceLbl.TabIndex = 18;
            this.balanceLbl.Text = "Balance: ";
            // 
            // accnoLabel
            // 
            this.accnoLabel.AutoSize = true;
            this.accnoLabel.Location = new System.Drawing.Point(38, 200);
            this.accnoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accnoLabel.Name = "accnoLabel";
            this.accnoLabel.Size = new System.Drawing.Size(76, 16);
            this.accnoLabel.TabIndex = 20;
            this.accnoLabel.Text = "Account no.";
            // 
            // amtField
            // 
            this.amtField.Location = new System.Drawing.Point(236, 245);
            this.amtField.Margin = new System.Windows.Forms.Padding(4);
            this.amtField.Name = "amtField";
            this.amtField.Size = new System.Drawing.Size(176, 22);
            this.amtField.TabIndex = 7;
            // 
            // accnoField
            // 
            this.accnoField.Location = new System.Drawing.Point(236, 197);
            this.accnoField.Margin = new System.Windows.Forms.Padding(4);
            this.accnoField.Name = "accnoField";
            this.accnoField.Size = new System.Drawing.Size(176, 22);
            this.accnoField.TabIndex = 6;
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.Location = new System.Drawing.Point(236, 363);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Size = new System.Drawing.Size(128, 28);
            this.dashboardBtn.TabIndex = 1;
            this.dashboardBtn.Text = "DASHBOARD";
            this.dashboardBtn.UseVisualStyleBackColor = true;
            this.dashboardBtn.Click += new System.EventHandler(this.dashboardBtn_Click);
            // 
            // MoneyTransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 432);
            this.Controls.Add(this.dashboardBtn);
            this.Controls.Add(this.accnoLabel);
            this.Controls.Add(this.accnoField);
            this.Controls.Add(this.unameLbl);
            this.Controls.Add(this.headerLbl);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.amtLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.amtField);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.balanceLbl);
            this.Name = "MoneyTransferForm";
            this.Text = "Banking App - Money Transfer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label amtLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label headerLbl;
        private System.Windows.Forms.Label unameLbl;
        private System.Windows.Forms.Label balanceLbl;
        private System.Windows.Forms.Label accnoLabel;
        private System.Windows.Forms.TextBox amtField;
        private System.Windows.Forms.TextBox accnoField;
        private System.Windows.Forms.Button dashboardBtn;
    }
}