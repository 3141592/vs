using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Gunter.Roy.Mathematics.GeneticFunction
{
    // A delegate type for hooking up change notifications.
    public delegate void ChangedEventHandler(object sender, EventArgs e);

    public class GraphSettings
    {
        // An event that clients can use to be notified whenever the
        // elements of the list change.
        public event ChangedEventHandler Changed;

        // Invoke the Changed event; called whenever list changes
        protected virtual void OnChanged(EventArgs e)
        {
            if (Changed != null) Changed(this, e);
        }

        private bool mGrid;
        private double mGridWidth;
        private bool mSmoothGraph;
        
        private bool mUpdated;
        private string mFunctionA;
        private string mFunctionB;
        private string mGraphType;

        //Family constants
        private double mC1Max;
        private double mC1Min;
        private double mC1Incr;

        private double mC2Max;
        private double mC2Min;
        private double mC2Incr;

        private double mXMax;
        private double mXMin;
        private double mXIncr;

        private double mYMax;
        private double mYMin;
        private double mYIncr;

        private double mStartingX;
        private long mN;

        private Color mBackground;

        private double mTraceLen;

        private double mSlopeColorLimit;

        private int mBaseR;
        private int mBaseG;
        private int mBaseB;

        public GraphSettings()
        {
            mGrid = false;
            mGridWidth = 1;
            mSmoothGraph = false;

            mFunctionA = "cos(x)";
            mFunctionB = "cos(t)^3 - sin(t)^3";
            mGraphType = GraphTypes.Function;

            mC1Max = 2.0;
            mC1Min = -2.0;
            mC1Incr = 0.5;

            mC2Max = 2.0;
            mC2Min = -2.0;
            mC2Incr = 0.5;

            mXMax = 2.0;
            mXMin = -2.0;
            mXIncr = 0.1;

            mYMax = 2.0;
            mYMin = -2.0;
            mYIncr = 0.1;

            mStartingX = 0.1;
            mN = 50;

            mBackground = Color.Black;

            mTraceLen = 0.1;

            mSlopeColorLimit = 2.0;

            mBaseR = 180;
            mBaseG = 180;
            mBaseB = 180;
        }

        public bool Updated
        {
            get { return mUpdated; }
            set { OnChanged(EventArgs.Empty); mUpdated = value; }
        }

        public bool Grid
        {
            get { return mGrid; }
            set { mGrid = value; }
        }

        public double GridWidth
        {
            get { return mGridWidth; }
            set { mGridWidth = value; }
        }

        public bool SmoothGraph
        {
            get { return mSmoothGraph; }
            set { mSmoothGraph = value; }
        }

        public int BaseB
        {
            get { return mBaseB; }
            set { mBaseB = value;}
        }

        public int BaseG
        {
            get { return mBaseG; }
            set { mBaseG = value; }
        }

        public int BaseR
        {
            get { return mBaseR; }
            set { mBaseR = value;}
        }

        public double SlopeColorLimit
        {
            get { return mSlopeColorLimit; }
            set { mSlopeColorLimit = value; }
        }

        public double TraceLen
        {
            get { return mTraceLen; }
            set { mTraceLen = value; }
        }

        public string FunctionA
        {
            get { return mFunctionA; }
            set { mFunctionA = value;}
        }

        public string FunctionB
        {
            get { return mFunctionB; }
            set { mFunctionB = value; }
        }

        public double C1Max
        {
            get { return mC1Max; }
            set { mC1Max = value; }
        }

        public double C1Min
        {
            get { return mC1Min; }
            set { mC1Min = value; }
        }

        public double C1Incr
        {
            get { return mC1Incr; }
            set { mC1Incr = value; }
        }
        public double C2Max
        {
            get { return mC2Max; }
            set { mC2Max = value; }
        }

        public double C2Min
        {
            get { return mC2Min; }
            set { mC2Min = value; }
        }

        public double C2Incr
        {
            get { return mC2Incr; }
            set { mC2Incr = value; }
        }

        public double XMax
        {
            get { return mXMax; }
            set { mXMax = value; }
        }

        public double XMin
        {
            get { return mXMin; }
            set { mXMin = value; }
        }

        public double XIncr
        {
            get { return mXIncr; }
            set { mXIncr = value; }
        }

        public double YMax
        {
            get { return mYMax; }
            set { mYMax = value; }
        }

        public double YMin
        {
            get { return mYMin; }
            set { mYMin = value; }
        }

        public double YIncr
        {
            get { return mYIncr; }
            set { mYIncr = value; }
        }

        public double StartingX
        {
            get { return mStartingX; }
            set { mStartingX = value; }
        }

        public long N
        {
            get { return mN; }
            set { mN = value; }
        }

        public Color Background
        {
            get { return mBackground; }
            set { mBackground = value; }
        }

        public string GraphType
        {
            get { return mGraphType; }
            set { mGraphType = value; }
        }
    }

    public static class GraphTypes
    {
        public static string Function
        { get { return "Function"; } }

        public static string Derivative
        { get { return "Derivative"; } }

        public static string VectorField
        { get { return "Vector Field"; } }

        public static string LevelCurves
        { get { return "Level Curves"; } }

        public static string LevelCurves2
        { get { return "Level Curves2"; } }

        public static string Slope
        { get { return "Slope"; } }

        public static string ParametricFamily
        { get { return "Parametric Family"; } }

        public static string ParametricFunction
        { get { return "Parametric Function"; } }

        public static string Iteration
        { get { return "Iteration"; } }

        public static string Cobweb
        { get { return "Cobweb"; } }

        public static string TwoDIteration
        { get { return "2DIteration"; } }

        public static string LiveUpdate
        { get { return "LiveUpdate"; } }

        public static int Count
        {
            get { return 9; }
        }

    }
}
