namespace Prog_120_S23_L17_LinearSearch
{
    internal class Program
    {
        static int[] numbers = { 10, 50, 30, 70, 80, 20, 90, 40 };

        static void Main(string[] args)
        {
            // Linear Search
            

        } // Main

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