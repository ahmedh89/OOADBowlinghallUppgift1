using System;
using System.Numerics;
using System.Text.RegularExpressions;
using OOADBowlinghallUppgift.Models;

namespace OOADBowlinghallUppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till Bowlinghallen!");

            // Skapa två spelare
            Console.Write("Ange namn på spelare 1: ");
            string? name1 = Console.ReadLine();
            Console.Write("Ange medlemsnummer för spelare 1: ");
            int memberNumber1;
            while (!int.TryParse(Console.ReadLine(), out memberNumber1))
            {
                Console.Write("Ogiltigt nummer, försök igen: ");
            }

            Console.Write("Ange namn på spelare 2: ");
            string? name2 = Console.ReadLine();
            Console.Write("Ange medlemsnummer för spelare 2: ");
            int memberNumber2;
            while (!int.TryParse(Console.ReadLine(), out memberNumber2))
            {
                Console.Write("Ogiltigt nummer, försök igen: ");
            }

            // Skapa spelare
            Player player1 = PlayerFactory.CreatePlayer(name1 ?? "Okänd", memberNumber1);
            Player player2 = PlayerFactory.CreatePlayer(name2 ?? "Okänd", memberNumber2);


            // Skapa en match
            Game match = new Game(player1, player2);

            // Registrera resultat
            Console.Write("Ange poäng för " + player1.Name + ": ");
            int score1;
            while (!int.TryParse(Console.ReadLine(), out score1))
            {
                Console.Write("Ogiltig poäng, försök igen: ");
            }

            Console.Write("Ange poäng för " + player2.Name + ": ");
            int score2;
            while (!int.TryParse(Console.ReadLine(), out score2))
            {
                Console.Write("Ogiltig poäng, försök igen: ");
            }

            match.RegisterResult(score1, score2);

            // Visa vinnaren eller om det blev oavgjort
            Console.WriteLine("\nMatchresultat:");
            Console.WriteLine(player1.Name + " - " + score1 + " poäng");
            Console.WriteLine(player2.Name + " - " + score2 + " poäng");

            if (match.MatchResult?.Winner != null)
            {
                Console.WriteLine("Vinnaren är: " + match.MatchResult.Winner.Name);
            }
            else
            {
                Console.WriteLine("Matchen slutade oavgjort!");
            }

            Console.WriteLine("\nTryck på valfri tangent för att avsluta...");
            Console.ReadKey();
        }
    }
}
