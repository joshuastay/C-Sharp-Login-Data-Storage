
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 522);
            this.panel1.TabIndex = 0;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(389, 444);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(94, 23);
            this.cancelButton.TabIndex = 17;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(160, 444);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(94, 23);
            this.editButton.TabIndex = 16;
            this.editButton.Text = "Save";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // passTextBox
            // 
            this.passTextBox.Location = new System.Drawing.Point(271, 345);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(212, 22);
            this.passTextBox.TabIndex = 15;
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(271, 257);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(212, 22);
            this.userTextBox.TabIndex = 14;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(271, 168);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(212, 22);
            this.titleTextBox.TabIndex = 13;
            // 
            // editPassLabel
            // 
            this.editPassLabel.AutoSize = true;
            this.editPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editPassLabel.Location = new System.Drawing.Point(77, 338);
            this.editPassLabel.Name = "editPassLabel";
            this.editPassLabel.Size = new System.Drawing.Size(135, 29);
            this.editPassLabel.TabIndex = 12;
            this.editPassLabel.Text = "Password:";
            // 
            // editUserLabel
            // 
            this.editUserLabel.AutoSize = true;
            this.editUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editUserLabel.Location = new System.Drawing.Point(77, 250);
            this.editUserLabel.Name = "editUserLabel";
            this.editUserLabel.Size = new System.Drawing.Size(139, 29);
            this.editUserLabel.TabIndex = 11;
            this.editUserLabel.Text = "Username:";
            // 
            // editNameLabel
            // 
            this.editNameLabel.AutoSize = true;
            this.editNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editNameLabel.Location = new System.Drawing.Point(77, 161);
            this.editNameLabel.Name = "editNameLabel";
            this.editNameLabel.Size = new System.Drawing.Size(149, 29);
            this.editNameLabel.TabIndex = 10;
            this.editNameLabel.Text = "Title Name:";
            // 
            // editTitleLabel
            // 
            this.editTitleLabel.AutoSize = true;
            this.editTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editTitleLabel.Location = new System.Drawing.Point(153, 51);
            this.editTitleLabel.Name = "editTitleLabel";
            this.editTitleLabel.Size = new System.Drawing.Size(250, 39);
            this.editTitleLabel.TabIndex = 9;
            this.editTitleLabel.Text = "Edit Login Data";
            // 
            // editEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 522);
            this.Controls.Add(this.panel1);
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