using System;
using System.Threading.Tasks;

namespace data.type
{
    internal class Program
    {
        static void Main(string[] args)
        {


            ////task1


            //// sozlerin ne zaman duracaqi serti verilmediyi ucun ozum elave eledim . 2 defe enter))



            //Console.WriteLine("enter words");
            //string[] word = new string[15];
            //Arrdaxilet(word);
            //Printwordnum(word);



            ////task2
            ///reqemlerin ne zaman duracaqini bilmediyim ucun belli say verdim . burda int tipi oldugu ucun 2 enter alinmadi((

            //Console.WriteLine("enter numbers");
            //int[] number = new int[5];
            //Enternumber(number);
            //Printcem(number);

           




        }
        static void Arrdaxilet(string[] word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                word[i] = Console.ReadLine();
                if (word[i] == "" + "")
                    break;
            }
        }
        static void Printwordnum(string[] word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                Console.Write(word[i] + " ");
                if (word[i] == "")
                {
                    Console.WriteLine(i + "soz");
                    break;
                }
            }
        }
        static void Enternumber(int[] number)
        {
            for(int i = 0; i < number.Length; i++)
            {
                number[i]=int.Parse(Console.ReadLine());
                if (number[i] == 0)
                    break;
            }
        }
        static void Printcem(int[] number)
        {
            int a = 0;
            for(int i = 0; i < number.Length; i++)
            {
                a += number[i];

                if (i==number.Length-1)
                {
                    Console.WriteLine(a);
                    break;
                }
            }
        }





    }
}
