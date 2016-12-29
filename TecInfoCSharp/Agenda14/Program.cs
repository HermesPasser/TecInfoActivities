using System;

namespace Agenda14
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Funcionario f1 = new Funcionario("oladi oblada", 2, 55.0);
			Console.Write ("Salario bruto: " + f1.fornecaSalarioBruto() + " salario liquido: " + f1.fornecaSalarioLiquido());
		}
	}
}
