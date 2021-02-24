
namespace TipCalculator
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
            this.EnterLabel = new System.Windows.Forms.Label();
            this.EnterTextBox = new System.Windows.Forms.TextBox();
            this.ComputeButton = new System.Windows.Forms.Button();
            this.ComputeTextBox = new System.Windows.Forms.TextBox();
            this.percentageLabel = new System.Windows.Forms.Label();
            this.percentageAmount = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.TipAmountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EnterLabel
            // 
            this.EnterLabel.AutoSize = true;
            this.EnterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EnterLabel.Location = new System.Drawing.Point(63, 55);
            this.EnterLabel.Name = "EnterLabel";
            this.EnterLabel.Size = new System.Drawing.Size(120, 20);
            this.EnterLabel.TabIndex = 0;
            this.EnterLabel.Text = "Enter Total Bill";
            this.EnterLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // EnterTextBox
            // 
            this.EnterTextBox.Location = new System.Drawing.Point(204, 55);
            this.EnterTextBox.Name = "EnterTextBox";
            this.EnterTextBox.Size = new System.Drawing.Size(291, 22);
            this.EnterTextBox.TabIndex = 1;
            this.EnterTextBox.TextChanged += new System.EventHandler(this.EnterTextBox_TextChanged);
            // 
            // ComputeButton
            // 
            this.ComputeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ComputeButton.Location = new System.Drawing.Point(233, 244);
            this.ComputeButton.Name = "ComputeButton";
            this.ComputeButton.Size = new System.Drawing.Size(113, 48);
            this.ComputeButton.TabIndex = 2;
            this.ComputeButton.Text = "Compute Tip";
            this.ComputeButton.UseVisualStyleBackColor = true;
            this.ComputeButton.Click += new System.EventHandler(this.ComputeButton_Click);
            // 
            // ComputeTextBox
            // 
            this.ComputeTextBox.Location = new System.Drawing.Point(204, 145);
            this.ComputeTextBox.Name = "ComputeTextBox";
            this.ComputeTextBox.Size = new System.Drawing.Size(291, 22);
            this.ComputeTextBox.TabIndex = 3;
            this.ComputeTextBox.TextChanged += new System.EventHandler(this.ComputeTextBox_TextChanged);
            // 
            // percentageLabel
            // 
            this.percentageLabel.AutoSize = true;
            this.percentageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.percentageLabel.Location = new System.Drawing.Point(63, 94);
            this.percentageLabel.Name = "percentageLabel";
            this.percentageLabel.Size = new System.Drawing.Size(122, 20);
            this.percentageLabel.TabIndex = 4;
            this.percentageLabel.Text = "Tip Percentage";
            this.percentageLabel.Click += new System.EventHandler(this.percentageLabel_Click);
            // 
            // percentageAmount
            // 
            this.percentageAmount.Location = new System.Drawing.Point(204, 94);
            this.percentageAmount.Name = "percentageAmount";
            this.percentageAmount.Size = new System.Drawing.Size(291, 22);
            this.percentageAmount.TabIndex = 5;
            this.percentageAmount.TextChanged += new System.EventHandler(this.percentageAmount_TextChanged);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(91, 197);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(92, 17);
            this.totalLabel.TabIndex = 6;
            this.totalLabel.Text = "Total Amount";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(204, 192);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(291, 22);
            this.totalTextBox.TabIndex = 7;
            // 
            // TipAmountLabel
            // 
            this.TipAmountLabel.AutoSize = true;
            this.TipAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TipAmountLabel.Location = new System.Drawing.Point(103, 147);
            this.TipAmountLabel.Name = "TipAmountLabel";
            this.TipAmountLabel.Size = new System.Drawing.Size(80, 17);
            this.TipAmountLabel.TabIndex = 8;
            this.TipAmountLabel.Text = "Tip Amount";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 328);
            this.Controls.Add(this.TipAmountLabel);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.percentageAmount);
            this.Controls.Add(this.percentageLabel);
            this.Controls.Add(this.ComputeTextBox);
            this.Controls.Add(this.ComputeButton);
            this.Controls.Add(this.EnterTextBox);
            this.Controls.Add(this.EnterLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EnterLabel;
        private System.Windows.Forms.TextBox EnterTextBox;
        private System.Windows.Forms.Button ComputeButton;
        private System.Windows.Forms.TextBox ComputeTextBox;
        private System.Windows.Forms.Label percentageLabel;
        private System.Windows.Forms.TextBox percentageAmount;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Label TipAmountLabel;
    }
}

