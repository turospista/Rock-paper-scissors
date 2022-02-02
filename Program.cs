using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Kő papír olló játék.");
		string answer = "";

		string playerChoice = "";
		string compChoice = "";
		int playerScore = 0;
		int compScore = 0;
		do
		{
			Random rnd = new Random();
			Console.WriteLine("Válassz egyet: Kő, Papír, Olló");
			switch (Console.ReadLine())
			{
				case "kő":
					playerChoice = "kő";
					break;
				case "papír":
					playerChoice = "papír";
					break;
				case "olló":
					playerChoice = "olló";
					break;
			}

			switch (rnd.Next(0, 3))
			{
				case 0:
					compChoice = "kő";
					break;
				case 1:
					compChoice = "papír";
					break;
				case 2:
					compChoice = "olló";
					break;
			}

			Console.WriteLine("A te választásod: {0}, a gép választása: {1}", playerChoice, compChoice);
			if ((playerChoice == "kő" && compChoice == "olló") || (playerChoice == "papír" && compChoice == "kő") || (playerChoice == "olló" && compChoice == "papír"))
			{
				Console.WriteLine("Gratulálok, nyertél!");
				playerScore++;
			}
			else if ((playerChoice == "kő" && compChoice == "papír") || (playerChoice == "papír" && compChoice == "olló") || (playerChoice == "olló" && compChoice == "kő"))
			{
				Console.WriteLine("Vesztettél!");
				compScore++;
			}
			else if (playerChoice == compChoice)
			{
				Console.WriteLine("Döntetlen!");
			}
			Console.WriteLine("Eredmény: Játékos: {0} --- Gép: {1}", playerScore, compScore);
			Console.WriteLine("Akarsz még játszani? (i/n)");
			answer = Console.ReadLine();
		}
		while (answer == "i");
	}
}