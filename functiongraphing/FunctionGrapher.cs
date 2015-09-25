using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Gunter.Roy.Graphics;

using info.lundin.Math;
using ZedGraph;

namespace Gunter.Roy.Mathematics.FunctionGrapher
{
    public partial class FunctionGrapher : Form
    {
        public GraphSettings grSettings = new GraphSettings();
        private Calulations calculations;
        private GraphSettingsDialog settingsdialog;
        private List<Color> ColorList;
        private Color OppositeGraphColor;
        GraphPane myPane;
        List<PointPair> pointlist = new List<PointPair>();

        public FunctionGrapher()
        {
            InitializeComponent();
            ColorList = new List<Color>();
            CreateColorList();
            grSettings.Changed += new ChangedEventHandler(SettingsChanged);
        }

        // This will be called whenever the list changes.
        private void SettingsChanged(object sender, EventArgs e)
        {
            grSettings = (GraphSettings)sender;
            CreateGraph(zedGraphControl1);
            SetSize();
            zedGraphControl1.Refresh();
        }

        public ZedGraphControl ZGControl
        {
            get
            {
                return this.zedGraphControl1;
            }
        }

        public void Detach()
        {
            // Detach the event and delete the list
            grSettings.Changed -= new ChangedEventHandler(SettingsChanged);
            grSettings = null;
        }

