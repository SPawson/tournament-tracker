using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Models;

namespace TrackerLibrary.Interfaces
{
    public interface IDataConnection
    {
        PrizeModel CreatePize(PrizeModel model);
    }
}
