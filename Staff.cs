using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LasVegasMagicalShow
{
    public class Staff : Person
    {
        private double staffSalary;

        public Staff(string personName, string personPassword, double staffSalary) : base(personName, personPassword)
        {
            this.staffSalary = staffSalary;
            title = "Staff";
        }

        public double StaffSalary
        {
            get { return staffSalary; }
            set { staffSalary = value; }
        }

        public override string ToString()
        {
            return base.ToString() + " - Earn: " + staffSalary + "$ / hour";
        }
    }
}