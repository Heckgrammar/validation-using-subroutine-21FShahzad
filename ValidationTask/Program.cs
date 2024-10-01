using static System.Net.Mime.MediaTypeNames;

namespace ValidationTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName, username, password, emailAddress;
            int age;

            // get the user inputs until all are valid.
            // The username should only be output once
            Console.Write("Enter first name: ");
            firstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            lastName = Console.ReadLine();
            Console.Write("Enter age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Password: ");
            password = Console.ReadLine();
            Console.Write("Enter email address: ");
            emailAddress = Console.ReadLine();


           

            //  Test your program with a range of tests to show all validation works
            // Show your evidence in the Readme

        }
        static bool ValidName(string name)
        {
            if (name.Length >= 2 && name.All(char.IsLetter) == true )
            {
                return true;
            }
            else
            { 
            return false;
            }
            
            
            // name must be at least two characters and contain only letters

            
        }

        static bool validAge(int age)
        {
            //age must be between 11 and 18 inclusive
            if  (age >= 18 && age >= 11)
            {
                return true;
            }
            else 
            {
           
                return false;

            }
        }

   
        static bool ValidPassword(string password)
        {

            // Check password is at least 8 characters in length
            // Check password contains a mix of lower case, upper case and non letter characters
            // QWErty%^& = valid
            // QWERTYUi = not valid
            // ab£$%^&* = not valid
            // QWERTYu! = valid
            return password.Length >= 8 &&
              password.Any(char.IsLower) &&
              password.Any(char.IsUpper) &&
              password.Any(ch => !char.IsLetterOrDigit(ch));



            // Check password contains no runs of more than 2 consecutive or repeating letters or numbers
            // AAbbdd!2 = valid (only 2 consecutive letters A and B and only 2 repeating of each)
            // abC461*+ = not valid (abC are 3 consecutive letters)
            // 987poiq! = not valid (987 are consecutive)



        }
        static bool validEmail(string email)
        {
            if (email == "")
            {
                return false;
            }

            if (email.IndexOf('@') != email.LastIndexOf('@'))
            {
                return false;
            }

            int atIndex = email.IndexOf('@');
            int dotIndex = email.IndexOf('.', atIndex);

            if (atIndex < 2)
            {
                return false;
            }

            if (dotIndex <= atIndex + 1 || dotIndex >= email.Length - 2)
            {
                return false;
            }

            return true;

        }

        // a valid email address
        // has at least 2 characters followed by an @ symbol
        // has at least 2 characters followed by a .
        // has at least 2 characters after the .
        // contains only one @ and any number of .
        // does not contain any other non letter or number characters

    }
        static string createUserName(string firstName, string lastName, int age)
        {
        // username is made up from:
        // first two characters of first name
        // last two characters of last name
        // age
        //e.g. Bob Smith aged 34 would have the username Both34

        return firstName.Substring(0, 2) + lastName.Substring(lastName.Length - 2) + age;

    }

    }


