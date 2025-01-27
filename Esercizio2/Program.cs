// Fai un programma che faccia finta di suonare tre volte ad un campanello ( writeline "DONG)
//e attendi facendo una readline
Console.WriteLine("Arrivo a casa del mio amico");

// Fallo 3 volte
for (int j = 1; j <= 3; j++)
{ 
    Console.WriteLine($"FOR Variabile: {j}");
}

//Definizione
int i = 1;
while (i <= 3)
{
    Console.WriteLine($"WHILE Variabile: {i}");
    if(i == 2){
        break;
    }
    i++;
}

// Fai e poi verifica
int k = 1;
do
{
    Console.WriteLine($"DO WHILE Variabile: {k}");
    k++;
} while (k <= 3);


Console.WriteLine($"Ciao");



