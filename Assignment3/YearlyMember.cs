using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class YearlyMember : Member
    {
        private double dues;

        public override double Dues { get { return dues; } set { if (value == dues) return; dues = value; } }

        public double WeeklyDues { get { return dues / 52; } }
        public double MonthlyDues { get { return dues / 12; } }

        #region Constructor
        public YearlyMember (string a, string b, string c, double d) : base(a, b, c)
        {
            Dues = d;
        }
        #endregion

        public new string ToString()
        {
           
            return ($"Weekly Dues: {this.WeeklyDues}, Monthly Dues: {this.MonthlyDues}, Annual Dues: {this.Dues}");
        }
    }
}
