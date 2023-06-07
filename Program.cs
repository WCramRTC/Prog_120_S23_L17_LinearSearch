using System.ComponentModel.Design.Serialization;

namespace Prog_120_S23_L17_LinearSearch
{
    internal class Program
    {
        static int[] numbers = { 10, 50, 30, 70, 80, 20, 90, 40 };
        static int[] random = { 37, 81, 5, 47, 19, 92, 76, 52, 63, 88, 10, 24, 42, 60, 98, 15, 72, 34, 50, 3 };

        static string[] names = { "Benel", "David", "Will", "Josh" };
        static string[] className = { "Prog 120", "Prog 120", "Prog 124", "CSI 234" };
        static string[] roomNumbers = { "Online", "102", "111", "106" };






        static void Main(string[] args)
        {

            string search = "Prog 124";
            int locationOfSearch = LocationOf(search, className);

            Console.WriteLine($"{names[locationOfSearch]} - Program : {className[locationOfSearch]} - Location : {roomNumbers[locationOfSearch]}");




            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine($"{names[i]} - Program : {className[i]} - Location : {roomNumbers[i]}");
            //}





        } // Main

        

        // Linear search that returns true or false
        public static bool Contains(int search, int[] array)
        {
            // Looping through the array
            foreach(int number in array)
            {
                Console.WriteLine(number);
                // Checking if our number exists
                if (search == number)
                {
                    // Return TRUE if found
                    return true;
                }
                
            }
            // If not found, return false
            return false;
        }

        // What is the location of our search
        //   0    1  2    3  4    5  6   7
        // { 10, 50, 30, 70, 80, 20, 90, 40 };
        public static int LocationOf(string search, string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (search == array[i])
                {
                    return i;
                }
            }

            return -1;
        }

        public static void Example()
        {

            // Search the array for a specific number

            // Find number 20
            // ONLY display the number 20

            Console.WriteLine("Enter a number to search for ");
            int search = int.Parse(Console.ReadLine());

            // Looping Through our entire Array
            for (int i = 0; i < numbers.Length; i++)
            {
                //Console.WriteLine(numbers[i] + $": {search == numbers[i]}");

                // We are comparing our search value with each value in the array
                // If the same value is found as a search, run this block of code
                if (search == numbers[i])
                {
                    Console.WriteLine($"{numbers[i]}");
                }

            }
            // inputs
            // outputs
            // loops
            // conditions
            // variables
            // operators
        }

    } // class

} // namespace