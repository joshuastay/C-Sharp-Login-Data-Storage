
namespace Login_Data_Storage
{
    partial class loginCreation
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.passBox = new System.Windows.Forms.TextBox();
            this.userBox = new System.Windows.Forms.TextBox();
            this.createUser = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.titleLabel);
            this.panel1.Controls.Add(this.passLabel);
            this.panel1.Controls.Add(this.userLabel);
            this.panel1.Controls.Add(this.passBox);
            this.panel1.Controls.Add(this.userBox);
            this.panel1.Controls.Add(this.createUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 315);
            this.panel1.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.titleLabel.Location = new System.Drawing.Point(12, 47);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(380, 29);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Create a Username and Password";
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(50, 184);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(73, 17);
            this.passLabel.TabIndex = 4;
            this.passLabel.Text = "Password:";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(46, 129);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(77, 17);
            this.userLabel.TabIndex = 3;
            this.userLabel.Text = "Username:";
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(140, 181);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(176, 22);
            this.passBox.TabIndex = 2;
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(140, 126);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(176, 22);
            this.userBox.TabIndex = 1;
            // 
            // createUser
            // 
            this.createUser.Location = new System.Drawing.Point(140, 244);
            this.createUser.Name = "createUser";
            this.createUser.Size = new System.Drawing.Size(114, 35);
            this.createUser.TabIndex = 0;
            this.createUser.Text = "Create User";
            this.createUser.UseVisualStyleBackColor = true;
            this.createUser.Click += new System.EventHandler(this.createUser_Click);
            // 
            // loginCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 315);
            this.Controls.Add(this.panel1);
            this.Name = "loginCreation";
            this.Text = "Create Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.Button createUser;
    }
}

