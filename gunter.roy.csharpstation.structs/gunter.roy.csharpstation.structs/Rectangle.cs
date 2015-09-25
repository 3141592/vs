using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gunter.roy.csharpstation.structs
{
    /// <summary>
    /// Custom struct type, representing a rectangular shape
    /// </summary>
    struct Rectangle
    {
        /// <summary>
        /// Height of rectangle
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Width of rectangle
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// Area of rectangle
        /// </summary>
        public int Area ()
        {
            return Height * Width;
        }
    }
}
