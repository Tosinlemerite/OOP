using OOP;

int subOption;
int option;
string ans = string.Empty;
Customer[] custData = new Customer[100];
Customer custObject = new Customer();

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

    if (option == 1)
    {
        do
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

                    Customer customer = custObject.CreateCustomer();
                    for (int i = 0; i < custData.Length; i++)
                    {
                        if (custData[i] == null)
                        {
                            customer.Code = Convert.ToString(i + 1).PadLeft(3, '0');
                            custData[i] = customer;
                            break;
                        }

                    }

                    break;

                case 2:

                    Console.WriteLine("Update Customers");
                    Console.Write("Enter Code: ");
                    string code = Console.ReadLine();
                    for (int i = 0; i < custData.Length; i++)
                    {
                        if (custData[i].Code == code)
                        {

                            Console.Write("First Name: ");
                            custData[i].FirstName = Console.ReadLine();
                            Console.WriteLine();

                            Console.Write("Last Name: ");
                            custData[i].LastName = Console.ReadLine();
                            Console.WriteLine();

                            Console.Write("Middle Name: ");
                            custData[i].MiddleName = Console.ReadLine();
                            Console.WriteLine();

                            Console.Write("Gender: Male(M) or Female(F)");
                            string sex = Console.ReadLine();
                            if (sex.ToLower() == "male" || sex.ToLower() == "m")
                            {
                                custData[i].Gender = "Male";
                            }
                            else if (sex.ToLower() == "female" || sex.ToLower() == "f")
                            {
                                custData[i].Gender = "Female";
                            }
                            Console.WriteLine();

                            Console.Write("National Identification Number(NIN): ");
                            custData[i].Nin = Console.ReadLine();
                            Console.WriteLine();

                            Console.Write("Bank Verification Number(BVN): ");
                            custData[i].Bvn = Console.ReadLine();
                            Console.WriteLine();

                            Console.Write("Address: ");
                            custData[i].Address = Console.ReadLine();
                            Console.WriteLine();

                            Console.Write("Country: ");
                            custData[i].Country = Console.ReadLine();
                            Console.WriteLine();

                            Console.Write("State of Origin: ");
                            custData[i].StateOfOrigin = Console.ReadLine();
                            Console.WriteLine();

                            Console.Write("Date of Birth: ");
                            custData[i].Dob = Console.ReadLine();
                            Console.WriteLine();

                            Console.Write("Phone Number: ");
                            custData[i].PhoneNumber = Console.ReadLine();
                            Console.WriteLine();

                            Console.Write("E-mail Address: ");
                            custData[i].Email = Console.ReadLine();
                            Console.WriteLine();

                            Console.Write("Account Type: Current(C) or Savings(S)");
                            string acctType = Console.ReadLine();
                            if (acctType.ToLower() == "Current" || acctType.ToLower() == "c")
                            {
                                custData[i].CustomerType = "Current";
                            }
                            else if (acctType.ToLower() == "Savings" || acctType.ToLower() == "S")
                            {
                                custData[i].CustomerType = "Savings";
                            }
                            Console.WriteLine();

                            Console.Write("Next of kin Name: ");
                            custData[i].NokName = Console.ReadLine();
                            Console.WriteLine();

                            Console.Write("Next of kin Address: ");
                            custData[i].NokAddress = Console.ReadLine();
                            Console.WriteLine();
                            Console.Write("Next of Kin Phone Number: ");
                            custData[i].NokPhone = Console.ReadLine();
                            Console.WriteLine();

                            Console.Write("Next of Kin E-mail Address: ");
                            custData[i].NokEmail = Console.ReadLine();
                            Console.WriteLine();

                            Console.Write("Next of KinRelationship: ");
                            custData[i].NokRelationshipType = Console.ReadLine();
                            Console.WriteLine();

                            break;
                        }
                    }

                    Console.ReadLine();

                    break;

                case 3:

                    Console.WriteLine("Delete Customers");
                    Console.Write("Enter Code: ");
                    string codes = Console.ReadLine();
                    for (int i = 0; i < custData.Length; i++)
                    {
                        if (custData[i].Code == codes)
                        {
                            custData[i] = null;
                        }
                    }

                    Console.ReadLine();

                    break;

                case 4:

                    Console.WriteLine("List Of Customers");
                    for (int i = 0; i < custData.Length; i++)
                    {
                        if (custData[i] != null)
                        {
                            Console.WriteLine((i + 1) + ". " + custData[i].FirstName + (" ") + custData[i].LastName);
                        }

                    }
                    Console.ReadLine();

                    break;

                case 5:

                    Console.WriteLine("Find Customer");
                    Console.Write("Enter Customer Details: ");
                    string searchParamitter = Console.ReadLine();
                    for (int i = 0; i < custData.Length; i++)
                    {
                        if (custData[i].Code.Substring(0, 3) == searchParamitter.Substring(0, 3) || custData[i].FirstName.Substring(0, 2) == searchParamitter.Substring(0, 2) || custData[i].LastName.Substring(0, 2) == searchParamitter.Substring(0, 2))
                        {
                            Console.WriteLine(custData[i].Code);
                            Console.WriteLine(custData[i].FirstName);
                            Console.WriteLine(custData[i].LastName);
                            Console.WriteLine(custData[i].MiddleName);
                            Console.WriteLine(custData[i].Nin);
                            Console.WriteLine(custData[i].Bvn);
                            Console.WriteLine(custData[i].Address);
                            Console.WriteLine(custData[i].StateOfOrigin);
                            Console.WriteLine(custData[i].Country);
                            Console.WriteLine(custData[i].CustomerType);
                            Console.WriteLine(custData[i].Dob);
                            Console.WriteLine(custData[i].PhoneNumber);
                            Console.WriteLine(custData[i].Email);
                            Console.WriteLine(custData[i].Gender);
                            Console.WriteLine(custData[i].NokName);
                            Console.WriteLine(custData[i].NokAddress);
                            Console.WriteLine(custData[i].NokPhone);
                            Console.WriteLine(custData[i].NokEmail);
                            Console.WriteLine(custData[i].NokGender);
                            Console.WriteLine(custData[i].NokRelationshipType);
                            break;
                        }
                    }
                    Console.ReadLine();
                    break;

                case 6:

                    Console.WriteLine("Find Customer by ID");
                    Console.ReadLine();

                    break;

                case 7:

                    Console.WriteLine("Find Customer By Code");
                    Console.Write("Enter Code: ");
                    string sCode = Console.ReadLine();
                    for (int i = 0; i < custData.Length; i++)
                    {
                        if (custData[i].Code == sCode)
                        {
                            Console.WriteLine(custData[i].Code);
                            Console.WriteLine(custData[i].FirstName);
                            Console.WriteLine(custData[i].LastName);
                            Console.WriteLine(custData[i].MiddleName);
                            Console.WriteLine(custData[i].Nin);
                            Console.WriteLine(custData[i].Bvn);
                            Console.WriteLine(custData[i].Address);
                            Console.WriteLine(custData[i].StateOfOrigin);
                            Console.WriteLine(custData[i].Country);
                            Console.WriteLine(custData[i].CustomerType);
                            Console.WriteLine(custData[i].Dob);
                            Console.WriteLine(custData[i].PhoneNumber);
                            Console.WriteLine(custData[i].Email);
                            Console.WriteLine(custData[i].Gender);
                            Console.WriteLine(custData[i].NokName);
                            Console.WriteLine(custData[i].NokAddress);
                            Console.WriteLine(custData[i].NokPhone);
                            Console.WriteLine(custData[i].NokEmail);
                            Console.WriteLine(custData[i].NokGender);
                            Console.WriteLine(custData[i].NokRelationshipType);
                            break;
                        }
                    }

                    Console.ReadLine();
                    break;
                case 8:
                    subOption = 8;

                    break;

            }

        }
        while (subOption != 8);


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


    Console.Beep();
    Console.Write("Do you want to continue: ");
    ans = Console.ReadLine();
}
while (ans.ToLower() == "yes" || ans.ToLower() == "y");




