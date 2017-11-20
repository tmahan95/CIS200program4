//Grading ID: D2575
//Program 4
//Due Date: 11/29/16
//Course Section: 76 
//Description: This class sorts the parcel objects in a parcel list by destination address in descending order.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class ParcelDestZipDescendingOrder : Comparer<Parcel>
    {

        public override int Compare(Parcel p1, Parcel p2)
        {
            if (p1 == null && p2 == null)//if both parcels are null, they are equal
                return 0;
            if (p1 == null)//p2 is greater than p1 if p1 is null
                return -1;
            if (p2 == null)//p1 is greater than p2 if p2 is null
                return 1;
            if (p1.DestinationAddress.Zip.CompareTo(p2.DestinationAddress.Zip) != 0)//test to make sure parcels do not cost the same if they are the same type
                return (-1)*(p1.DestinationAddress.Zip.CompareTo(p2.DestinationAddress.Zip));
            else
                return 0; //if the dest address is the same, the parcels are equal

        }
    }
}
