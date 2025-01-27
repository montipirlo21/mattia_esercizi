// Crea un programma che richieda all'utente di inserire il proprio nome e lo stampi.
public partial class Program
{
    public static void Main()
    {
        // Creare un menu 1 voto e peso del voto massimo voti a 20 massimo peso 100, 2 media dei voti , 9 exit
        // int indexVoto = 0;
        // double[] voti = new double[20];
        // double[] pesi = new double[20];

        int intScelta;
        do
        {
            Console.WriteLine("Inserisci 1=voto, 2=media o 9=exit");
            string scelta = Console.ReadLine();
            intScelta = Convert.ToInt32(scelta);

            // Devo capire cosa ha scelto l'operatore
            switch (intScelta)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 9:
                    Console.WriteLine("Esco dal programma");
                    break;
                default:
                    break;
            }

        } while (intScelta != 9);

        
    }
}

