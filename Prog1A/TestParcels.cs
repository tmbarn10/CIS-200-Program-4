// Program 1A
// CIS 200-01/76
// Fall 2017
// Due: 11/27/2017
// By: C5503

// File: TestParcels.cs
// This is a simple, console application designed to exercise the Parcel hierarchy.
// It creates several different Parcels and prints them.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class TestParcels
    {
        // Precondition:  None
        // Postcondition: Parcels have been created and displayed
        static void Main(string[] args)
        {
            // Test Data - Magic Numbers OK
            Address a1 = new Address("  John Smith  ", "   123 Any St.   ", "  Apt. 45 ",
                "  Louisville   ", "  KY   ", 40202); // Test Address 1
            Address a2 = new Address("Jane Doe", "987 Main St.",
                "Beverly Hills", "CA", 90210); // Test Address 2
            Address a3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 79901); // Test Address 3
            Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4
            Address a5 = new Address("John Stamos", "3483 Golden Gate Way", "Apt. 1",
                "San Francisco", "CA", 94016); // Test Address 5

            Letter letter1 = new Letter(a1, a2, 3.95M);                            // Letter test object
            Letter letter2 = new Letter(a3, a5, 5.25M);                            // Letter test object
            Letter letter3 = new Letter(a2, a5, 4.24M);                            // Letter test object
            GroundPackage gp1 = new GroundPackage(a3, a4, 14, 10, 5, 12.5);        // Ground test object
            GroundPackage gp2 = new GroundPackage(a2, a5, 13, 8, 4, 12.3);         // Ground test object
            GroundPackage gp3 = new GroundPackage(a1, a5, 12, 5, 3, 11.25);        // Ground test object
            NextDayAirPackage ndap1 = new NextDayAirPackage(a1, a3, 25, 15, 15,    // Next Day test object
                85, 7.50M);
            NextDayAirPackage ndap2 = new NextDayAirPackage(a2, a5, 24, 18, 6,    // Next Day test object
                57, 7.62M);
            TwoDayAirPackage tdap1 = new TwoDayAirPackage(a2, a1, 46.5, 39.5, 28.0, // Two Day test object
                80.5, TwoDayAirPackage.Delivery.Saver);
            TwoDayAirPackage tdap2 = new TwoDayAirPackage(a5, a1, 40, 45, 29.3, // Two Day test object
                74.2, TwoDayAirPackage.Delivery.Early);

            List<Parcel> parcels;      // List of test parcels

            parcels = new List<Parcel>
            {
                letter1, // Populate list
                letter2,
                letter3,
                gp1,
                gp2,
                gp3,
                ndap1,
                ndap2,
                tdap1,
                tdap2
            };

            Console.WriteLine("Original List:"); // Shows original list of Parcels for each object in the list
            Console.WriteLine("====================");
            foreach (Parcel p in parcels)
            {
                Console.WriteLine(p);
                Console.WriteLine("====================");
            }
            Pause();

            parcels.Sort(); // Sorts the list of parcels in its natural order, which is ascending order by cost, stated in the Parcel class
            Console.WriteLine("Sorted list of parcels in natural order (ascending by cost):");
            Console.WriteLine("====================");
            foreach (Parcel p in parcels)
            {
                Console.WriteLine(p);
                Console.WriteLine("====================");
            }
            Pause();

            parcels.Sort(new DescendByDestZip()); // Sort the list of Parcels in descending order by destination zip code using the DescendByDestZip comparer
            Console.WriteLine("Parcels sorted by destination zip code in descending order:");
            Console.WriteLine("====================");
            foreach (Parcel p in parcels)
            {
                Console.WriteLine(p);
                Console.WriteLine("====================");
            }
            Pause();
        }

        // Precondition:  None
        // Postcondition: Pauses program execution until user presses Enter and
        //                then clears the screen
        public static void Pause()
        {
            Console.WriteLine("Press Enter to Continue...");
            Console.ReadLine();

            Console.Clear(); // Clear screen
        }
    }
}
