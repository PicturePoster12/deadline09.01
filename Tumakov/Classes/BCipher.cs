using System;
using System.Text;
namespace Tumakov
{
    internal class BCipher : ICipher
    {
        public string Encode(string input)
        {
            return Transform(input);
        }
        public string Decode(string input)
        {
            return Transform(input);
        }
        private string Transform(string input)
        {
            var result = new StringBuilder();
            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    char baseChar = char.IsUpper(c) ? 'А' : 'а';
                    result.Append((char)(baseChar + 31 - (c - baseChar)));
                }
                else
                {
                    result.Append(c);
                }
            }
            return result.ToString();
        }
    }
}