using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vigenère_Cipher
{
    class VigenereCipher
    {
        private static char ShiftChar(char c, int shift)
        {
            //Ensure the character is a letter
            if (!char.IsLetter(c))
            {
                return c;
            }
            char d = 'A';
            int offset = (c - d + shift) % 26;
            if (offset < 0) offset += 26; // To handle negative shifts

            return (char)(d + offset); 
        }
        public static string Encrypt(string plaintext, string keyword)
        {

            keyword = keyword.ToUpper(); //convert keyword to uppercase

            plaintext = plaintext.ToUpper();    //convert plaintext to uppercase
            StringBuilder ciphertext = new StringBuilder();
            int keywordindex = 0;
            foreach (char c in plaintext)
            {
                if (char.IsLetter(c))
                {
                    int shift = keyword[keywordindex % keyword.Length] - 'A';
                    ciphertext.Append(ShiftChar(c, shift)); // Positive shift for encryption
                    keywordindex++;
                }
                else
                {
                    ciphertext.Append(c); // Non-alphabetic characters are added unchanged
                }
            }
            return ciphertext.ToString();

        }
        public static string Decrypt(string ciphertext, string keyword)
        {
            keyword = keyword.ToUpper();
            ciphertext = ciphertext.ToUpper();
            StringBuilder plaintext = new StringBuilder();

            int keywordIndex = 0;
            foreach (char c in ciphertext)
            {
                if (char.IsLetter(c))
                {

                    int shift = keyword[keywordIndex % keyword.Length] - 'A';
                    plaintext.Append(ShiftChar(c, -shift)); // Negative shift for decryption
                    keywordIndex++;
                }
                else
                {
                    plaintext.Append(c); // Non-alphabetic characters are added unchanged
                }
            }
            return plaintext.ToString();
        }
        
    }
}
