using System;
using System.Text;
using System.Collections.Generic;

namespace PasswordGenerator
{
    static class PasswordFormation
    {
        private static readonly Random rnd = new Random();
        private static string passwordResult;

        public static string GetPass(List <char> Symbols, int passwordLength)
        {
            passwordResult = string.Empty;

            for (int counter = 0; counter < passwordLength; counter++)
            {
                passwordResult+=(Symbols[rnd.Next(Symbols.Count)]);
            }

            return passwordResult;
        }
    }
}