package folhaPagamento;

public class Chefe extends Funcionario {
	 private double gratificacaoChefia; 
	 
	 Chefe(){
		 gratificacaoChefia = 0.1;
	 }
	
	 //valem as mesmas resalvas do metodo da superclass
	public double fornecaSalarioLiquido(){
		double recebe=0;
		if (super.getGratificacaoProd() >= 10 && super.getGratificacaoProd() < 25){
			recebe = super.getSalarioBase()*0.10;
		}else if (super.getGratificacaoProd() >= 25){
			recebe = super.getSalarioBase()*0.25;
		}
		return (recebe*gratificacaoChefia)/10;
	}
}