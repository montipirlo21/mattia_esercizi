using System;

public static class RotateArray
{

    // Dato un array, devi riuscire a invertire i dati dell'array senza usare un altro array
    // ATTENZIONE a due cose: a come sostituisci i dati e quante iterazioni fai e a non sovrascriverti la roba mentre la sposti
    // Puoi provare anche la versione con un numero dispari 
    // Versione con numero pari
    // int[] numeriOriginali = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
    // Versione con numero dispari di elementi
    // int[] numeriOriginali = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 }; 
    public static void Rotate(int[] numeriOriginali)
    {
        for (int i = 0; i < numeriOriginali.Length; i++)
        {
            Console.Write(numeriOriginali[i] + " ");
        }
        Console.WriteLine();

        // RISULTATO ATTESO 
        // 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
        // RISULTATO ATTESO Versione con numero dispari di elementi
        // 1, 2, 3, 4, 5, 6, 7, 8, 9

        for (int i = 0; i < numeriOriginali.Length; i++)
        {
            Console.Write(numeriOriginali[i] + " ");
        }
        Console.WriteLine();
    }
}
