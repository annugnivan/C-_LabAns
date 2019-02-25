//main class
class Program
    {
        static void Main(string[] args)
        {
            //main class method to use other methods
            Program program = new Program();

            //decimal deposit amount
            decimal depositAmount;
            decimal withdrawalAmount;
            decimal totalAmount;

           
            //creates objects with predetermined values
            Account account1 = new Account(50.00M);
            Account account2 = new Account(-7.53M);

            //prints out the account balances
            program.printBill(account1.Balance, account2.Balance);
            
            //input deposit for acc1
            Console.WriteLine("Enter deposit amount for account1: ");
            depositAmount = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("adding {0:C} to account1 balance\n", depositAmount);
            account1.Credit(depositAmount);

            //prints out the account balances
            program.printBill(account1.Balance, account2.Balance);

            Console.Write("Enter deposit amount for account2: ");
            depositAmount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("adding {0:C} to account2 balance\n", depositAmount);
            account2.Credit(depositAmount);

            //prints out the account balances
            program.printBill(account1.Balance, account2.Balance);

            Console.WriteLine("Enter withdrawal amount for account1: ");
            withdrawalAmount = Convert.ToDecimal(Console.ReadLine());
            account1.withdraw(withdrawalAmount);

            //prints out the account balances
            program.printBill(account1.Balance, account2.Balance);

            Console.WriteLine("Enter withdrawal amount for account2: ");
            withdrawalAmount = Convert.ToDecimal(Console.ReadLine());
            account1.withdraw(withdrawalAmount);

            //prints out the account balances
            program.printBill(account1.Balance, account2.Balance);

            //calculates total
            totalAmount = account1.Balance + account2.Balance;
            Console.WriteLine("\nTotal balance is {0:C}", totalAmount);

            Console.ReadKey();
        }

        public void printBill(decimal balance1, decimal balance2)
        {
            
            Console.WriteLine("account1 balance: {0:C}", balance1);
            Console.WriteLine("account2 balance: {0:C}\n", balance2);
        }
        
    }

//account class
public class Account
    {
        private decimal balance;

        public Account (decimal initialBalance)
        {
            Balance = initialBalance;
        }

        public void Credit(decimal amount)
        {
            Balance = Balance + amount;
        }

        //learn how to use this method
        public decimal Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if (value >= 0)
                    balance = value;
                else
                    Console.WriteLine("Please enter a more legible value");
            }
        }

        public void withdraw(decimal w_amount)
        {
            //validation for method
            Console.WriteLine("Subtracting {0} from account...", w_amount);
            if (balance - w_amount <= 0)
            {
                Console.WriteLine("Transaction denied, insufficient balance");
            }
            else
            {
                Console.WriteLine("Transaction accepted");
                balance = balance - w_amount;
            }
        }


    }