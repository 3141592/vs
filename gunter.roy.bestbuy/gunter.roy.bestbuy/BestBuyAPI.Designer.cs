namespace gunter.roy.bestbuy
{
    partial class BestBuyAPI
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
            this._getReviewsButton = new System.Windows.Forms.Button();
            this._getProductsButton = new System.Windows.Forms.Button();
            this._mostViewedButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._searchTermTextBox = new System.Windows.Forms.TextBox();
            this._addSearchTermButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this._searchTermsListBox = new System.Windows.Forms.ListBox();
            this._searchButton = new System.Windows.Forms.Button();
            this._resultsListBox = new System.Windows.Forms.ListBox();
            this._clearSearchTermsButton = new System.Windows.Forms.Button();
            this._clearResultsButton = new System.Windows.Forms.Button();
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
            // _getReviewsButton
            // 
            this._getReviewsButton.Location = new System.Drawing.Point(498, 365);
            this._getReviewsButton.Name = "_getReviewsButton";
            this._getReviewsButton.Size = new System.Drawing.Size(78, 23);
            this._getReviewsButton.TabIndex = 2;
            this._getReviewsButton.Text = "Get Reviews";
            this._getReviewsButton.UseVisualStyleBackColor = true;
            // 
            // _getProductsButton
            // 
            this._getProductsButton.Location = new System.Drawing.Point(417, 365);
            this._getProductsButton.Name = "_getProductsButton";
            this._getProductsButton.Size = new System.Drawing.Size(78, 23);
            this._getProductsButton.TabIndex = 3;
            this._getProductsButton.Text = "Get Products";
            this._getProductsButton.UseVisualStyleBackColor = true;
            this._getProductsButton.Click += new System.EventHandler(this._getProductsButton_Click);
            // 
            // _mostViewedButton
            // 
            this._mostViewedButton.Location = new System.Drawing.Point(333, 365);
            this._mostViewedButton.Name = "_mostViewedButton";
            this._mostViewedButton.Size = new System.Drawing.Size(78, 23);
            this._mostViewedButton.TabIndex = 4;
            this._mostViewedButton.Text = "Most Viewed";
            this._mostViewedButton.UseVisualStyleBackColor = true;
            this._mostViewedButton.Click += new System.EventHandler(this._mostViewedButton_Click);
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
            this._searchTermsListBox.Location = new System.Drawing.Point(15, 44);
            this._searchTermsListBox.Name = "_searchTermsListBox";
            this._searchTermsListBox.Size = new System.Drawing.Size(643, 82);
            this._searchTermsListBox.TabIndex = 9;
            // 
            // _searchButton
            // 
            this._searchButton.Location = new System.Drawing.Point(225, 365);
            this._searchButton.Name = "_searchButton";
            this._searchButton.Size = new System.Drawing.Size(102, 23);
            this._searchButton.TabIndex = 10;
            this._searchButton.Text = "Search Products";
            this._searchButton.UseVisualStyleBackColor = true;
            this._searchButton.Click += new System.EventHandler(this._searchButton_Click);
            // 
            // _resultsListBox
            // 
            this._resultsListBox.FormattingEnabled = true;
            this._resultsListBox.HorizontalScrollbar = true;
            this._resultsListBox.Location = new System.Drawing.Point(15, 166);
            this._resultsListBox.Name = "_resultsListBox";
            this._resultsListBox.Size = new System.Drawing.Size(643, 186);
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
            this._clearResultsButton.Location = new System.Drawing.Point(534, 137);
            this._clearResultsButton.Name = "_clearResultsButton";
            this._clearResultsButton.Size = new System.Drawing.Size(124, 23);
            this._clearResultsButton.TabIndex = 13;
            this._clearResultsButton.Text = "Clear Results Term";
            this._clearResultsButton.UseVisualStyleBackColor = true;
            this._clearResultsButton.Click += new System.EventHandler(this._clearResultsButton_Click);
            // 
            // BestBuyAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 400);
            this.Controls.Add(this._clearResultsButton);
            this.Controls.Add(this._clearSearchTermsButton);
            this.Controls.Add(this._resultsListBox);
            this.Controls.Add(this._searchButton);
            this.Controls.Add(this._searchTermsListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._addSearchTermButton);
            this.Controls.Add(this._searchTermTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._mostViewedButton);
            this.Controls.Add(this._getProductsButton);
            this.Controls.Add(this._getReviewsButton);
            this.Controls.Add(this._exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BestBuyAPI";
            this.Text = "BestBuy API";
            this.Load += new System.EventHandler(this.BestBuyAPI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button _exitButton;
        private System.Windows.Forms.Button _getReviewsButton;
        private System.Windows.Forms.Button _getProductsButton;
        private System.Windows.Forms.Button _mostViewedButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _searchTermTextBox;
        private System.Windows.Forms.Button _addSearchTermButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox _searchTermsListBox;
        private System.Windows.Forms.Button _searchButton;
        private System.Windows.Forms.ListBox _resultsListBox;
        private System.Windows.Forms.Button _clearSearchTermsButton;
        private System.Windows.Forms.Button _clearResultsButton;
    }
}

