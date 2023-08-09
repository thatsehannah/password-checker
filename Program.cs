using System;

namespace PasswordChecker
{
    class Program
    {
        static int passwordValidator(string password)
        {
            if (password == null)
            {
                return 0;
            }

            int score = 0;

            int minLength = 8;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string specialChars = "$%&*!@#_";

            if (password.Length >= minLength)
            {
                score++;
            }

            if (password.IndexOfAny(uppercase.ToCharArray()) != -1)
            {
                score++;
            }

            if (password.IndexOfAny(lowercase.ToCharArray()) != -1)
            {
                score++;
            }

            if (password.IndexOfAny(digits.ToCharArray()) != -1)
            {
                score++;
            }

            if (password.IndexOfAny(specialChars.ToCharArray()) != -1)
            {
                score++;
            }

            return score;
        }

        public static void Main(string[] args)
        {
            Console.Write("Enter your password: ");
            int score = passwordValidator(Console.ReadLine());

            switch (score)
            {
                case 4: case 5:
                    Console.WriteLine("Password is extremely strong");
                    break;
                case 3:
                    Console.WriteLine("Password is strong");
                    break;
                case 2:
                    Console.WriteLine("Password is medium");
                    break;
                case 1:
                    Console.WriteLine("Password is weak");
                    break;
                default:
                    Console.WriteLine("Password doesn't meet any of the standards");
                    break;
            }

        }
    }
}

