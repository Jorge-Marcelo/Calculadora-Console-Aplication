using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Menu();
		}

		static void Soma()
		{
			Console.Clear();
			Console.Write("Digite um numero: ");
			float num1 = num1 = float.Parse(Console.ReadLine());
			num1.ToString("0.00");

			Console.Write("Digite um numero: ");
			float num2 = num2 = float.Parse(Console.ReadLine());
			num2.ToString("0.00");

			float resultado = resultado = num1 + num2;
			resultado.ToString("0.00");

			Console.WriteLine("---------------------------------");
			Console.WriteLine($"Resultado do Calculo: {num1} + {num2} = {resultado}");

		}

		static void Subi()
		{
			Console.Clear();
			Console.Write("Digite um numero: ");
			float num1 = num1 = float.Parse(Console.ReadLine());
			num1.ToString("0.00");

			Console.Write("Digite um numero: ");
			float num2 = num2 = float.Parse(Console.ReadLine());
			num2.ToString("0.00");

			float resultado = resultado = num1 - num2;
			resultado.ToString("0.00");

			Console.WriteLine("---------------------------------");
			Console.WriteLine($"Resultado do Calculo: {num1} - {num2} = {resultado}");
		}

		static void Multi()
		{
			Console.Clear();
			Console.Write("Digite um numero: ");
			float num1 = num1 = float.Parse(Console.ReadLine());
			num1.ToString("0.00");

			Console.Write("Digite um numero: ");
			float num2 = num2 = float.Parse(Console.ReadLine());
			num2.ToString("0.00");

			float resultado = resultado = num1 * num2;
			resultado.ToString("0.00");

			Console.WriteLine("---------------------------------");
			Console.WriteLine($"Resultado do Calculo: {num1} X {num2} = {resultado}");
		}

		static void Divi()
		{
			Console.Clear();
			Console.Write("Digite um numero: ");
			float num1 = num1 = float.Parse(Console.ReadLine());
			num1.ToString("0.00");

			Console.Write("Digite um numero: ");
			float num2 = num2 = float.Parse(Console.ReadLine());
			num2.ToString("0.00");

			float resultado = resultado = num1 / num2;
			resultado.ToString("0.00");

			float resto = num1 % num2;

			Console.WriteLine("---------------------------------");
			Console.WriteLine($"Resultado do Calculo: {num1} / {num2} = {resultado}");

			Console.WriteLine("---------------------------------");
			Console.WriteLine($"Resultado do resto da divisão: {resto}");
		}

		static void Menu()
		{
			Console.Clear();
			Console.WriteLine("Bem-Vindo a Calculadora");
			Console.WriteLine("Ecolha uma opção");
			Console.WriteLine("0 - Sair");
			Console.WriteLine("1 - Soma ");
			Console.WriteLine("2 - Subitração ");
			Console.WriteLine("3 - Multiplicação ");
			Console.WriteLine("4 - Divisão ");
			Console.WriteLine("----------------------------");
			Console.Write("Operação Matematica: ");
			short opc = short.Parse(Console.ReadLine());

			switch (opc)
			{
				case 0: System.Environment.Exit(0); break;
				case 1: Soma(); break;
				case 2: Subi(); break;
				case 3: Multi(); break;
				case 4: Divi(); break;
			}

		}

	}
}
