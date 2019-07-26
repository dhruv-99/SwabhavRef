namespace BankApp
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
            this.PassbookButton = new System.Windows.Forms.Button();
            this.DoTransactionButton = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.usernameLabel2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.currentBalanceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PassbookButton
            // 
            this.PassbookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassbookButton.Location = new System.Drawing.Point(116, 120);
            this.PassbookButton.Name = "PassbookButton";
            this.PassbookButton.Size = new System.Drawing.Size(150, 50);
            this.PassbookButton.TabIndex = 0;
            this.PassbookButton.Text = "Passbook";
            this.PassbookButton.UseVisualStyleBackColor = true;
            this.PassbookButton.Click += new System.EventHandler(this.PassbookButton_Click);
            // 
            // DoTransactionButton
            // 
            this.DoTransactionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoTransactionButton.Location = new System.Drawing.Point(335, 120);
            this.DoTransactionButton.Name = "DoTransactionButton";
            this.DoTransactionButton.Size = new System.Drawing.Size(150, 50);
            this.DoTransactionButton.TabIndex = 1;
            this.DoTransactionButton.Text = "Do Transaction";
            this.DoTransactionButton.UseVisualStyleBackColor = true;
            this.DoTransactionButton.Click += new System.EventHandler(this.DoTransactionButton_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(541, 13);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(0, 17);
            this.usernameLabel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // usernameLabel2
            // 
            this.usernameLabel2.AutoSize = true;
            this.usernameLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel2.Location = new System.Drawing.Point(332, 229);
            this.usernameLabel2.Name = "usernameLabel2";
            this.usernameLabel2.Size = new System.Drawing.Size(0, 17);
            this.usernameLabel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(189, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Current Balance";
            // 
            // currentBalanceLabel
            // 
            this.currentBalanceLabel.AutoSize = true;
            this.currentBalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentBalanceLabel.Location = new System.Drawing.Point(335, 271);
            this.currentBalanceLabel.Name = "currentBalanceLabel";
            this.currentBalanceLabel.Size = new System.Drawing.Size(0, 17);
            this.currentBalanceLabel.TabIndex = 6;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 477);
            this.Controls.Add(this.currentBalanceLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usernameLabel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.DoTransactionButton);
            this.Controls.Add(this.PassbookButton);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PassbookButton;
        private System.Windows.Forms.Button DoTransactionButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label usernameLabel2;
        public System.Windows.Forms.Label usernameLabel;
        public System.Windows.Forms.Label currentBalanceLabel;
    }
}