namespace gunter.roy.bestbuy
{
    partial class BestBuyAPIApp
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
            this._exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._searchTermTextBox = new System.Windows.Forms.TextBox();
            this._addSearchTermButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this._searchTermsListBox = new System.Windows.Forms.ListBox();
            this._searchProductsButton = new System.Windows.Forms.Button();
            this._resultsListBox = new System.Windows.Forms.ListBox();
            this._clearSearchTermsButton = new System.Windows.Forms.Button();
            this._clearResultsButton = new System.Windows.Forms.Button();
            this._requestTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._startingPageTextBox = new System.Windows.Forms.TextBox();
            this._pageSizeTextBox = new System.Windows.Forms.TextBox();
            this._fieldsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this._totalPagesTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _exitButton
            // 
            this._exitButton.Location = new System.Drawing.Point(579, 365);
            this._exitButton.Name = "_exitButton";
            this._exitButton.Size = new System.Drawing.Size(78, 23);
            this._exitButton.TabIndex = 1;
            this._exitButton.Text = "Exit";
            this._exitButton.UseVisualStyleBackColor = true;
            this._exitButton.Click += new System.EventHandler(this._exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search Term:";
            // 
            // _searchTermTextBox
            // 
            this._searchTermTextBox.Location = new System.Drawing.Point(89, 10);
            this._searchTermTextBox.Name = "_searchTermTextBox";
            this._searchTermTextBox.Size = new System.Drawing.Size(322, 20);
            this._searchTermTextBox.TabIndex = 6;
            // 
            // _addSearchTermButton
            // 
            this._addSearchTermButton.Location = new System.Drawing.Point(417, 7);
            this._addSearchTermButton.Name = "_addSearchTermButton";
            this._addSearchTermButton.Size = new System.Drawing.Size(108, 23);
            this._addSearchTermButton.TabIndex = 7;
            this._addSearchTermButton.Text = "Add Search Term";
            this._addSearchTermButton.UseVisualStyleBackColor = true;
            this._addSearchTermButton.Click += new System.EventHandler(this._addSearchTermButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Results:";
            // 
            // _searchTermsListBox
            // 
            this._searchTermsListBox.FormattingEnabled = true;
            this._searchTermsListBox.Location = new System.Drawing.Point(455, 49);
            this._searchTermsListBox.Name = "_searchTermsListBox";
            this._searchTermsListBox.Size = new System.Drawing.Size(202, 82);
            this._searchTermsListBox.TabIndex = 9;
            // 
            // _searchProductsButton
            // 
            this._searchProductsButton.Location = new System.Drawing.Point(342, 365);
            this._searchProductsButton.Name = "_searchProductsButton";
            this._searchProductsButton.Size = new System.Drawing.Size(102, 23);
            this._searchProductsButton.TabIndex = 10;
            this._searchProductsButton.Text = "Search Products";
            this._searchProductsButton.UseVisualStyleBackColor = true;
            this._searchProductsButton.Click += new System.EventHandler(this._searchProductsButton_Click);
            // 
            // _resultsListBox
            // 
            this._resultsListBox.FormattingEnabled = true;
            this._resultsListBox.HorizontalScrollbar = true;
            this._resultsListBox.Location = new System.Drawing.Point(15, 166);
            this._resultsListBox.MultiColumn = true;
            this._resultsListBox.Name = "_resultsListBox";
            this._resultsListBox.Size = new System.Drawing.Size(643, 160);
            this._resultsListBox.TabIndex = 11;
            // 
            // _clearSearchTermsButton
            // 
            this._clearSearchTermsButton.Location = new System.Drawing.Point(531, 7);
            this._clearSearchTermsButton.Name = "_clearSearchTermsButton";
            this._clearSearchTermsButton.Size = new System.Drawing.Size(124, 23);
            this._clearSearchTermsButton.TabIndex = 12;
            this._clearSearchTermsButton.Text = "Clear Search Term";
            this._clearSearchTermsButton.UseVisualStyleBackColor = true;
            this._clearSearchTermsButton.Click += new System.EventHandler(this._clearSearchTermsButton_Click);
            // 
            // _clearResultsButton
            // 
            this._clearResultsButton.Location = new System.Drawing.Point(449, 365);
            this._clearResultsButton.Name = "_clearResultsButton";
            this._clearResultsButton.Size = new System.Drawing.Size(124, 23);
            this._clearResultsButton.TabIndex = 13;
            this._clearResultsButton.Text = "Clear Results Term";
            this._clearResultsButton.UseVisualStyleBackColor = true;
            this._clearResultsButton.Click += new System.EventHandler(this._clearResultsButton_Click);
            // 
            // _requestTextBox
            // 
            this._requestTextBox.Location = new System.Drawing.Point(18, 333);
            this._requestTextBox.Name = "_requestTextBox";
            this._requestTextBox.Size = new System.Drawing.Size(640, 20);
            this._requestTextBox.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Fields:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Starting Page:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Page Size:";
            // 
            // _startingPageTextBox
            // 
            this._startingPageTextBox.Location = new System.Drawing.Point(341, 49);
            this._startingPageTextBox.Name = "_startingPageTextBox";
            this._startingPageTextBox.Size = new System.Drawing.Size(39, 20);
            this._startingPageTextBox.TabIndex = 19;
            // 
            // _pageSizeTextBox
            // 
            this._pageSizeTextBox.Location = new System.Drawing.Point(342, 76);
            this._pageSizeTextBox.Name = "_pageSizeTextBox";
            this._pageSizeTextBox.Size = new System.Drawing.Size(38, 20);
            this._pageSizeTextBox.TabIndex = 20;
            // 
            // _fieldsCheckedListBox
            // 
            this._fieldsCheckedListBox.FormattingEnabled = true;
            this._fieldsCheckedListBox.Location = new System.Drawing.Point(89, 49);
            this._fieldsCheckedListBox.Name = "_fieldsCheckedListBox";
            this._fieldsCheckedListBox.Size = new System.Drawing.Size(166, 79);
            this._fieldsCheckedListBox.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(386, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "of";
            // 
            // _totalPagesTextBox
            // 
            this._totalPagesTextBox.Location = new System.Drawing.Point(408, 76);
            this._totalPagesTextBox.Name = "_totalPagesTextBox";
            this._totalPagesTextBox.Size = new System.Drawing.Size(41, 20);
            this._totalPagesTextBox.TabIndex = 23;
            // 
            // BestBuyAPIApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 400);
            this.Controls.Add(this._totalPagesTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._fieldsCheckedListBox);
            this.Controls.Add(this._pageSizeTextBox);
            this.Controls.Add(this._startingPageTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._requestTextBox);
            this.Controls.Add(this._clearResultsButton);
            this.Controls.Add(this._clearSearchTermsButton);
            this.Controls.Add(this._resultsListBox);
            this.Controls.Add(this._searchProductsButton);
            this.Controls.Add(this._searchTermsListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._addSearchTermButton);
            this.Controls.Add(this._searchTermTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BestBuyAPIApp";
            this.Text = "BestBuy API Products";
            this.Load += new System.EventHandler(this.BestBuyAPIApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button _exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _searchTermTextBox;
        private System.Windows.Forms.Button _addSearchTermButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox _searchTermsListBox;
        private System.Windows.Forms.Button _searchProductsButton;
        private System.Windows.Forms.ListBox _resultsListBox;
        private System.Windows.Forms.Button _clearSearchTermsButton;
        private System.Windows.Forms.Button _clearResultsButton;
        private System.Windows.Forms.TextBox _requestTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _startingPageTextBox;
        private System.Windows.Forms.TextBox _pageSizeTextBox;
        private System.Windows.Forms.CheckedListBox _fieldsCheckedListBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _totalPagesTextBox;
    }
}

