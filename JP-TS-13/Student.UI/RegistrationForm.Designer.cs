namespace Student.UI
{
    partial class RegistrationForm
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
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordValue = new System.Windows.Forms.TextBox();
            this.emailValue = new System.Windows.Forms.TextBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(12, 147);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(57, 15);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "პაროლი";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(12, 67);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(73, 15);
            this.emailLabel.TabIndex = 5;
            this.emailLabel.Text = "ელ-ფოსტა";
            // 
            // passwordValue
            // 
            this.passwordValue.Location = new System.Drawing.Point(12, 165);
            this.passwordValue.Name = "passwordValue";
            this.passwordValue.Size = new System.Drawing.Size(237, 23);
            this.passwordValue.TabIndex = 6;
            this.passwordValue.UseSystemPasswordChar = true;
            // 
            // emailValue
            // 
            this.emailValue.Location = new System.Drawing.Point(12, 85);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(237, 23);
            this.emailValue.TabIndex = 3;
            // 
            // registerBtn
            // 
            this.registerBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.registerBtn.Location = new System.Drawing.Point(0, 264);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(261, 39);
            this.registerBtn.TabIndex = 7;
            this.registerBtn.Text = "რეგისტრაცია";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 303);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.passwordValue);
            this.Controls.Add(this.emailValue);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "რეგისტრაცია";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label passwordLabel;
        private Label emailLabel;
        private TextBox passwordValue;
        private TextBox emailValue;
        private Button registerBtn;
    }
}