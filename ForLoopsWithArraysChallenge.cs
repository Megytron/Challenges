using System;

public class Program
{
	public void Main()
	{
		string[] sashimi = {"Salmon", "Tuna", "Whitefish", "Yellowtail", "Calamari", "Crab", "Ahi tuna"};
		foreach(var fish in sashimi) {
			Console.WriteLine(fish + " sashimi is da bomb" + ".");
		}
	}
}
