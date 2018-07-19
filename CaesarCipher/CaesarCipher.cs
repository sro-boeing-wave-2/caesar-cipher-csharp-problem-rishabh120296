using System;
using System.Linq;

namespace CaesarCipher
{
    public static class RotationalCipher
    {
        public static string Rotate(string text, int shiftKey)
        {
            string outputString = "";
            foreach (char letter in text)
            {
                int unicode = letter;
                if (unicode >= 97 && unicode <= 122)
                {
                    unicode = unicode + shiftKey;
                    if (unicode > 122)
                    {
                        unicode = unicode - 26;
                    }
                }
                if (unicode >= 65 && unicode <= 90)
                {
                    unicode = unicode + shiftKey;
                    if (unicode > 90)
                    {
                        unicode = unicode - 26;
                    }
                }


                outputString += (char)unicode;
            }
            return outputString;
        }
    }
}
