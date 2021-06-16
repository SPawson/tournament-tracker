using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
   public class PersonModel
    {
        /// <summary>
        /// Represents the first name
        /// </summary>
        public string Firstname { get; set; }
        /// <summary>
        /// Represents the Lastname
        /// </summary>
        public string Lastname { get; set; }
        /// <summary>
        /// Represents the Email Address 
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Represents the phone number
        /// </summary>
        public string PhoneNumber { get; set; }
    }
}
