
namespace Login_Data_Storage
{
    partial class loginDataStorage
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
            this.loginSelection = new System.Windows.Forms.Panel();
            this.editButton = new System.Windows.Forms.Button();
            this.createNewButton = new System.Windows.Forms.Button();
            this.passDisplayLabel = new System.Windows.Forms.Label();
            this.passLabelDisplay = new System.Windows.Forms.Label();
            this.userDisplayLabel = new System.Windows.Forms.Label();
            this.userLabelDisplay = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.loginSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginSelection
            // 
            this.loginSelection.Controls.Add(this.editButton);
            this.loginSelection.Controls.Add(this.createNewButton);
            this.loginSelection.Controls.Add(this.passDisplayLabel);
            this.loginSelection.Controls.Add(this.passLabelDisplay);
            this.loginSelection.Controls.Add(this.userDisplayLabel);
            this.loginSelection.Controls.Add(this.userLabelDisplay);
            this.loginSelection.Controls.Add(this.comboBox1);
            this.loginSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginSelection.Location = new System.Drawing.Point(0, 0);
            this.loginSelection.Name = "loginSelection";
            this.loginSelection.Size = new System.Drawing.Size(669, 603);
            this.loginSelection.TabIndex = 0;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(366, 483);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(111, 30);
            this.editButton.TabIndex = 6;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // createNewButton
            // 
            this.createNewButton.Location = new System.Drawing.Point(173, 483);
            this.createNewButton.Name = "createNewButton";
            this.createNewButton.Size = new System.Drawing.Size(111, 30);
            this.createNewButton.TabIndex = 5;
            this.createNewButton.Text = "Create New";
            this.createNewButton.UseVisualStyleBackColor = true;
            // 
            // passDisplayLabel
            // 
            this.passDisplayLabel.AutoSize = true;
            this.passDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passDisplayLabel.Location = new System.Drawing.Point(413, 298);
            this.passDisplayLabel.Name = "passDisplayLabel";
            this.passDisplayLabel.Size = new System.Drawing.Size(64, 25);
            this.passDisplayLabel.TabIndex = 4;
            this.passDisplayLabel.Text = "label2";
            // 
            // passLabelDisplay
            // 
            this.passLabelDisplay.AutoSize = true;
            this.passLabelDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabelDisplay.Location = new System.Drawing.Point(168, 298);
            this.passLabelDisplay.Name = "passLabelDisplay";
            this.passLabelDisplay.Size = new System.Drawing.Size(113, 25);
            this.passLabelDisplay.TabIndex = 3;
            this.passLabelDisplay.Text = "Password:";
            // 
            // userDisplayLabel
            // 
            this.userDisplayLabel.AutoSize = true;
            this.userDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userDisplayLabel.Location = new System.Drawing.Point(413, 211);
            this.userDisplayLabel.Name = "userDisplayLabel";
            this.userDisplayLabel.Size = new System.Drawing.Size(64, 25);
            this.userDisplayLabel.TabIndex = 2;
            this.userDisplayLabel.Text = "label2";
            this.userDisplayLabel.Click += new System.EventHandler(this.userDisplayLabel_Click);
            // 
            // userLabelDisplay
            // 
            this.userLabelDisplay.AutoSize = true;
            this.userLabelDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabelDisplay.Location = new System.Drawing.Point(168, 211);
            this.userLabelDisplay.Name = "userLabelDisplay";
            this.userLabelDisplay.Size = new System.Drawing.Size(117, 25);
            this.userLabelDisplay.TabIndex = 1;
            this.userLabelDisplay.Text = "Username:";
            this.userLabelDisplay.Click += new System.EventHandler(this.userLabelDisplay_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(173, 123);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(304, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // loginDataStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 603);
            this.Controls.Add(this.loginSelection);
            this.Name = "loginDataStorage";
            this.Text = "Login Data Storage";
            this.loginSelection.ResumeLayout(false);
            this.loginSelection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginSelection;
        private System.Windows.Forms.Label userDisplayLabel;
        private System.Windows.Forms.Label userLabelDisplay;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label passDisplayLabel;
        private System.Windows.Forms.Label passLabelDisplay;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button createNewButton;
    }
}