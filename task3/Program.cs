using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //3.Parametr olaraq 1 string dəyər qəbul edən və həmin string dəyəri icində bosluqlar qalmayacaq hala gətirən metod.
            //Misal olaraq, name = " Yusif    Osmanov   " deyə bir variable-mız varsa onu yaratdigimiz metoda göndərdikdə
            //variable-daki dəyər "YusifOsmanov" olmalıdır.

            Console.WriteLine("daxil edin:");
            string given_sentence = Console.ReadLine();
            space_remover(given_sentence);
            string requested = space_remover(given_sentence);
            Console.WriteLine("Our sentence will be like that: " + requested);
        }


        static string space_remover(string sentence)
        {
            string new_word = "";
            

            foreach (char letter in sentence)
            {

                if ((letter >= 'A' && letter <= 'Z') || (letter >= 'a' && letter <= 'z'))
                {
                    new_word=new_word + letter;
                    
                }
                else
                {
                   
                    continue;
                }
            }

            return new_word;
        }


    }

    }

