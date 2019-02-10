using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    abstract class Member
    {
        #region variables
        private string name { get; set; }
        private string address { get; set; }
        private string phone { get; set; }

        #endregion

        public abstract double Dues { get; set; }

        #region  constructor
        public Member (string nameIn, string addressIn, string phoneIn)
        {
            name = nameIn;
            address = addressIn;
            phone = phoneIn;
        }
        #endregion

        public override string ToString()
        {
            string formattedPhone = ($"({this.phone.Substring(0, 3)}) {this.phone.Substring(3,3)}-{this.phone.Substring(6,4)}");
            return ($"Name: {this.name}, Address: {this.address}, Phone: {formattedPhone}") ;
        }
    }
}
