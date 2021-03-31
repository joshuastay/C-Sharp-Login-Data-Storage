using System;
using System.Collections.Generic;

namespace Login_Data_Storage
{
    [Serializable]
    public class Encoder
    {
        /// <summary>
        /// Encoder class is used to hide a string, replacing each character in a string
        /// with a key of 128 to 256 characters in length. It is able to decrypt the string as well.
        /// </summary>
        private char[] characterSet = new char[256];
        private int index;
        private string result;
        private Dictionary<char, string> cipher = new Dictionary<char, string>();
        private Dictionary<string, char> reversecipher = new Dictionary<string, char>();
        private char serparator;
        private string encrypted;
        private int keyLength;
        [NonSerialized]
        private string decrypted;
        [NonSerialized]
        private Random generator = new Random();

        // Encoder constructor
        // initializes the Ecoder object storing 255 characters into an array
        // also creates dictionary to reference each character to a new value
        public Encoder()
        {
            for (int i = 0; i <= 255; i++)
            {
                char c = Convert.ToChar(i);
                characterSet[i] = c;
            }
            serparator = characterSet[generator.Next(255)];
            foreach (char i in characterSet)
            {
                if (!char.IsControl(i))
                {
                    var tempkey = this.keyGenerator();
                    cipher.Add(i, tempkey);
                    reversecipher.Add(tempkey, i);
                }
            }
        }
        // keyGenerator method returns a string to act as a key
        public string keyGenerator()
        {
            // initializes result variable to produce a unique result
            result = "";
            // sets a length to produce encyrption key
            keyLength = generator.Next(128, 255);
            // continues adding random characters unitl keylength is met
            while (result.Length != keyLength)
            {
                index = generator.Next(255);
                // ensures the separator is not used
                if (characterSet[index] != serparator)
                {
                    result += Convert.ToString(characterSet[index]);
                    continue;
                }
                else
                {
                    continue;
                }
            }
            return result;
        }
        // Takes a string as input and returns the encrypted string 
        public string encryptString(string textToHide)
        {
            encrypted = "";
            foreach (char item in textToHide)
            {
                encrypted += cipher[item] + serparator;
            }
            return encrypted;
        }
        // Takes an encrypted string as input and returns decrypted string
        public string decryptString(string textToReveal)
        {
            decrypted = "";

            string[] tempArray = textToReveal.Split(serparator);
            foreach (string n in tempArray)
            {
                try
                {
                    decrypted += reversecipher[n];
                }
                catch
                {
                    break;
                }
            }
            return decrypted;
        }
    }



}
