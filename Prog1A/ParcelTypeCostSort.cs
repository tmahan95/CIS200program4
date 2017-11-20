//Grading ID: D2575
//Program 4
//Due Date: 11/29/16
//Course Section: 76 
//Description: This class is used to sort the parcel objects by type, then by cost within each type.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class ParcelTypeCostSort : Comparer<Parcel>
    {
        public override int Compare(Parcel p1, Parcel p2)
        {
            if (p1 == null && p2 == null)//if both parcels are null, they are equal
                return 0;
            if (p1 == null)//p2 is greater than p1 if p1 is null
                return -1;
            if (p2 == null)//p1 is greater than p2 if p2 is null
                return 1;

            if (p1.GetType().ToString().CompareTo(p2.GetType().ToString()) != 0) //test to see if the parcels are not the same type
                return p1.GetType().ToString().CompareTo(p2.GetType().ToString()); //compare the types, return the results
            else if (p1.CalcCost().CompareTo(p2.CalcCost()) != 0)//test to make sure parcels do not cost the same if they are the same type
                return p1.CalcCost().CompareTo(p2.CalcCost());//compare the costs, return the results.
            else
                return 0;//if type and cost are the same, return the parcels are equal.
        }
    }
}
