namespace Bookstore
{
    partial class PayBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayBill));
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceTextLabel = new System.Windows.Forms.Label();
            this.payBillButton = new System.Windows.Forms.Button();
            this.bookLabel = new System.Windows.Forms.Label();
            this.booksPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(267, 421);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(0, 25);
            this.priceLabel.TabIndex = 16;
            // 
            // priceTextLabel
            // 
            this.priceTextLabel.AutoSize = true;
            this.priceTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextLabel.Location = new System.Drawing.Point(190, 421);
            this.priceTextLabel.Name = "priceTextLabel";
            this.priceTextLabel.Size = new System.Drawing.Size(67, 25);
            this.priceTextLabel.TabIndex = 15;
            this.priceTextLabel.Text = "Price: ";
            // 
            // payBillButton
            // 
            this.payBillButton.Location = new System.Drawing.Point(15, 409);
            this.payBillButton.Name = "payBillButton";
            this.payBillButton.Size = new System.Drawing.Size(125, 35);
            this.payBillButton.TabIndex = 14;
            this.payBillButton.Text = "Pay bill";
            this.payBillButton.UseVisualStyleBackColor = true;
            this.payBillButton.Click += new System.EventHandler(this.payBillButton_Click);
            // 
            // bookLabel
            // 
            this.bookLabel.AutoSize = true;
            this.bookLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookLabel.Location = new System.Drawing.Point(15, 16);
            this.bookLabel.Name = "bookLabel";
            this.bookLabel.Size = new System.Drawing.Size(67, 25);
            this.bookLabel.TabIndex = 13;
            this.bookLabel.Text = "Books";
            // 
            // booksPanel
            // 
            this.booksPanel.AutoScroll = true;
            this.booksPanel.Location = new System.Drawing.Point(15, 51);
            this.booksPanel.Name = "booksPanel";
            this.booksPanel.Size = new System.Drawing.Size(334, 324);
            this.booksPanel.TabIndex = 12;
            // 
            // PayBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 462);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.priceTextLabel);
            this.Controls.Add(this.payBillButton);
            this.Controls.Add(this.bookLabel);
            this.Controls.Add(this.booksPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PayBill";
            this.Text = "Pay Bill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label priceTextLabel;
        private System.Windows.Forms.Button payBillButton;
        private System.Windows.Forms.Label bookLabel;
        private System.Windows.Forms.Panel booksPanel;
    }
}