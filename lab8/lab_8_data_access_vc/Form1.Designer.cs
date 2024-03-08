namespace lab_8_data_access_vc
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
            this.studentBtn = new System.Windows.Forms.Button();
            this.outputTable = new System.Windows.Forms.TableLayoutPanel();
            this.courseBtn = new System.Windows.Forms.Button();
            this.booksBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.studentEnrollBtn = new System.Windows.Forms.Button();
            this.courseBookAdoptionBtn = new System.Windows.Forms.Button();
            this.executeField = new System.Windows.Forms.TextBox();
            this.executeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentBtn
            // 
            this.studentBtn.Location = new System.Drawing.Point(37, 32);
            this.studentBtn.Margin = new System.Windows.Forms.Padding(4);
            this.studentBtn.Name = "studentBtn";
            this.studentBtn.Size = new System.Drawing.Size(100, 28);
            this.studentBtn.TabIndex = 0;
            this.studentBtn.Text = "Student";
            this.studentBtn.UseVisualStyleBackColor = true;
            this.studentBtn.Click += new System.EventHandler(this.studentBtn_Click);
            // 
            // outputTable
            // 
            this.outputTable.AutoScroll = true;
            this.outputTable.ColumnCount = 4;
            this.outputTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.outputTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.outputTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.outputTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.outputTable.Location = new System.Drawing.Point(37, 102);
            this.outputTable.Margin = new System.Windows.Forms.Padding(4);
            this.outputTable.Name = "outputTable";
            this.outputTable.RowCount = 1;
            this.outputTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.outputTable.Size = new System.Drawing.Size(1561, 508);
            this.outputTable.TabIndex = 1;
            // 
            // courseBtn
            // 
            this.courseBtn.Location = new System.Drawing.Point(299, 32);
            this.courseBtn.Margin = new System.Windows.Forms.Padding(4);
            this.courseBtn.Name = "courseBtn";
            this.courseBtn.Size = new System.Drawing.Size(100, 28);
            this.courseBtn.TabIndex = 2;
            this.courseBtn.Text = "Course";
            this.courseBtn.UseVisualStyleBackColor = true;
            this.courseBtn.Click += new System.EventHandler(this.courseBtn_Click);
            // 
            // booksBtn
            // 
            this.booksBtn.Location = new System.Drawing.Point(569, 32);
            this.booksBtn.Margin = new System.Windows.Forms.Padding(4);
            this.booksBtn.Name = "booksBtn";
            this.booksBtn.Size = new System.Drawing.Size(100, 28);
            this.booksBtn.TabIndex = 3;
            this.booksBtn.Text = "Books";
            this.booksBtn.UseVisualStyleBackColor = true;
            this.booksBtn.Click += new System.EventHandler(this.booksBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(1499, 32);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(4);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(100, 28);
            this.clearBtn.TabIndex = 4;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // studentEnrollBtn
            // 
            this.studentEnrollBtn.Location = new System.Drawing.Point(839, 32);
            this.studentEnrollBtn.Margin = new System.Windows.Forms.Padding(4);
            this.studentEnrollBtn.Name = "studentEnrollBtn";
            this.studentEnrollBtn.Size = new System.Drawing.Size(141, 28);
            this.studentEnrollBtn.TabIndex = 5;
            this.studentEnrollBtn.Text = "Student with Enroll";
            this.studentEnrollBtn.UseVisualStyleBackColor = true;
            this.studentEnrollBtn.Click += new System.EventHandler(this.studentEnrollBtn_Click);
            // 
            // courseBookAdoptionBtn
            // 
            this.courseBookAdoptionBtn.Location = new System.Drawing.Point(1144, 32);
            this.courseBookAdoptionBtn.Margin = new System.Windows.Forms.Padding(4);
            this.courseBookAdoptionBtn.Name = "courseBookAdoptionBtn";
            this.courseBookAdoptionBtn.Size = new System.Drawing.Size(208, 28);
            this.courseBookAdoptionBtn.TabIndex = 6;
            this.courseBookAdoptionBtn.Text = "Course with Book_adoption";
            this.courseBookAdoptionBtn.UseVisualStyleBackColor = true;
            this.courseBookAdoptionBtn.Click += new System.EventHandler(this.courseBookAdoptionBtn_Click);
            // 
            // executeField
            // 
            this.executeField.Location = new System.Drawing.Point(37, 658);
            this.executeField.Margin = new System.Windows.Forms.Padding(4);
            this.executeField.Name = "executeField";
            this.executeField.Size = new System.Drawing.Size(601, 22);
            this.executeField.TabIndex = 7;
            // 
            // executeBtn
            // 
            this.executeBtn.Location = new System.Drawing.Point(726, 655);
            this.executeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.executeBtn.Name = "executeBtn";
            this.executeBtn.Size = new System.Drawing.Size(180, 28);
            this.executeBtn.TabIndex = 8;
            this.executeBtn.Text = "Execute SQL Command";
            this.executeBtn.UseVisualStyleBackColor = true;
            this.executeBtn.Click += new System.EventHandler(this.executeBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1644, 738);
            this.Controls.Add(this.executeBtn);
            this.Controls.Add(this.executeField);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.courseBookAdoptionBtn);
            this.Controls.Add(this.studentEnrollBtn);
            this.Controls.Add(this.booksBtn);
            this.Controls.Add(this.courseBtn);
            this.Controls.Add(this.outputTable);
            this.Controls.Add(this.studentBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Students Database Viewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button studentBtn;
        private System.Windows.Forms.TableLayoutPanel outputTable;
        private System.Windows.Forms.Button courseBtn;
        private System.Windows.Forms.Button booksBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button studentEnrollBtn;
        private System.Windows.Forms.Button courseBookAdoptionBtn;
        private System.Windows.Forms.TextBox executeField;
        private System.Windows.Forms.Button executeBtn;
    }
}

