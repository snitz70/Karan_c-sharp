using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karan.Numbers
{
    public class Room
    {
        /// <summary>
        /// Get the total cost of floor tiles for a room
        /// using the inputed height, width and cost per tile
        /// </summary>
        /// 
        public double Height { get; set; }
        public double Width { get; set; }
        public double CostPerTile { get; set; }
        public double Area
        {
            get
            {
                return (Height * Width);
            }

        }
        public decimal TotalCost
        {
            get
            {
                return (decimal)(Area * CostPerTile);
            }
        }
    }
}
