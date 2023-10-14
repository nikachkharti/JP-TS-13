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
            this.teacherIdValue = new System.Windows.Forms.TextBox();
            this.getSingleTeacherBtn = new System.Windows.Forms.Button();
            this.foundTeacherName = new System.Windows.Forms.Label();
            this.TeachersGroup = new System.Windows.Forms.GroupBox();
            this.TeachersGroup.SuspendLayout();
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
            this.showTeachersBtn.Location = new System.Drawing.Point(6, 100);
            this.showTeachersBtn.Name = "showTeachersBtn";
            this.showTeachersBtn.Size = new System.Drawing.Size(152, 28);
            this.showTeachersBtn.TabIndex = 1;
            this.showTeachersBtn.Text = "ყველა მასწავლებელი";
            this.showTeachersBtn.UseVisualStyleBackColor = true;
            this.showTeachersBtn.Click += new System.EventHandler(this.showTeachersBtn_Click);
            // 
            // teacherIdValue
            // 
            this.teacherIdValue.Location = new System.Drawing.Point(6, 24);
            this.teacherIdValue.Name = "teacherIdValue";
            this.teacherIdValue.Size = new System.Drawing.Size(363, 23);
            this.teacherIdValue.TabIndex = 2;
            // 
            // getSingleTeacherBtn
            // 
            this.getSingleTeacherBtn.Location = new System.Drawing.Point(297, 53);
            this.getSingleTeacherBtn.Name = "getSingleTeacherBtn";
            this.getSingleTeacherBtn.Size = new System.Drawing.Size(72, 23);
            this.getSingleTeacherBtn.TabIndex = 3;
            this.getSingleTeacherBtn.Text = "ძებნა";
            this.getSingleTeacherBtn.UseVisualStyleBackColor = true;
            this.getSingleTeacherBtn.Click += new System.EventHandler(this.getSingleTeacherBtn_Click);
            // 
            // foundTeacherName
            // 
            this.foundTeacherName.AutoSize = true;
            this.foundTeacherName.Location = new System.Drawing.Point(6, 57);
            this.foundTeacherName.Name = "foundTeacherName";
            this.foundTeacherName.Size = new System.Drawing.Size(150, 15);
            this.foundTeacherName.TabIndex = 4;
            this.foundTeacherName.Text = "ნაპოვნი მასწავლებელი";
            this.foundTeacherName.Visible = false;
            // 
            // TeachersGroup
            // 
            this.TeachersGroup.Controls.Add(this.teacherIdValue);
            this.TeachersGroup.Controls.Add(this.showTeachersBtn);
            this.TeachersGroup.Controls.Add(this.foundTeacherName);
            this.TeachersGroup.Controls.Add(this.getSingleTeacherBtn);
            this.TeachersGroup.Location = new System.Drawing.Point(12, 9);
            this.TeachersGroup.Name = "TeachersGroup";
            this.TeachersGroup.Size = new System.Drawing.Size(375, 627);
            this.TeachersGroup.TabIndex = 5;
            this.TeachersGroup.TabStop = false;
            this.TeachersGroup.Text = "მასწავლებლები";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 648);
            this.Controls.Add(this.TeachersGroup);
            this.Controls.Add(this.showStudentsBtn);
            this.Controls.Add(this.HelloLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TeachersGroup.ResumeLayout(false);
            this.TeachersGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label HelloLabel;
        private Button showStudentsBtn;
        private Button showTeachersBtn;
        private TextBox teacherIdValue;
        private Button getSingleTeacherBtn;
        private Label foundTeacherName;
        private GroupBox TeachersGroup;
    }
}