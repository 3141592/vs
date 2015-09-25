using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gunter.roy.msdn.microsoft.polymorphism
{
    public class DrawingObject
    {
        public virtual void Draw()
        {
            Console.WriteLine("Generic drawing an object.");
        } 
    }

    public class Line : DrawingObject
    {
        public override void Draw()
        {
            Console.WriteLine("I am a Line.");
        }
    }

    public class Circle : DrawingObject
    {
        public override void Draw()
        {
            Console.WriteLine("I am a Circle.");
        }
    }

    public class Square : DrawingObject
    {
        public override void Draw()
        {
            Console.WriteLine("I am a Square.");
        }
    }

}
