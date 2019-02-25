//main class
class Program
    {
        static void Main(string[] args)
        {
            //original information
            Console.WriteLine("Original item info");
            Inventory Hammer = new Inventory("6969696", "Johnny Hammer", 20, 20.3M);
            Console.WriteLine(Hammer);

            Console.WriteLine();

            //update desc
            Hammer.ChangeDesc("Extra Powered Drilldo");
            Console.WriteLine("Updated item info");
            Console.WriteLine(Hammer);

            Console.WriteLine();

            //update the item info
            Hammer.ChangeQuant(200);
            Console.WriteLine("Updated item info");
            Console.WriteLine(Hammer);

            Console.ReadKey();
        }

        
    }

//Inventory class
public class Inventory
    {
        //regular getter and setter
        private string PartNum { get; set; }
        private string PartDesc { get; set; }
        private int quantity;
        private decimal price = 0;

        public Inventory (string partNum, string partDesc, int _quantity, decimal _price)
        {
            PartNum = partNum;
            PartDesc = partDesc;
            Quantity = _quantity;
            PricePerItem = _price;
        }

        //conditional getter and setter
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if (value >= 0)
                {
                    quantity = value;
                }
            }
        }

        public decimal PricePerItem
        {
            get
            {
                return price;
            }
            set
            {
                if (value >= 0)
                {
                    price = value;
                }
            }
        }

        //methods to change the values
        public void ChangeDesc(string newDesc)
        {
            PartDesc = newDesc;
        }

        public void ChangeQuant (int newQuant)
        {
            Quantity = newQuant;
        }

        //holy ToString() method
        public override string ToString()
        {
            return "Part Number: " + PartNum +
                "\nDescription: " + PartDesc +
                "\nQuantity: " + quantity +
                "\nPrice: MYR " + price +
                "\nTotal price of all items: MYR" + (quantity * price);
        }
    }