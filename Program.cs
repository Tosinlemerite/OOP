using OOP;

int subOption;
int option;
string ans = string.Empty;
Customer[] customers = new Customer[100];

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

          Customer customer = new Customer();
          Console.WriteLine("Create Customers");
          Console.WriteLine();
          Console.WriteLine("Input Customer Details");
          Console.WriteLine();

          Console.Write("First Name: ");
          customer.FirstName = Console.ReadLine();
          Console.WriteLine();

          Console.Write("Last Name: ");
          customer.LastName = Console.ReadLine();
          Console.WriteLine();

          Console.Write("Middle Name: ");
          customer.MiddleName = Console.ReadLine();
          Console.WriteLine();

          Console.Write("Gender: Male(M) or Female(F)");
          string gender = Console.ReadLine();
          if (gender.ToLower() == "male" || gender.ToLower() == "m")
          {
            customer.Gender = "Male";
          }
          else if (gender.ToLower() == "female" || gender.ToLower() == "f")
          {
            customer.Gender = "Female";
          }
          Console.WriteLine();

          Console.Write("National Identification Number(NIN): ");
          customer.Nin = Console.ReadLine();
          Console.WriteLine();

          Console.Write("Bank Verification Number(BVN): ");
          customer.Bvn = Console.ReadLine();
          Console.WriteLine();

          Console.Write("Address: ");
          customer.Address = Console.ReadLine();
          Console.WriteLine();

          Console.Write("Country: ");
          customer.Country = Console.ReadLine();
          Console.WriteLine();

          Console.Write("State of Origin: ");
          customer.StateOfOrigin = Console.ReadLine();
          Console.WriteLine();

          Console.Write("Date of Birth: ");
          customer.Dob = Console.ReadLine();
          Console.WriteLine();

          Console.Write("Phone Number: ");
          customer.PhoneNumber = Console.ReadLine();
          Console.WriteLine();

          Console.Write("E-mail Address: ");
          customer.Email = Console.ReadLine();
          Console.WriteLine();

          Console.Write("Account Type: Current(C) or Savings(S)");
          string accountType = Console.ReadLine();
          if (accountType.ToLower() == "Current" || accountType.ToLower() == "c")
          {
            customer.CustomerType = "Current";
          }
          else if (accountType.ToLower() == "Savings" || accountType.ToLower() == "S")
          {
            customer.CustomerType = "Savings";
          }
          Console.WriteLine();

          Console.Write("Next of kin Name: ");
          customer.NokName = Console.ReadLine();
          Console.WriteLine();

          Console.Write("Next of kin Address: ");
          customer.NokAddress = Console.ReadLine();
          Console.WriteLine();
          Console.Write("Next of Kin Phone Number: ");
          customer.NokPhone = Console.ReadLine();
          Console.WriteLine();

          Console.Write("Next of Kin E-mail Address: ");
          customer.NokEmail = Console.ReadLine();
          Console.WriteLine();

          Console.Write("Next of KinRelationship: ");
          customer.NokRelationshipType = Console.ReadLine();
          Console.WriteLine();

          for (int i = 0; i < customers.Length; i++)
          {
            if (customers[i] == null)
            {
              customer.Code = Convert.ToString(i + 1).PadLeft(3, '0');
              customers[i] = customer;
              break;
            }

          }

          break;

        case 2:

          Console.WriteLine("Update Customers");
          Console.Write("Enter Code: ");
          string code = Console.ReadLine();
          for (int i = 0; i < customers.Length; i++)
          {
            if (customers[i].Code == code)
            {

              Console.Write("First Name: ");
              customers[i].FirstName = Console.ReadLine();
              Console.WriteLine();

              Console.Write("Last Name: ");
              customers[i].LastName = Console.ReadLine();
              Console.WriteLine();

              Console.Write("Middle Name: ");
              customers[i].MiddleName = Console.ReadLine();
              Console.WriteLine();

              Console.Write("Gender: Male(M) or Female(F)");
              string sex = Console.ReadLine();
              if (sex.ToLower() == "male" || sex.ToLower() == "m")
              {
                customers[i].Gender = "Male";
              }
              else if (sex.ToLower() == "female" || sex.ToLower() == "f")
              {
                customers[i].Gender = "Female";
              }
              Console.WriteLine();

              Console.Write("National Identification Number(NIN): ");
              customers[i].Nin = Console.ReadLine();
              Console.WriteLine();

              Console.Write("Bank Verification Number(BVN): ");
              customers[i].Bvn = Console.ReadLine();
              Console.WriteLine();

              Console.Write("Address: ");
              customers[i].Address = Console.ReadLine();
              Console.WriteLine();

              Console.Write("Country: ");
              customers[i].Country = Console.ReadLine();
              Console.WriteLine();

              Console.Write("State of Origin: ");
              customers[i].StateOfOrigin = Console.ReadLine();
              Console.WriteLine();

              Console.Write("Date of Birth: ");
              customers[i].Dob = Console.ReadLine();
              Console.WriteLine();

              Console.Write("Phone Number: ");
              customers[i].PhoneNumber = Console.ReadLine();
              Console.WriteLine();

              Console.Write("E-mail Address: ");
              customers[i].Email = Console.ReadLine();
              Console.WriteLine();

              Console.Write("Account Type: Current(C) or Savings(S)");
              string acctType = Console.ReadLine();
              if (acctType.ToLower() == "Current" || acctType.ToLower() == "c")
              {
                customers[i].CustomerType = "Current";
              }
              else if (acctType.ToLower() == "Savings" || acctType.ToLower() == "S")
              {
                customers[i].CustomerType = "Savings";
              }
              Console.WriteLine();

              Console.Write("Next of kin Name: ");
              customers[i].NokName = Console.ReadLine();
              Console.WriteLine();

              Console.Write("Next of kin Address: ");
              customers[i].NokAddress = Console.ReadLine();
              Console.WriteLine();
              Console.Write("Next of Kin Phone Number: ");
              customers[i].NokPhone = Console.ReadLine();
              Console.WriteLine();

              Console.Write("Next of Kin E-mail Address: ");
              customers[i].NokEmail = Console.ReadLine();
              Console.WriteLine();

              Console.Write("Next of KinRelationship: ");
              customers[i].NokRelationshipType = Console.ReadLine();
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
          for (int i = 0; i < customers.Length; i++)
          {
            if (customers[i].Code == codes)
            {
              customers[i] = null;
            }
          }

          Console.ReadLine();

          break;

        case 4:

          Console.WriteLine("List Of Customers");
          for (int i = 0; i < customers.Length; i++)
          {
            if (customers[i] != null)
            {
              Console.WriteLine((i + 1) + ". " + customers[i].FirstName + (" ") + customers[i].LastName);
            }

          }
          Console.ReadLine();

          break;

        case 5:

          Console.WriteLine("Find Customer");
          Console.Write("Enter Customer Details: ");
          string searchParamitter = Console.ReadLine();
          for (int i = 0; i < customers.Length; i++)
          {
            if (customers[i].Code.Substring(0, 3) == searchParamitter.Substring(0, 3) || customers[i].FirstName.Substring(0, 2) == searchParamitter.Substring(0, 2) || customers[i].LastName.Substring(0, 2) == searchParamitter.Substring(0, 2))
            {
              Console.WriteLine(customers[i].Code);
              Console.WriteLine(customers[i].FirstName);
              Console.WriteLine(customers[i].LastName);
              Console.WriteLine(customers[i].MiddleName);
              Console.WriteLine(customers[i].Nin);
              Console.WriteLine(customers[i].Bvn);
              Console.WriteLine(customers[i].Address);
              Console.WriteLine(customers[i].StateOfOrigin);
              Console.WriteLine(customers[i].Country);
              Console.WriteLine(customers[i].CustomerType);
              Console.WriteLine(customers[i].Dob);
              Console.WriteLine(customers[i].PhoneNumber);
              Console.WriteLine(customers[i].Email);
              Console.WriteLine(customers[i].Gender);
              Console.WriteLine(customers[i].NokName);
              Console.WriteLine(customers[i].NokAddress);
              Console.WriteLine(customers[i].NokPhone);
              Console.WriteLine(customers[i].NokEmail);
              Console.WriteLine(customers[i].NokGender);
              Console.WriteLine(customers[i].NokRelationshipType);
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
          for (int i = 0; i < customers.Length; i++)
          {
            if (customers[i].Code == sCode)
            {
              Console.WriteLine(customers[i].Code);
              Console.WriteLine(customers[i].FirstName);
              Console.WriteLine(customers[i].LastName);
              Console.WriteLine(customers[i].MiddleName);
              Console.WriteLine(customers[i].Nin);
              Console.WriteLine(customers[i].Bvn);
              Console.WriteLine(customers[i].Address);
              Console.WriteLine(customers[i].StateOfOrigin);
              Console.WriteLine(customers[i].Country);
              Console.WriteLine(customers[i].CustomerType);
              Console.WriteLine(customers[i].Dob);
              Console.WriteLine(customers[i].PhoneNumber);
              Console.WriteLine(customers[i].Email);
              Console.WriteLine(customers[i].Gender);
              Console.WriteLine(customers[i].NokName);
              Console.WriteLine(customers[i].NokAddress);
              Console.WriteLine(customers[i].NokPhone);
              Console.WriteLine(customers[i].NokEmail);
              Console.WriteLine(customers[i].NokGender);
              Console.WriteLine(customers[i].NokRelationshipType);
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



