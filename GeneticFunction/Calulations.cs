using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ZedGraph;

namespace Gunter.Roy.Mathematics.GeneticFunction
{
    public partial class Calulations : Form
    {
        private GeneticFunction mainForm;
        private List<PointPair> pointlist;
        private static bool _exists = false;

        public Calulations(GeneticFunction _mainForm, PointPairList _points)
        {
            InitializeComponent();
            mainForm = _mainForm;
            pointlist = _points;
        }

        public bool Exists { get { return _exists; } }

        private void Calulations_Load(object sender, EventArgs e)
        {
            _exists = true;
            this.Left = mainForm.Left;
            this.Top = mainForm.Top + mainForm.Height;
            this.Width = mainForm.Width;
            this.Height = (mainForm.Height)/2;
            this.dataGridView1.Height = this.Height - 63;

            if (pointlist.Count > 0)
            {
                foreach (PointPair point in pointlist)
                {
                    this.dataGridView1.Rows.Add(point.X, point.Y);
                }
            }

        }

        private void Calulations_FormClosing(object sender, FormClosingEventArgs e)
        {
            _exists = false;
        }

        private void dataGridView1_SizeChanged(object sender, EventArgs e)
        {
            if (this.dataGridView1.Left + this.dataGridView1.Width + 50 > mainForm.Width)
            {
                this.Width = this.dataGridView1.Left + this.dataGridView1.Width + 50;
            }
        }
    }
}
