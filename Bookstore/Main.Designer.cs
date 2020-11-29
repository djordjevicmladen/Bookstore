namespace Bookstore
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.billsButton = new System.Windows.Forms.Button();
            this.RadioButton = new System.Windows.Forms.RadioButton();
            this.byNameRadioButton = new System.Windows.Forms.RadioButton();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.bookLabel = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.bookPanel = new System.Windows.Forms.Panel();
            this.billButton = new System.Windows.Forms.Button();
            this.addBookButton = new System.Windows.Forms.Button();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // billsButton
            // 
            this.billsButton.Location = new System.Drawing.Point(9, 388);
            this.billsButton.Name = "billsButton";
            this.billsButton.Size = new System.Drawing.Size(170, 50);
            this.billsButton.TabIndex = 23;
            this.billsButton.Text = "Bills";
            this.billsButton.UseVisualStyleBackColor = true;
            this.billsButton.Click += new System.EventHandler(this.billsButton_Click);
            // 
            // RadioButton
            // 
            this.RadioButton.AutoSize = true;
            this.RadioButton.Location = new System.Drawing.Point(9, 209);
            this.RadioButton.Name = "RadioButton";
            this.RadioButton.Size = new System.Drawing.Size(90, 21);
            this.RadioButton.TabIndex = 22;
            this.RadioButton.TabStop = true;
            this.RadioButton.Text = "By author";
            this.RadioButton.UseVisualStyleBackColor = true;
            // 
            // byNameRadioButton
            // 
            this.byNameRadioButton.AutoSize = true;
            this.byNameRadioButton.Location = new System.Drawing.Point(9, 182);
            this.byNameRadioButton.Name = "byNameRadioButton";
            this.byNameRadioButton.Size = new System.Drawing.Size(71, 21);
            this.byNameRadioButton.TabIndex = 21;
            this.byNameRadioButton.TabStop = true;
            this.byNameRadioButton.Text = "By title";
            this.byNameRadioButton.UseVisualStyleBackColor = true;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(9, 154);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(170, 22);
            this.searchTextBox.TabIndex = 20;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(10, 115);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(75, 25);
            this.searchLabel.TabIndex = 19;
            this.searchLabel.Text = "Search";
            // 
            // bookLabel
            // 
            this.bookLabel.AutoSize = true;
            this.bookLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookLabel.Location = new System.Drawing.Point(207, 8);
            this.bookLabel.Name = "bookLabel";
            this.bookLabel.Size = new System.Drawing.Size(67, 25);
            this.bookLabel.TabIndex = 18;
            this.bookLabel.Text = "Books";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(9, 47);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(170, 24);
            this.comboBoxCategory.TabIndex = 17;
            this.comboBoxCategory.SelectedValueChanged += new System.EventHandler(this.comboBoxCategory_SelectedValueChanged);
            // 
            // bookPanel
            // 
            this.bookPanel.AutoScroll = true;
            this.bookPanel.Location = new System.Drawing.Point(185, 47);
            this.bookPanel.Name = "bookPanel";
            this.bookPanel.Size = new System.Drawing.Size(320, 391);
            this.bookPanel.TabIndex = 16;
            // 
            // billButton
            // 
            this.billButton.Location = new System.Drawing.Point(9, 331);
            this.billButton.Name = "billButton";
            this.billButton.Size = new System.Drawing.Size(170, 50);
            this.billButton.TabIndex = 15;
            this.billButton.Text = "Bill";
            this.billButton.UseVisualStyleBackColor = true;
            this.billButton.Click += new System.EventHandler(this.billButton_Click);
            // 
            // addBookButton
            // 
            this.addBookButton.Location = new System.Drawing.Point(9, 275);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(170, 50);
            this.addBookButton.TabIndex = 14;
            this.addBookButton.Text = "Add book";
            this.addBookButton.UseVisualStyleBackColor = true;
            this.addBookButton.Click += new System.EventHandler(this.addBook_Click);
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.Location = new System.Drawing.Point(10, 8);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(107, 25);
            this.categoryLabel.TabIndex = 13;
            this.categoryLabel.Text = "Categories";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 467);
            this.Controls.Add(this.billsButton);
            this.Controls.Add(this.RadioButton);
            this.Controls.Add(this.byNameRadioButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.bookLabel);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.bookPanel);
            this.Controls.Add(this.billButton);
            this.Controls.Add(this.addBookButton);
            this.Controls.Add(this.categoryLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Bookstore";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button billsButton;
        private System.Windows.Forms.RadioButton RadioButton;
        private System.Windows.Forms.RadioButton byNameRadioButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label bookLabel;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Panel bookPanel;
        private System.Windows.Forms.Button billButton;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.Label categoryLabel;
    }
}