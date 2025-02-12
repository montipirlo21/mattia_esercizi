
// Creare un programma che stampi un menu.
// il menu compare una sola volta per ogni volta che lanci il programma
// Il menu deve avere le seguenti opzioni:
// 1. Chiedo di inserire un numero e lo deve stampare moltiplicato * 2
// 2. Chiedo di inserire un numero e lo devo stampare moltiplicato per se stesso

public partial class Program
{
    public static void Main()
    {
        // ReverseArray();
        // VerificaArrayUguali();
        // DoppioFor();
    }

    public static void DoppioFor()
    {
        int[] numeroOrdinato = new int[] { 1, 2 }; // 3
        int[] numeroAlContrario = new int[] { 4, 3 }; // 10
        int[] numeroAlContrario2 = new int[] { 1, 4 }; // 10

        int totale = 0;
        // 3
        for (int i = 0; i < numeroOrdinato.Length; i++)
        {
            // 3 * 10
            for (int j = 0; j < numeroAlContrario.Length; j++)
            {
                for (int k = 0; k < numeroAlContrario2.Length; k++)
                {
                    int risultatoMoltiplicazione = numeroOrdinato[i] * numeroAlContrario[j] * numeroAlContrario2[k];
                    Console.WriteLine($"risultatoMoltiplicazione = {risultatoMoltiplicazione} {numeroOrdinato[i]} * {numeroAlContrario[j]} * {numeroAlContrario2[k]}");
                    totale = totale + risultatoMoltiplicazione;
                    Console.WriteLine($"totale = {totale}");
                }               
            }
        }

        for (int i = 0; i < numeroOrdinato.Length; i++)
        {
            Console.Write(numeroOrdinato[i] + " ");
        }
        Console.WriteLine();

        for (int i = 0; i < numeroAlContrario.Length; i++)
        {
            Console.Write(numeroAlContrario[i] + " ");
        }
        Console.WriteLine();
    }

    public static void VerificaArrayUguali()
    {
        int[] numeroOrdinato = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int[] numeroAlContrario = new int[] { 0, 1, 2, 4, 3, 5, 6, 7, 8, 9 };

        bool sonoUguali = true;
        for (int i = 0; i < numeroOrdinato.Length; i++)
        {
            if (numeroOrdinato[i] == numeroAlContrario[i])
            {
                // Se i numeri sono uguali, tutto ok 
                Console.WriteLine($"Numeri uguali indice {i} : {numeroOrdinato[i]} == {numeroAlContrario[i]}");
            }
            else
            {
                Console.WriteLine($"Numeri DIVERSI indice {i} : {numeroOrdinato[i]} != {numeroAlContrario[i]}");
                sonoUguali = false;
                break;
            }
        }

        Console.WriteLine($"Gli array sono uguali? {sonoUguali}");

        for (int i = 0; i < numeroOrdinato.Length; i++)
        {
            Console.Write(numeroOrdinato[i] + " ");
        }
        Console.WriteLine();

        for (int i = 0; i < numeroAlContrario.Length; i++)
        {
            Console.Write(numeroAlContrario[i] + " ");
        }
        Console.WriteLine();
    }

    public static void ReverseArray()
    {
        int[] numeroOrdinato = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int[] numeroAlContrario = new int[10]; // 9, 8, etc 0

        for (int i = 0; i < numeroOrdinato.Length; i++)
        {
            // Prendere il valore alla posizione i
            Console.WriteLine($"numeroOrdinato indice {i} : {numeroOrdinato[i]}");

            // Calcolo indice dell'array di destinazione
            int j = numeroOrdinato.Length - i - 1;

            // Inserisco il valore nell'array di destinazione
            numeroAlContrario[j] = numeroOrdinato[i];
            Console.WriteLine($"numeroAlContrario indice {j} : {numeroAlContrario[j]}");
        }

        for (int i = 0; i < numeroOrdinato.Length; i++)
        {
            Console.Write(numeroOrdinato[i] + " ");
        }
        Console.WriteLine();

        for (int i = 0; i < numeroAlContrario.Length; i++)
        {
            Console.Write(numeroAlContrario[i] + " ");
        }
        Console.WriteLine();
    }
}

