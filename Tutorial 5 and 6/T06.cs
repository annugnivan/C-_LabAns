//main class
static void Main(string[] args)
        {
            //Account
            Account Eric = new Account("6969696969", "Eric Lau", 60000);
            Console.WriteLine(Eric);

            //Supplier Account
            SupplierAccount Derek = new SupplierAccount("420420420", "Dick Rick", 6800, "VIP");
            Console.WriteLine(Derek);
            Derek.increaseBalance(200);
            Console.WriteLine(Derek);
            Derek.sellItem(2, 20);
            Console.WriteLine(Derek + "\n");

            //Customer Account
            CustomerAccount Mike = new CustomerAccount("8008135", "Milk Man", 200);
            Console.WriteLine(Mike + "\n");
            Mike.BuyItem(2, 3.50);
            Console.WriteLine(Mike + "\n");
            Mike.ReceivePayment(420.69);
            Console.WriteLine(Mike);

            Console.ReadKey();
        }

//account class 
//getter and setters
        private string number;
        private double balance;
        public string Name { get; set; }

        //conditional getters and setter
        public string Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }

        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }

        //overloaded constructor
        public Account(string num, string nm, double bal)
        {
            Number = num;
            Name = nm;
            Balance = bal;
        }

        //to increase account balance
        public void increaseBalance(double amount)
        {
            if (amount > 0)
            {
                Balance = Balance + amount;
                Console.WriteLine("Transaction accepted");
            }
            else
            {
                Console.WriteLine("Transaction denied");
            }
        }

        //decreases account balance
        public void decreaseBal(double amount)
        {
            if ((amount > 0) || (amount > Balance))
            {
                Console.WriteLine("Transaction denied because of insufficient balance/invalid input");
            }
            else
            {
                Balance = Balance - amount;
                Console.WriteLine("Transaction accepted");
            }
        }
        
        public override string ToString()
        {
            return string.Format("\n\nAccount information\nAccount no: {0}\nHolder's name: {1}\nAccount balance: {2:C}", Number, Name, Balance);
        }

//supplier account
public string SupplierType { get; set; }

      

        //need empty constructor in your class otherwise this will result in an error
        //only for constructor
        public SupplierAccount(string num, string nm, double bal, String st) : base(num, nm, bal)//need to include base(a, b, c) otherwise error
        {
            Number = num;
            Name = nm;
            Balance = bal;
            SupplierType = st;
        }

        //sell item method
        public void sellItem(double quantity, double price)
        {
            if (quantity * price > 0)
            {
                Balance = Balance + (quantity * price);
            }
            else
            {
                Console.WriteLine("Transactional error");
            }
        }

        //increases account balance
        public new void increaseBalance(double amount)
        {
            if (amount > 0)
            {
                if (SupplierType.Equals("VIP"))
                {
                    Console.WriteLine("VIP status detected");
                    amount = 2 * amount;
                }
                    Balance = Balance + amount;
                Console.WriteLine("Transaction accepted");
            }
            else
            {
                Console.WriteLine("Transaction denied");
            }
        }
        //you know what it is
        public override string ToString()
        {
            return string.Format("\n\nAccount information\nAccount no: {0}\nHolder's name: {1}\nAccount balance: {2}\nSupplier Type: {3}", Number, Name, Balance, SupplierType);
        }

//customer account
//constructor
        public CustomerAccount(string num, string nm, double bal):base(num, nm, bal)
        {
            Number = num;
            Name = nm;
            Balance = bal;
        }

        //validation
        private bool checkBalance(double total)
        {
            if(Balance > total)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //buys item
        public void BuyItem(int quantity, double price)
        {
            double total = quantity * price;
            if (checkBalance(total) == true)
            {
                Balance = Balance - total;
                Console.WriteLine("Thank you for your purchase");
            }
            else
            {
                Console.WriteLine("Insufficient funds");
            }
        }

        //increases amount in account
        public void ReceivePayment(double amount)
        {
            increaseBalance(amount);
        }

        public override string ToString()
        {
            return string.Format("Account information\nAccount no: {0}\nHolder's name: {1}\nAccount balance: {2}", Number, Name, Balance);
        }