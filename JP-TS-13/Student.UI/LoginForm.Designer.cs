namespace Student.UI
{
    partial class LoginForm
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
            this.authorizeButton = new System.Windows.Forms.Button();
            this.emailValue = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordValue = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.registrationLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // authorizeButton
            // 
            this.authorizeButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.authorizeButton.Location = new System.Drawing.Point(0, 312);
            this.authorizeButton.Name = "authorizeButton";
            this.authorizeButton.Size = new System.Drawing.Size(261, 39);
            this.authorizeButton.TabIndex = 4;
            this.authorizeButton.Text = "ავტორიზაცია";
            this.authorizeButton.UseVisualStyleBackColor = true;
            this.authorizeButton.Click += new System.EventHandler(this.authorizeButton_Click);
            // 
            // emailValue
            // 
            this.emailValue.Location = new System.Drawing.Point(12, 87);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(237, 23);
            this.emailValue.TabIndex = 1;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(12, 69);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(73, 15);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "ელ-ფოსტა";
            // 
            // passwordValue
            // 
            this.passwordValue.Location = new System.Drawing.Point(12, 167);
            this.passwordValue.Name = "passwordValue";
            this.passwordValue.Size = new System.Drawing.Size(237, 23);
            this.passwordValue.TabIndex = 2;
            this.passwordValue.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(12, 149);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(57, 15);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "პაროლი";
            // 
            // registrationLink
            // 
            this.registrationLink.AutoSize = true;
            this.registrationLink.Location = new System.Drawing.Point(162, 193);
            this.registrationLink.Name = "registrationLink";
            this.registrationLink.Size = new System.Drawing.Size(87, 15);
            this.registrationLink.TabIndex = 3;
            this.registrationLink.TabStop = true;
            this.registrationLink.Text = "რეგისტრაცია";
            this.registrationLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registrationLink_LinkClicked);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 351);
            this.Controls.Add(this.registrationLink);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.passwordValue);
            this.Controls.Add(this.emailValue);
            this.Controls.Add(this.authorizeButton);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ავტორიზაცია";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button authorizeButton;
        private TextBox emailValue;
        private Label emailLabel;
        private TextBox passwordValue;
        private Label passwordLabel;
        private LinkLabel registrationLink;
    }
}