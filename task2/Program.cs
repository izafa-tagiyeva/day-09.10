using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.İstənilən verilən cümlədə sözlərin baş hərflərini ekrana yazdıran method yazın
            //məs .("Hello World --> "H" "W" )

            Console.WriteLine("daxil edin:");
            string given_sentence = Console.ReadLine();
            print_first_letter(given_sentence);
            string first_letters = print_first_letter(given_sentence);
            Console.WriteLine("First letters: " + first_letters);
        }
        static string print_first_letter(string sentence)
        {
            string new_word = "";
            bool new_word_start = true;

            foreach (char letter in sentence)
            {
                
                if ((letter >= 'A' && letter <= 'Z') || (letter >= 'a' && letter <= 'z'))
                {
                    if (new_word_start)
                    {
                        new_word =new_word + " \" " + letter + " \" ";
                        new_word_start = false;
                    }
                }
                else
                {
                    new_word_start = true;
                }
            }

            return new_word;
        }
    }
}
