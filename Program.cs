using OOP;

int subOption;
int option;
string ans = string.Empty;

do
{

    Console.Clear();
    Console.WriteLine("******************************************");
    Console.WriteLine("Welcome To MeriteFi Core Banking Platform");
    Console.WriteLine("******************************************");
    Console.WriteLine();
    Console.Beep();
    Console.WriteLine("Please Select an Option:");
    Console.WriteLine();

    Console.WriteLine("1. Manage Customers");
    Console.WriteLine("2. Manage Accounts");
    Console.WriteLine("3. Exit Application");
    Console.WriteLine();

    Console.Write("Option: ");
    option = Convert.ToInt32(Console.ReadLine());

    do
    {

        if (option == 1)
        {

            Console.Beep();
            Console.WriteLine();
            Console.WriteLine("Please select a Customer Management Option:");
            Console.WriteLine();

            Console.WriteLine("1.  Create Customers");
            Console.WriteLine("2.  Update Customers");
            Console.WriteLine("3.  Delete Customers");
            Console.WriteLine("4.  List Of Customers");
            Console.WriteLine("5.  Find Customer");
            Console.WriteLine("6.  Find Customer by ID");
            Console.WriteLine("7.  Find Customer By Code");
            Console.WriteLine("8.  Go Back To Previous Menu");

            Console.WriteLine();
            Console.Write("Option: ");
            subOption = Convert.ToInt32(Console.ReadLine());

            switch (subOption)
            {
                case 1:
                    Customer customer = new Customer();
                    break;

                case 2:

                    break;

                case 3:

                    break;

                case 4:

                    break;

                case 5:

                    break;

                case 6:

                    break;

                case 7:

                    break;
                case 8:

                    break;

            }


        }
        else if (option == 2)
        {

            Console.Beep();
            Console.WriteLine();
            Console.WriteLine("Please Select an Option:");
            Console.WriteLine();

            Console.WriteLine("1.  Create Accounts");
            Console.WriteLine("2.  Update Accounts");
            Console.WriteLine("3.  Delete Accounts");
            Console.WriteLine("4.  List Of Accounts");
            Console.WriteLine("5.  Find Account");
            Console.WriteLine("6.  Find Account by Number");
            Console.WriteLine("7.  Find Account By Code");
            Console.WriteLine("8.  Go Back To Previous Menu");

            Console.WriteLine();
            Console.Write("Option: ");
            subOption = Convert.ToInt32(Console.ReadLine());

            switch (subOption)
            {
                case 1:
                    Account account = new Account();
                    break;

                case 2:

                    break;

                case 3:

                    break;

                case 4:

                    break;

                case 5:

                    break;

                case 6:

                    break;

                case 7:

                    break;
                case 8:

                    break;

            }


        }
        else
        {
            ans = "yes";
        }

    }
    while ();


    Console.Beep();
    Console.Write("Do you want to continue: ");
    ans = Console.ReadLine();
}
while (ans.ToLower() == "yes" || ans.ToLower() == "y");

