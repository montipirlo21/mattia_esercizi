using System;

namespace Esercizi.Esercizi;

public static class Sorting
{
    public static (int[], int ) SelectionSort(int[] abitanti)
    {
        // for (int i = 0; i < abitanti.Length; i++)
        // {
        //     for (int j = i + 1; j < abitanti.Length; j++)
        //     {
        //         if (abitanti[i] > abitanti[j])
        //         {
        //             int tmp = 0;
        //             tmp = abitanti[i];
        //             abitanti[i] = abitanti[j];
        //             abitanti[j] = tmp;
        //         }
        //     }
        // }

        int scambi = 0;
        int tmp;
        int n = abitanti.Length;

        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (abitanti[i] > abitanti[j])
                {
                    tmp = abitanti[i];
                    abitanti[i] = abitanti[j];
                    abitanti[j] = tmp;
                    scambi++;
                }
            }
        }



        return (abitanti, scambi);
    }

    // public static (int[], int) SelectionSort(int[] abitanti)
    // {
    //     int scambi = 0;
    //     for (int i = 0; i < abitanti.Length -1; i++)
    //     {
    //         int minValue = abitanti[i];
    //         int indice = i;

    //         for (int j = i + 1; j < abitanti.Length; j++)
    //         {
    //             if (abitanti[j] < minValue)
    //             {
    //                 minValue = abitanti[j];
    //                 indice = j;
    //             }
    //         }

    //         int tmp = 0;
    //         tmp = abitanti[i];
    //         abitanti[i] = abitanti[indice];
    //         abitanti[indice] = tmp;
    //         scambi++;

    //     }

    //     return (abitanti, scambi);
    // }

    //int[] abitanti = { 320000, 380000, 390000, 580000, 670000, 870000, 960000 ,  1400000, 2870000 };
    //int[] expected ={ 320000, 380000, 390000, 580000, 670000, 870000, 960000 ,1_000_000,  1400000, 2870000 };

    public static int[] Insertion_element(int[] abitanti, int valore)
    {
        int[] abitantiAggiunta = new int[abitanti.Length + 1];

        bool inserted = false;
        int j = 0;
        for (int i = 0; i < abitanti.Length; i++)
        {
            if (abitanti[i] > valore && inserted == false)
            {
                // Lo vado ad inserire 
                abitantiAggiunta[j] = valore;
                inserted = true;
                j++;
            }

            abitantiAggiunta[j] = abitanti[i];
            j++;
        }

        return abitantiAggiunta;

    }
}
