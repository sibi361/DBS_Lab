namespace lab2_q2
{
    partial class DashboardForm
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
            this.unameLbl = new System.Windows.Forms.Label();
            this.headerLbl = new System.Windows.Forms.Label();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.balanceLbl = new System.Windows.Forms.Label();
            this.mTransferBtn = new System.Windows.Forms.Button();
            this.chngPassBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.transactionsBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // unameLbl
            // 
            this.unameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.unameLbl.AutoSize = true;
            this.unameLbl.BackColor = System.Drawing.Color.White;
            this.unameLbl.Location = new System.Drawing.Point(45, 105);
            this.unameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unameLbl.Name = "unameLbl";
            this.unameLbl.Size = new System.Drawing.Size(65, 16);
            this.unameLbl.TabIndex = 21;
            this.unameLbl.Text = "Welcome";
            // 
            // headerLbl
            // 
            this.headerLbl.AutoSize = true;
            this.headerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLbl.Location = new System.Drawing.Point(41, 39);
            this.headerLbl.Name = "headerLbl";
            this.headerLbl.Size = new System.Drawing.Size(131, 29);
            this.headerLbl.TabIndex = 20;
            this.headerLbl.Text = "Dashboard";
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(282, 43);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(170, 28);
            this.logoutBtn.TabIndex = 0;
            this.logoutBtn.Text = "LOGOUT";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // balanceLbl
            // 
            this.balanceLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balanceLbl.AutoSize = true;
            this.balanceLbl.BackColor = System.Drawing.Color.White;
            this.balanceLbl.Location = new System.Drawing.Point(45, 158);
            this.balanceLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.balanceLbl.Name = "balanceLbl";
            this.balanceLbl.Size = new System.Drawing.Size(63, 16);
            this.balanceLbl.TabIndex = 22;
            this.balanceLbl.Text = "Balance: ";
            // 
            // mTransferBtn
            // 
            this.mTransferBtn.Location = new System.Drawing.Point(282, 99);
            this.mTransferBtn.Name = "mTransferBtn";
            this.mTransferBtn.Size = new System.Drawing.Size(170, 28);
            this.mTransferBtn.TabIndex = 1;
            this.mTransferBtn.Text = "MONEY TRANSFER";
            this.mTransferBtn.UseVisualStyleBackColor = true;
            this.mTransferBtn.Click += new System.EventHandler(this.mTransferBtn_Click);
            // 
            // chngPassBtn
            // 
            this.chngPassBtn.Location = new System.Drawing.Point(282, 152);
            this.chngPassBtn.Name = "chngPassBtn";
            this.chngPassBtn.Size = new System.Drawing.Size(170, 28);
            this.chngPassBtn.TabIndex = 2;
            this.chngPassBtn.Text = "CHANGE PASSWORD";
            this.chngPassBtn.UseVisualStyleBackColor = true;
            this.chngPassBtn.Click += new System.EventHandler(this.chngPassBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Recent Transactions:";
            // 
            // transactionsBox
            // 
            this.transactionsBox.BackColor = System.Drawing.Color.White;
            this.transactionsBox.Location = new System.Drawing.Point(46, 255);
            this.transactionsBox.Multiline = true;
            this.transactionsBox.Name = "transactionsBox";
            this.transactionsBox.ReadOnly = true;
            this.transactionsBox.Size = new System.Drawing.Size(406, 136);
            this.transactionsBox.TabIndex = 25;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 432);
            this.Controls.Add(this.transactionsBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chngPassBtn);
            this.Controls.Add(this.mTransferBtn);
            this.Controls.Add(this.unameLbl);
            this.Controls.Add(this.headerLbl);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.balanceLbl);
            this.Name = "DashboardForm";
            this.Text = "Banking App - Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label unameLbl;
        private System.Windows.Forms.Label headerLbl;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label balanceLbl;
        private System.Windows.Forms.Button mTransferBtn;
        private System.Windows.Forms.Button chngPassBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox transactionsBox;
    }
}