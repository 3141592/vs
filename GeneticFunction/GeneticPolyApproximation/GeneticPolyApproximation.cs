using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using info.lundin.Math;
using Numerics = Meta.Numerics;
using Matrices = Meta.Numerics.Matrices;
using ZedGraph;

namespace Gunter.Roy.Mathematics.GeneticPolyApproximations
{
    public class GeneticPolyApproximation
    {
        //How many terms the approximating polynomial will have.
        private int mTerms;

        //Function to be approximated
        private PointPairList mFunctionValues;

        //Allowable error of approximation
        private double mError;

        //Types of exponents allowed.
        private string mExponenttype;

        //Number of individuals in a generation.
        private int mPopulationSize;

        //Crossover point 0.0 to 1.0 as percentage of Terms
        private int mCrossoverPoint;

        //Number of individuals to reproduce
        private int mNumberOfReproducers;

        private double mChanceOfMutation;

        //Generations to run
        private long mGenerations;

        private int mGenerationCount;

        //Best Fitness Found
        private IndividualDNA mBestFitness;

        private List<IndividualDNA> mCurrentGeneration;
        private List<IndividualDNA> mNewGeneration;
        private List<IndividualDNA> mReproducers;

        // Example #3: Write only some strings in an array to a file.
        string filename = DateTime.Now.Year.ToString() +
                          DateTime.Now.Month.ToString() +
                          DateTime.Now.Day.ToString() + "." +
                          DateTime.Now.Hour.ToString() + "." +
                          DateTime.Now.Minute.ToString() + "." +
                          DateTime.Now.Second.ToString() + "." + "GeneticPoly.txt";

        string reproducerfile = DateTime.Now.Year.ToString() +
                        DateTime.Now.Month.ToString() +
                        DateTime.Now.Day.ToString() + "." +
                        DateTime.Now.Hour.ToString() + "." +
                        DateTime.Now.Minute.ToString() + "." +
                        DateTime.Now.Second.ToString() + "." + "Reproducers.txt";

        public GeneticPolyApproximation()
        {

        }

        public GeneticPolyApproximation(int _Terms,
                                        int _PopulationSize,
                                        double _PercentReproducing,
                                        double _ChanceOfMutation,
                                        long _Generations,
                                        double _CrossoverPoint,
                                        string _Exponenttype, 
                                        double _Error, 
                                        PointPairList _FunctionValues)
        {
            mTerms = _Terms;
            mGenerations = _Generations;
            mFunctionValues = _FunctionValues;
            mError = _Error;
            mExponenttype = _Exponenttype;
            mPopulationSize = _PopulationSize;
            CrossoverPoint = Convert.ToInt16(_CrossoverPoint * mTerms);
            NumberOfReproducers = Convert.ToInt32(mPopulationSize * _PercentReproducing);
            mReproducers = new List<IndividualDNA>();

            mChanceOfMutation = _ChanceOfMutation;

            mCurrentGeneration = new List<IndividualDNA>(mPopulationSize);
            mNewGeneration = new List<IndividualDNA>(mPopulationSize);
        }

        public void Start()
        {
            CreateInitialRandomGeneration();

            for (long i = 1; i < mGenerations; i++)
            {
                CreateNewGeneration();
            }
        }

