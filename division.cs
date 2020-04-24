using System;
using System.Globalization;


class Program
{
    static void Main(string[] args)
    {
	     //ganzahlig
		 
        int erg1 = 1 / 2;
        Console.WriteLine("{0} ", erg1);
        double erg2 = 1 / 2;
        Console.WriteLine("{0} ", erg2);
		
	    //mit gebrochenen zahlen
		
        double erg3 = 1f / 2.0;
        Console.WriteLine(erg3.ToString("F2", CultureInfo.InvariantCulture));
    }
}
