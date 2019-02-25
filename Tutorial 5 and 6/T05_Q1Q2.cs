//date class
public class Date
    {
        //instance variables
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        //date constructor to input values using system
        public Date(int d, int m, int y)
        {
            Day = d;
            Month = m;
            Year = y;
        }
        //parameterless constructor
        public Date() { }

        //method to set date, works with both constructors
        private void setDate()
        {
            Console.Write("Enter day: ");
            Day = int.Parse(Console.ReadLine());
            Console.Write("Enter month: ");
            Month = int.Parse(Console.ReadLine());
            Console.Write("Enter year: ");
            Year = int.Parse(Console.ReadLine());
        }

        //THE method
        public override string ToString()
        {
            return string.Format("{0}/{1}/{2}", Day, Month, Year);
        }
    }
//employee method
public class Employee
    {
        //instance vars
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //this only allows Date objects to be used
        private readonly Date birthDate;
        private readonly Date hireDate;

        //employee overloaded constructor
        public Employee(string fn, string ln, Date bd, Date hd)
        {
            FirstName = fn;
            LastName = ln;
            birthDate = bd;
            hireDate = hd;
        }

        //you know what it is
        public override string ToString()
        {
            return string.Format("Name: {0}, {1}\nHired: {2}\nBorn: {3}", 
                FirstName, LastName, birthDate, hireDate);
        }
    }
//main class
class Program
    {
        static void Main(string[] args)
        {
            //date objects
            Date BobBDay = new Date(20, 3, 1970); //uses overloaded
            Date BobHDay = new Date(); //uses empty

            //method to manually input values for date
            BobHDay.setDate();

            //Bob employee object
            Employee Bob = new Employee("Bobert", "Danbert", BobBDay, BobHDay);

            //toString() handles the rest
            Console.WriteLine(Bob);

            Console.ReadKey();
        }
    }