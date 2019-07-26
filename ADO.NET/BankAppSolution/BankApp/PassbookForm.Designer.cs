namespace BankApp
{
    partial class PassbookForm
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passbookGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.passbookLable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.passbookGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.CausesValidation = false;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(533, 9);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(0, 17);
            this.usernameLabel.TabIndex = 0;
            // 
            // passbookGridView
            // 
            this.passbookGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.passbookGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.passbookGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.passbookGridView.Location = new System.Drawing.Point(51, 124);
            this.passbookGridView.Name = "passbookGridView";
            this.passbookGridView.Size = new System.Drawing.Size(563, 150);
            this.passbookGridView.TabIndex = 1;
            this.passbookGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(51, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Download ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // passbookLable
            // 
            this.passbookLable.AutoSize = true;
            this.passbookLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passbookLable.Location = new System.Drawing.Point(270, 58);
            this.passbookLable.Name = "passbookLable";
            this.passbookLable.Size = new System.Drawing.Size(108, 26);
            this.passbookLable.TabIndex = 3;
            this.passbookLable.Text = "Passbook";
            // 
            // PassbookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 477);
            this.Controls.Add(this.passbookLable);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passbookGridView);
            this.Controls.Add(this.usernameLabel);
            this.Name = "PassbookForm";
            this.Text = "PassbookForm";
            ((System.ComponentModel.ISupportInitialize)(this.passbookGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.DataGridView passbookGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label passbookLable;
    }
}