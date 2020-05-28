using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Password
{

    

    class PasswordGenerator
    {
        private const string CapitalLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string SmallLeters = "abcdefghijklmnopqrstuvwxyz";
        private const string Digits = "0123456789";
        private const string SpecialChars = "~!@#$%^&*()_+=`{}[]\\|':;.,/?<>";
        private const string AllChars = CapitalLetters + SmallLeters + Digits + SpecialChars;

        private static Random rnd = new Random();

        private static char GenerateChar(string availableChars)
        {
            int randomIndex = rnd.Next(availableChars.Length);
            char randomChar = availableChars[randomIndex];
            return randomChar;
        }

        private static void InsertAtRandomPosition(StringBuilder password, char character)
        {
            int randomPosition = rnd.Next(password.Length + 1);
            password.Insert(randomPosition, character);
        }

        public static void Main(string[] args)
        {
            StringBuilder password = new StringBuilder();

            for (int i = 1; i <= 2; i++)
            {
                char capitalLetter = GenerateChar(CapitalLetters);
                InsertAtRandomPosition(password, capitalLetter);
            }
            for (int i = 1; i <= 2; i++)
            {
                char smallLeter = GenerateChar(SmallLeters);
                InsertAtRandomPosition(password, smallLeter);
            }
            char digit = GenerateChar(Digits);
            InsertAtRandomPosition(password, digit);
            for(int i = 1; i <= 3; i++)
            {
                char specialChar = GenerateChar(SpecialChars);
                InsertAtRandomPosition(password, specialChar);
            }
            int count = rnd.Next(8);
            for(int i = 1; i <= count; i++)
            {
                char specialChar = GenerateChar(AllChars);
                InsertAtRandomPosition(password, specialChar);
            }
            Console.WriteLine(password);
            Console.ReadLine();

        }
    }
}