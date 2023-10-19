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
            this.StudentsList = new System.Windows.Forms.ListBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.DobLabel = new System.Windows.Forms.Label();
            this.pinLabel = new System.Windows.Forms.Label();
            this.firstNameValue = new System.Windows.Forms.TextBox();
            this.lastNameValue = new System.Windows.Forms.TextBox();
            this.dobValue = new System.Windows.Forms.DateTimePicker();
            this.pinValue = new System.Windows.Forms.TextBox();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
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
            // StudentsList
            // 
            this.StudentsList.FormattingEnabled = true;
            this.StudentsList.ItemHeight = 15;
            this.StudentsList.Location = new System.Drawing.Point(757, 143);
            this.StudentsList.Name = "StudentsList";
            this.StudentsList.Size = new System.Drawing.Size(408, 229);
            this.StudentsList.TabIndex = 6;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(757, 375);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(53, 15);
            this.firstNameLabel.TabIndex = 7;
            this.firstNameLabel.Text = "სახელი";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(757, 419);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(42, 15);
            this.lastNameLabel.TabIndex = 7;
            this.lastNameLabel.Text = "გვარი";
            // 
            // DobLabel
            // 
            this.DobLabel.AutoSize = true;
            this.DobLabel.Location = new System.Drawing.Point(757, 463);
            this.DobLabel.Name = "DobLabel";
            this.DobLabel.Size = new System.Drawing.Size(127, 15);
            this.DobLabel.TabIndex = 7;
            this.DobLabel.Text = "დაბადების თარიღი";
            // 
            // pinLabel
            // 
            this.pinLabel.AutoSize = true;
            this.pinLabel.Location = new System.Drawing.Point(757, 507);
            this.pinLabel.Name = "pinLabel";
            this.pinLabel.Size = new System.Drawing.Size(101, 15);
            this.pinLabel.TabIndex = 7;
            this.pinLabel.Text = "პირადი ნომერი";
            // 
            // firstNameValue
            // 
            this.firstNameValue.Location = new System.Drawing.Point(757, 393);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.Size = new System.Drawing.Size(232, 23);
            this.firstNameValue.TabIndex = 2;
            // 
            // lastNameValue
            // 
            this.lastNameValue.Location = new System.Drawing.Point(757, 437);
            this.lastNameValue.Name = "lastNameValue";
            this.lastNameValue.Size = new System.Drawing.Size(232, 23);
            this.lastNameValue.TabIndex = 2;
            // 
            // dobValue
            // 
            this.dobValue.Location = new System.Drawing.Point(757, 481);
            this.dobValue.Name = "dobValue";
            this.dobValue.Size = new System.Drawing.Size(232, 23);
            this.dobValue.TabIndex = 8;
            // 
            // pinValue
            // 
            this.pinValue.Location = new System.Drawing.Point(757, 525);
            this.pinValue.Name = "pinValue";
            this.pinValue.Size = new System.Drawing.Size(232, 23);
            this.pinValue.TabIndex = 2;
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(1054, 393);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(111, 23);
            this.editBtn.TabIndex = 9;
            this.editBtn.Text = "რედაქტირება";
            this.editBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(1054, 436);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(111, 23);
            this.deleteBtn.TabIndex = 9;
            this.deleteBtn.Text = "წაშლა";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(1054, 525);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(111, 23);
            this.addBtn.TabIndex = 9;
            this.addBtn.Text = "დამატება";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 648);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.dobValue);
            this.Controls.Add(this.pinValue);
            this.Controls.Add(this.lastNameValue);
            this.Controls.Add(this.firstNameValue);
            this.Controls.Add(this.pinLabel);
            this.Controls.Add(this.DobLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.StudentsList);
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
        private ListBox StudentsList;
        private Label firstNameLabel;
        private Label lastNameLabel;
        private Label DobLabel;
        private Label pinLabel;
        private TextBox firstNameValue;
        private TextBox lastNameValue;
        private DateTimePicker dobValue;
        private TextBox pinValue;
        private Button editBtn;
        private Button deleteBtn;
        private Button addBtn;
    }
}