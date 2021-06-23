using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Interfaces;
using TrackerLibrary.Models;

namespace TrackerLibrary.Classes
{
    public class TextConnector : IDataConnection
    {
        // TODO - Make the create prize actually save to Text file
        /// <summary>
        /// Saves a new prize to the text file
        /// </summary>
        /// <param name="model">Prize information</param>
        /// <returns>The prize information, including the prize id</returns>
        public PrizeModel CreatePize(PrizeModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}
