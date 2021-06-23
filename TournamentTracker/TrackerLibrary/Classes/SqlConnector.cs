using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Interfaces;
using TrackerLibrary.Models;

namespace TrackerLibrary.Classes
{
    public class SqlConnector : IDataConnection
    {
        // TODO - Make the create prize actually save to DB
        /// <summary>
        /// Saves a new prize to the database
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
