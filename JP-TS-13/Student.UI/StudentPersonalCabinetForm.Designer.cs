namespace Student.UI
{
    partial class StudentPersonalCabinetForm
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
            this.dobValue = new System.Windows.Forms.DateTimePicker();
            this.pinValue = new System.Windows.Forms.TextBox();
            this.lastNameValue = new System.Windows.Forms.TextBox();
            this.firstNameValue = new System.Windows.Forms.TextBox();
            this.pinLabel = new System.Windows.Forms.Label();
            this.DobLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.editBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dobValue
            // 
            this.dobValue.Location = new System.Drawing.Point(12, 115);
            this.dobValue.Name = "dobValue";
            this.dobValue.Size = new System.Drawing.Size(283, 23);
            this.dobValue.TabIndex = 16;
            // 
            // pinValue
            // 
            this.pinValue.Location = new System.Drawing.Point(12, 159);
            this.pinValue.Name = "pinValue";
            this.pinValue.Size = new System.Drawing.Size(283, 23);
            this.pinValue.TabIndex = 9;
            // 
            // lastNameValue
            // 
            this.lastNameValue.Location = new System.Drawing.Point(12, 71);
            this.lastNameValue.Name = "lastNameValue";
            this.lastNameValue.Size = new System.Drawing.Size(283, 23);
            this.lastNameValue.TabIndex = 10;
            // 
            // firstNameValue
            // 
            this.firstNameValue.Location = new System.Drawing.Point(12, 27);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.Size = new System.Drawing.Size(283, 23);
            this.firstNameValue.TabIndex = 11;
            // 
            // pinLabel
            // 
            this.pinLabel.AutoSize = true;
            this.pinLabel.Location = new System.Drawing.Point(12, 141);
            this.pinLabel.Name = "pinLabel";
            this.pinLabel.Size = new System.Drawing.Size(101, 15);
            this.pinLabel.TabIndex = 12;
            this.pinLabel.Text = "პირადი ნომერი";
            // 
            // DobLabel
            // 
            this.DobLabel.AutoSize = true;
            this.DobLabel.Location = new System.Drawing.Point(12, 97);
            this.DobLabel.Name = "DobLabel";
            this.DobLabel.Size = new System.Drawing.Size(127, 15);
            this.DobLabel.TabIndex = 13;
            this.DobLabel.Text = "დაბადების თარიღი";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(12, 53);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(42, 15);
            this.lastNameLabel.TabIndex = 14;
            this.lastNameLabel.Text = "გვარი";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(12, 9);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(53, 15);
            this.firstNameLabel.TabIndex = 15;
            this.firstNameLabel.Text = "სახელი";
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(12, 200);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(111, 23);
            this.editBtn.TabIndex = 17;
            this.editBtn.Text = "რედაქტირება";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // StudentPersonalCabinetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 253);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.dobValue);
            this.Controls.Add(this.pinValue);
            this.Controls.Add(this.lastNameValue);
            this.Controls.Add(this.firstNameValue);
            this.Controls.Add(this.pinLabel);
            this.Controls.Add(this.DobLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Name = "StudentPersonalCabinetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentPersonalCabinetForm";
            this.Load += new System.EventHandler(this.StudentPersonalCabinetForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dobValue;
        private TextBox pinValue;
        private TextBox lastNameValue;
        private TextBox firstNameValue;
        private Label pinLabel;
        private Label DobLabel;
        private Label lastNameLabel;
        private Label firstNameLabel;
        private Button editBtn;
    }
}