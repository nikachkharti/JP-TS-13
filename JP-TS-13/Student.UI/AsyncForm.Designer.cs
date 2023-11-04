namespace Student.UI
{
    partial class AsyncForm
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
            this.CountBtn = new System.Windows.Forms.Button();
            this.charactersQuantity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CountBtn
            // 
            this.CountBtn.Location = new System.Drawing.Point(125, 57);
            this.CountBtn.Name = "CountBtn";
            this.CountBtn.Size = new System.Drawing.Size(75, 23);
            this.CountBtn.TabIndex = 0;
            this.CountBtn.Text = "COUNT";
            this.CountBtn.UseVisualStyleBackColor = true;
            this.CountBtn.Click += new System.EventHandler(this.CountBtn_Click);
            // 
            // charactersQuantity
            // 
            this.charactersQuantity.AutoSize = true;
            this.charactersQuantity.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.charactersQuantity.Location = new System.Drawing.Point(137, 103);
            this.charactersQuantity.Name = "charactersQuantity";
            this.charactersQuantity.Size = new System.Drawing.Size(47, 47);
            this.charactersQuantity.TabIndex = 1;
            this.charactersQuantity.Text = "...";
            // 
            // AsyncForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 207);
            this.Controls.Add(this.charactersQuantity);
            this.Controls.Add(this.CountBtn);
            this.Name = "AsyncForm";
            this.Text = "AsyncForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CountBtn;
        private Label charactersQuantity;
    }
}