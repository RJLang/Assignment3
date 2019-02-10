using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class LifeTimeMember : Member
    {
        private double dues;
        private double discount;

        public double Discount { get; set; }
        public override double Dues { get { return dues; } set { if (value > 0) { discount = value * .15; dues = value - discount; }; } }


        #region constructor

        public LifeTimeMember (string a, string b, string c, double d) :base(a, b, c)
        {
            Dues = d;
        }
        #endregion

        public new string ToString()
        {
            return ($"Lifetime member dues: {this.Dues}, With the discount of: {this.discount}");
        }

    }
}
