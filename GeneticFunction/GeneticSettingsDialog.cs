using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using info.lundin.Math;
using ZedGraph;
using Gunter.Roy.Mathematics.GeneticPolyApproximations;

namespace Gunter.Roy.Mathematics.GeneticFunction
{
    public partial class GeneticSettingsDialog : Form
    {
        private GeneticFunction mMainForm;
        private GeneticPolyApproximation mGeneticPoly;
        private static bool mExists = false;
        public bool Exists { get { return mExists; } }

        private int mTerms;
        private int mPopulationSize;
        private double mPercentReproducing;
        private double mChanceOfMutatiion;
        private long mGenerations;
        private double mCrossoverPoint;
        private string mExponentType;
        private double mError;

        public GeneticSettingsDialog(GeneticPolyApproximation _GeneticPoly, GeneticFunction _MainForm)
        {
            mGeneticPoly = _GeneticPoly;
            mMainForm = _MainForm;

            InitializeComponent();

            this.comboBoxExponentType.Items.Add(ExponentTypes.PositiveInteger);
            this.comboBoxExponentType.Items.Add(ExponentTypes.Integer);
            this.comboBoxExponentType.Items.Add(ExponentTypes.PositiveReal);
            this.comboBoxExponentType.Items.Add(ExponentTypes.Real);
            this.comboBoxExponentType.SelectedIndex = 0;

            this.textBoxTerms.Text = "5";
            this.textBoxPopulationSize.Text = "50";
            this.textBoxPercentReproducing.Text = "0.50";
            this.textBoxChanceOfMutatiion.Text = "0.50";
            this.textBoxGenerations.Text = "100";
            this.textBoxCrossoverPoint.Text = "5";
            this.comboBoxExponentType.Text = ExponentTypes.PositiveInteger;
            this.textBoxError.Text = "0.05";
        }

        private void GeneticSettings_Load(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            int.TryParse(this.textBoxTerms.Text, out mTerms);
            int.TryParse(this.textBoxPopulationSize.Text, out mPopulationSize);
            double.TryParse(this.textBoxPercentReproducing.Text, out mPercentReproducing);
            double.TryParse(this.textBoxChanceOfMutatiion.Text, out mChanceOfMutatiion);
            long.TryParse(this.textBoxGenerations.Text, out mGenerations);
            double.TryParse(this.textBoxCrossoverPoint.Text, out mCrossoverPoint);
            mExponentType = this.comboBoxExponentType.Text;
            double.TryParse(this.textBoxError.Text, out mError);

            mGeneticPoly = new GeneticPolyApproximation(mTerms,
                                                        mPopulationSize,
                                                        mPercentReproducing,
                                                        mChanceOfMutatiion,
                                                        mGenerations,
                                                        mCrossoverPoint,
                                                        mExponentType,
                                                        mError,
                                                        mMainForm.FunctionValues);

            this.Cursor = Cursors.WaitCursor;
            mGeneticPoly.Start();
            mMainForm.textBoxEquation.Text = mGeneticPoly.Equation;
            this.Cursor = Cursors.Default;
            this.Close();
        }
    }
}
