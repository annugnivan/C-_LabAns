public static void Main(string[] args)
        {
            //list of shitty array
            int[] intArray = { 1, 2, 3, 4, 5, 6 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };

            //input for low index
            Console.Write("Please input low index");
            int LowInd = int.Parse(Console.ReadLine());

            //validation
            while (LowInd < 0 || LowInd > intArray.Length)
            {
                Console.WriteLine("Invalid input");
                Console.Write("Please input low index");
                LowInd = int.Parse(Console.ReadLine());
            }

            //input for high index
            Console.Write("Please input high index");
            int HiInd = int.Parse(Console.ReadLine());

            //validation
            while (HiInd < LowInd || HiInd > intArray.Length)
            {
                Console.WriteLine("Invalid input");
                Console.Write("Please input high index");
                HiInd = int.Parse(Console.ReadLine());
            }

            DisplayArray(intArray, LowInd, HiInd);

            Console.ReadKey();
        }

        //print index from lowindex to highindex
        private static void DisplayArray(int[] inputArray, int lowIndex, int highIndex)
        {
            
            //VALIDATION
            /*lowIndex >= 0 && lowIndex lowIndex < ArraySize
             * highIndex > lowIndex && highIndex < ArraySize
             */

            //prints out the arrays based on the low index and high index
            for (int i = lowIndex; i < highIndex + 1; i++)
            {
                Console.WriteLine(inputArray[i]);
            }
        }