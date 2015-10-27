namespace gunter.roy.getcredentials
{
    partial class GetCredentials
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
            this._credentialsComboBox = new System.Windows.Forms.ComboBox();
            this._selectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _credentialsComboBox
            // 
            this._credentialsComboBox.FormattingEnabled = true;
            this._credentialsComboBox.Location = new System.Drawing.Point(14, 12);
            this._credentialsComboBox.Name = "_credentialsComboBox";
            this._credentialsComboBox.Size = new System.Drawing.Size(247, 21);
            this._credentialsComboBox.TabIndex = 0;
            // 
            // _selectButton
            // 
            this._selectButton.Location = new System.Drawing.Point(268, 12);
            this._selectButton.Name = "_selectButton";
            this._selectButton.Size = new System.Drawing.Size(75, 23);
            this._selectButton.TabIndex = 1;
            this._selectButton.Text = "Select";
            this._selectButton.UseVisualStyleBackColor = true;
            this._selectButton.Click += new System.EventHandler(this._selectButton_Click);
            // 
            // GetCredentials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 59);
            this.Controls.Add(this._selectButton);
            this.Controls.Add(this._credentialsComboBox);
            this.Name = "GetCredentials";
            this.Text = "Select Credentials";
            this.Load += new System.EventHandler(this.GetCredentials_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox _credentialsComboBox;
        private System.Windows.Forms.Button _selectButton;
    }
}

