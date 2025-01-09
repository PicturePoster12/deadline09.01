using System;
namespace Tumakov
{
    interface ICipher
    {
        string Encode(string input);
        string Decode(string input);
    }
}
