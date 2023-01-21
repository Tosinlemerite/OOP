using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP
{
    public class Customer
    {
        public string Code;
        public string FirstName;
        public string LastName;
        public string MiddleName;
        public string Nin;
        public string Bvn;
        public string Address;
        public string StateOfOrigin;
        public string Country = "Nigeria";
        public string CustomerType;
        public string Dob;
        public string PhoneNumber;
        public string Email;
        public string Gender;
        public string NokName;
        public string NokAddress;
        public string NokPhone;
        public string NokEmail;
        public string NokGender;
        public string NokRelationshipType;

        //Customer Methods
        public Customer CreateCustomer()
        {
            Customer customer = new Customer();
            Console.WriteLine("Create Customers");
            Console.WriteLine();
            Console.WriteLine("Input Custormer Details");
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


            return customer;
        }
        public Customer UpdateCustomer()
        {
            return null;
        }
        public Customer DeleteCustomer()
        {
            return null;
        }
        public Customer[] ListOfCustomers()
        {
            return null;
        }
        public Customer[] FindCustomer()
        {
            return null;
        }
        public Customer FindCustomerById()
        {
            return null;
        }
        public Customer FindCustomerByCode()
        {
            return null;
        }
        public static bool VerifyNIN()
        {
            return true;
        }
        public static bool VerifyBVN()
        {
            return true;
        }



    }
}