using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class TeamModel
    {
        public string Name { get; set; }
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
    }
}
