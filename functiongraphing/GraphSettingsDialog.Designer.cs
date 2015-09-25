namespace Gunter.Roy.Mathematics.FunctionGrapher
{
    partial class GraphSettingsDialog
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.textBoxFunctionA = new System.Windows.Forms.TextBox();
            this.labelXTMinMax = new System.Windows.Forms.Label();
            this.textBoxxMin = new System.Windows.Forms.TextBox();
            this.textBoxxMax = new System.Windows.Forms.TextBox();
            this.textBoxxIncr = new System.Windows.Forms.TextBox();
            this.labelXTIncr = new System.Windows.Forms.Label();
            this.textBoxyIncr = new System.Windows.Forms.TextBox();
            this.labelYIncr = new System.Windows.Forms.Label();
            this.textBoxyMax = new System.Windows.Forms.TextBox();
            this.textBoxyMin = new System.Windows.Forms.TextBox();
            this.labelYMinMax = new System.Windows.Forms.Label();
            this.textBoxTraceLen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSlopeColorLimit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxBaseB = new System.Windows.Forms.TextBox();
            this.textBoxBaseG = new System.Windows.Forms.TextBox();
            this.textBoxBaseR = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxGraphType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxFunctionB = new System.Windows.Forms.TextBox();
            this.textBoxC2Incr = new System.Windows.Forms.TextBox();
            this.label1C2Incr = new System.Windows.Forms.Label();
            this.textBoxC2Max = new System.Windows.Forms.TextBox();
            this.textBoxC2Min = new System.Windows.Forms.TextBox();
            this.label1C2MinMax = new System.Windows.Forms.Label();
            this.textBoxC1Incr = new System.Windows.Forms.TextBox();
            this.label1C1Incr = new System.Windows.Forms.Label();
            this.textBoxC1Max = new System.Windows.Forms.TextBox();
            this.textBoxC1Min = new System.Windows.Forms.TextBox();
            this.label1c1MinMax = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxBackground = new System.Windows.Forms.PictureBox();
            this.checkBoxGrid = new System.Windows.Forms.CheckBox();
            this.textBoxGridWidth = new System.Windows.Forms.TextBox();
            this.checkBoxSmoothGraph = new System.Windows.Forms.CheckBox();
            this.labelGraphType = new System.Windows.Forms.LinkLabel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxStartingX = new System.Windows.Forms.TextBox();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(234, 419);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 21;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonApply.Location = new System.Drawing.Point(153, 419);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 20;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // textBoxFunctionA
            // 
            this.textBoxFunctionA.Location = new System.Drawing.Point(97, 77);
            this.textBoxFunctionA.Name = "textBoxFunctionA";
            this.textBoxFunctionA.Size = new System.Drawing.Size(242, 20);
            this.textBoxFunctionA.TabIndex = 1;
            // 
            // labelXTMinMax
            // 
            this.labelXTMinMax.AutoSize = true;
            this.labelXTMinMax.Location = new System.Drawing.Point(3, 73);
            this.labelXTMinMax.Name = "labelXTMinMax";
            this.labelXTMinMax.Size = new System.Drawing.Size(65, 13);
            this.labelXTMinMax.TabIndex = 2;
            this.labelXTMinMax.Text = "x/t Min/Max";
            // 
            // textBoxxMin
            // 
            this.textBoxxMin.Location = new System.Drawing.Point(73, 70);
            this.textBoxxMin.Name = "textBoxxMin";
            this.textBoxxMin.Size = new System.Drawing.Size(42, 20);
            this.textBoxxMin.TabIndex = 9;
            this.textBoxxMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxxMax
            // 
            this.textBoxxMax.Location = new System.Drawing.Point(121, 70);
            this.textBoxxMax.Name = "textBoxxMax";
            this.textBoxxMax.Size = new System.Drawing.Size(42, 20);
            this.textBoxxMax.TabIndex = 10;
            this.textBoxxMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxxIncr
            // 
            this.textBoxxIncr.Location = new System.Drawing.Point(255, 70);
            this.textBoxxIncr.Name = "textBoxxIncr";
            this.textBoxxIncr.Size = new System.Drawing.Size(42, 20);
            this.textBoxxIncr.TabIndex = 11;
            this.textBoxxIncr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelXTIncr
            // 
            this.labelXTIncr.AutoSize = true;
            this.labelXTIncr.Location = new System.Drawing.Point(208, 73);
            this.labelXTIncr.Name = "labelXTIncr";
            this.labelXTIncr.Size = new System.Drawing.Size(41, 13);
            this.labelXTIncr.TabIndex = 5;
            this.labelXTIncr.Text = "x/t Incr";
            // 
            // textBoxyIncr
            // 
            this.textBoxyIncr.Location = new System.Drawing.Point(255, 96);
            this.textBoxyIncr.Name = "textBoxyIncr";
            this.textBoxyIncr.Size = new System.Drawing.Size(42, 20);
            this.textBoxyIncr.TabIndex = 14;
            this.textBoxyIncr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelYIncr
            // 
            this.labelYIncr.AutoSize = true;
            this.labelYIncr.Location = new System.Drawing.Point(216, 99);
            this.labelYIncr.Name = "labelYIncr";
            this.labelYIncr.Size = new System.Drawing.Size(33, 13);
            this.labelYIncr.TabIndex = 10;
            this.labelYIncr.Text = "y Incr";
            // 
            // textBoxyMax
            // 
            this.textBoxyMax.Location = new System.Drawing.Point(121, 96);
            this.textBoxyMax.Name = "textBoxyMax";
            this.textBoxyMax.Size = new System.Drawing.Size(42, 20);
            this.textBoxyMax.TabIndex = 13;
            this.textBoxyMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxyMin
            // 
            this.textBoxyMin.Location = new System.Drawing.Point(73, 96);
            this.textBoxyMin.Name = "textBoxyMin";
            this.textBoxyMin.Size = new System.Drawing.Size(42, 20);
            this.textBoxyMin.TabIndex = 12;
            this.textBoxyMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelYMinMax
            // 
            this.labelYMinMax.AutoSize = true;
            this.labelYMinMax.Location = new System.Drawing.Point(9, 99);
            this.labelYMinMax.Name = "labelYMinMax";
            this.labelYMinMax.Size = new System.Drawing.Size(57, 13);
            this.labelYMinMax.TabIndex = 7;
            this.labelYMinMax.Text = "y Min/Max";
            // 
            // textBoxTraceLen
            // 
            this.textBoxTraceLen.Location = new System.Drawing.Point(92, 18);
            this.textBoxTraceLen.Name = "textBoxTraceLen";
            this.textBoxTraceLen.Size = new System.Drawing.Size(42, 20);
            this.textBoxTraceLen.TabIndex = 15;
            this.textBoxTraceLen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Trace Length";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Slope Colors";
            // 
            // textBoxSlopeColorLimit
            // 
            this.textBoxSlopeColorLimit.Location = new System.Drawing.Point(92, 63);
            this.textBoxSlopeColorLimit.Name = "textBoxSlopeColorLimit";
            this.textBoxSlopeColorLimit.Size = new System.Drawing.Size(42, 20);
            this.textBoxSlopeColorLimit.TabIndex = 16;
            this.textBoxSlopeColorLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Limit";
            // 
            // textBoxBaseB
            // 
            this.textBoxBaseB.Location = new System.Drawing.Point(188, 89);
            this.textBoxBaseB.Name = "textBoxBaseB";
            this.textBoxBaseB.Size = new System.Drawing.Size(42, 20);
            this.textBoxBaseB.TabIndex = 19;
            this.textBoxBaseB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxBaseG
            // 
            this.textBoxBaseG.Location = new System.Drawing.Point(140, 89);
            this.textBoxBaseG.Name = "textBoxBaseG";
            this.textBoxBaseG.Size = new System.Drawing.Size(42, 20);
            this.textBoxBaseG.TabIndex = 18;
            this.textBoxBaseG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxBaseR
            // 
            this.textBoxBaseR.Location = new System.Drawing.Point(92, 89);
            this.textBoxBaseR.Name = "textBoxBaseR";
            this.textBoxBaseR.Size = new System.Drawing.Size(42, 20);
            this.textBoxBaseR.TabIndex = 17;
            this.textBoxBaseR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Base RGB";
            // 
            // comboBoxGraphType
            // 
            this.comboBoxGraphType.FormattingEnabled = true;
            this.comboBoxGraphType.Location = new System.Drawing.Point(97, 50);
            this.comboBoxGraphType.Name = "comboBoxGraphType";
            this.comboBoxGraphType.Size = new System.Drawing.Size(242, 21);
            this.comboBoxGraphType.TabIndex = 0;
            this.comboBoxGraphType.SelectedIndexChanged += new System.EventHandler(this.comboBoxGraphType_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Graph Type:";
            // 
            // textBoxFunctionB
            // 
            this.textBoxFunctionB.Location = new System.Drawing.Point(97, 102);
            this.textBoxFunctionB.Name = "textBoxFunctionB";
            this.textBoxFunctionB.Size = new System.Drawing.Size(242, 20);
            this.textBoxFunctionB.TabIndex = 2;
            // 
            // textBoxC2Incr
            // 
            this.textBoxC2Incr.Location = new System.Drawing.Point(255, 45);
            this.textBoxC2Incr.Name = "textBoxC2Incr";
            this.textBoxC2Incr.Size = new System.Drawing.Size(42, 20);
            this.textBoxC2Incr.TabIndex = 8;
            this.textBoxC2Incr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1C2Incr
            // 
            this.label1C2Incr.AutoSize = true;
            this.label1C2Incr.Location = new System.Drawing.Point(209, 48);
            this.label1C2Incr.Name = "label1C2Incr";
            this.label1C2Incr.Size = new System.Drawing.Size(40, 13);
            this.label1C2Incr.TabIndex = 40;
            this.label1C2Incr.Text = "c2 Incr";
            // 
            // textBoxC2Max
            // 
            this.textBoxC2Max.Location = new System.Drawing.Point(121, 45);
            this.textBoxC2Max.Name = "textBoxC2Max";
            this.textBoxC2Max.Size = new System.Drawing.Size(42, 20);
            this.textBoxC2Max.TabIndex = 7;
            this.textBoxC2Max.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxC2Min
            // 
            this.textBoxC2Min.Location = new System.Drawing.Point(73, 45);
            this.textBoxC2Min.Name = "textBoxC2Min";
            this.textBoxC2Min.Size = new System.Drawing.Size(42, 20);
            this.textBoxC2Min.TabIndex = 6;
            this.textBoxC2Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1C2MinMax
            // 
            this.label1C2MinMax.AutoSize = true;
            this.label1C2MinMax.Location = new System.Drawing.Point(3, 48);
            this.label1C2MinMax.Name = "label1C2MinMax";
            this.label1C2MinMax.Size = new System.Drawing.Size(64, 13);
            this.label1C2MinMax.TabIndex = 37;
            this.label1C2MinMax.Text = "c2 Min/Max";
            // 
            // textBoxC1Incr
            // 
            this.textBoxC1Incr.Location = new System.Drawing.Point(255, 19);
            this.textBoxC1Incr.Name = "textBoxC1Incr";
            this.textBoxC1Incr.Size = new System.Drawing.Size(42, 20);
            this.textBoxC1Incr.TabIndex = 5;
            this.textBoxC1Incr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1C1Incr
            // 
            this.label1C1Incr.AutoSize = true;
            this.label1C1Incr.Location = new System.Drawing.Point(209, 22);
            this.label1C1Incr.Name = "label1C1Incr";
            this.label1C1Incr.Size = new System.Drawing.Size(40, 13);
            this.label1C1Incr.TabIndex = 35;
            this.label1C1Incr.Text = "c1 Incr";
            // 
            // textBoxC1Max
            // 
            this.textBoxC1Max.Location = new System.Drawing.Point(121, 19);
            this.textBoxC1Max.Name = "textBoxC1Max";
            this.textBoxC1Max.Size = new System.Drawing.Size(42, 20);
            this.textBoxC1Max.TabIndex = 4;
            this.textBoxC1Max.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxC1Min
            // 
            this.textBoxC1Min.Location = new System.Drawing.Point(73, 19);
            this.textBoxC1Min.Name = "textBoxC1Min";
            this.textBoxC1Min.Size = new System.Drawing.Size(42, 20);
            this.textBoxC1Min.TabIndex = 3;
            this.textBoxC1Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1c1MinMax
            // 
            this.label1c1MinMax.AutoSize = true;
            this.label1c1MinMax.Location = new System.Drawing.Point(3, 22);
            this.label1c1MinMax.Name = "label1c1MinMax";
            this.label1c1MinMax.Size = new System.Drawing.Size(64, 13);
            this.label1c1MinMax.TabIndex = 32;
            this.label1c1MinMax.Text = "c1 Min/Max";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxTraceLen);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxSlopeColorLimit);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBoxBaseR);
            this.groupBox1.Controls.Add(this.textBoxBaseG);
            this.groupBox1.Controls.Add(this.textBoxBaseB);
            this.groupBox1.Location = new System.Drawing.Point(25, 291);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 122);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visuals";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxStartingX);
            this.groupBox2.Controls.Add(this.textBoxN);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.pictureBoxBackground);
            this.groupBox2.Controls.Add(this.textBoxC1Min);
            this.groupBox2.Controls.Add(this.labelXTMinMax);
            this.groupBox2.Controls.Add(this.textBoxC2Incr);
            this.groupBox2.Controls.Add(this.textBoxxMin);
            this.groupBox2.Controls.Add(this.label1C2Incr);
            this.groupBox2.Controls.Add(this.textBoxxMax);
            this.groupBox2.Controls.Add(this.textBoxC2Max);
            this.groupBox2.Controls.Add(this.labelXTIncr);
            this.groupBox2.Controls.Add(this.textBoxC2Min);
            this.groupBox2.Controls.Add(this.textBoxxIncr);
            this.groupBox2.Controls.Add(this.label1C2MinMax);
            this.groupBox2.Controls.Add(this.labelYMinMax);
            this.groupBox2.Controls.Add(this.textBoxC1Incr);
            this.groupBox2.Controls.Add(this.textBoxyMin);
            this.groupBox2.Controls.Add(this.label1C1Incr);
            this.groupBox2.Controls.Add(this.textBoxyMax);
            this.groupBox2.Controls.Add(this.textBoxC1Max);
            this.groupBox2.Controls.Add(this.labelYIncr);
            this.groupBox2.Controls.Add(this.textBoxyIncr);
            this.groupBox2.Controls.Add(this.label1c1MinMax);
            this.groupBox2.Location = new System.Drawing.Point(25, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 157);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parameters";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Background";
            // 
            // pictureBoxBackground
            // 
            this.pictureBoxBackground.BackColor = System.Drawing.Color.Black;
            this.pictureBoxBackground.Location = new System.Drawing.Point(254, 122);
            this.pictureBoxBackground.Name = "pictureBoxBackground";
            this.pictureBoxBackground.Size = new System.Drawing.Size(43, 25);
            this.pictureBoxBackground.TabIndex = 41;
            this.pictureBoxBackground.TabStop = false;
            this.pictureBoxBackground.Click += new System.EventHandler(this.pictureBoxBackground_Click);
            // 
            // checkBoxGrid
            // 
            this.checkBoxGrid.AutoSize = true;
            this.checkBoxGrid.Location = new System.Drawing.Point(97, 9);
            this.checkBoxGrid.Name = "checkBoxGrid";
            this.checkBoxGrid.Size = new System.Drawing.Size(129, 17);
            this.checkBoxGrid.TabIndex = 44;
            this.checkBoxGrid.Text = "Show Grid   /   Width:";
            this.checkBoxGrid.UseVisualStyleBackColor = true;
            // 
            // textBoxGridWidth
            // 
            this.textBoxGridWidth.Location = new System.Drawing.Point(232, 7);
            this.textBoxGridWidth.Name = "textBoxGridWidth";
            this.textBoxGridWidth.Size = new System.Drawing.Size(107, 20);
            this.textBoxGridWidth.TabIndex = 45;
            // 
            // checkBoxSmoothGraph
            // 
            this.checkBoxSmoothGraph.AutoSize = true;
            this.checkBoxSmoothGraph.Location = new System.Drawing.Point(97, 27);
            this.checkBoxSmoothGraph.Name = "checkBoxSmoothGraph";
            this.checkBoxSmoothGraph.Size = new System.Drawing.Size(94, 17);
            this.checkBoxSmoothGraph.TabIndex = 46;
            this.checkBoxSmoothGraph.Text = "Smooth Graph";
            this.checkBoxSmoothGraph.UseVisualStyleBackColor = true;
            // 
            // labelGraphType
            // 
            this.labelGraphType.AutoSize = true;
            this.labelGraphType.Location = new System.Drawing.Point(42, 80);
            this.labelGraphType.Name = "labelGraphType";
            this.labelGraphType.Size = new System.Drawing.Size(51, 13);
            this.labelGraphType.TabIndex = 47;
            this.labelGraphType.TabStop = true;
            this.labelGraphType.Text = "Function:";
            this.labelGraphType.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelGraphType_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "x/n";
            // 
            // textBoxStartingX
            // 
            this.textBoxStartingX.Location = new System.Drawing.Point(72, 122);
            this.textBoxStartingX.Name = "textBoxStartingX";
            this.textBoxStartingX.Size = new System.Drawing.Size(42, 20);
            this.textBoxStartingX.TabIndex = 44;
            this.textBoxStartingX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(120, 122);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(42, 20);
            this.textBoxN.TabIndex = 45;
            this.textBoxN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GraphSettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonApply;
            this.ClientSize = new System.Drawing.Size(367, 452);
            this.ControlBox = false;
            this.Controls.Add(this.labelGraphType);
            this.Controls.Add(this.checkBoxSmoothGraph);
            this.Controls.Add(this.textBoxGridWidth);
            this.Controls.Add(this.checkBoxGrid);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxFunctionB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxGraphType);
            this.Controls.Add(this.textBoxFunctionA);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.buttonClose);
            this.KeyPreview = true;
            this.Name = "GraphSettingsDialog";
            this.Text = "Settings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.GraphSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.TextBox textBoxFunctionA;
        private System.Windows.Forms.Label labelXTMinMax;
        private System.Windows.Forms.TextBox textBoxxMin;
        private System.Windows.Forms.TextBox textBoxxMax;
        private System.Windows.Forms.TextBox textBoxxIncr;
        private System.Windows.Forms.Label labelXTIncr;
        private System.Windows.Forms.TextBox textBoxyIncr;
        private System.Windows.Forms.Label labelYIncr;
        private System.Windows.Forms.TextBox textBoxyMax;
        private System.Windows.Forms.TextBox textBoxyMin;
        private System.Windows.Forms.Label labelYMinMax;
        private System.Windows.Forms.TextBox textBoxTraceLen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxSlopeColorLimit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxBaseB;
        private System.Windows.Forms.TextBox textBoxBaseG;
        private System.Windows.Forms.TextBox textBoxBaseR;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxGraphType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxFunctionB;
        private System.Windows.Forms.TextBox textBoxC2Incr;
        private System.Windows.Forms.Label label1C2Incr;
        private System.Windows.Forms.TextBox textBoxC2Max;
        private System.Windows.Forms.TextBox textBoxC2Min;
        private System.Windows.Forms.Label label1C2MinMax;
        private System.Windows.Forms.TextBox textBoxC1Incr;
        private System.Windows.Forms.Label label1C1Incr;
        private System.Windows.Forms.TextBox textBoxC1Max;
        private System.Windows.Forms.TextBox textBoxC1Min;
        private System.Windows.Forms.Label label1c1MinMax;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxGrid;
        private System.Windows.Forms.TextBox textBoxGridWidth;
        private System.Windows.Forms.CheckBox checkBoxSmoothGraph;
        private System.Windows.Forms.LinkLabel labelGraphType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxBackground;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxStartingX;
        private System.Windows.Forms.TextBox textBoxN;
    }
}