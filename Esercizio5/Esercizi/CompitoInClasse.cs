using System;

namespace Esercizi.Esercizi;

public class CompitoInClasse
{
    public static void Elaborazione()
    {
        int[] v = new int[]{0, 0, 0, 1, 2, 7, 8, 8};

        // n == 8 
        int n = v.Length;

        int i = 0;
        int count = 0;
        int valore = 0;

        // 0 < 8 = true
        while (i < n)
        {
            count = 0;

            // valore == 0
            valore = v[i];

            // 0 < 8 && 0 == 0
            // count == 1  1 < 8 && 0 == 0 TRUE
            // count == 2  2 < 8 && 0 == 0 TRUE
            // count == 3  3 < 8 && 1 == 0 FALSE
            while (i < n && v[i] == valore)
            {
                count++;
                i++;
            }

            // 0, 3
            // 1, 1
            // 2, 1
            // 7, 1
            // 8, 2 
            Console.WriteLine("{0} {1}" , valore, count);
        }
    }

    public static void Elaborazione_2()
    {
        // 3.6
        int[] v = new int[]{0, 1, 2, 7, 8};

        double media = 0;
        double somma = 0;
        
        for (int i = 0; i < v.Length; i++)
        {
            somma = somma + v[i];
        }

        media = somma / v.Length;

        Console.WriteLine($"la media è {media}");
    }
}
