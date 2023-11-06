using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4TPA
{
    internal class Program
    {





        static void Main(string[] args)
        {

            // wyjście 


            Console.WriteLine("podja jakąś liczbę: ");



            // wejście i konwersja liczby na stsowny typ

             
            int a = int.Parse(Console.ReadLine());


            // operacja arytmetyczna

            int pole = a * a;

            // wyście i konkatenacja tekstu z zmienną - znak +
            Console.WriteLine("pole wkadratu wynosi " +  pole);


            



            // pętla i instrukcja warunkowa na podstawie przedziału od 10 do 1000 z liczbami podzielnymi przez 2 i 3 lub 5
            for (int i = 10;i<=1000;i++)
            {
                if(i % 2 == 0 & i % 3 == 0 || i % 5 == 0)
                {
                    Console.WriteLine("podanle liczby to: " + i);
                }
            }



            // incijalizacja z wykorzystniame pętli i tablicy do sumowania elementów tablicy

            int sum = 0;

            int[] ints = { 5, 3, 12, 15, 33, 44, 55, 67, 89, 100 };

            for (int i = 0; i < ints.Length; i++)
            {
                sum += ints[i];
            }

            Console.WriteLine("suma elementów tablicy wynosi: " + sum);




















            //zamkniecie konsoli w momęcie klikniecia klawisza - warunek konieczny inaczej konsola zniknie


            Console.ReadKey();
        }
    }
}
