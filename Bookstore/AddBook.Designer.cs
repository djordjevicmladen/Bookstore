namespace Bookstore
{
    partial class AddBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBook));
            this.bookCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.bookDiscountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.bookPriceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.bookCategoryLabel = new System.Windows.Forms.Label();
            this.bookDiscountLabel = new System.Windows.Forms.Label();
            this.bookPriceLabel = new System.Windows.Forms.Label();
            this.bookAuthorTextBox = new System.Windows.Forms.TextBox();
            this.bookAuthorLabel = new System.Windows.Forms.Label();
            this.bookNameTextBox = new System.Windows.Forms.TextBox();
            this.bookNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bookDiscountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookPriceNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // bookCategoryComboBox
            // 
            this.bookCategoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookCategoryComboBox.FormattingEnabled = true;
            this.bookCategoryComboBox.Location = new System.Drawing.Point(17, 324);
            this.bookCategoryComboBox.Name = "bookCategoryComboBox";
            this.bookCategoryComboBox.Size = new System.Drawing.Size(370, 28);
            this.bookCategoryComboBox.TabIndex = 24;
            // 
            // bookDiscountNumericUpDown
            // 
            this.bookDiscountNumericUpDown.Location = new System.Drawing.Point(17, 254);
            this.bookDiscountNumericUpDown.Name = "bookDiscountNumericUpDown";
            this.bookDiscountNumericUpDown.Size = new System.Drawing.Size(370, 22);
            this.bookDiscountNumericUpDown.TabIndex = 23;
            // 
            // bookPriceNumericUpDown
            // 
            this.bookPriceNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.bookPriceNumericUpDown.Location = new System.Drawing.Point(17, 184);
            this.bookPriceNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.bookPriceNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bookPriceNumericUpDown.Name = "bookPriceNumericUpDown";
            this.bookPriceNumericUpDown.Size = new System.Drawing.Size(370, 22);
            this.bookPriceNumericUpDown.TabIndex = 22;
            this.bookPriceNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 35);
            this.button1.TabIndex = 21;
            this.button1.Text = "Add book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.addBook_Click);
            // 
            // bookCategoryLabel
            // 
            this.bookCategoryLabel.AutoSize = true;
            this.bookCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookCategoryLabel.Location = new System.Drawing.Point(17, 299);
            this.bookCategoryLabel.Name = "bookCategoryLabel";
            this.bookCategoryLabel.Size = new System.Drawing.Size(116, 20);
            this.bookCategoryLabel.TabIndex = 20;
            this.bookCategoryLabel.Text = "Book category";
            // 
            // bookDiscountLabel
            // 
            this.bookDiscountLabel.AutoSize = true;
            this.bookDiscountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookDiscountLabel.Location = new System.Drawing.Point(17, 229);
            this.bookDiscountLabel.Name = "bookDiscountLabel";
            this.bookDiscountLabel.Size = new System.Drawing.Size(76, 20);
            this.bookDiscountLabel.TabIndex = 19;
            this.bookDiscountLabel.Text = "Discount";
            // 
            // bookPriceLabel
            // 
            this.bookPriceLabel.AutoSize = true;
            this.bookPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookPriceLabel.Location = new System.Drawing.Point(17, 159);
            this.bookPriceLabel.Name = "bookPriceLabel";
            this.bookPriceLabel.Size = new System.Drawing.Size(107, 20);
            this.bookPriceLabel.TabIndex = 18;
            this.bookPriceLabel.Text = "Price of book";
            // 
            // bookAuthorTextBox
            // 
            this.bookAuthorTextBox.Location = new System.Drawing.Point(17, 114);
            this.bookAuthorTextBox.Name = "bookAuthorTextBox";
            this.bookAuthorTextBox.Size = new System.Drawing.Size(370, 22);
            this.bookAuthorTextBox.TabIndex = 17;
            // 
            // bookAuthorLabel
            // 
            this.bookAuthorLabel.AutoSize = true;
            this.bookAuthorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookAuthorLabel.Location = new System.Drawing.Point(17, 89);
            this.bookAuthorLabel.Name = "bookAuthorLabel";
            this.bookAuthorLabel.Size = new System.Drawing.Size(117, 20);
            this.bookAuthorLabel.TabIndex = 16;
            this.bookAuthorLabel.Text = "Author\'s name";
            // 
            // bookNameTextBox
            // 
            this.bookNameTextBox.Location = new System.Drawing.Point(17, 44);
            this.bookNameTextBox.Name = "bookNameTextBox";
            this.bookNameTextBox.Size = new System.Drawing.Size(370, 22);
            this.bookNameTextBox.TabIndex = 15;
            // 
            // bookNameLabel
            // 
            this.bookNameLabel.AutoSize = true;
            this.bookNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookNameLabel.Location = new System.Drawing.Point(17, 19);
            this.bookNameLabel.Name = "bookNameLabel";
            this.bookNameLabel.Size = new System.Drawing.Size(79, 20);
            this.bookNameLabel.TabIndex = 14;
            this.bookNameLabel.Text = "Book title";
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 472);
            this.Controls.Add(this.bookCategoryComboBox);
            this.Controls.Add(this.bookDiscountNumericUpDown);
            this.Controls.Add(this.bookPriceNumericUpDown);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bookCategoryLabel);
            this.Controls.Add(this.bookDiscountLabel);
            this.Controls.Add(this.bookPriceLabel);
            this.Controls.Add(this.bookAuthorTextBox);
            this.Controls.Add(this.bookAuthorLabel);
            this.Controls.Add(this.bookNameTextBox);
            this.Controls.Add(this.bookNameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddBook";
            this.Text = "Add Book";
            this.Load += new System.EventHandler(this.AddBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookDiscountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookPriceNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox bookCategoryComboBox;
        private System.Windows.Forms.NumericUpDown bookDiscountNumericUpDown;
        private System.Windows.Forms.NumericUpDown bookPriceNumericUpDown;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label bookCategoryLabel;
        private System.Windows.Forms.Label bookDiscountLabel;
        private System.Windows.Forms.Label bookPriceLabel;
        private System.Windows.Forms.TextBox bookAuthorTextBox;
        private System.Windows.Forms.Label bookAuthorLabel;
        private System.Windows.Forms.TextBox bookNameTextBox;
        private System.Windows.Forms.Label bookNameLabel;
    }
}