        public GraphSettings Settings
        {
            get
            {
                return grSettings;
            }

            set
            {
                grSettings = value;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateGraph(zedGraphControl1);
            SetSize();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            SetSize();
        }

        private void SetSize()
        {
            zedGraphControl1.Location = new Point(12, 28);
            zedGraphControl1.Size = new Size(ClientRectangle.Width - 20, ClientRectangle.Height - 45);
        }

        private void CreateGraph(ZedGraphControl zgc)
        {
            this.Cursor = Cursors.WaitCursor;

            pointlist.Clear();

            try
            {
                myPane = zgc.GraphPane;

                // Set the Titles
                if (grSettings.GraphType.Equals(GraphTypes.ParametricFamily) || grSettings.GraphType.Equals(GraphTypes.ParametricFunction))
                {
                    myPane.Title.Text = grSettings.GraphType + ": (" + grSettings.FunctionA + ", " + grSettings.FunctionB + ")";
                }
                else
                {
                    myPane.Title.Text = grSettings.GraphType + ": " + grSettings.FunctionA;
                }

                myPane.Chart.Fill.Type = FillType.Solid;
                myPane.Chart.Fill.Color = grSettings.Background;
                OppositeGraphColor = Color.FromArgb(255 - grSettings.Background.R,
                                                    255 - grSettings.Background.G,
                                                    255 - grSettings.Background.B);

                if (grSettings.GraphType.Equals(GraphTypes.Function))
                {
                    CreateGraphOfFunction(zgc);
                }
                else if (grSettings.GraphType.Equals(GraphTypes.Derivative))
                {
                    CreateGraphOfDerivative(zgc);
                }
                else if (grSettings.GraphType.Equals(GraphTypes.VectorField))
                {
                    CreateGraphOfVectorField(zgc);
                }
                else if (grSettings.GraphType.Equals(GraphTypes.LevelCurves))
                {
                    CreateGraphOfLevelCurves(zgc);
                }
                else if (grSettings.GraphType.Equals(GraphTypes.LevelCurves2))
                {
                    CreateGraphOfLevelCurves(zgc);
                }
                else if (grSettings.GraphType.Equals(GraphTypes.ParametricFunction))
                {
                    CreateGraphOfParametricFunction(zgc);
                }
                else if (grSettings.GraphType.Equals(GraphTypes.ParametricFamily))
                {
                    CreateGraphOfParametricFamily(zgc);
                }
                else if (grSettings.GraphType.Equals(GraphTypes.Slope))
                {
                    CreateGraphOfSlope(zgc);
                }
                else if (grSettings.GraphType.Equals(GraphTypes.Iteration))
                {
                    CreateGraphOfIteration(zgc);
                }
                else if (grSettings.GraphType.Equals(GraphTypes.Cobweb))
                {
                    CreateGraphOfCobweb(zgc);
                }
                else if (grSettings.GraphType.Equals(GraphTypes.TwoDIteration))
                {
                    CreateGraphOf2DIteration(zgc);
                }

                // Tell ZedGraph to refigure the axes since the data have changed
                zgc.AxisChange();

                if (grSettings.Grid)
                {
                    myPane.XAxis.MajorGrid.IsVisible = true;
                    myPane.YAxis.MajorGrid.IsVisible = true;

                    myPane.XAxis.Color = Color.FromArgb(255 - grSettings.Background.R,
                                                        255 - grSettings.Background.G,
                                                        255 - grSettings.Background.B);

                    myPane.XAxis.MajorGrid.Color = Color.FromArgb(255 - grSettings.Background.R,
                                                                  255 - grSettings.Background.G,
                                                                  255 - grSettings.Background.B);

                    myPane.YAxis.Color = Color.FromArgb(255 - grSettings.Background.R,
                                                        255 - grSettings.Background.G,
                                                        255 - grSettings.Background.B);
                    myPane.YAxis.MajorGrid.Color = Color.FromArgb(255 - grSettings.Background.R,
                                                                  255 - grSettings.Background.G,
                                                                  255 - grSettings.Background.B);
                }
                else
                {
                    myPane.XAxis.MajorGrid.IsVisible = false;
                    myPane.YAxis.MajorGrid.IsVisible = false;
                }

                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreateGraphOfFunction(ZedGraphControl zgc)
        {
            PointPairList list = new PointPairList();
            PointPair point = new PointPair();
            LineItem myCurve;
            double x, y;

            for (x = grSettings.XMin; x <= grSettings.XMax; x = x + grSettings.XIncr)
            {
                y = function(x);

                if (!grSettings.SmoothGraph)
                {
                    list = new PointPairList();
                }
                point = new PointPair();
                point.X = x;
                point.Y = y;
                list.Add(point);
                pointlist.Add(point);

                if (!grSettings.SmoothGraph)
                {
                    myCurve = myPane.AddCurve("", list, OppositeGraphColor, SymbolType.Default);
                    myCurve.Symbol.Size = 1;
                }
            }
            if (grSettings.SmoothGraph)
            {
                myCurve = myPane.AddCurve("", list, OppositeGraphColor, SymbolType.Default);
                myCurve.Symbol.Size = 1;
            }
        }

        private void CreateGraphOfIteration(ZedGraphControl zgc)
        {
            PointPairList list = new PointPairList();
            PointPair point = new PointPair();
            LineItem myCurve;
            double x, y;

            y = grSettings.StartingX;

            for (long n = 1; n <= grSettings.N; n++)
            {
                y = function(y);

                if (!grSettings.SmoothGraph)
                {
                    list = new PointPairList();
                }
                point = new PointPair();
                point.X = n;
                point.Y = y;
                list.Add(point);
                pointlist.Add(point);

                if (!grSettings.SmoothGraph)
                {
                    myCurve = myPane.AddCurve("", list, OppositeGraphColor, SymbolType.Default);
                    myCurve.Symbol.Size = 1;
                }
            }
            if (grSettings.SmoothGraph)
            {
                myCurve = myPane.AddCurve("", list, OppositeGraphColor, SymbolType.Default);
                myCurve.Symbol.Size = 1;
            }
        }

        private void CreateGraphOfCobweb(ZedGraphControl zgc)
        {
            PointPairList list = new PointPairList();
            PointPair point = new PointPair();
            LineItem myCurve;
            LineItem myCurve2;
            double x;

            myPane.XAxis.Color = OppositeGraphColor;
            myPane.YAxis.Color = OppositeGraphColor;
            myPane.XAxis.IsVisible = true;
            myPane.YAxis.IsVisible = true;

            PointPairList list1 = new PointPairList();
            PointPairList list2 = new PointPairList();
            for (x = grSettings.XMin; x <= grSettings.XMax; x = x + grSettings.XIncr)
            {
                list1.Add(x, x);
                myCurve = myPane.AddCurve("", list1, Color.Blue, SymbolType.None);

                list2.Add(x, function(x));
                myCurve2 = myPane.AddCurve("", list2, OppositeGraphColor, SymbolType.None);
            }
            CobwebPlots();
        }

        private void CobwebPlots()
        {
            PointPairList cobwebList;

            double x0 = grSettings.StartingX;
            double y0 = 0;
            cobwebList = new PointPairList();
            for (long n = 0; n < grSettings.N; n++)
            {
                cobwebList.Add(x0, y0);
                y0 = function(x0);
                cobwebList.Add(x0, y0);
                cobwebList.Add(y0, y0);
                x0 = y0;

                LineItem cobwebCurve = myPane.AddCurve("", cobwebList, RedBlueSlopeColor(y0), SymbolType.Plus);
            }
        }

        private void CreateGraphOfDerivative(ZedGraphControl zgc)
        {
            // Make up some data arrays based on the Sine function
            double x, y;
            PointPairList list = new PointPairList();
            PointPair point = new PointPair();
            LineItem myCurve;

            for (x = grSettings.XMin; x <= grSettings.XMax; x = x + grSettings.XIncr)
            {
                y = derivative(x);

                if (!grSettings.SmoothGraph)
                {
                    list = new PointPairList();
                }
                point = new PointPair();
                point.X = x;
                point.Y = y;
                list.Add(point);
                pointlist.Add(point);

                if (!grSettings.SmoothGraph)
                {
                    myCurve = myPane.AddCurve("", list, SlopeColor(y), SymbolType.Default);
                    myCurve.Symbol.Size = 1;
                }
            }
            if (grSettings.SmoothGraph)
            {
                myCurve = myPane.AddCurve("", list, Color.Yellow, SymbolType.Default);
                myCurve.Symbol.Size = 1;
            }
        }

        private void CreateGraphOfParametricFunction(ZedGraphControl zgc)
        {
            PointPairList list = new PointPairList();
            PointPair point = new PointPair();
            LineItem myCurve;
            double t;
            double x, y;
           
            int colorIndex = 1;
            Color color = ColorList[colorIndex];

            for (t = grSettings.XMin; t <= grSettings.XMax; t = t + grSettings.XIncr)
            {
                x = parametricfunction(grSettings.FunctionA, t);
                y = parametricfunction(grSettings.FunctionB, t);

                if (!grSettings.SmoothGraph)
                {
                    list = new PointPairList();
                }
                point = new PointPair();
                point.X = x;
                point.Y = y;
                list.Add(point);
                pointlist.Add(point);

                if (!grSettings.SmoothGraph)
                {
                    myCurve = myPane.AddCurve("", list, color, SymbolType.Default);
                    myCurve.Symbol.Size = 1;
                }
            }

            if (grSettings.SmoothGraph)
            {
                myCurve = myPane.AddCurve("", list, color, SymbolType.Default);
                myCurve.Symbol.Size = 1;
            }

            colorIndex++;
            if (colorIndex >= ColorList.Count) colorIndex = 0;
            color = ColorList[colorIndex];
        }

        private void CreateGraphOfParametricFamily(ZedGraphControl zgc)
        {
            PointPairList list = new PointPairList();
            PointPair point = new PointPair();
            LineItem myCurve;
            double t;
            double x, y;

            double c = grSettings.C1Min;
            double c1 = grSettings.C1Min;
            double c2 = grSettings.C2Min;

            int colorIndex = 1;
            Color color = ColorList[colorIndex];

            while (c1 < grSettings.C1Max || c2 < grSettings.C2Max)
            {
                for (t = grSettings.XMin; t <= grSettings.XMax; t = t + grSettings.XIncr)
                {
                    x = parametricfamilyfunction(grSettings.FunctionA, t, c, c1, c2);
                    y = parametricfamilyfunction(grSettings.FunctionB, t, c, c1, c2);

                    if (!grSettings.SmoothGraph)
                    {
                        list = new PointPairList();
                    }
                    point = new PointPair();
                    point.X = x;
                    point.Y = y;
                    list.Add(point);
                    pointlist.Add(point);

                    if (!grSettings.SmoothGraph)
                    {
                        myCurve = myPane.AddCurve("", list, color, SymbolType.Default);
                        myCurve.Symbol.Size = 1;
                    }
                }

                if (grSettings.SmoothGraph)
                {
                    myCurve = myPane.AddCurve("", list, color, SymbolType.Default);
                    myCurve.Symbol.Size = 1;
                }

                c = c + grSettings.C1Incr;
                c1 = c1 + grSettings.C1Incr;
                c2 = c2 + grSettings.C2Incr;
                colorIndex = colorIndex * 3;
                if (colorIndex >= ColorList.Count) colorIndex = 1;
                color = ColorList[colorIndex];
            }
        }

        private void CreateGraphOfVectorField(ZedGraphControl zgc)
        {
            double x, y, z;
            PointPairList list = new PointPairList();
            PointPair point = new PointPair();
            LineItem myCurve;

            for (x = grSettings.XMin; x <= grSettings.XMax; x = x + grSettings.XIncr)
            {
                for (y = grSettings.YMin; y <= grSettings.YMax; y = y + grSettings.YIncr)
                {
                    z = vectorfield(x, y);

                    list = new PointPairList();
                    point = new PointPair();
                    point.X = x;
                    point.Y = y;
                    list.Add(point);
                    pointlist.Add(point);

                    point.X = x + z * Math.Cos(Math.Atan(z));
                    point.Y = y + z * Math.Sin(Math.Atan(z));
                    list.Add(point);
                    pointlist.Add(point);

                    myCurve = myPane.AddCurve("", list, RedBlueSlopeColor(z), SymbolType.Default);
                    myCurve.Symbol.Size = 1;
                }
            }
        }

        private void CreateGraphOfLevelCurves(ZedGraphControl zgc)
        {
            double x, y, z;
            PointPairList list = new PointPairList();
            PointPair point = new PointPair();
            LineItem myCurve;
            double line = 0;
            double area = Math.Pow( Math.Pow(grSettings.XIncr,2) + Math.Pow(grSettings.YIncr, 2), 0.5);

            for (x = grSettings.XMin; x <= grSettings.XMax; x = x + grSettings.XIncr)
            {
                for (y = grSettings.YMin; y <= grSettings.YMax; y = y + grSettings.YIncr)
                {
                    z = levelcurve(x, y);
                    line = Math.Round(z);

                    list = new PointPairList();
                    point = new PointPair();
                    point.X = x;
                    point.Y = y;
                    list.Add(point);
                    pointlist.Add(point);

                    if (z >= line - area && z <= line + area)
                    {
                        list.Add(point);
                        pointlist.Add(point);

                        myCurve = myPane.AddCurve("", list, RedBlueSlopeColor(z), SymbolType.Default);
                        myCurve.Symbol.Size = 1;
                    }
                }
                //myCurve = myPane.AddCurve("", list, Color.Red, SymbolType.Default);
                //myCurve.Symbol.Size = 1;
            }
        }

        private void CreateGraphOfLevelCurves2(ZedGraphControl zgc)
        {
            double x, y, z;
            PointPairList list = new PointPairList();
            PointPair point = new PointPair();
            LineItem myCurve;
            double line = 0;
            double area = Math.Pow(Math.Pow(grSettings.XIncr, 2) + Math.Pow(grSettings.YIncr, 2), 0.5);

            for (x = grSettings.XMin; x <= grSettings.XMax; x = x + grSettings.XIncr)
            {
                for (y = grSettings.YMin; y <= grSettings.YMax; y = y + grSettings.YIncr)
                {
                    z = levelcurve(x, y);
                    line = Math.Round(z);

                    list = new PointPairList();
                    point = new PointPair();
                    point.X = x;
                    point.Y = y;
                    list.Add(point);
                    pointlist.Add(point);

                    if (z >= line - area && z <= line + area)
                    {
                        list.Add(point);
                        pointlist.Add(point);

                        myCurve = myPane.AddCurve("", list, RedBlueSlopeColor(z), SymbolType.Default);
                        myCurve.Symbol.Size = 1;
                    }
                }
                //myCurve = myPane.AddCurve("", list, Color.Red, SymbolType.Default);
                //myCurve.Symbol.Size = 1;
            }
        }

        private void CreateGraphOfSlope(ZedGraphControl zgc)
        {
            // Make up some data arrays based on the Sine function
            double x, y, y1, y2, y3;
            PointPairList list = new PointPairList();
            PointPairList list1 = new PointPairList();
            PointPairList list2 = new PointPairList();
            PointPairList list3 = new PointPairList();
            PointPair point = new PointPair();
            LineItem myCurve;

            //  y' = y^2 - x
            for (x = grSettings.XMin; x <= grSettings.XMax; x = x + grSettings.XIncr)
            {
                for (y = grSettings.YMin; y <= grSettings.YMax; y = y + grSettings.YIncr)
                {
                    y1 = slope(x, y);

                    y2 = y1 + 0.1 * y1;
                    y3 = y1 - 0.1 * y1;

                    list = new PointPairList();
                    point = new PointPair();
                    point.X = x;
                    point.Y = y;
                    list.Add(point);
                    pointlist.Add(point);

                    myCurve = myPane.AddCurve("", list, SlopeColor(y1), SymbolType.Default);
                    myCurve.Symbol.Size = 1;
                }
            }
        }

        private void CreateGraphOf2DIteration(ZedGraphControl zgc)
        {
            PointPairList list = new PointPairList();
            PointPair point = new PointPair();
            LineItem myCurve;
            double x, y;

            myPane.XAxis.Color = OppositeGraphColor;
            myPane.YAxis.Color = OppositeGraphColor;
            myPane.XAxis.IsVisible = true;
            myPane.YAxis.IsVisible = true;

            DrawCircle(zgc, 1);

            for (x = grSettings.XMin; x <= grSettings.XMax; x = x + grSettings.XIncr)
            {
                y = function(x);

                if (!grSettings.SmoothGraph)
                {
                    list = new PointPairList();
                }
                point = new PointPair();
                point.X = x;
                point.Y = y;
                list.Add(point);
                pointlist.Add(point);

                if (!grSettings.SmoothGraph)
                {
                    myCurve = myPane.AddCurve("", list, OppositeGraphColor, SymbolType.Default);
                    myCurve.Symbol.Size = 1;
                }
            }
            if (grSettings.SmoothGraph)
            {
                myCurve = myPane.AddCurve("", list, OppositeGraphColor, SymbolType.Default);
                myCurve.Symbol.Size = 1;
            }
        }

        private void DrawCircle(ZedGraphControl zgc, double diameter)
        {
            PointPairList list = new PointPairList();
            PointPair point = new PointPair();
            LineItem myCurve;

            for (double theta = 0; theta <= Math.PI* 2; theta = theta + Math.PI * 2 /360)
            {
                point = new PointPair();
                point.X = diameter/2*Math.Cos(theta);
                point.Y = diameter / 2 * Math.Sin(theta); ;
                list.Add(point);
                pointlist.Add(point);

            }
            myCurve = myPane.AddCurve("", list, OppositeGraphColor, SymbolType.None);
            myCurve.Symbol.Size = 1;
        }

        private void CreateColorList()
        {
            Color color = new Color();
            string colorName = String.Empty;

            // Get a Type object for the Example type.
            Type t = typeof(Color);
            System.Array members3 = t.GetProperties();

            for( int i = 0; i < members3.GetLength(0); i++ )
            {
                Object obj = members3.GetValue(i);
                colorName = obj.ToString();
                colorName = colorName.Replace("System.Drawing.Color ", "");
                color = Color.FromName(colorName);
                ColorList.Add(color);
            }

        }

        private void CreateGrid(double _width)
        {
            PointPairList list = new PointPairList();
            PointPair point = new PointPair();
            LineItem myCurve;
            double x, y;

            GraphPane np = myPane;

            for (x = grSettings.XMin; x <= grSettings.XMax; x = x + _width)
            {
                list = new PointPairList();
                point = new PointPair();
                point.X = x;
                point.Y = grSettings.YMax;
                list.Add(point);

                point = new PointPair();
                point.X = x;
                point.Y = grSettings.YMin;
                list.Add(point);

                myCurve = myPane.AddCurve("", list, Color.LightGray, SymbolType.None);
            }

            for (y = grSettings.YMin; y <= grSettings.YMax; y = y + _width)
            {
                list = new PointPairList();
                point = new PointPair();
                point.X = grSettings.XMin;
                point.Y = y;
                list.Add(point);

                point = new PointPair();
                point.X = grSettings.XMax;
                point.Y = y;
                list.Add(point);

                myCurve = myPane.AddCurve("", list, Color.AntiqueWhite, SymbolType.None);
                myCurve.Symbol.Size = 1;
            }
        }

        private Color NewColor(int index)
        {
            return ColorList[index];
        }

        private Color RedBlueSlopeColor(double slope)
        {
            //Scale slope to 50 to 210
            Color color = Color.Red;
            double lum = 50;

            try
            {
                if (slope < 0)
                {
                    lum = 190 * Math.Log10(-slope) + 50;
                    HSLColor redcolor = new HSLColor(0.0, 240.0, lum);
                    color = redcolor;
                }
                else
                {
                    lum = 190 * Math.Log10(slope) + 50;
                    HSLColor bluecolor = new HSLColor(160.0, 240.0, lum);
                    color = bluecolor;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return color;
        }

        private Color BlueSlopeColor(double slope)
        {
            //Scale slope to 50 to 210
            double lum = 50;
            //System.Diagnostics.Debug.WriteLine(Math.Atan(slope));
            lum = -190 * Math.Atan(slope) + 240;

            HSLColor bluecolor = new HSLColor(160.0, 240.0, lum);

            return bluecolor;
        }

        private Color SlopeColor(double slope)
        {
            // Create a green color using the FromRgb static method.
            Color myRgbColor = new Color();
            int R = 0;
            int G = 0;
            int B = 0;

            Random rnd = new Random();
            byte[] rgb = new byte[3];
            rnd.NextBytes(rgb);

            if (slope <= 0)
            {
                R = Convert.ToInt32(255 * (-grSettings.SlopeColorLimit / slope));
                G = Convert.ToInt32(255 * (-grSettings.SlopeColorLimit / slope));
                B = Convert.ToInt32(255 * (-grSettings.SlopeColorLimit / slope));

                //G = grSettings.BaseG;
                //B = grSettings.BaseB;
            }
            else if (slope <= -grSettings.SlopeColorLimit)
            {
                R = Convert.ToInt32(255 * (-grSettings.SlopeColorLimit / slope));
                G = Convert.ToInt32(255 * (-grSettings.SlopeColorLimit / slope));
                B = Convert.ToInt32(255 * (-grSettings.SlopeColorLimit / slope));

                //G = grSettings.BaseG;
                //B = grSettings.BaseB;
            }
            else if (slope <= grSettings.SlopeColorLimit)
            {
                R = Convert.ToInt32((255 / (2 * grSettings.SlopeColorLimit)) * slope + (255 / 2));
                G = Convert.ToInt32((255 / (2 * grSettings.SlopeColorLimit)) * slope + (255 / 2));
                B = Convert.ToInt32((255 / (2 * grSettings.SlopeColorLimit)) * slope + (255 / 2));

                //R = grSettings.BaseR;
                //B = grSettings.BaseB;
            }
            else if (slope > grSettings.SlopeColorLimit)
            {
                R = Convert.ToInt32(255 * (grSettings.SlopeColorLimit / slope));
                G = Convert.ToInt32(255 * (grSettings.SlopeColorLimit / slope));
                B = Convert.ToInt32(255 * (grSettings.SlopeColorLimit / slope));

                //G = grSettings.BaseG;
                //R = grSettings.BaseR;
            }
            myRgbColor = Color.FromArgb(R, G, B);
            return myRgbColor;
        }

        private double function(double x0)
        {
            // Instantiate the parser
            ExpressionParser parser = new ExpressionParser();

            // Create a hashtable to hold values
            Hashtable h = new Hashtable();

            // Add variables and values to hashtable
            h.Add("t", 0);
            h.Add("x", x0.ToString());
            h.Add("c", 0);
            h.Add("c1", 0);
            h.Add("c2", 0);

            // Parse and write the result
            string tempFunction = grSettings.FunctionA;
            double result = parser.Parse(tempFunction, h);

            return result;
        }

        private double parametricfunction(string _function, double t0)
        {
            // Instantiate the parser
            ExpressionParser parser = new ExpressionParser();

            // Create a hashtable to hold values
            Hashtable h = new Hashtable();

            // Add variables and values to hashtable
            h.Add("t", t0.ToString());
            h.Add("x", 0);
            h.Add("c", 0);
            h.Add("c1", 0);
            h.Add("c2", 0);

            // Parse and write the result
            string tempFunction = _function;
            double result = parser.Parse(tempFunction, h);

            return result;
        }

        private double parametricfamilyfunction(string _function, double t0, double c, double c1, double c2)
        {
            // Instantiate the parser
            ExpressionParser parser = new ExpressionParser();

            // Create a hashtable to hold values
            Hashtable h = new Hashtable();

            // Add variables and values to hashtable
            h.Add("t", t0.ToString());
            h.Add("x", t0.ToString());
            h.Add("c", c.ToString());
            h.Add("c1", c1.ToString());
            h.Add("c2", c2.ToString());

            // Parse and write the result
            string tempFunction = _function;
            double result = parser.Parse(tempFunction, h);

            return result;
        }

        private double derivative(double x0)
        {
            // Instantiate the parser
            ExpressionParser parser = new ExpressionParser();

            // Create a hashtable to hold values
            Hashtable h = new Hashtable();

            // Add variables and values to hashtable
            h.Add("t", x0.ToString());
            h.Add("x", x0.ToString());
            h.Add("c", 0);
            h.Add("c1", 0);
            h.Add("c2", 0);

            // Parse and write the result
            string tempFunction = grSettings.FunctionA;
            double result = parser.Parse(tempFunction, h);

            return result;
        }

        private double vectorfield(double x0, double y0)
        {
            // Instantiate the parser
            ExpressionParser parser = new ExpressionParser();

            // Create a hashtable to hold values
            Hashtable h = new Hashtable();

            // Add variables and values to hashtable
            h.Add("x", x0.ToString());
            h.Add("y", y0.ToString());
            h.Add("t", x0.ToString());
            h.Add("c", 0);
            h.Add("c1", 0);
            h.Add("c2", 0);

            // Parse and write the result
            string tempFunction = grSettings.FunctionA;
            double result = parser.Parse(tempFunction, h);

            return result;
        }

        private double levelcurve(double x0, double y0)
        {
            // Instantiate the parser
            ExpressionParser parser = new ExpressionParser();

            // Create a hashtable to hold values
            Hashtable h = new Hashtable();

            // Add variables and values to hashtable
            h.Add("x", x0.ToString());
            h.Add("y", y0.ToString());
            h.Add("t", x0.ToString());
            h.Add("c", 0);
            h.Add("c1", 0);
            h.Add("c2", 0);

            // Parse and write the result
            string tempFunction = grSettings.FunctionA;
            double result = parser.Parse(tempFunction, h);

            return result;
        }

        private double slope(double x0, double y0)
        {
            // Instantiate the parser
            ExpressionParser parser = new ExpressionParser();

            // Create a hashtable to hold values
            Hashtable h = new Hashtable();

            // Add variables and values to hashtable
            h.Add("x", x0.ToString());
            h.Add("y", x0.ToString());
            h.Add("t", y0.ToString());
            h.Add("c", 0);
            h.Add("c1", 0);
            h.Add("c2", 0);

            // Parse and write the result
            string tempFunction = grSettings.FunctionA;
            double result = parser.Parse(tempFunction, h);

            return result;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                GraphSettingsDialog settings = new GraphSettingsDialog(grSettings, this);
                settings.Show();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (settingsdialog == null)
            {
                settingsdialog = new GraphSettingsDialog(grSettings, this);
                settingsdialog.Show();
            }
            else if (settingsdialog.Exists)
            {
                settingsdialog.Focus();
            }
            else
            {
                settingsdialog = new GraphSettingsDialog(grSettings, this);
                settingsdialog.Show();
            }
        }

        private void calculationsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (calculations == null)
            {
                calculations = new Calulations(this, pointlist);
                calculations.Show();
            }
            else if (calculations.Exists)
            {
                calculations.Focus();
            }
            else
            {
                calculations = new Calulations(this, pointlist);
                calculations.Show();
            }
        }

        private void newGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form newgraph = new FunctionGrapher();
            newgraph.Show();
        }

        private void graphItToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateGraph(zedGraphControl1);
            SetSize();
        }

        private void zedGraphControl1_MouseClick(object sender, MouseEventArgs e)
        {
            if (grSettings.GraphType.Equals(GraphTypes.VectorField))
            {
                this.Cursor = Cursors.WaitCursor;
                double x, y, z, startZ;
                PointPairList list = new PointPairList();
                PointPair point = new PointPair();
                PointPair startPoint = new PointPair();
                LineItem myCurve;

                startPoint.X = e.X;
                startPoint.Y = e.Y;
                y = startPoint.Y;
                startZ = vectorfield(startPoint.X, startPoint.Y);
                if (startZ < 0) startZ = -startZ;
                double measure = startZ;
                if (measure < 0.5) measure = 0.5;

                for (x = startPoint.X; x <= measure; measure = measure + grSettings.XIncr)
                {
                    z = vectorfield(x, y);

                    list = new PointPairList();
                    point = new PointPair();
                    point.X = x;
                    point.Y = y;
                    list.Add(point);
                    pointlist.Add(point);

                    point.X = x + z * Math.Cos(Math.Atan(z));
                    point.Y = y + z * Math.Sin(Math.Atan(z));
                    list.Add(point);
                    pointlist.Add(point);

                    myCurve = myPane.AddCurve("", list, Color.Yellow, SymbolType.Default);
                    myCurve.Symbol.Size = 1;
                }
            }
            this.Cursor = Cursors.Default;
        }
    }
}