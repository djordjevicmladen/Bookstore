namespace Bookstore
{
    partial class AddToCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddToCart));
            this.bookQuantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.addToCarts = new System.Windows.Forms.Button();
            this.bookQuantityLabel = new System.Windows.Forms.Label();
            this.bookCategoryTextBox = new System.Windows.Forms.TextBox();
            this.bookDiscountTextBox = new System.Windows.Forms.TextBox();
            this.bookPriceTextBox = new System.Windows.Forms.TextBox();
            this.bookAuthorTextBox = new System.Windows.Forms.TextBox();
            this.bookNameTextBox = new System.Windows.Forms.TextBox();
            this.bookCategoryLabel = new System.Windows.Forms.Label();
            this.bookDiscountLabel = new System.Windows.Forms.Label();
            this.bookPriceLabel = new System.Windows.Forms.Label();
            this.bookAuthorLabel = new System.Windows.Forms.Label();
            this.bookNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bookQuantityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // bookQuantityNumericUpDown
            // 
            this.bookQuantityNumericUpDown.Location = new System.Drawing.Point(17, 393);
            this.bookQuantityNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bookQuantityNumericUpDown.Name = "bookQuantityNumericUpDown";
            this.bookQuantityNumericUpDown.Size = new System.Drawing.Size(370, 22);
            this.bookQuantityNumericUpDown.TabIndex = 35;
            this.bookQuantityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // addToCarts
            // 
            this.addToCarts.Location = new System.Drawing.Point(17, 460);
            this.addToCarts.Name = "addToCarts";
            this.addToCarts.Size = new System.Drawing.Size(125, 35);
            this.addToCarts.TabIndex = 34;
            this.addToCarts.Text = "Add to cart";
            this.addToCarts.UseVisualStyleBackColor = true;
            this.addToCarts.Click += new System.EventHandler(this.addToCarts_Click);
            // 
            // bookQuantityLabel
            // 
            this.bookQuantityLabel.AutoSize = true;
            this.bookQuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookQuantityLabel.Location = new System.Drawing.Point(17, 368);
            this.bookQuantityLabel.Name = "bookQuantityLabel";
            this.bookQuantityLabel.Size = new System.Drawing.Size(133, 20);
            this.bookQuantityLabel.TabIndex = 33;
            this.bookQuantityLabel.Text = "Quantity of Book";
            // 
            // bookCategoryTextBox
            // 
            this.bookCategoryTextBox.Location = new System.Drawing.Point(17, 323);
            this.bookCategoryTextBox.Name = "bookCategoryTextBox";
            this.bookCategoryTextBox.ReadOnly = true;
            this.bookCategoryTextBox.Size = new System.Drawing.Size(370, 22);
            this.bookCategoryTextBox.TabIndex = 32;
            // 
            // bookDiscountTextBox
            // 
            this.bookDiscountTextBox.Location = new System.Drawing.Point(17, 253);
            this.bookDiscountTextBox.Name = "bookDiscountTextBox";
            this.bookDiscountTextBox.ReadOnly = true;
            this.bookDiscountTextBox.Size = new System.Drawing.Size(370, 22);
            this.bookDiscountTextBox.TabIndex = 31;
            // 
            // bookPriceTextBox
            // 
            this.bookPriceTextBox.Location = new System.Drawing.Point(17, 183);
            this.bookPriceTextBox.Name = "bookPriceTextBox";
            this.bookPriceTextBox.ReadOnly = true;
            this.bookPriceTextBox.Size = new System.Drawing.Size(370, 22);
            this.bookPriceTextBox.TabIndex = 30;
            // 
            // bookAuthorTextBox
            // 
            this.bookAuthorTextBox.Location = new System.Drawing.Point(17, 113);
            this.bookAuthorTextBox.Name = "bookAuthorTextBox";
            this.bookAuthorTextBox.ReadOnly = true;
            this.bookAuthorTextBox.Size = new System.Drawing.Size(370, 22);
            this.bookAuthorTextBox.TabIndex = 29;
            // 
            // bookNameTextBox
            // 
            this.bookNameTextBox.Location = new System.Drawing.Point(17, 43);
            this.bookNameTextBox.Name = "bookNameTextBox";
            this.bookNameTextBox.ReadOnly = true;
            this.bookNameTextBox.Size = new System.Drawing.Size(370, 22);
            this.bookNameTextBox.TabIndex = 28;
            // 
            // bookCategoryLabel
            // 
            this.bookCategoryLabel.AutoSize = true;
            this.bookCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookCategoryLabel.Location = new System.Drawing.Point(17, 298);
            this.bookCategoryLabel.Name = "bookCategoryLabel";
            this.bookCategoryLabel.Size = new System.Drawing.Size(116, 20);
            this.bookCategoryLabel.TabIndex = 27;
            this.bookCategoryLabel.Text = "Book category";
            // 
            // bookDiscountLabel
            // 
            this.bookDiscountLabel.AutoSize = true;
            this.bookDiscountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookDiscountLabel.Location = new System.Drawing.Point(17, 228);
            this.bookDiscountLabel.Name = "bookDiscountLabel";
            this.bookDiscountLabel.Size = new System.Drawing.Size(76, 20);
            this.bookDiscountLabel.TabIndex = 26;
            this.bookDiscountLabel.Text = "Discount";
            // 
            // bookPriceLabel
            // 
            this.bookPriceLabel.AutoSize = true;
            this.bookPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookPriceLabel.Location = new System.Drawing.Point(17, 157);
            this.bookPriceLabel.Name = "bookPriceLabel";
            this.bookPriceLabel.Size = new System.Drawing.Size(107, 20);
            this.bookPriceLabel.TabIndex = 25;
            this.bookPriceLabel.Text = "Price of book";
            // 
            // bookAuthorLabel
            // 
            this.bookAuthorLabel.AutoSize = true;
            this.bookAuthorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookAuthorLabel.Location = new System.Drawing.Point(17, 87);
            this.bookAuthorLabel.Name = "bookAuthorLabel";
            this.bookAuthorLabel.Size = new System.Drawing.Size(117, 20);
            this.bookAuthorLabel.TabIndex = 24;
            this.bookAuthorLabel.Text = "Author\'s name";
            // 
            // bookNameLabel
            // 
            this.bookNameLabel.AutoSize = true;
            this.bookNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookNameLabel.Location = new System.Drawing.Point(17, 17);
            this.bookNameLabel.Name = "bookNameLabel";
            this.bookNameLabel.Size = new System.Drawing.Size(79, 20);
            this.bookNameLabel.TabIndex = 23;
            this.bookNameLabel.Text = "Book title";
            // 
            // AddToCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 512);
            this.Controls.Add(this.bookQuantityNumericUpDown);
            this.Controls.Add(this.addToCarts);
            this.Controls.Add(this.bookQuantityLabel);
            this.Controls.Add(this.bookCategoryTextBox);
            this.Controls.Add(this.bookDiscountTextBox);
            this.Controls.Add(this.bookPriceTextBox);
            this.Controls.Add(this.bookAuthorTextBox);
            this.Controls.Add(this.bookNameTextBox);
            this.Controls.Add(this.bookCategoryLabel);
            this.Controls.Add(this.bookDiscountLabel);
            this.Controls.Add(this.bookPriceLabel);
            this.Controls.Add(this.bookAuthorLabel);
            this.Controls.Add(this.bookNameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddToCart";
            this.Text = "Add to Cart";
            ((System.ComponentModel.ISupportInitialize)(this.bookQuantityNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown bookQuantityNumericUpDown;
        private System.Windows.Forms.Button addToCarts;
        private System.Windows.Forms.Label bookQuantityLabel;
        private System.Windows.Forms.TextBox bookCategoryTextBox;
        private System.Windows.Forms.TextBox bookDiscountTextBox;
        private System.Windows.Forms.TextBox bookPriceTextBox;
        private System.Windows.Forms.TextBox bookAuthorTextBox;
        private System.Windows.Forms.TextBox bookNameTextBox;
        private System.Windows.Forms.Label bookCategoryLabel;
        private System.Windows.Forms.Label bookDiscountLabel;
        private System.Windows.Forms.Label bookPriceLabel;
        private System.Windows.Forms.Label bookAuthorLabel;
        private System.Windows.Forms.Label bookNameLabel;
    }
}