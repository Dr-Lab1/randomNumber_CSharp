using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 101); // Génère un nombre aléatoire entre 1 et 100 inclus

        Console.WriteLine("Devinez le nombre entre 1 et 100 :");

        int userGuess;
        int i = 0;
        bool isGuessCorrect = false;

        while (!isGuessCorrect)
        {
            string input = Console.ReadLine();

            if (!int.TryParse(input, out userGuess))
            {
                Console.WriteLine("Veuillez entrer un nombre valide.");
                continue;
            }

            if (userGuess < randomNumber)
            {
                Console.WriteLine("Le nombre est plus grand.");
            }
            else if (userGuess > randomNumber)
            {
                Console.WriteLine("Le nombre est plus petit.");
            }
            else
            {
                Console.WriteLine("Bravo ! Vous avez deviné le nombre !");
                isGuessCorrect = true;
            }

            i++;
        }

        Console.WriteLine("Le nombre d'essais :" + i);
        Console.ReadKey();
    }
}