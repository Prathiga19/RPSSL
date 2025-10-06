using System; 
//jeg laver en enum med de 5 muligheder i spillet
enum Throw
{
    Rock,
    Paper,
    Scissors,
    Lizard,
    Spock
}

//Enum til resultat
enum Result
{
    Tie,
    Win,
    Lose
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Velkommen til Rock, Paper, Scissors, Lizard, Spock!");
        Console.WriteLine("Skriv et tal mellem 1-5:");
        Console.WriteLine("1. Rock\n2. Paper\n3. Scissors\n4. Lizard\n5. Spock");

        //læser spillerens valg
        int input = Convert.ToInt32(Console.ReadLine());
        Throw player = (Throw)(input - 1);

        //Computeren vælger tilfældigt
        Throw computer = GetRandomThrow();

        //viser begge valg
        Console.WriteLine($"Du valgte: {player}");
        Console.WriteLine($"computeren valgte: {computer}");

        //finder vinderen
        Result result = GetResult(player, computer);

        //skriver resultat ud 
        Console.WriteLine($"Resultat: {result}");
    }
    //her vælger computeren tilfældigt et af de fem valg
    static Throw GetRandomThrow()
    {
        Random r = new Random();
        int number = r.Next(0, 5);
        return (Throw)number;
        
    }
    //Her tjekker jeg forskellen på spiller og computer for at finde vinderen 
    static Result GetResult(Throw player, Throw computer)
    {
        if (player == computer)
            return Result.Tie;
        
        int diff = (int)player - (int)computer;

        switch (diff)
        {
            case -4:
            case -2:
            case 1:
            case 3:
                return Result.Win;
            case -3:
            case -1:
            case 2: 
            case 4:
                return Result.Lose;
            default:
                return Result.Tie; 
        }
    }
    
}
    
