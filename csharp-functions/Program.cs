using Microsoft.VisualBasic;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace csharp_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                // Snack 11
                // Dare la possibilità di inserire due parole.
                // Verificare tramite una funzione che le due parole abbiano la stessa lunghezza.
                // Se hanno la stessa lunghezza, stamparle entrambe, altrimenti stampare la più lunga delle due.

                //Console.WriteLine("Inserisci la prima parola:");
                //string word1 = Console.ReadLine();
                //Console.WriteLine("Inserisci la seconda parola:");
                //string word2 = Console.ReadLine();

                //void CheckWordsLenght(string w1, string w2)
                //{ 
                //    if (w1.Length == w2.Length)
                //    {
                //        Console.WriteLine($"{w1} e {w2} hanno la stessa lunghezza");
                //    }
                //    else if(w1.Length > w2.Length)
                //    {
                //        Console.WriteLine($"{w1} è la parola più lunga");
                //    }
                //    else
                //    {
                //        Console.WriteLine($"{w2} è la parola più lunga");
                //    }
                //}
                //CheckWordsLenght(word1, word2);

            }
            {
                // Snack 12
                // Scrivere una funzione per verificare se un numero è pari o dispari.
                // Quindi chiedere un numero all'utente e comunicargli se è pari o dispari.

                //void EvenOrOdd(int num)
                //{
                //    if (num % 2 == 0)
                //        Console.WriteLine("Il numero è pari");
                //    else
                //        Console.WriteLine("Il numero è dispari");
                //}

                //int number;
                //Console.WriteLine("Inserisci numero");
                //while (int.TryParse(Console.ReadLine(), out number) == false)
                //{
                //    Console.WriteLine("Sintassi errata. Inserisci numero");
                //}
                //EvenOrOdd(number);
            }
            {
                /*--------------------------
                  ESERCIZIO CSHARP FUNCTION
                ---------------------------*/

                    // Stampa Array
                    void StampaArray(int[] array)
                    {
                        Console.Write("[");
                        for (int i = 0; i < array.Length; i++)
                        {
                            Console.Write(array[i]);
                            if (i < array.Length - 1)
                                Console.Write(", ");
                        }
                        Console.Write("]");
                    }

                    // Fai il quadrato
                    int Quadrato(int number)
                    {
                        return number * number;
                    }

                    // Eleva un array al quadrato
                    int[] ElevaArrayAlQuadrato(int[] array)
                    {
                        int[] arrayCopy = new int[array.Length];
                        for (int i = 0;i < arrayCopy.Length; i++)
                        {
                            arrayCopy[i] = Quadrato(array[i]);
                        }
                        return arrayCopy;
                    }

                    // Somma elementi di un array
                    int SommaElementiArray(int[] array)
                    {
                        int sum = 0;
                        foreach (int element in array)
                        {
                            sum += element;
                        }
                        return sum;
                    }

                    /*---------------
                      Array traccia
                     --------------*/
                    int[] givenNumbers = { 2, 6, 7, 5, 3, 9 };

                    /*--------------------
                      ESERCIZIO CON BONUS
                    ---------------------*/

                    Console.WriteLine("Quanti numeri vuoi inserire?");
                    int length = Convert.ToInt32(Console.ReadLine());
                    int[] numbers = new int[length];

                    for (int i = 0; i < length; i++)
                    {
                        Console.WriteLine($"Inserisci un numero {i + 1} / {length}");
                        numbers[i] = Convert.ToInt32(Console.ReadLine());
                    }

                    // Stampo l'array di numeri dato
                    Console.WriteLine("Array originale:");
                    StampaArray(numbers);

                    // Faccio il quadrato dell'array dato 
                    Console.WriteLine("\nArray dopo l'elevamento al quadrato:");
                    int[] squaredNumbers = ElevaArrayAlQuadrato(numbers);

                    // Stampo a video l'array
                    StampaArray(squaredNumbers);

                    // Controllo che l'array originale non sia cambiato
                    Console.WriteLine("\nArray originale:");
                    StampaArray(numbers);

                    // Sommo tutti gli elementi dell'array
                    int totalSum = SommaElementiArray(numbers);
                    Console.WriteLine($"\nLa somma degli elementi dell'array è {totalSum}");

                    // Sommo tutti gli elementi dell'array che sono stati elevati al quadrato
                    int sumSquaredArray = SommaElementiArray(squaredNumbers);
                    Console.WriteLine($"\nLa somma degli elementi dell'array elevati al quadrato è {sumSquaredArray}");
            }
            {
                /*---------------------------------------------------------------------------------------------------------------
                 Scrivere un piccolo programma che esegue le seguenti funzioni: 
                 (Si inserisca ogni funzionalità in uno o più metodi a seconda delle necessità)
                 - Permette di Calcolare l'area di un cerchio  (I numeri sono in virgola quindi attenzione.)
                 - Converta i gradi da Celsius a Farenheit
                 - Verificare se il numero fornito in input è un numero primo o no
                 - Concatenare due stringhe date in ingresso (BONUS: Permettere all'utente anche di scegliere il carattere per la concatenazione)
                 - Verificare se una parola data in input è palindroma (HELP: la funzione Equals delle stringhe ci può aiutare)
                 ---------------------------------------------------------------------------------------------------------------*/

                // Permette di Calcolare l'area di un cerchio  (I numeri sono in virgola quindi attenzione.)

                double pi = 3.14;

                Console.WriteLine("Per calcolare l'area di un cerchio inserisci il raggio");
                double radius = Convert.ToDouble(Console.ReadLine());
                void PrintArea(double r)
                {
                    double area = r * r * pi;
                    Console.WriteLine($"L'area del cerchio con raggio {radius} è {area}");
                }
                PrintArea(radius);

                // Converta i gradi da Celsius a Farenheit

                Console.WriteLine("Inserisci i gradi Celsius che vuoi convertire in Farenheit");
                double degrees = Convert.ToDouble(Console.ReadLine());
                void ConvertToFarenheit(double d)
                {
                    double convertedDegrees = (d * 9 / 5) + 32;
                    Console.WriteLine($"{d} gradi Celsius corrispondono a {convertedDegrees} gradi in Farenheit");
                }
                ConvertToFarenheit(degrees);

                // Verificare se il numero fornito in input è un numero primo o no

                Console.WriteLine("Inserisci un numero");
                int number = Convert.ToInt32(Console.ReadLine());
                if (IsPrime(number))
                {
                    Console.WriteLine($"{number} è un numero primo");
                }
                else
                {
                    Console.WriteLine($"{number} è un numero composto");
                }

                bool IsPrime(int number)
                {
                    if (number <= 1)
                    {
                        return false;
                    }

                    for (int i = 2; i * i <= number; i++)
                    {
                        if (number % i == 0)
                        {
                            return false;
                        }
                    }
                    return true;
                }

                // Concatenare due stringhe date in ingresso(BONUS: Permettere all'utente anche di scegliere il carattere per la concatenazione)

                Console.WriteLine("Inserisci una parola");
                string word1 = Console.ReadLine();
                Console.WriteLine("Inserisci una parola");
                string word2 = Console.ReadLine();
                Console.WriteLine("Digita un carattere per la concatenazione");
                string char1 = Console.ReadLine();

                string linkedWords = LinkWords(word1, word2, char1);
                Console.WriteLine(linkedWords);

                string LinkWords(string word1, string word2, string char1)
                {
                    return word1 + " " +  char1 + " " + word2;
                }

                // Verificare se una parola data in input è palindroma(HELP: la funzione Equals delle stringhe ci può aiutare)

                {
                    Console.WriteLine("Inserisci una parola");
                    string wordToCheck = Console.ReadLine();

                    if (IsPalindrome(wordToCheck))
                    {
                        Console.WriteLine("La parola è palindroma.");
                    }
                    else
                    {
                        Console.WriteLine("La parola non è palindroma.");
                    }
                }

                static bool IsPalindrome(string word)
                {
                    return word.Equals(ReverseString(word));
                }

                static string ReverseString(string input)
                {
                    char[] charArray = input.ToCharArray();
                    Array.Reverse(charArray);
                    return new string(charArray);
                }
            }

        }
    }
}
