//main method
class Program
    {
        static void Main(string[] args)
        {
            //object creation prompts the code to run
            fuct ass = new fuct();
            Console.ReadKey();
        }
        
    }

//fuct class
public class fuct
    {
        public fuct()
        {
            //prompt to enter integer
            Console.Write("Please enter an int: ");
            //input value
            int fucc = int.Parse(Console.ReadLine());
            //validation for value
            while(fucc < 0)
            {
                Console.Write("Invalid input. Please enter a positive value");
                fucc = int.Parse(Console.ReadLine());
            }
            //ans var and init
            int ans = 1;
            //recursive function to calculate the fact
            for (int i = fucc; i > 0; i --)
            {
                ans = i * ans;
            }
            //prints out the outputfuct 
            Console.WriteLine("{0}! = {1}", fucc, ans);
        }
    }