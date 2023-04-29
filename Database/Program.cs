namespace Database
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee=new Employee("Ellen", "Admin", 23000);
            Console.WriteLine("PLease enter the employee's user ID:  ");
           
        }

        class Employee
        {
            private string name;
            private string position;
            private int age;
            private int annualsalary;
            private string email;
            private int userID;

            public Employee(string name, string position, int annualsalary) {
                this.name = name;
                this.position = position;
                this.annualsalary = annualsalary;
            }
                

        }

        public void setName(string newName)
        {
            name=newName;
        }

        public string getName()
        {
            return name;
        }
        public string getPosition(string position)
        {
            return position;
        }




    }
}