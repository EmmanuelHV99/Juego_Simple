/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 29/08/2022
 * Time: 03:14 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Caracteres
{
	public enum Color{Red, Green, Blue}
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Ingresa un caracter");
		/*	char c= (char)Console.Read();
			if (Char.IsLetter(c)) {
				if (Char.IsLower(c)) {
					Console.WriteLine("El caracter esta en minuscula");
				}
				else{
					Console.WriteLine("El caracter esta en mayuscula");
				}
			}
			else{
				Console.WriteLine("El caracter ingresado no es un caracter alfabetico");
			}*/
			
			
			
			
			//sintaxis de switch
			
			int caseswitch =1;
			switch(caseswitch){
				case 1:
					Console.WriteLine("Case 1");
					break;
				case 2:
					Console.WriteLine("Case 2");
					break;
				default:
					Console.WriteLine("Default case");
					break;
			}
			
			Color c=(Color)(new Random()).Next(0,4);
			switch(c){
				case Color.Red:
					Console.WriteLine("El color es rojo");
					break;
				case Color.Green:
					Console.WriteLine("El color es verde");
					break;
				case Color.Blue:
					Console.WriteLine("El color es azul");
					break;
				default:
					Console.WriteLine("El color es desconocido");
					break;
			}
			
			bool var=true;
			
			switch(var){
				case true:
					Console.WriteLine("Es verdadero");
					break;
				default:
					Console.WriteLine("Es falso");
					break;
			}
			
			int a=100, b=200;
			
			Console.WriteLine("Hola " + a + " mundo");
			Console.WriteLine("{1} Hola {0} mundo {1}",a,b);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}