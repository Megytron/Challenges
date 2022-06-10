using System;

public class Program
{
	public static void Main()
	{
		infected[] infectedType = {new infected(), new infected(), new infected ()};
		infectedType[1].infectedName = "Clicker";
		infectedType[2].infectedName = "Bloater";
		
		for(var i=0;i<infectedType.Length;i++) {
			infectedType[i].infectedStrength = 1000;
		}
		
		foreach(var zombie in infectedType){
			Console.WriteLine(zombie.infectedName);
			Console.WriteLine(zombie.infectedStrength);
		}
	}
}

public class infected {
	public string infectedName = "Runner";
	public int infectedStrength = 1;
}
