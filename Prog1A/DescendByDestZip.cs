// Program 4
// CIS 200-01/76
// Fall 2017
// Due: 11/27/2017
// By: C5503

// File: DescendByDestZip.cs
// Class that is derived from the IComparer<Parcel> that is used to sort parcels by destination zip code in descending order
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    public class DescendByDestZip : IComparer<Parcel>
    {
        // Precondition: None
        // Postcondition: When p1 < p2, method returns a positive #
        //                When p1 = p2, method returns zero
        //                When p1 > p2, method returns negative #
        public int Compare(Parcel p1, Parcel p2) // Return sorted parcels by destination zip code in descending order
        {
            if (p1 == null && p2 == null)
                return 0;

            if (p1 == null)
                return -1;

            if (p2 == null)
                return 1;

            return (p2.DestinationAddress.Zip).CompareTo(p1.DestinationAddress.Zip);
        }
    }
}
