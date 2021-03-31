
namespace Login_Data_Storage
{
    partial class editEntry
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.editPassLabel = new System.Windows.Forms.Label();
            this.editUserLabel = new System.Windows.Forms.Label();
            this.editNameLabel = new System.Windows.Forms.Label();
            this.editTitleLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.editButton);
            this.panel1.Controls.Add(this.passTextBox);
            this.panel1.Controls.Add(this.userTextBox);
            this.panel1.Controls.Add(this.titleTextBox);
            this.panel1.Controls.Add(this.editPassLabel);
            this.panel1.Controls.Add(this.editUserLabel);
            this.panel1.Controls.Add(this.editNameLabel);
            this.panel1.Controls.Add(this.editTitleLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 424);
            this.panel1.TabIndex = 0;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(292, 361);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(70, 19);
            this.cancelButton.TabIndex = 17;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(120, 361);
            this.editButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(70, 19);
            this.editButton.TabIndex = 16;
            this.editButton.Text = "Save";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // passTextBox
            // 
            this.passTextBox.Location = new System.Drawing.Point(203, 280);
            this.passTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(160, 20);
            this.passTextBox.TabIndex = 15;
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(203, 209);
            this.userTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(160, 20);
            this.userTextBox.TabIndex = 14;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(203, 136);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(160, 20);
            this.titleTextBox.TabIndex = 13;
            this.titleTextBox.TextChanged += new System.EventHandler(this.titleTextBox_TextChanged);
            // 
            // editPassLabel
            // 
            this.editPassLabel.AutoSize = true;
            this.editPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editPassLabel.Location = new System.Drawing.Point(58, 275);
            this.editPassLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.editPassLabel.Name = "editPassLabel";
            this.editPassLabel.Size = new System.Drawing.Size(106, 24);
            this.editPassLabel.TabIndex = 12;
            this.editPassLabel.Text = "Password:";
            // 
            // editUserLabel
            // 
            this.editUserLabel.AutoSize = true;
            this.editUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editUserLabel.Location = new System.Drawing.Point(58, 203);
            this.editUserLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.editUserLabel.Name = "editUserLabel";
            this.editUserLabel.Size = new System.Drawing.Size(111, 24);
            this.editUserLabel.TabIndex = 11;
            this.editUserLabel.Text = "Username:";
            // 
            // editNameLabel
            // 
            this.editNameLabel.AutoSize = true;
            this.editNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editNameLabel.Location = new System.Drawing.Point(58, 131);
            this.editNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.editNameLabel.Name = "editNameLabel";
            this.editNameLabel.Size = new System.Drawing.Size(117, 24);
            this.editNameLabel.TabIndex = 10;
            this.editNameLabel.Text = "Title Name:";
            // 
            // editTitleLabel
            // 
            this.editTitleLabel.AutoSize = true;
            this.editTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editTitleLabel.Location = new System.Drawing.Point(115, 41);
            this.editTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.editTitleLabel.Name = "editTitleLabel";
            this.editTitleLabel.Size = new System.Drawing.Size(199, 31);
            this.editTitleLabel.TabIndex = 9;
            this.editTitleLabel.Text = "Edit Login Data";
            // 
            // editEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 424);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "editEntry";
            this.Text = "Edit Data";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label editPassLabel;
        private System.Windows.Forms.Label editUserLabel;
        private System.Windows.Forms.Label editNameLabel;
        private System.Windows.Forms.Label editTitleLabel;
    }
}