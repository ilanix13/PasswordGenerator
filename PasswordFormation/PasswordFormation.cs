using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace PasswordGenerator
{
    static class PasswordFormation
    {
        private static readonly Random rnd = new Random(DateTime.UtcNow.Millisecond);
        public static int passwordLength;
        public static List<char> Symbols = new List<char>();

        public static char[] Lower = Enumerable.Range('a', 'z' - 'a' + 1).Select(c => (char)c).ToArray();
        public static char[] Upper = Enumerable.Range('A', 'Z' - 'A' + 1).Select(c => (char)c).ToArray();
        public static char[] Digits = Enumerable.Range('0', '9' - '0' + 1).Select(c => (char)c).ToArray();
        public static char[] SpecSymb = Enumerable.Range('!', '/' - '!' + 1).Select(c => (char)c).ToArray();
        public static string GetPass(List <char> Symbols, int passwordLength)
        {
            StringBuilder passwordResult = new StringBuilder();

            for (int counter = 0; counter < passwordLength; counter++)
            {
                passwordResult.Append(Symbols[rnd.Next(Symbols.Count)]);
            }

            return passwordResult.ToString();
        }
    }
}