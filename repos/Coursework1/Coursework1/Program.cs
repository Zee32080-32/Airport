using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;


namespace Coursework1
{
    class Program
    {
        private static readonly int SEATING_CAPACITY = 12;


        static void Main(string[] args)
        {
            String[] airplane = new String[SEATING_CAPACITY];

            airplane[0] = "Pilot";
            airplane[1] = "Mary Drew";
            airplane[2] = "E";
            airplane[3] = "E";
            airplane[4] = "Homer Simpson";
            airplane[5] = "Marge Simpson";
            airplane[6] = "Bart Simpson";
            airplane[7] = "Lisa Simpson";
            airplane[8] = "Maggi Simpson";
            airplane[9] = "Mastershake";
            airplane[10] = "Frylock";
            airplane[11] = "Meatwad";

            WriteLine("Enter V to View All Seats");
            WriteLine("Enter A to Add a Person");
            WriteLine("Enter E to Display Empty seats");
            WriteLine("Enter D to Delete passenger from seat");
            WriteLine("Enter F to Find a seat name");
            WriteLine("Enter S to Store program data in to a file");
            WriteLine("Enter O to view the seats alphabeticallly");
            WriteLine("Enter Q to Quit");
            string selection = ReadLine();

            while (selection != "Q")
            {
                if (selection == "V")
                {
                    Viewall(airplane);

                    WriteLine("Enter V to View All Seats");
                    WriteLine("Enter A to Add a Person");
                    WriteLine("Enter E to Display Empty seats");
                    WriteLine("Enter D to Delete passenger from seat");
                    WriteLine("Enter F to Find a seat name");
                    WriteLine("Enter S to Store program data in to a file");
                    WriteLine("Enter O to view the seats alphabeticallly");
                    WriteLine("Enter Q to Quit");
                    selection = ReadLine();
                }
                else if (selection == "A")
                {
                    Add(airplane);

                    WriteLine("Enter V to View All Seats");
                    WriteLine("Enter A to Add a Person");
                    WriteLine("Enter E to Display Empty seats");
                    WriteLine("Enter D to Delete passenger from seat");
                    WriteLine("Enter F to Find a seat name");
                    WriteLine("Enter S to Store program data in to a file");
                    WriteLine("Enter O to view the seats alphabeticallly");
                    WriteLine("Enter Q to Quit");
                    selection = ReadLine();
                }
                else if (selection == "E")
                {
                    Empty(airplane);

                    WriteLine("Enter V to View All Seats");
                    WriteLine("Enter A to Add a Person");
                    WriteLine("Enter E to Display Empty seats");
                    WriteLine("Enter D to Delete passenger from seat");
                    WriteLine("Enter F to Find a seat name");
                    WriteLine("Enter S to Store program data in to a file");
                    WriteLine("Enter O to view the seats alphabeticallly");
                    WriteLine("Enter Q to Quit");
                    selection = ReadLine();
                }
                else if (selection == "D")
                {
                    Delete(airplane);

                    WriteLine("Enter V to View All Seats");
                    WriteLine("Enter A to Add a Person");
                    WriteLine("Enter E to Display Empty seats");
                    WriteLine("Enter D to Delete passenger from seat");
                    WriteLine("Enter F to Find a seat name");
                    WriteLine("Enter S to Store program data in to a file");
                    WriteLine("Enter O to view the seats alphabeticallly");
                    WriteLine("Enter Q to Quit");
                    selection = ReadLine();
                }
                else if (selection == "F")
                {
                    Search(airplane);

                    WriteLine("Enter V to View All Seats");
                    WriteLine("Enter A to Add a Person");
                    WriteLine("Enter E to Display Empty seats");
                    WriteLine("Enter D to Delete passenger from seat");
                    WriteLine("Enter F to Find a seat name");
                    WriteLine("Enter S to Store program data in to a file");
                    WriteLine("Enter O to view the seats alphabeticallly");
                    WriteLine("Enter Q to Quit");
                    selection = ReadLine();
                }
                else if (selection == "S")
                {
                    Save(airplane);

                    WriteLine("Enter V to View All Seats");
                    WriteLine("Enter A to Add a Person");
                    WriteLine("Enter E to Display Empty seats");
                    WriteLine("Enter D to Delete passenger from seat");
                    WriteLine("Enter F to Find a seat name");
                    WriteLine("Enter S to Store program data in to a file");
                    WriteLine("Enter O to view the seats alphabeticallly");
                    WriteLine("Enter Q to Quit");
                    selection = ReadLine();
                }
                else if (selection == "O")
                {
                    Sort(airplane);

                    WriteLine("Enter V to View All Seats");
                    WriteLine("Enter A to Add a Person");
                    WriteLine("Enter E to Display Empty seats");
                    WriteLine("Enter D to Delete passenger from seat");
                    WriteLine("Enter F to Find a seat name");
                    WriteLine("Enter S to Store program data in to a file");
                    WriteLine("Enter O to view the seats alphabeticallly");
                    WriteLine("Enter Q to Quit");
                    selection = ReadLine();
                }
                else if (selection == "Q")
                {
                    System.Environment.Exit(0);
                }
                else
                {
                    WriteLine("Enter a letter");
                    selection = ReadLine();
                }
            }
        }

