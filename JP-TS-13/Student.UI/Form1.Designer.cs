namespace Student.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HelloLabel = new System.Windows.Forms.Label();
            this.showStudentsBtn = new System.Windows.Forms.Button();
            this.showTeachersBtn = new System.Windows.Forms.Button();
            this.studentidValue = new System.Windows.Forms.TextBox();
            this.getSingleStudentBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HelloLabel
            // 
            this.HelloLabel.AutoSize = true;
            this.HelloLabel.Font = new System.Drawing.Font("Super Snack", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HelloLabel.ForeColor = System.Drawing.Color.Orange;
            this.HelloLabel.Location = new System.Drawing.Point(393, 9);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(393, 47);
            this.HelloLabel.TabIndex = 0;
            this.HelloLabel.Text = "STUDENTS APPLICATION";
            // 
            // showStudentsBtn
            // 
            this.showStudentsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showStudentsBtn.Location = new System.Drawing.Point(961, 94);
            this.showStudentsBtn.Name = "showStudentsBtn";
            this.showStudentsBtn.Size = new System.Drawing.Size(204, 43);
            this.showStudentsBtn.TabIndex = 1;
            this.showStudentsBtn.Text = "სტუდენტების ჩამოტვირთვა";
            this.showStudentsBtn.UseVisualStyleBackColor = true;
            this.showStudentsBtn.Click += new System.EventHandler(this.showStudentsBtn_Click);
            // 
            // showTeachersBtn
            // 
            this.showTeachersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showTeachersBtn.Location = new System.Drawing.Point(751, 94);
            this.showTeachersBtn.Name = "showTeachersBtn";
            this.showTeachersBtn.Size = new System.Drawing.Size(204, 43);
            this.showTeachersBtn.TabIndex = 1;
            this.showTeachersBtn.Text = "მასწავლებლების ჩამოტვირთვა";
            this.showTeachersBtn.UseVisualStyleBackColor = true;
            this.showTeachersBtn.Click += new System.EventHandler(this.showTeachersBtn_Click);
            // 
            // studentidValue
            // 
            this.studentidValue.Location = new System.Drawing.Point(25, 237);
            this.studentidValue.Name = "studentidValue";
            this.studentidValue.Size = new System.Drawing.Size(328, 23);
            this.studentidValue.TabIndex = 2;
            // 
            // getSingleStudentBtn
            // 
            this.getSingleStudentBtn.Location = new System.Drawing.Point(359, 223);
            this.getSingleStudentBtn.Name = "getSingleStudentBtn";
            this.getSingleStudentBtn.Size = new System.Drawing.Size(280, 49);
            this.getSingleStudentBtn.TabIndex = 3;
            this.getSingleStudentBtn.Text = "კონკრეტული სტუდენტის ჩამოტვირთვა";
            this.getSingleStudentBtn.UseVisualStyleBackColor = true;
            this.getSingleStudentBtn.Click += new System.EventHandler(this.getSingleStudentBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 648);
            this.Controls.Add(this.getSingleStudentBtn);
            this.Controls.Add(this.studentidValue);
            this.Controls.Add(this.showTeachersBtn);
            this.Controls.Add(this.showStudentsBtn);
            this.Controls.Add(this.HelloLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label HelloLabel;
        private Button showStudentsBtn;
        private Button showTeachersBtn;
        private TextBox studentidValue;
        private Button getSingleStudentBtn;
    }
}