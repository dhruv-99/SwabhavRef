namespace MDIBankApp
{
    partial class UserForm
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
            this.usernammeLabel = new System.Windows.Forms.Label();
            this.passbookButton = new System.Windows.Forms.Button();
            this.transactionButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameLabel2 = new System.Windows.Forms.Label();
            this.currentBalanceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernammeLabel
            // 
            this.usernammeLabel.AutoSize = true;
            this.usernammeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernammeLabel.Location = new System.Drawing.Point(544, 13);
            this.usernammeLabel.Name = "usernammeLabel";
            this.usernammeLabel.Size = new System.Drawing.Size(0, 17);
            this.usernammeLabel.TabIndex = 0;
            // 
            // passbookButton
            // 
            this.passbookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passbookButton.Location = new System.Drawing.Point(118, 103);
            this.passbookButton.Name = "passbookButton";
            this.passbookButton.Size = new System.Drawing.Size(170, 70);
            this.passbookButton.TabIndex = 1;
            this.passbookButton.Text = "Passbook";
            this.passbookButton.UseVisualStyleBackColor = true;
            this.passbookButton.Click += new System.EventHandler(this.passbookButton_Click);
            // 
            // transactionButton
            // 
            this.transactionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionButton.Location = new System.Drawing.Point(348, 103);
            this.transactionButton.Name = "transactionButton";
            this.transactionButton.Size = new System.Drawing.Size(170, 70);
            this.transactionButton.TabIndex = 2;
            this.transactionButton.Text = "Transaction";
            this.transactionButton.UseVisualStyleBackColor = true;
            this.transactionButton.Click += new System.EventHandler(this.transactionButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Balance";
            // 
            // usernameLabel2
            // 
            this.usernameLabel2.AutoSize = true;
            this.usernameLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel2.Location = new System.Drawing.Point(322, 233);
            this.usernameLabel2.Name = "usernameLabel2";
            this.usernameLabel2.Size = new System.Drawing.Size(0, 17);
            this.usernameLabel2.TabIndex = 5;
            // 
            // currentBalanceLabel
            // 
            this.currentBalanceLabel.AutoSize = true;
            this.currentBalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentBalanceLabel.Location = new System.Drawing.Point(325, 274);
            this.currentBalanceLabel.Name = "currentBalanceLabel";
            this.currentBalanceLabel.Size = new System.Drawing.Size(0, 17);
            this.currentBalanceLabel.TabIndex = 6;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 414);
            this.Controls.Add(this.currentBalanceLabel);
            this.Controls.Add(this.usernameLabel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.transactionButton);
            this.Controls.Add(this.passbookButton);
            this.Controls.Add(this.usernammeLabel);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernammeLabel;
        private System.Windows.Forms.Button passbookButton;
        private System.Windows.Forms.Button transactionButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label usernameLabel2;
        public System.Windows.Forms.Label currentBalanceLabel;
    }
}