        private static void Viewall(string[] array)
        {
            for (int x = 0; x < SEATING_CAPACITY; x++)
            {
                WriteLine(array[x]);

            }
            WriteLine();
        }

        private static void Add(string[] array)
        {
            String name = "";
            WriteLine("Enter your name");
            name = ReadLine();

            int seat;
            WriteLine("enter seat");
            seat = Convert.ToInt32(ReadLine());

            if (array[seat] == "E")
            {
                array[seat] = name;
            }
            else
            {
                WriteLine("Seat is taken enter another seat");
                seat = Convert.ToInt32(ReadLine());
            }

            for (int x = 0; x < SEATING_CAPACITY; x++)
            {
                WriteLine(array[x]);

            }
            WriteLine();
        }

        private static void Empty(string[] array)
        {
            for (int x = 0; x < SEATING_CAPACITY; x++)
            {
                if (array[x] == "E")
                {
                    WriteLine("Seat {0} is empty", x);

                }
            }
            WriteLine();
        }

        private static void Delete(string[] array)
        {
            String name = "";
            WriteLine("Enter your name to remove yourself");
            name = ReadLine();
            Boolean seat = false;
            for (int x = 0; x < SEATING_CAPACITY; x++)
            {
                if (array[x] == name)
                {
                    array[x] = "E";
                    WriteLine("Name removed");
                    seat = true;
                }
            }

            while (seat == false)
            {
                WriteLine("name not found try again");
                name = ReadLine();

                for (int x = 0; x < SEATING_CAPACITY; x++)
                {
                    if (array[x] == name)
                    {
                        array[x] = "E";
                        WriteLine("Name removed");
                        seat = true;
                    }

                }
            }
            for (int x = 0; x < SEATING_CAPACITY; x++)
            {
                WriteLine(array[x]);
            }
            WriteLine();
        }

        private static void Search(string[] array)
        {
            Boolean seat = false;
            string name = "";
            WriteLine("Enter your name to find your seat");
            name = ReadLine();

            for (int x = 0; x < SEATING_CAPACITY; x++)
            {
                if (array[x] == name)
                {
                    WriteLine("{0} your seat is {1}", name, x);
                    seat = true;
                }
            }
            while (seat == false)
            {
                WriteLine("Name not found try again");
                name = ReadLine();

                for (int x = 0; x < SEATING_CAPACITY; x++)
                {
                    if (array[x] == name)
                    {
                        WriteLine("{0} your seat is {1}", name, x);
                        seat = true;
                    }
                }
            }

        }

        private static void Sort(string[] array)
        {
            for (int x = 1; x < SEATING_CAPACITY; x++)
            {
                for (int y = 0; y < array.Length - x; y++)
                {
                    if (array[y].CompareTo(array[y + 1]) > 0)
                    {
                        String temp = array[y];
                        array[y] = array[y + 1];
                        array[y + 1] = temp;
                    }

                }
            }
            for (int z = 0; z < SEATING_CAPACITY; z++)
            {
                WriteLine(array[z]);

            }
        }

        private static void Save(string[] array)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Zeeshan\Documents\C# Projects\source\file.txt"))
            {
                
                foreach (string line in array)
                {
                    file.WriteLine(line);
                }
            }
        }
    }
}
