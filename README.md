# Vigenère Cipher Tool

## Overview
This project implements a basic Vigenère Cipher encryption and decryption tool in C#. The Vigenère Cipher is a method of encrypting alphabetic text using a series of different Caesar ciphers based on the letters of a keyword. This implementation provides functionalities to both encrypt and decrypt text using the Vigenère Cipher algorithm.

## Features
1. **Encryption**: Convert plaintext into ciphertext using a keyword.
2. **Decryption**: Convert ciphertext back into plaintext using the same keyword.
   
## Future features
**Cracking (solving)** : crack(solve) vigenere cipher without keyword
## Files
1. **Program.cs**: Contains the implementation of the Vigenère Cipher algorithm including encryption and decryption methods.
1. **VigenereCipher.cs**: Defines the VigenereCipher class with methods for encrypting and decrypting text.

## How to Use

1. **Clone the Repository**:

```bash
git clone https://github.com/DZ-T/Vigenere-Cipher.git
cd Vigenere-Cipher
```
2. **Build the Project**: Open the solution in Visual Studio or use the .NET CLI to build the project:

```bash
dotnet build
```
3. **Run the Application**: Run the application using Visual Studio or the .NET CLI:

```bash
dotnet run
```
3. **Follow the Prompts**:

- Choose (1) for encryption or (2) for decryption.
- Enter the plaintext or ciphertext and the keyword.
- View the result and choose to perform another operation or exit.

## Contributing
Feel free to open issues or submit pull requests for improvements or bug fixes.

## License
This project is licensed under the MIT License. See the [LICENSE] (LICENCE) file for details.



