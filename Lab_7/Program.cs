using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables to store values
            string name;
            string email;
            string phone;
            string date;
            bool validName;
            bool validEmail;
            bool validPhone;
            bool validDate;
            
            Console.WriteLine("Please enter a valid Name: ");
            name = Console.ReadLine();


            //store true/false here so it doesn't get lost in space
            //call your function/equation
            validName = ValidateRegexString.ValidName(name);

            //check if it's true or false

            if (validName)
            {
                Console.WriteLine(" Name is Valid! ");
            }
            else
            {
                Console.WriteLine("The Name entered is invalid! ");
            }
            
            //email
            Console.WriteLine("Please enter a valid email: ");
            email = Console.ReadLine();
            validEmail = ValidateRegexString.ValidEmail(email);

            if (validEmail)
            {
                Console.WriteLine(" email is Valid! ");
            }
            else
            {
                Console.WriteLine("The email entered is invalid! ");
            }

            //phone
            Console.WriteLine("Please enter a valid phone number: ");
            phone = Console.ReadLine();
            validPhone = ValidateRegexString.ValidPhone(phone);

            if (validPhone)
            {
                Console.WriteLine(" the phone number is Valid! ");
            }
            else
            {
                Console.WriteLine("The phone number entered is invalid! ");
            }

            //date
            Console.WriteLine("Please enter a valid date: ");
            date = Console.ReadLine();
            validDate = ValidateRegexString.ValidPhone(date);

            if (validDate)
            {
                Console.WriteLine(" date is Valid! ");
            }
            else
            {
                Console.WriteLine("The date entered is invalid! ");
            }

        }
    }
}
