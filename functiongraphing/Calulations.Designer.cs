namespace Gunter.Roy.Mathematics.FunctionGrapher
{
    partial class Calulations
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.XValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.functionGrapherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.functionGrapherBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.functionGrapherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.functionGrapherBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.XValue,
            this.YValue});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(308, 342);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.SizeChanged += new System.EventHandler(this.dataGridView1_SizeChanged);
            // 
            // XValue
            // 
            this.XValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.XValue.Frozen = true;
            this.XValue.HeaderText = "X-Value";
            this.XValue.Name = "XValue";
            this.XValue.ReadOnly = true;
            this.XValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.XValue.Width = 50;
            // 
            // YValue
            // 
            this.YValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.YValue.Frozen = true;
            this.YValue.HeaderText = "Y-Value";
            this.YValue.Name = "YValue";
            this.YValue.ReadOnly = true;
            this.YValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.YValue.Width = 50;
            // 
            // functionGrapherBindingSource
            // 
            this.functionGrapherBindingSource.DataSource = typeof(Gunter.Roy.Mathematics.FunctionGrapher.FunctionGrapher);
            // 
            // functionGrapherBindingSource1
            // 
            this.functionGrapherBindingSource1.DataSource = typeof(Gunter.Roy.Mathematics.FunctionGrapher.FunctionGrapher);
            // 
            // Calulations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(332, 367);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Calulations";
            this.Text = "Calulations";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Calulations_FormClosing);
            this.Load += new System.EventHandler(this.Calulations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.functionGrapherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.functionGrapherBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource functionGrapherBindingSource;
        private System.Windows.Forms.BindingSource functionGrapherBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn XValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn YValue;
    }
}