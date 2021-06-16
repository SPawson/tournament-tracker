using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// Represents the finishing place for the prize
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Represents the place name for the prize
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Represents the prize amount
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Represents the percentage of the prize
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
