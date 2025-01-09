using System;
using System.Text;
namespace Tumakov
{
    internal class ACipher : ICipher
    {
        public string Encode(string input)
        {
            var result = new StringBuilder();
            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    char baseChar = char.IsUpper(c) ? 'А' : 'а';
                    result.Append((char)(baseChar + (c - baseChar + 1) % 32));
                }
                else
                {
                    result.Append(c);
                }
            }
            return result.ToString();
        }
        public string Decode(string input)
        {
            var result = new StringBuilder();
            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    char baseChar = char.IsUpper(c) ? 'А' : 'а';
                    result.Append((char)(baseChar + (c - baseChar + 31) % 32));
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