using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gunter.roy.msdn.microsoft.operatoroverloading
{
    public class MathVector : ArrayList
    {
        public static MathVector operator + (MathVector vector1, MathVector vector2)
        {
            try
            {
                MathVector results = new MathVector();

                for(int i = 0; i < vector1.Count; i++)
                {
                    results.Add((decimal)vector1[i] + (decimal)vector2[i]);
                }
                return results;
            }
            catch(MathVectorDifferentLengthException ex)
            {
                Console.WriteLine("MathVectors must be the same length.");
                return null;
            }
        }

        public static decimal operator *(MathVector vector1, MathVector vector2)
        {
            try
            {
                decimal value = 0.0M;
                for (int i = 0; i < vector1.Count; i++)
                {
                    value = value + ((decimal)vector1[i] * (decimal)vector2[i]);
                }
                return value;
            }
            catch (MathVectorDifferentLengthException ex)
            {
                Console.WriteLine("MathVectors must be the same length.");
                return 0.0M;
            }
        }

        public override string ToString()
        {
            string representation = string.Empty;

            foreach(decimal coordinate in this)
            {
                representation = representation + coordinate + " ";
            }

            return representation;
        }
    }

    public class MathVectorDifferentLengthException : Exception
    {
        public MathVectorDifferentLengthException()
        {

        }
    }
}
