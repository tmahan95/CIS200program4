// Program 1A
// CIS 200-01/76
// Fall 2016
// Due: 10/10/2016
// By: Andrew L. Wright (students use Grading ID)

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
            Address a1 = new Address("John Smith", "123 Any St.", "Apt. 45",
                "Louisville", "KY", 40202); // Test Address 1
            Address a2 = new Address("Jane Doe", "987 Main St.", "",
                "Beverly Hills", "CA", 90210); // Test Address 2
            Address a3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 79901); // Test Address 3
            Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4

            Letter letter1 = new Letter(a1, a2, 3.95M);                            // Letter test object
            Letter letter2 = new Letter(a2, a1, 90.0M);                            // Second Letter test object
            Letter letter3 = new Letter(a3, a4, 10.0M);                            // Third Letter test object
            Letter letter4 = new Letter(a3, a1, 6.0M);                             // Fourth Letter test object
            GroundPackage gp1 = new GroundPackage(a3, a4, 14, 10, 5, 12.5);        // Ground test object
            GroundPackage gp2 = new GroundPackage(a2, a4, 12, 12, 15, 20.8);       // Second Ground test object
            GroundPackage gp3 = new GroundPackage(a1, a2, 9, 8, 7, 15.0);          // Third Ground test object
            NextDayAirPackage ndap1 = new NextDayAirPackage(a1, a3, 25, 15, 15,    // Next Day test object
                85, 7.50M);
            NextDayAirPackage ndap2 = new NextDayAirPackage(a4, a1, 10, 6, 5,      // Second Next Day test object
                7, 80.0M);
            TwoDayAirPackage tdap1 = new TwoDayAirPackage(a1, a4, 46.5, 39.5, 28.0,// Two Day test object
                80.5, TwoDayAirPackage.Delivery.Saver);
            TwoDayAirPackage tdap2 = new TwoDayAirPackage(a4, a3, 5, 6, 7,         // Second Two Day test object
                8.0, TwoDayAirPackage.Delivery.Early);


            List<Parcel> parcels;      // List of test parcels

            parcels = new List<Parcel>();

            parcels.Add(letter1); // Populate list
            parcels.Add(letter2);
            parcels.Add(letter3);
            parcels.Add(letter4);
            parcels.Add(gp1);
            parcels.Add(gp2);
            parcels.Add(gp3);
            parcels.Add(ndap1);
            parcels.Add(ndap2);
            parcels.Add(tdap1);
            parcels.Add(tdap2);

            Console.WriteLine("Original List:"); //Start Original list
            Console.WriteLine("====================");//Help keep parcel lists seperated in console
            foreach (Parcel p in parcels) //start loop to display 
            {
                Console.WriteLine(p); //Write parcel object to console
                Console.WriteLine("====================");//help keep parcels seperated in console
            }
            Pause();//Wait for user to review console and hit enter


            parcels.Sort(); //Sort using default/natural order
            Console.WriteLine("Parcels sorted in ascending order by Cost"); 
            foreach (Parcel p in parcels)//Start loop to write sorted parcels to consol
            {
                Console.WriteLine(p);//Write parcel object to console
                Console.WriteLine("====================");
            }
            Pause();//wait for user to review consol and hit enter

            parcels.Sort(new ParcelDestZipDescendingOrder()); //sort parcels using the class that lists by descending cost
            Console.WriteLine("Parcels sorted in descending order by Cost");
            foreach (Parcel p in parcels) //start loop to write sorted parcels
            {
                Console.WriteLine(p);// Write parcel object to console
                Console.WriteLine("====================");
            }
            Pause();//wait for user to review consol and hit enter

            parcels.Sort(new ParcelTypeCostSort()); //sort using class that orders by type, then cost
            Console.WriteLine("Parcels sorted by type, then by cost");
            foreach (Parcel p in parcels)//start loop to write parcels to console
            {
                Console.WriteLine(p);// Write parcel object to console
                Console.WriteLine("====================");
            }
            Pause();//wait for user to review consol and hit enter

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
