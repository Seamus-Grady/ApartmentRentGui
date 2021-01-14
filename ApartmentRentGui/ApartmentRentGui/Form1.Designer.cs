namespace ApartmentRentGui
{
    partial class Form1
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
            this.rentTextBox = new System.Windows.Forms.TextBox();
            this.rentLabel = new System.Windows.Forms.Label();
            this.rentButton = new System.Windows.Forms.Button();
            this.DarenLabel = new System.Windows.Forms.Label();
            this.lukeLabel = new System.Windows.Forms.Label();
            this.seamusLabel = new System.Windows.Forms.Label();
            this.cjLabel = new System.Windows.Forms.Label();
            this.darenRentAmount = new System.Windows.Forms.TextBox();
            this.lukeRentAmount = new System.Windows.Forms.TextBox();
            this.seamusRentAmount = new System.Windows.Forms.TextBox();
            this.cjRentAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rentTextBox
            // 
            this.rentTextBox.Location = new System.Drawing.Point(69, 244);
            this.rentTextBox.Name = "rentTextBox";
            this.rentTextBox.Size = new System.Drawing.Size(288, 31);
            this.rentTextBox.TabIndex = 0;
            // 
            // rentLabel
            // 
            this.rentLabel.AutoSize = true;
            this.rentLabel.Location = new System.Drawing.Point(64, 181);
            this.rentLabel.Name = "rentLabel";
            this.rentLabel.Size = new System.Drawing.Size(265, 25);
            this.rentLabel.TabIndex = 1;
            this.rentLabel.Text = "Please Enter Rent Amount";
            // 
            // rentButton
            // 
            this.rentButton.Location = new System.Drawing.Point(64, 325);
            this.rentButton.Name = "rentButton";
            this.rentButton.Size = new System.Drawing.Size(293, 87);
            this.rentButton.TabIndex = 2;
            this.rentButton.Text = "Submit";
            this.rentButton.UseVisualStyleBackColor = true;
            this.rentButton.Click += new System.EventHandler(this.rentButton_Click);
            // 
            // DarenLabel
            // 
            this.DarenLabel.AutoSize = true;
            this.DarenLabel.Location = new System.Drawing.Point(747, 95);
            this.DarenLabel.Name = "DarenLabel";
            this.DarenLabel.Size = new System.Drawing.Size(94, 25);
            this.DarenLabel.TabIndex = 3;
            this.DarenLabel.Text = "Daren  $";
            // 
            // lukeLabel
            // 
            this.lukeLabel.AutoSize = true;
            this.lukeLabel.Location = new System.Drawing.Point(758, 184);
            this.lukeLabel.Name = "lukeLabel";
            this.lukeLabel.Size = new System.Drawing.Size(83, 25);
            this.lukeLabel.TabIndex = 4;
            this.lukeLabel.Text = "Luke  $";
            // 
            // seamusLabel
            // 
            this.seamusLabel.AutoSize = true;
            this.seamusLabel.Location = new System.Drawing.Point(727, 280);
            this.seamusLabel.Name = "seamusLabel";
            this.seamusLabel.Size = new System.Drawing.Size(114, 25);
            this.seamusLabel.TabIndex = 5;
            this.seamusLabel.Text = "Seamus  $";
            // 
            // cjLabel
            // 
            this.cjLabel.AutoSize = true;
            this.cjLabel.Location = new System.Drawing.Point(779, 355);
            this.cjLabel.Name = "cjLabel";
            this.cjLabel.Size = new System.Drawing.Size(62, 25);
            this.cjLabel.TabIndex = 6;
            this.cjLabel.Text = "CJ  $";
            // 
            // darenRentAmount
            // 
            this.darenRentAmount.Location = new System.Drawing.Point(847, 89);
            this.darenRentAmount.Name = "darenRentAmount";
            this.darenRentAmount.ReadOnly = true;
            this.darenRentAmount.Size = new System.Drawing.Size(228, 31);
            this.darenRentAmount.TabIndex = 7;
            // 
            // lukeRentAmount
            // 
            this.lukeRentAmount.Location = new System.Drawing.Point(847, 178);
            this.lukeRentAmount.Name = "lukeRentAmount";
            this.lukeRentAmount.ReadOnly = true;
            this.lukeRentAmount.Size = new System.Drawing.Size(228, 31);
            this.lukeRentAmount.TabIndex = 8;
            // 
            // seamusRentAmount
            // 
            this.seamusRentAmount.Location = new System.Drawing.Point(847, 274);
            this.seamusRentAmount.Name = "seamusRentAmount";
            this.seamusRentAmount.ReadOnly = true;
            this.seamusRentAmount.Size = new System.Drawing.Size(228, 31);
            this.seamusRentAmount.TabIndex = 9;
            // 
            // cjRentAmount
            // 
            this.cjRentAmount.Location = new System.Drawing.Point(847, 349);
            this.cjRentAmount.Name = "cjRentAmount";
            this.cjRentAmount.ReadOnly = true;
            this.cjRentAmount.Size = new System.Drawing.Size(228, 31);
            this.cjRentAmount.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "$";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 616);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cjRentAmount);
            this.Controls.Add(this.seamusRentAmount);
            this.Controls.Add(this.lukeRentAmount);
            this.Controls.Add(this.darenRentAmount);
            this.Controls.Add(this.cjLabel);
            this.Controls.Add(this.seamusLabel);
            this.Controls.Add(this.lukeLabel);
            this.Controls.Add(this.DarenLabel);
            this.Controls.Add(this.rentButton);
            this.Controls.Add(this.rentLabel);
            this.Controls.Add(this.rentTextBox);
            this.Name = "Form1";
            this.Text = "RentCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rentTextBox;
        private System.Windows.Forms.Label rentLabel;
        private System.Windows.Forms.Button rentButton;
        private System.Windows.Forms.Label DarenLabel;
        private System.Windows.Forms.Label lukeLabel;
        private System.Windows.Forms.Label seamusLabel;
        private System.Windows.Forms.Label cjLabel;
        private System.Windows.Forms.TextBox darenRentAmount;
        private System.Windows.Forms.TextBox lukeRentAmount;
        private System.Windows.Forms.TextBox seamusRentAmount;
        private System.Windows.Forms.TextBox cjRentAmount;
        private System.Windows.Forms.Label label1;
    }
}

