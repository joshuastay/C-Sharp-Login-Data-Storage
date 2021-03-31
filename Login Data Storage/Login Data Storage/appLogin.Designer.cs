
namespace Login_Data_Storage
{
    partial class appLogin
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
            this.passLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.passBox = new System.Windows.Forms.TextBox();
            this.userBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(64, 117);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(73, 17);
            this.passLabel.TabIndex = 9;
            this.passLabel.Text = "Password:";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(60, 62);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(77, 17);
            this.userLabel.TabIndex = 8;
            this.userLabel.Text = "Username:";
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(154, 114);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(176, 22);
            this.passBox.TabIndex = 7;
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(154, 59);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(176, 22);
            this.userBox.TabIndex = 6;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(154, 177);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(114, 35);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // appLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 265);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.loginButton);
            this.Name = "appLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.Button loginButton;
    }
}