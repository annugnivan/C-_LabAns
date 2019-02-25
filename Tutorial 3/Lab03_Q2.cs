//main class
class Program
    {
        static void Main(string[] args)
        {
            //Integer object
            Integer power = new Integer();

            //conditions to work
            bool condition = true;
            int Base;
            int Exp;
                
            //calculation segment
            while (condition)//as long condition is true the prog will run
            {
                //prompt to input info
                Console.Write("Please enter int (negative to terminate): ");
                Base = int.Parse(Console.ReadLine());
                //validation to determine if negative is entered
                if (Base < 0)//if negative is entered
                {
                    Console.WriteLine("Program terminated");
                    condition = false;//loop breaks
                }
                else //if value is positive
                {
                    Console.Write("Please enter your exponent: ");
                    Exp = int.Parse(Console.ReadLine());
                    power.Power(Base, Exp);
                }
               
            }
            
            //Console.ReadKey();
        }
//Integer class
public class Integer
    {

        public Integer ()
        {
            
        }

        public void Power(int bAse, int eXp)
        {
            int Pow = bAse;
            //calculation for the method
            for (int counter = eXp - 1; counter > 0; counter--)
            {
                Pow = Pow * bAse;
            }
            Console.WriteLine("{0} to the power of {1} is {2}",bAse, eXp, Pow);
        }

    }