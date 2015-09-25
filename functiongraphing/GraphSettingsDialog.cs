using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Gunter.Roy.Mathematics.FunctionGrapher
{
    public partial class GraphSettingsDialog : Form
    {
        private GraphSettings settings;
        private FunctionGrapher mainForm;
        private static bool _exists = false;
        private Form MathHelp;

        public bool Exists { get { return _exists; } }

        public GraphSettingsDialog(GraphSettings _settings, FunctionGrapher _mainForm)
        {
            InitializeComponent();

            this.checkBoxGrid.Checked = _settings.Grid;
            this.textBoxGridWidth.Text = _settings.GridWidth.ToString();

            this.checkBoxSmoothGraph.Checked = _settings.SmoothGraph;

            this.comboBoxGraphType.Items.Add(GraphTypes.Function);
            this.comboBoxGraphType.Items.Add(GraphTypes.Derivative);
            this.comboBoxGraphType.Items.Add(GraphTypes.Slope);
            this.comboBoxGraphType.Items.Add(GraphTypes.VectorField);
            this.comboBoxGraphType.Items.Add(GraphTypes.LevelCurves);
            this.comboBoxGraphType.Items.Add(GraphTypes.LevelCurves2);
            this.comboBoxGraphType.Items.Add(GraphTypes.ParametricFamily);
            this.comboBoxGraphType.Items.Add(GraphTypes.ParametricFunction);
            this.comboBoxGraphType.Items.Add(GraphTypes.Iteration);
            this.comboBoxGraphType.Items.Add(GraphTypes.Cobweb);
            this.comboBoxGraphType.Items.Add(GraphTypes.TwoDIteration);
            this.comboBoxGraphType.SelectedIndex = 0;

            settings = new GraphSettings();
            settings = _settings;

            mainForm = _mainForm;

            this.textBoxSlopeColorLimit.Text = settings.SlopeColorLimit.ToString();
            this.textBoxBaseB.Text = settings.BaseB.ToString();
            this.textBoxBaseG.Text = settings.BaseG.ToString();
            this.textBoxBaseR.Text = settings.BaseR.ToString();

            this.textBoxFunctionA.Text = settings.FunctionA.ToString();
            this.textBoxFunctionB.Text = settings.FunctionB.ToString();

            //Family constants
            this.textBoxC1Incr.Text = settings.C1Incr.ToString();
            this.textBoxC1Max.Text = settings.C1Max.ToString();
            this.textBoxC1Min.Text = settings.C1Min.ToString();

            this.textBoxC2Incr.Text = settings.C2Incr.ToString();
            this.textBoxC2Max.Text = settings.C2Max.ToString();
            this.textBoxC2Min.Text = settings.C2Min.ToString();

            //Funxction constants
            this.textBoxTraceLen.Text = settings.TraceLen.ToString();
            this.textBoxxIncr.Text = settings.XIncr.ToString();
            this.textBoxxMax.Text = settings.XMax.ToString();
            this.textBoxxMin.Text = settings.XMin.ToString();

            this.textBoxyIncr.Text = settings.YIncr.ToString();
            this.textBoxyMax.Text = settings.YMax.ToString();
            this.textBoxyMin.Text = settings.YMin.ToString();

            this.textBoxStartingX.Text = settings.StartingX.ToString();
            this.textBoxN.Text = settings.N.ToString();

            this.pictureBoxBackground.BackColor = settings.Background;
            this.colorDialog1.Color = settings.Background;

            if (settings.GraphType.Equals(GraphTypes.Derivative))
            {
                this.comboBoxGraphType.SelectedItem = GraphTypes.Derivative;
            }
            else if (settings.GraphType.Equals(GraphTypes.Function))
            {
                this.comboBoxGraphType.SelectedItem = GraphTypes.Function;
            }
            else if (settings.GraphType.Equals(GraphTypes.VectorField))
            {
                this.comboBoxGraphType.SelectedItem = GraphTypes.VectorField;
            }
            else if (settings.GraphType.Equals(GraphTypes.Slope))
            {
                this.comboBoxGraphType.SelectedItem = GraphTypes.Slope;
            }
            else if (settings.GraphType.Equals(GraphTypes.ParametricFamily))
            {
                this.comboBoxGraphType.SelectedItem = GraphTypes.ParametricFamily;
            }
            else if (settings.GraphType.Equals(GraphTypes.ParametricFunction))
            {
                this.comboBoxGraphType.SelectedItem = GraphTypes.ParametricFunction;
            }
            else if (settings.GraphType.Equals(GraphTypes.Iteration))
            {
                this.comboBoxGraphType.SelectedItem = GraphTypes.Iteration;
            }
            else if (settings.GraphType.Equals(GraphTypes.Cobweb))
            {
                this.comboBoxGraphType.SelectedItem = GraphTypes.Cobweb;
            }
            else if (settings.GraphType.Equals(GraphTypes.TwoDIteration))
            {
                this.comboBoxGraphType.SelectedItem = GraphTypes.TwoDIteration;
            }
        }

        private void GraphSettings_Load(object sender, EventArgs e)
        {
            this.Left = mainForm.Left + mainForm.Width;
            this.Top = mainForm.Top;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if( settings.Updated ) ApplyNewSettings();
            this.Cursor = Cursors.Default;
            this.Close();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            ApplyNewSettings();
            this.Cursor = Cursors.Default;
        }

        private void ApplyNewSettings()
        {
            mainForm.ZGControl.GraphPane.CurveList.Clear();

            settings.Grid = this.checkBoxGrid.Checked;
            settings.GridWidth = Convert.ToDouble(this.textBoxGridWidth.Text);

            settings.SmoothGraph = this.checkBoxSmoothGraph.Checked;

            settings.SlopeColorLimit = Convert.ToDouble(this.textBoxSlopeColorLimit.Text);
            settings.BaseB = Convert.ToInt16(this.textBoxBaseB.Text);
            settings.BaseG = Convert.ToInt16(this.textBoxBaseG.Text);
            settings.BaseR = Convert.ToInt16(this.textBoxBaseR.Text);

            settings.FunctionA = this.textBoxFunctionA.Text;
            settings.FunctionB = this.textBoxFunctionB.Text;

            //Family constants
            settings.C1Incr = Convert.ToDouble(this.textBoxC1Incr.Text);
            settings.C1Max = Convert.ToDouble(this.textBoxC1Max.Text);
            settings.C1Min = Convert.ToDouble(this.textBoxC1Min.Text);

            settings.C2Incr = Convert.ToDouble(this.textBoxC2Incr.Text);
            settings.C2Max = Convert.ToDouble(this.textBoxC2Max.Text);
            settings.C2Min = Convert.ToDouble(this.textBoxC2Min.Text);

            //Function constants
            settings.TraceLen = Convert.ToDouble(this.textBoxTraceLen.Text);
            settings.XIncr = Convert.ToDouble(this.textBoxxIncr.Text);
            settings.XMax = Convert.ToDouble(this.textBoxxMax.Text);
            settings.XMin = Convert.ToDouble(this.textBoxxMin.Text);

            settings.YIncr = Convert.ToDouble(this.textBoxyIncr.Text);
            settings.YMax = Convert.ToDouble(this.textBoxyMax.Text);
            settings.YMin = Convert.ToDouble(this.textBoxyMin.Text);

            settings.StartingX = Convert.ToDouble(this.textBoxStartingX.Text);
            settings.N = Convert.ToInt64(this.textBoxN.Text);

            if (this.comboBoxGraphType.SelectedItem.Equals(GraphTypes.Derivative))
            {
                settings.GraphType = GraphTypes.Derivative;
            }
            else if (this.comboBoxGraphType.SelectedItem.Equals(GraphTypes.Function))
            {
                settings.GraphType = GraphTypes.Function;
            }
            else if (this.comboBoxGraphType.SelectedItem.Equals(GraphTypes.VectorField))
            {
                settings.GraphType = GraphTypes.VectorField;
            }
            else if (this.comboBoxGraphType.SelectedItem.Equals(GraphTypes.LevelCurves))
            {
                settings.GraphType = GraphTypes.LevelCurves;
            }
            else if (this.comboBoxGraphType.SelectedItem.Equals(GraphTypes.LevelCurves2))
            {
                settings.GraphType = GraphTypes.LevelCurves2;
            }
            else if (this.comboBoxGraphType.SelectedItem.Equals(GraphTypes.ParametricFamily))
            {
                settings.GraphType = GraphTypes.ParametricFamily;
            }
            else if (this.comboBoxGraphType.SelectedItem.Equals(GraphTypes.ParametricFunction))
            {
                settings.GraphType = GraphTypes.ParametricFunction;
            }
            else if (this.comboBoxGraphType.SelectedItem.Equals(GraphTypes.Slope))
            {
                settings.GraphType = GraphTypes.Slope;
            }
            else if (this.comboBoxGraphType.SelectedItem.Equals(GraphTypes.Iteration))
            {
                settings.GraphType = GraphTypes.Iteration;
            }
            else if (this.comboBoxGraphType.SelectedItem.Equals(GraphTypes.Cobweb))
            {
                settings.GraphType = GraphTypes.Cobweb;
            }
            else if (this.comboBoxGraphType.SelectedItem.Equals(GraphTypes.TwoDIteration))
            {
                settings.GraphType = GraphTypes.TwoDIteration;
            }

            settings.Updated = true;
        }

        private void SetFunctionUI()
        {
            labelGraphType.Text = GraphTypes.Function + ":";
            textBoxFunctionB.Enabled = false;
            textBoxC1Max.Enabled = false;
            textBoxC1Min.Enabled = false;
            textBoxC1Incr.Enabled = false;
            textBoxC2Max.Enabled = false;
            textBoxC2Min.Enabled = false;
            textBoxC2Incr.Enabled = false;
            textBoxC2Incr.Enabled = false;
            labelXTMinMax.Text = "x Min/Max";
            labelXTIncr.Text = "x Incr";
            textBoxxIncr.Enabled = true;
            textBoxxMax.Enabled = true;
            textBoxxMin.Enabled = true;
            textBoxyMin.Enabled = false;
            textBoxyMax.Enabled = false;
            textBoxyIncr.Enabled = false;
            textBoxStartingX.Enabled = false;
            textBoxN.Enabled = false;
        }

        private void Set2DIterationUI()
        {
            labelGraphType.Text = GraphTypes.Function + ":";
            textBoxFunctionB.Enabled = false;
            textBoxC1Max.Enabled = false;
            textBoxC1Min.Enabled = false;
            textBoxC1Incr.Enabled = false;
            textBoxC2Max.Enabled = false;
            textBoxC2Min.Enabled = false;
            textBoxC2Incr.Enabled = false;
            textBoxC2Incr.Enabled = false;
            labelXTMinMax.Text = "x Min/Max";
            labelXTIncr.Text = "x Incr";
            textBoxxIncr.Enabled = true;
            textBoxxMax.Enabled = true;
            textBoxxMin.Enabled = true;
            textBoxyMin.Enabled = true;
            textBoxyMax.Enabled = true;
            textBoxyIncr.Enabled = true;
            textBoxStartingX.Enabled = false;
            textBoxN.Enabled = true;
        }

        private void SetIterationUI()
        {
            labelGraphType.Text = GraphTypes.Function + ":";
            textBoxFunctionB.Enabled = false;
            textBoxC1Max.Enabled = false;
            textBoxC1Min.Enabled = false;
            textBoxC1Incr.Enabled = false;
            textBoxC2Max.Enabled = false;
            textBoxC2Min.Enabled = false;
            textBoxC2Incr.Enabled = false;
            textBoxC2Incr.Enabled = false;
            labelXTMinMax.Text = "x Min/Max";
            labelXTIncr.Text = "x Incr";
            textBoxxIncr.Enabled = false;
            textBoxxMax.Enabled = false;
            textBoxxMin.Enabled = false;
            textBoxyMin.Enabled = false;
            textBoxyMax.Enabled = false;
            textBoxyIncr.Enabled = false;
            textBoxStartingX.Enabled = true;
            textBoxN.Enabled = true;
        }

        private void SetCobwebUI()
        {
            labelGraphType.Text = GraphTypes.Function + ":";
            textBoxFunctionB.Enabled = false;
            textBoxC1Max.Enabled = false;
            textBoxC1Min.Enabled = false;
            textBoxC1Incr.Enabled = false;
            textBoxC2Max.Enabled = false;
            textBoxC2Min.Enabled = false;
            textBoxC2Incr.Enabled = false;
            textBoxC2Incr.Enabled = false;
            labelXTMinMax.Text = "x Min/Max";
            labelXTIncr.Text = "x Incr";
            textBoxxIncr.Enabled = true;
            textBoxxMax.Enabled = true;
            textBoxxMin.Enabled = true;
            textBoxyMin.Enabled = false;
            textBoxyMax.Enabled = false;
            textBoxyIncr.Enabled = false;
            textBoxStartingX.Enabled = true;
            textBoxN.Enabled = true;
        }

        private void SetLevelCurvesUI()
        {
            labelGraphType.Text = GraphTypes.Function + ":";
            textBoxFunctionB.Enabled = false;
            textBoxC1Max.Enabled = false;
            textBoxC1Min.Enabled = false;
            textBoxC1Incr.Enabled = false;
            textBoxC2Max.Enabled = false;
            textBoxC2Min.Enabled = false;
            textBoxC2Incr.Enabled = false;
            textBoxC2Incr.Enabled = false;
            labelXTMinMax.Text = "x Min/Max";
            labelXTIncr.Text = "x Incr";
            textBoxxIncr.Enabled = true;
            textBoxxMax.Enabled = true;
            textBoxxMin.Enabled = true;
            textBoxyMin.Enabled = true;
            textBoxyMax.Enabled = true;
            textBoxyIncr.Enabled = true;
        }

        private void SetParametricFamilyUI()
        {
            labelGraphType.Text = GraphTypes.ParametricFamily + ":";
            textBoxFunctionB.Enabled = true;
            textBoxC1Max.Enabled = true;
            textBoxC1Min.Enabled = true;
            textBoxC1Incr.Enabled = true;
            textBoxC2Max.Enabled = true;
            textBoxC2Min.Enabled = true;
            textBoxC2Incr.Enabled = true;
            textBoxC2Incr.Enabled = true;
            labelXTMinMax.Text = "t Min/Max";
            labelXTIncr.Text = "t Incr";
            textBoxxIncr.Enabled = true;
            textBoxxMax.Enabled = true;
            textBoxxMin.Enabled = true;
            textBoxyMin.Enabled = false;
            textBoxyMax.Enabled = false;
            textBoxyIncr.Enabled = false;
        }

        private void SetParametricFunctionUI()
        {
            labelGraphType.Text = GraphTypes.ParametricFunction + ":";
            textBoxFunctionB.Enabled = true;
            textBoxC1Max.Enabled = false;
            textBoxC1Min.Enabled = false;
            textBoxC1Incr.Enabled = false;
            textBoxC2Max.Enabled = false;
            textBoxC2Min.Enabled = false;
            textBoxC2Incr.Enabled = false;
            textBoxC2Incr.Enabled = false;
            labelXTMinMax.Text = "t Min/Max";
            labelXTIncr.Text = "t Incr";
            textBoxxIncr.Enabled = true;
            textBoxxMax.Enabled = true;
            textBoxxMin.Enabled = true;
            textBoxyMin.Enabled = false;
            textBoxyMax.Enabled = false;
            textBoxyIncr.Enabled = false;
        }

        private void SetSlopeUI()
        {
            labelGraphType.Text = GraphTypes.Slope + ":";
            textBoxFunctionB.Enabled = false;
            textBoxC1Max.Enabled = false;
            textBoxC1Min.Enabled = false;
            textBoxC1Incr.Enabled = false;
            textBoxC2Max.Enabled = false;
            textBoxC2Min.Enabled = false;
            textBoxC2Incr.Enabled = false;
            textBoxC2Incr.Enabled = false;
            labelXTMinMax.Text = "x Min/Max";
            labelXTIncr.Text = "x Incr";
            textBoxxIncr.Enabled = true;
            textBoxxMax.Enabled = true;
            textBoxxMin.Enabled = true;
            textBoxyMin.Enabled = true;
            textBoxyMax.Enabled = true;
            textBoxyIncr.Enabled = true;
        }

        private void SetVectorFieldUI()
        {
            labelGraphType.Text = GraphTypes.VectorField + ":";
            textBoxFunctionB.Enabled = false;
            textBoxC1Max.Enabled = false;
            textBoxC1Min.Enabled = false;
            textBoxC1Incr.Enabled = false;
            textBoxC2Max.Enabled = false;
            textBoxC2Min.Enabled = false;
            textBoxC2Incr.Enabled = false;
            textBoxC2Incr.Enabled = false;
            labelXTMinMax.Text = "x Min/Max";
            labelXTIncr.Text = "x Incr";
            textBoxxIncr.Enabled = true;
            textBoxxMax.Enabled = true;
            textBoxxMin.Enabled = true;
            textBoxyMin.Enabled = true;
            textBoxyMax.Enabled = true;
            textBoxyIncr.Enabled = true;
        }

        private void SetDerivativeFunctionUI()
        {
            labelGraphType.Text = GraphTypes.VectorField + ":";
            textBoxFunctionB.Enabled = false;
            textBoxC1Max.Enabled = false;
            textBoxC1Min.Enabled = false;
            textBoxC1Incr.Enabled = false;
            textBoxC2Max.Enabled = false;
            textBoxC2Min.Enabled = false;
            textBoxC2Incr.Enabled = false;
            textBoxC2Incr.Enabled = false;
            labelXTMinMax.Text = "x Min/Max";
            labelXTIncr.Text = "x Incr";
            textBoxxIncr.Enabled = true;
            textBoxxMax.Enabled = true;
            textBoxxMin.Enabled = true;
            textBoxyMin.Enabled = true;
            textBoxyMax.Enabled = true;
            textBoxyMin.Enabled = true;
            textBoxyIncr.Enabled = true;
        }

        private void comboBoxGraphType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxGraphType.SelectedItem.Equals(GraphTypes.Function))
            {
                SetFunctionUI();
            }
            if (comboBoxGraphType.SelectedItem.Equals(GraphTypes.ParametricFunction))
            {
                SetParametricFunctionUI();
            }
            if (comboBoxGraphType.SelectedItem.Equals(GraphTypes.ParametricFamily))
            {
                SetParametricFamilyUI();
            }
            if (comboBoxGraphType.SelectedItem.Equals(GraphTypes.Derivative))
            {
                SetDerivativeFunctionUI();
            }
            if (comboBoxGraphType.SelectedItem.Equals(GraphTypes.Slope))
            {
                SetSlopeUI();
            }
            if (comboBoxGraphType.SelectedItem.Equals(GraphTypes.VectorField))
            {
                SetSlopeUI();
            }
            if (comboBoxGraphType.SelectedItem.Equals(GraphTypes.LevelCurves))
            {
                SetLevelCurvesUI();
            }
            if (comboBoxGraphType.SelectedItem.Equals(GraphTypes.LevelCurves2))
            {
                SetLevelCurvesUI();
            }
            if (comboBoxGraphType.SelectedItem.Equals(GraphTypes.Iteration))
            {
                SetIterationUI();
            } 
            if (comboBoxGraphType.SelectedItem.Equals(GraphTypes.Cobweb))
            {
                SetCobwebUI();
            }
            if (comboBoxGraphType.SelectedItem.Equals(GraphTypes.TwoDIteration))
            {
                Set2DIterationUI();
            } 
        }

        private void labelGraphType_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MathHelp = new SystemMathHelp();
            MathHelp.Show();

            if (MathHelp == null)
            {
                MathHelp = new SystemMathHelp();
                MathHelp.Show();
            }
            else
            {
                MathHelp.Focus();
            }
        }

        private void pictureBoxBackground_Click(object sender, EventArgs e)
        {
            this.colorDialog1.ShowDialog();
            this.pictureBoxBackground.BackColor = this.colorDialog1.Color;
            settings.Background = this.colorDialog1.Color;
        }
    }
}