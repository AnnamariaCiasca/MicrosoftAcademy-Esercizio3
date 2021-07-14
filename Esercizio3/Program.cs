/*Analizza Numeri

Si scriva un programma per poter analizzare una sequenza di numeri.
Dati N numeri interi letti da tastiera (alternativa generati in maniera Random)
si vogliono calcolare e stampare su schermo diversi risultati:

1.quanti sono i numeri positivi, nulli e negativi
2.quanti sono i numeri pari e dispari
3.se la sequenza dei numeri inseriti è crescente, decrescente oppure né crescente né decrescente.

Suggerimento.
Una sequenza è crescente se ogni numero è maggiore del precedente,
decrescente se ogni numero è minore del precedente,
né crescente né decrescente in tutti gli altri casi.*/


using System;

namespace Esercizio3
{
    class Program
    {
        static void Main(string[] args)
        {

            int n;
            Console.WriteLine("Quanti numeri vuoi generare?");
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Inserisci un numero intero");
            }

            int[] vettore = new int[n];

            RiempiVettore(ref n, ref vettore);
            ContaSegno(ref n, ref vettore);
            ContaPariDisp(ref n, ref vettore);
            VerificaOrdine(ref n, ref vettore);

    
        }

        private static void VerificaOrdine(ref int n, ref int[] vet)
{           
            bool crescente = true;
            bool decrescente = true;
            
            for (int i = 1; i < n; i++)
            {
                if (vet[i] <= vet[i-1])
                {
                    crescente = false ;
                }
                else if(vet[i] >= vet[i - 1])
                {
                    decrescente = false;
                }
                
                
              
            }
                if (crescente)
                {
                    Console.WriteLine("\nIl vettore è ordinato in maniera crescente");
                }
                else if (decrescente)
                {
                    Console.WriteLine("\nIl vettore è ordinato in maniera decrescente");
                }
                else if(!crescente && !decrescente)
            {
                Console.WriteLine("\nIl vettore non è ordinato");
            }

               

            }
        
 

        private static void ContaPariDisp(ref int n, ref int[] vet)
        {
            int contPari = 0;
            int contDispari = 0;

            for (int i = 0; i < n; i++)
            {
                if (vet[i] % 2 == 0)
                {
                    contPari++;
                }
                else
                {
                    contDispari++;
                    {

                    }
                }
            }

                    Console.WriteLine($"\nNel vettore ci sono: \n" +
                        $" {contPari} numeri pari,\n " +
                        $"{contDispari} numeri dispari.\n ");
                
            
        }

        private static void ContaSegno(ref int n, ref int[] vet)
        {
            int contPos = 0;
            int contNeg = 0;
            int contNull = 0;
            for (int i = 0; i < n; i++)
            {
                if (vet[i] > 0)
                {
                    contPos++;
                }
                else if (vet[i] < 0)
                {
                    contNeg++;
                }
                else if (vet[i] == 0)
                {
                    contNull++;
                }
            }

            Console.WriteLine($"\nNel vettore ci sono: \n" +
                $" {contPos} numeri positivi,\n " +
                $"{contNeg} numeri negativi,\n " +
                $"{contNull} numeri nulli.\n");
        }

        private static void RiempiVettore(ref int n, ref int[] vet)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Inserisci il {i + 1}° numero: ");
                vet[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{vet[i]} \t");
            }
        }
    }
}

     
    
