using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {


        static void Main(string[] args)
        {
            bool FalseTrue = true;
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n',
                                           'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            Console.WriteLine(alphabet);

            do
            {
                Console.Write("Please, write \"Encrypt\" or \"Decrypt\": ");
                //Vyber z moznosti ecrypt alebo decrypt
                string ChooseEncryptOrDecript = Console.ReadLine();

                if (ChooseEncryptOrDecript == "Decrypt")
                {
                    Console.Write("Please, write word to decrypt: ");
                    string EncryptedWord = Console.ReadLine();

                    DecriptingMessage(alphabet, EncryptedWord);
                    

                    break;
                }
                else if (ChooseEncryptOrDecript == "Encrypt")
                {
                    Console.Write("Please, write word to encrypt: ");
                    string UnecryptedWord = Console.ReadLine();
                    EncryptingMessage(alphabet, UnecryptedWord);
                    

                    break;
                }
                else
                {
                    Console.WriteLine("You did not chose from \"Encrypt\" or \"Decrypt\" options. Please, choose again.");

                }


            } while (FalseTrue == true);

        }


        static void DecriptingMessage(char[] alphabet, string EncryptedWord)
        {



            char[] EncryptedWordasArray = EncryptedWord.ToCharArray();

            for (int i = 0; i < EncryptedWordasArray.Length; i++)
            {
                int CharIndex = Array.IndexOf(alphabet, EncryptedWordasArray[i]);

                Console.Write(alphabet[(CharIndex - 3 + alphabet.Length) % alphabet.Length]);
            }

        }

        static void EncryptingMessage(char[] alphabet, string UnecryptedWord)
        {

            char[] EncryptedWordasArray = UnecryptedWord.ToCharArray();

            for (int i = 0; i < EncryptedWordasArray.Length; i++)
            {
                int CharIndex = Array.IndexOf(alphabet, EncryptedWordasArray[i]);

                Console.Write(alphabet[(CharIndex + 3) % alphabet.Length]);
            }



        }


    }
}
