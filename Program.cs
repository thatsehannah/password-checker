using System;

namespace PasswordChecker
{
    class Program
    {
        static int passwordValidator(string password)
        {
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

        }
    }
}

