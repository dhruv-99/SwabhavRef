namespace BankApp
{
    partial class TransactionForm
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
            this.displayNameLable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.transactionAmountTextBox = new System.Windows.Forms.TextBox();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.WithdrawRadioButton = new System.Windows.Forms.RadioButton();
            this.DepositRadioButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.commitButton = new System.Windows.Forms.Button();
            this.GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayNameLable
            // 
            this.displayNameLable.AutoSize = true;
            this.displayNameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayNameLable.Location = new System.Drawing.Point(533, 18);
            this.displayNameLable.Name = "displayNameLable";
            this.displayNameLable.Size = new System.Drawing.Size(0, 17);
            this.displayNameLable.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Transaction";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amount";
            // 
            // transactionAmountTextBox
            // 
            this.transactionAmountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionAmountTextBox.Location = new System.Drawing.Point(322, 169);
            this.transactionAmountTextBox.Name = "transactionAmountTextBox";
            this.transactionAmountTextBox.Size = new System.Drawing.Size(100, 23);
            this.transactionAmountTextBox.TabIndex = 3;
            // 
            // GroupBox
            // 
            this.GroupBox.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.GroupBox.Controls.Add(this.WithdrawRadioButton);
            this.GroupBox.Controls.Add(this.DepositRadioButton);
            this.GroupBox.Location = new System.Drawing.Point(322, 198);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(200, 68);
            this.GroupBox.TabIndex = 4;
            this.GroupBox.TabStop = false;
            // 
            // WithdrawRadioButton
            // 
            this.WithdrawRadioButton.AutoSize = true;
            this.WithdrawRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WithdrawRadioButton.Location = new System.Drawing.Point(7, 44);
            this.WithdrawRadioButton.Name = "WithdrawRadioButton";
            this.WithdrawRadioButton.Size = new System.Drawing.Size(84, 21);
            this.WithdrawRadioButton.TabIndex = 1;
            this.WithdrawRadioButton.TabStop = true;
            this.WithdrawRadioButton.Text = "Withdraw";
            this.WithdrawRadioButton.UseVisualStyleBackColor = true;
            // 
            // DepositRadioButton
            // 
            this.DepositRadioButton.AutoSize = true;
            this.DepositRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepositRadioButton.Location = new System.Drawing.Point(7, 20);
            this.DepositRadioButton.Name = "DepositRadioButton";
            this.DepositRadioButton.Size = new System.Drawing.Size(74, 21);
            this.DepositRadioButton.TabIndex = 0;
            this.DepositRadioButton.TabStop = true;
            this.DepositRadioButton.Text = "Deposit";
            this.DepositRadioButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(245, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Type";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // commitButton
            // 
            this.commitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commitButton.Location = new System.Drawing.Point(285, 285);
            this.commitButton.Name = "commitButton";
            this.commitButton.Size = new System.Drawing.Size(96, 23);
            this.commitButton.TabIndex = 6;
            this.commitButton.Text = "Commit";
            this.commitButton.UseVisualStyleBackColor = true;
            this.commitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 477);
            this.Controls.Add(this.commitButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.transactionAmountTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.displayNameLable);
            this.Name = "TransactionForm";
            this.Text = "TransactionForm";
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox transactionAmountTextBox;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.RadioButton WithdrawRadioButton;
        private System.Windows.Forms.RadioButton DepositRadioButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button commitButton;
        public System.Windows.Forms.Label displayNameLable;
    }
}