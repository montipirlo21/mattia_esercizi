// Crea un programma che richieda all'utente di inserire il proprio nome e lo stampi.
public partial class Program
{
    public static void Main()
    {
        // Richiedo il nome
        Console.WriteLine("Inserisci il tuo nome:");

        // Attendo che lo legga
        string nome = Console.ReadLine();

        // Lo stampo a video     
        Console.WriteLine("Il tuo nome è " + nome);
    }
}