        public void Save()
        {
            string textline = String.Empty;

            mCurrentGeneration.Sort();
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename, true))
            {
                file.WriteLine("==========================================");
                mReproducers.Sort();
                file.WriteLine("Reproducers: " + mReproducers.Count);
                foreach (IndividualDNA ind in mReproducers)
                {
                    //{index[,alignment][:formatString]}
                    textline = String.Format("{0,12:#0.000}", ind.Fitness);

                    foreach (double gene in ind.Genes)
                    {
                        //textline = textline + gene.ToString("#.000") + "  ";
                        textline = textline + String.Format("{0,12:#0.000}", gene);
                    }

                    file.WriteLine(textline);
                    textline = String.Empty;
                }

                file.WriteLine("Generation: " + mGenerationCount.ToString() + 
                               ", Best Fitness: " + BestFitness.Fitness.ToString() +
                               ", Generation: " + BestFitness.Generation.ToString());

                foreach (IndividualDNA ind in mCurrentGeneration)
                {
                    //{index[,alignment][:formatString]}
                    textline = String.Format("{0,12:#0.000}", ind.Fitness);

                    foreach (double gene in ind.Genes)
                    {
                        //textline = textline + gene.ToString("#.000") + "  ";
                        textline = textline + String.Format("{0,12:#0.000}", gene);
                    }

                    file.WriteLine(textline);
                    file.Flush();
                    textline = String.Empty;
                }
                

                file.Flush();
            }
        }

        public void SaveReproducers()
        {
            string textline = String.Empty;

            mCurrentGeneration.Sort();
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(reproducerfile, true))
            {
                file.WriteLine("==========================================");
                file.WriteLine("Generation: " + mGenerationCount.ToString() + 
                               ", Best Fitness: " + BestFitness.Fitness.ToString() +
                               ", Generation: " + BestFitness.Generation.ToString());

                //{index[,alignment][:formatString]}
                textline = String.Format("{0,12:#0.000}", BestFitness.Fitness);

                foreach (double gene in BestFitness.Genes)
                {
                    //textline = textline + gene.ToString("#.000") + "  ";
                    textline = textline + String.Format("{0,12:#0.000}", gene);
                }

                file.WriteLine(textline);
                file.Flush();
                textline = String.Empty;

                file.WriteLine("==========================================");
                file.WriteLine("Reproducers: " + mReproducers.Count + ", " 
                                + "Generation: " + mGenerationCount.ToString() 
                                + ", Best Fitness: " + BestFitness.Fitness.ToString());

                foreach (IndividualDNA ind in mReproducers)
                {
                    //{index[,alignment][:formatString]}
                    textline = String.Format("{0,12:#0.000}", ind.Fitness);

                    foreach (double gene in ind.Genes)
                    {
                        //textline = textline + gene.ToString("#.000") + "  ";
                        textline = textline + String.Format("{0,12:#0.000}", gene);
                    }

                    file.WriteLine(textline);
                    file.Flush();
                    textline = String.Empty;
                }
                file.Flush();
            }
        }

        public string ToEquation()
        {
            string equation = String.Empty;

            mCurrentGeneration.Sort();

            int exponent = 0;
            string op = String.Empty;
            foreach (double gene in mCurrentGeneration[0].Genes)
            {
                if( gene >= 0 ) 
                {
                    op = " + ";
                }
                else 
                {
                    op = "";
                }

                if (equation.Equals(String.Empty)) op = "";

                equation = equation + op + gene.ToString() + "x^" + exponent.ToString() + "  ";
                exponent++;
            }

            return equation;
        }

        public string ToEquation(IndividualDNA individual)
        {
            string equation = String.Empty;

            int exponent = 0;
            string op = String.Empty;
            foreach (double gene in individual.Genes)
            {
                if (gene >= 0)
                {
                    op = " + ";
                }
                else
                {
                    op = "";
                }

                if (equation.Equals(String.Empty)) op = "";

                equation = equation + op + gene.ToString() + "x^" + exponent.ToString() + "  ";
                exponent++;
            }

            return equation;
        }

        public void CreateInitialRandomGeneration()
        {
            IndividualDNA individual;

            for (int i = 0; i < mPopulationSize; i++)
            {
                individual = new IndividualDNA(mTerms, MinMaxFunctionValueY(FunctionValues));
                individual.CreateInitialRandomGeneration(mCurrentGeneration.Count);
                mCurrentGeneration.Add(individual);
            }
            EvaluateIndividuals(mCurrentGeneration);
            mCurrentGeneration.Sort();

            mBestFitness = mCurrentGeneration[0];
            Save();
        }

        public PointPair MinMaxFunctionValueY(PointPairList _function)
        {
            PointPair MinMax = new PointPair(0,0);

            foreach (PointPair value in _function)
            {
                if (value.Y < MinMax.X) MinMax.X = value.Y;
                if (value.Y > MinMax.Y) MinMax.Y = value.Y;
            }

            return MinMax;
        }

        public void CreateNewGeneration()
        {
            mGenerationCount++;
            mCurrentGeneration.Sort();
            mNewGeneration = new List<IndividualDNA>();
            mReproducers = new List<IndividualDNA>();

            //Select individuals with best fitness for reproduction
            for (int i = 0; i < NumberOfReproducers; i++)
            {
                mReproducers.Add(mCurrentGeneration[i]);
            }
            mReproducers.Sort();

            //Create Mother and Father sets of individuals
            List<IndividualDNA> Mothers = new List<IndividualDNA>();
            List<IndividualDNA> Fathers = new List<IndividualDNA>();

            CreateNewGeneration1(Mothers, Fathers);

            //Check for new Bestfit individual
            mCurrentGeneration.Sort();
            if (Math.Abs(mCurrentGeneration[0].Fitness) < Math.Abs(mBestFitness.Fitness)) mBestFitness = mCurrentGeneration[0];

            SaveReproducers();
            Save();
        }

        private void CreateNewGeneration1(List<IndividualDNA> Mothers, List<IndividualDNA> Fathers)
        {
            Mothers = mReproducers;
            Fathers = mReproducers;

            IndividualDNA child = new IndividualDNA();

            //Add the top n to the new generation
            mNewGeneration.Add(mCurrentGeneration[0]);
            mNewGeneration.Add(mCurrentGeneration[1]);

            //Perform cartesian product of Mothers and Fathers for reproduction
            foreach (IndividualDNA mother in Mothers)
            {
                foreach (IndividualDNA father in Fathers)
                {
                    if (!father.Equals(mother))
                    {
                        child = Reproduce(mother, father);
                        child.Generation = GenerationCount;
                        mNewGeneration.Add(child);
                    }
                }
            }

            //if mNewGeneration is too small, fill it up with the 
            //best from mCurrentGeneration
            int currentcount = 0;
            while (mNewGeneration.Count < mPopulationSize)
            {
                mNewGeneration.Add(mCurrentGeneration[currentcount%50]);
                currentcount++;
            }

            //Calculate fitness of mNewGeneration
            EvaluateIndividuals(mNewGeneration);
            mNewGeneration.Sort();

            //Make mNewGeneration the mCurrentGeneration
            mCurrentGeneration.Clear();
            for (int i = 0; i < mPopulationSize; i++)
            {
                if (!mCurrentGeneration.Contains(mNewGeneration[i]))
                {
                    mCurrentGeneration.Add(mNewGeneration[i]);
                }
            }
            currentcount = 0;
            while (mCurrentGeneration.Count < mPopulationSize)
            {
                mCurrentGeneration.Add(mNewGeneration[currentcount%50]);
                currentcount++;
            }
        }

        public void EvaluateIndividuals(List<IndividualDNA> _generation)
        {
            EvaluateIndividuals2(_generation);
        }

        private void EvaluateIndividuals1(List<IndividualDNA> _generation)
        {
            double tempError = 0;

            for (int i = 0; i < _generation.Count; i++)
            {
                foreach (PointPair value in mFunctionValues)
                {
                    tempError = tempError + Math.Abs(value.Y - GetApproximationPointValue(_generation[i].Genes, value.X));
                }
                _generation[i].Fitness = tempError;
                tempError = 0;
            }
        }

        private void EvaluateIndividuals2(List<IndividualDNA> _generation)
        {
            foreach (IndividualDNA ind in _generation)
            {
                ind.Evaluate(mFunctionValues);
            }
        }

        public IndividualDNA Reproduce(IndividualDNA _mother, IndividualDNA _father)
        {
            return Crossover3(_mother, _father);
        }

        public IndividualDNA Crossover1(IndividualDNA _mother, IndividualDNA _father)
        {
            IndividualDNA child = new IndividualDNA(_mother.Terms);
            child = _mother;

            for (int i = 0; i < mCrossoverPoint; i++)
            {
                child.Genes[i] = _father.Genes[i];
            }

            return child;
        }

        public IndividualDNA Crossover2(IndividualDNA _mother, IndividualDNA _father)
        {
            IndividualDNA child = new IndividualDNA(_mother.Terms);

            for (int i = 0; i < Terms; i++)
            {
                if (i%2 == 0)
                {
                    child.Genes[i] = _mother.Genes[i];
                }
                else
                {
                    child.Genes[i] = _father.Genes[i];
                }
            }

            return child;
        }

        public IndividualDNA Crossover3(IndividualDNA _mother, IndividualDNA _father)
        {
            IndividualDNA child = new IndividualDNA(_mother.Terms);

            for (int i = 0; i < Terms; i++)
            {
                if (i % 2 == 0)
                {
                    child.Genes[i] = _mother.Genes[i];
                }
                else
                {
                    child.Genes[i] = _father.Genes[i];
                }
            }

            return RandomMutation(child);
        }

        public List<IndividualDNA> RandomMutation(List<IndividualDNA> _generation)
        {
            return RandomMutation1(_generation);
        }

        public List<IndividualDNA> RandomMutation1(List<IndividualDNA> _generation)
        {
            List<IndividualDNA> MutatedGeneration = new List<IndividualDNA>();
            MutatedGeneration = _generation;

            Random rand = new Random(DateTime.Now.Millisecond);
            Random rand2 = new Random(Convert.ToInt32(10000*rand.NextDouble()));

            if (rand2.NextDouble() <= mChanceOfMutation)
            {
                MutatedGeneration[rand2.Next(0, MutatedGeneration.Count - 1)].Genes[rand2.Next(0, Terms - 1)] = 
                        rand2.NextDouble();
            }

            return MutatedGeneration;
        }

        public IndividualDNA RandomMutation(IndividualDNA _individual)
        {
            IndividualDNA MutatedDNA = new IndividualDNA();
            MutatedDNA = _individual;

            Random rand = new Random(DateTime.Now.Millisecond);
            Random rand2 = new Random(Convert.ToInt32(10000 * rand.Next(-100, 100)));

            if (rand2.NextDouble() <= mChanceOfMutation)
            {
                MutatedDNA.Genes[rand2.Next(Terms/2, Terms - 1)] = rand2.Next(-100, 100);
            }

            return MutatedDNA;
        }

        public double GetApproximationPointValue(Matrices.Vector<double> _individual, double _x)
        {
            double value = 0;

            for (int i = 0; i < _individual.Dimension; i++)
            {
                value = value + _individual[i] * Math.Pow(_x, i);
            }

            return value;
        }

        //*******************************************************
        // Properties
        //*******************************************************
        public int Terms
        {
            get { return mTerms; }
            set { mTerms = value; }
        }
        public PointPairList FunctionValues
        {
            get { return mFunctionValues; }
            set { mFunctionValues = value; }
        }
        public double Error
        {
            get { return mError; }
            set { mError = value; }
        }
        public string ExponentType
        {
            get { return mExponenttype; }
            set { mExponenttype = value; }
        }
        public int PopulationSize
        {
            get { return mPopulationSize; }
            set { mPopulationSize = value; }
        }
        public int CrossoverPoint
        {
            get { return mCrossoverPoint; }
            set 
            {

                if (value > Terms) value = Terms;
                mCrossoverPoint = value; 
            }
        }
        public IndividualDNA BestFitness
        {
            get { return mBestFitness; }
            set { mBestFitness = value; }
        }
        public int NumberOfReproducers
        {
            get 
            {
                return mNumberOfReproducers; 
            }
            set 
            {
                if (value > PopulationSize) value = PopulationSize;
                mNumberOfReproducers = value; 
            }
        }
        public double ChanceOfMutation
        {
            get { return mChanceOfMutation; }
            set { mChanceOfMutation = value; }
        }
        public int GenerationCount
        {
            get { return mGenerationCount; }
            set { mGenerationCount = value; }
        }
        public string Equation
        {
            get { return ToEquation(); }
        }
    }

    public class IndividualDNA :  IComparable
    {
        private int mTerms;
        private double mFitness;
        private Matrices.Vector<double> mGenes;
        private List<PointPair> mError;
        private long mGeneration;
        private double mMaxFuntionValue;
        private double mMinFuntionValue;

        public IndividualDNA()
        {
            mTerms = 0;
            mFitness = 0;
            mGeneration = 0;
            mMaxFuntionValue = 0;
            mMinFuntionValue = 0;
        }

        public IndividualDNA(int _Terms)
        {
            mTerms = _Terms;
            mFitness = 0;
            mGenes = new Matrices.Vector<double>(mTerms);
            mError = new List<PointPair>();
            mGeneration = 0;
            mMinFuntionValue = 0;
            mMaxFuntionValue = 0;
        }

        public IndividualDNA(int _Terms, PointPair _MinMaxFunctionValue)
        {
            mTerms = _Terms;
            mFitness = 0;
            mGenes = new Matrices.Vector<double>(mTerms);
            mError = new List<PointPair>();
            mGeneration = 0;
            mMinFuntionValue = _MinMaxFunctionValue.X;
            mMaxFuntionValue = _MinMaxFunctionValue.Y;
        }

        public void Evaluate(List<PointPair> _FunctionValues)
        {
            Evaluate1(_FunctionValues);
        }

        private void Evaluate1(List<PointPair> _FunctionValues)
        {
            PointPair point = new PointPair();
            Fitness = 0;
            foreach (PointPair value in _FunctionValues)
            {
                point.X = value.X;
                point.Y =  Math.Abs(value.Y - GetApproximationPointValue(value.X));
                Fitness = Fitness + point.Y;
                Error.Add(point);
            }
        }

        private double GetApproximationPointValue(double _x)
        {
            double value = 0;

            for (int i = 0; i < Terms; i++)
            {
                value = value + Genes[i] * Math.Pow(_x, i);
            }

            return value;
        }

        public void CreateInitialRandomGeneration(int _seed)
        {
            CreateInitialRandomGeneration1(_seed);
            //CreateInitialRandomGeneration2(_seed);
        }

        private void CreateInitialRandomGeneration1(int _seed)
        {
            //Inititally assume exponents are 0, 1, 2, 3, ... mTerms
            mGenes = new Matrices.Vector<double>(Terms);

            Random rand = new Random(DateTime.Now.Millisecond);
            byte[] buffer = new byte[1];
            int sign = 0;

            for (int j = 0; j < Terms; j++)
            {
                for (int i = 0; i <= _seed * 2; i++)
                {
                    rand.NextBytes(buffer);
                }
                sign = buffer[0] % 2;
                if (sign == 0) sign = -1;

                mGenes[j] = Math.Round(rand.NextDouble() * sign, 3);
            }
        }

        private void CreateInitialRandomGeneration2(int _seed)
        {
            //Inititally assume exponents are 0, 1, 2, 3, ... mTerms
            mGenes = new Matrices.Vector<double>(Terms);

            Random rand = new Random(DateTime.Now.Millisecond);
            byte[] buffer = new byte[1];
            int sign = 0;

            for (int j = 0; j < Terms; j++)
            {
                for (int i = 0; i <= _seed * 2; i++)
                {
                    rand.NextBytes(buffer);
                }
                sign = buffer[0] % 2;
                if (sign == 0) sign = -1;

                int min = 1000;
                //mGenes[j] = Math.Round(Math.Sqrt(rand.NextDouble()) * sign, 3);
                mGenes[j] = Math.Round((double)rand.Next((int)MinFuntionValue, (int)MaxFuntionValue) * sign, 3);
            }
        }

        private void CreateInitialRandomGeneration3(int _seed)
        {
            //Inititally assume exponents are 0, 1, 2, 3, ... mTerms
            mGenes = new Matrices.Vector<double>(Terms);

            Random rand = new Random(DateTime.Now.Millisecond);
            byte[] buffer = new byte[1];
            int sign = 0;

            for (int j = 0; j < Terms; j++)
            {
                for (int i = 0; i <= _seed * 2; i++)
                {
                    rand.NextBytes(buffer);
                }
                sign = buffer[0] % 2;
                if (sign == 0) sign = -1;

                if (MaxFuntionValue == 0 && MinFuntionValue == 0)
                {
                    mGenes[j] = Math.Round(Math.Sqrt(rand.NextDouble()) * sign, 3);
                }
                else
                {
                    mGenes[j] = rand.NextDouble() * MaxFuntionValue + MinFuntionValue;
                }
            }
        }

        public int Terms
        {
            get { return mTerms; }
            set { mTerms = value; }
        }

        public double Fitness 
        {
            get { return mFitness; } 
            set 
            {
                mFitness = Math.Round(value, 3); 
            } 
        }
        public Matrices.Vector<double> Genes
        {
            get { return mGenes; }
            set { mGenes = value; }
        }
        public List<PointPair> Error
        {
            get { return mError; }
            set { mError = value; }
        }
        public long Generation
        {
            get { return mGeneration; }
            set { mGeneration = value; }
        }
        public double MaxFuntionValue
        {
            get { return mMaxFuntionValue; }
            set { mMaxFuntionValue = value; }
        }
        public double MinFuntionValue
        {
            get { return mMinFuntionValue; }
            set { mMinFuntionValue = value; }
        }
        public int CompareTo(object obj)
        {
            int result = 1;
            if (obj != null && obj is IndividualDNA)
            {
                IndividualDNA w = obj as IndividualDNA;

                double comparex = Math.Abs(this.Fitness);
                double comparey = Math.Abs(w.Fitness);
                result = comparex.CompareTo(comparey);
            }
            return result;
        }

        static public int Compare(IndividualDNA x, IndividualDNA y)
        {
            int result = 1;

            double comparex = 0;
            double comparey = 0;

            if (x != null && y != null)
            {
                comparex = Math.Abs(x.Fitness);
                comparey = Math.Abs(y.Fitness);
                result = comparex.CompareTo(comparey);
            }
            return result;
        }

        //IEnumerable Interface

    }

    public class IndividualDNAEnum : IEnumerator
    {
        public IndividualDNA[] _DNA;

        // Enumerators are positioned before the first element
        // until the first MoveNext() call.
        int position = -1;

        public IndividualDNAEnum(IndividualDNA[] list)
        {
            _DNA = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _DNA.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public IndividualDNA Current
        {
            get
            {
                try
                {
                    return _DNA[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }

    public class ExponentTypes
    {
        public static string Integer { get { return "Integer"; } }
        public static string Real { get { return "Real"; } }
        public static string PositiveInteger { get { return "PositiveInteger"; } }
        public static string PositiveReal { get { return "PositiveReal"; } }
    }
}
