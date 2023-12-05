using System;
					
public class Program
{
	public static void Main()
	{
		int x, b = 0 ;
		
		while(b<31)
		{
			Console.WriteLine("upisite vrijednosti karte: ");
			try {
			x = Convert.ToInt32(Console.ReadLine());
			if(x >= 13 || x <= 1)
		{
			Console.WriteLine("nisti unjeo tocnu vrijednost");
				continue;
		}	else
			{
				b += x;
			}
			}
			catch (Exception ex) { Console.WriteLine(ex.Message);}
    					
		if(b == 31)
		{
			Console.WriteLine("Bodovi: " + b);
			Console.WriteLine("Pobjeda");
		}else
		{
			Console.WriteLine("Bodovi: " + b);
			Console.WriteLine("Gubitak");
		}
		

	}
}
}