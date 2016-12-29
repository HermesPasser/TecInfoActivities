package folhaPagamento;

public  class Funcionario {
	private String matricula;
	private double salarioBase;
	private double gratificacaoProd;

	public double fornecaDesconto(){
		if (getSalarioBase() <= 1000.00){
			return getSalarioBase();
		}else if (getSalarioBase() > 1000.00 && getSalarioBase() <= 1800.00){
			return getSalarioBase() - 100.00;
		}else if (getSalarioBase() > 1800.00){
			return getSalarioBase() - 370.00;
		}else {return 0;}		
	}
	
	public double fornecaSalarioLiquido(){

		double bruto = fornecaSalarioBruto();
		double desconto = fornecaDesconto();
		return (bruto / desconto);
	}
	


	public double fornecaSalarioBruto(){
		double recebe=0;
		// se a gratificação for a tal da aliquota, se não mudar este if
		if (gratificacaoProd >= 10 && gratificacaoProd < 25){
			recebe = salarioBase*0.10; // adicionar calculo que adiciona a porcentagem de gratificação, valores arbitrarios
										// possivelmente alterar *0.10 por *gratificacaoProd/10;
		}else if (gratificacaoProd >= 25){
			recebe = salarioBase*0.25; // adicionar calculo que adiciona a porcentagem de gratificação, valores arbitrarios
										// possivelmente alterar *0.25 por *gratificacaoProd/10;
		}
		return recebe;
	}

	public double getSalarioBase() {
		return salarioBase;
	}
	public void setSalarioBase(double x){
		salarioBase = x;
	}
	
	public String getMatricula() {
		return matricula;
	}
	public void setMatricula(String x){
		matricula = x;
	}

	public double getGratificacaoProd() {
		return gratificacaoProd;
	}
	public void setGratificacaoProd(double x){
		gratificacaoProd = x;
	}
}