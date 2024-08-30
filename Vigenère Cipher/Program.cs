using System;

namespace Vigenère_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueRunning = true;
            while (continueRunning)
            {
                try
                {
                    Console.WriteLine("-----------------Vigenère cipher-----------------");
                    Console.Write("Welcome to vigenère cipher encryption/decryption tool\n Choose (1) for encryption / (2) for decryption \n choose :");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter the plaintext:");
                            string plaintext = Console.ReadLine();
                            Console.WriteLine("Enter the keyword:");
                            string keyword = Console.ReadLine();
                            string encrypted = VigenereCipher.Encrypt(plaintext, keyword);
                            Console.WriteLine($"Encrypted text: {encrypted}");
                            break;
                        case 2:
                            Console.WriteLine("Enter the plaintext:");
                            string ciphertext = Console.ReadLine();
                            Console.WriteLine("Enter the keyword:");
                            string decrykeyword = Console.ReadLine();
                            string decrypted = VigenereCipher.Decrypt(ciphertext, decrykeyword);
                            Console.WriteLine($"Decrypted text: {decrypted}");
                            break;
                            


                    }
                    Console.Write("Do you want to perform another operation? (yes/no): ");
                    string continueChoice = Console.ReadLine().Trim().ToLower();
                    if (continueChoice != "yes")
                    {
                        continueRunning = false; // Exit the loop if the user does not want to continue
                    }
                }
                catch (FormatException ex)
                {
                    // Handle cases where the input is not a valid number
                    Console.WriteLine("Invalid input format. Please enter a valid number. " + ex);
                }
                catch (Exception ex)
                {
                    // Handle any other exceptions
                    Console.WriteLine("An unexpected error occurred: " + ex.Message);
                }

            }
           

        }
    }

}
