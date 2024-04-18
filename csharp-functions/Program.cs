using System;

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
                    int square = number * number;
                    return square;
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
                // int[] numbers = { 2, 6, 7, 5, 3, 9 };

                /*-------
                  BONUS
                -------*/

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
        }
    }
}
