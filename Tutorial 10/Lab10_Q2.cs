static void Main(string[] args)
    {
        int[] intArray = { 1, 2, 3, 4, 5, 6 };
        double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7 };
        char[] charArray = { 'H', 'E', 'L', 'L', 'O' };

        //string method
        string[] stringArray = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };

        //method called to print the array
        DisplayArray(stringArray);
        Console.ReadKey();
    }

    //new array to be printed
    public static void DisplayArray(string[] stringArray)
    {
        //for loop
        for(int x = 0; x < stringArray.Length; x++)
        {
            //to allow the method to skip a line
            if (x == (stringArray.Length / 2))
            {
                Console.WriteLine(" ");
            }
            //prints out the array
            Console.Write(stringArray[x] + "   ");
        }
    }