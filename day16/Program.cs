namespace day16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Ellen here");
            Console.WriteLine("Hi Ellen, Matt here");
           
            {
                StudentAccount ba1 = new StudentAccount("matthew.ettridge@iungo.solutions", "Password1", 10, -1000);// parameters for account
                StudentAccount bal2 = new StudentAccount("ehouston1992@hotmail.com", "Tree", 5, -200);
                Console.WriteLine(ba1.withdraw(1000));
                Console.WriteLine(ba1.balance);
                validateUser(ba1);
                userControls(bal2);
            }
            static void validateUser(BankAccount acc)//able to pass in any account here
            {
                while (true)
                {
                    Console.WriteLine("enter an email");
                    string email = Console.ReadLine();
                    Console.WriteLine("enter a password");
                    string password = Console.ReadLine();
                    if (email == acc.email && password == acc.password)
                    {
                        Console.WriteLine("Login Sucessful");
                        break;//stops while loop once entered correct info
                    }
                    Console.WriteLine("Login failed");//if incorrect stuff is entered, will prompt user + contionue looping
                }

            }
        }
        static void userControls(BankAccount acc)
        {
            Console.WriteLine(" 1. Deposit 2.Withdraw 3.Exit");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter the amount you wish to deposit: ");
                    int amount = Convert.ToInt32((Console.ReadLine()));
                    acc.withdraw();
                    break;
            }
        }
        class BankAccount
        {
            public string email;
            public string password;
            public int balance;

            public BankAccount(string email, string password, int balance)//also constructor, will run everytime input is BankAccount
            {
                this.email = email;
                this.password = password;
                this.balance = balance;
            }

            public int deposit(int amount)//method
            {
                Console.WriteLine($"Your current balance is {balance}, how much would you like to deposit?: ");
                balance += amount;

                return balance;
            }

            public int withdraw(int amount)//method
            {
                if (balance - amount >= 0)
                {
                    balance -= amount;
                    Console.WriteLine("Withdrawal Successful");
                    return balance;
                }

                Console.WriteLine("Withdrawal unsuccessful, balance must remain positive");
                return balance;
            }
        }

        class StudentAccount : BankAccount // inheriting from bankaccount,
        {

            public int overdraftLimit;

            public StudentAccount(string email, string password, int balance, int overdraftLimit) : base(email, password, balance)//constructor, will run each time StudentAccount is input, base is there to inherit from bank account to stop reinputting code repeatedly
            {
                this.overdraftLimit = overdraftLimit;
            }

            public int withdraw(int amount)
            {
                if (balance - amount >= overdraftLimit)
                {
                    balance -= amount;
                    Console.WriteLine("Withdrawal successful");
                    return balance;
                }

                Console.WriteLine("Withdrawal unsuccessful, balance cannot excede overdraft limit");
                return balance;
            }
        }
    }

}
    
