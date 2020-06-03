using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Escriba el precio del producto");
	  String pc = Console.ReadLine();
	 
      Console.WriteLine("EFC=Efectivo o Tarj=Tarjeta");
	  String pg = Console.ReadLine();
		
	  if(pg == "Tarj" )
	  {
		  Console.WriteLine("Escriba numero de su tarjeta");
		  
		  String tarj = Console.ReadLine();
	      long tNum = long.Parse(tarj);
		  
		  if(tarj.Length < 12 || tNum < 0)
		  {
			  
			  Console.WriteLine("please verifique si los numeros ingresados son correctos");
			  
		  }else
		  {
			  Console.WriteLine("pago mediante tarjeta exitoso");
		  }
		  
	  }else
	  {
		  Console.WriteLine("su pago en efectivo fue exitoso");
	  }
		
}   }
	