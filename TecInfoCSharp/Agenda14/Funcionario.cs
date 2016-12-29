using System;

namespace Agenda14 {
	public class Funcionario {

		private string matricula;
		private double salarioBase;
		private double gratificacaoProd;

		public Funcionario (string matricula, double salarioBase, double gratificacao) {
			this.matricula = matricula;
			this.salarioBase = salarioBase;
			this.gratificacaoProd = gratificacao;
		}

		public double fornecaSalarioBruto(){
			double recebe = 0;
			if (gratificacaoProd >= 10 && gratificacaoProd < 25)
				recebe = salarioBase*0.10; 
			else if (gratificacaoProd >= 25)
				recebe = salarioBase*0.25; 

			return recebe;
		}

		public double fornecaDesconto(){
			if (salarioBase <= 1000.00)
				return salarioBase;
			else if (salarioBase > 1000.00 && salarioBase <= 1800.00)
				return salarioBase - 100.00;
			else if (salarioBase > 1800.00)
				return salarioBase - 370.00;
			else 
				return 0;
		}

		public double fornecaSalarioLiquido(){
			double bruto = fornecaSalarioBruto();
			double desconto = fornecaDesconto();
			return (bruto / desconto);
		}
	}
}