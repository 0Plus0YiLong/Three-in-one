using System;

namespace password
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Enter password here");
                string password;
                bool inputlength = false;
                password = Console.ReadLine();

                int userInputLength = password.Length;

                if(password.Length>=8)
                {
                    inputlength = true;
                }
                else
                {
                    Console.WriteLine("Password must be more than 8 digits");
                }

                char[] splitUserInput = password.ToCharArray();

                bool test = Password.checkUpper(splitUserInput, userInputLength);
                bool test1 = Password.checkLower(splitUserInput, userInputLength);
                bool test2 = Password.checkInteger(splitUserInput, userInputLength);
                //bool test3 = inputlength;
                if(Password.checkUpper(splitUserInput, userInputLength) == true && Password.checkInteger(splitUserInput, userInputLength) == true && Password.checkLower(splitUserInput, userInputLength) == true && inputlength == true)
                // if(inputlength == true && test == true && test1 == true && test2 == true);
                {
                    break;
                } 
            }
        }

        
    }

    public class Password
    {
        public static bool checkUpper(char[] getSplitUserInput, int getUserInputLength)
        {
            for(int h=0;h<getUserInputLength;h++)
            {
                if(Char.IsUpper(getSplitUserInput[h]))
                {
                    return true;
                }
            }
            Console.WriteLine("Password must contain at least one uppercase letter");
            return false;
        }

        public static bool checkLower(char[] getSplitUserInput, int getUserInputLength)
        {
            for(int h=0;h<getUserInputLength;h++)
            {
                if(Char.IsLower(getSplitUserInput[h]))
                {
                    return true;
                }
            }
            Console.WriteLine("Password must contain at least one lowercase letter");
            return false;
        }

        public static bool checkInteger(char[] getSplitUserInput, int getUserInputLength)
        {
            for(int h=0;h<getUserInputLength;h++)
            {
                if(Char.IsDigit(getSplitUserInput[h]))
                {
                    return true;
                }
            }
            Console.WriteLine("Passwor must contain at least one number");
            return false;
        }
    }
}
