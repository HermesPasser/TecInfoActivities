package folhaPagamento;

public class Apoio extends Funcionario {
	private int nrDependentes; // numero de pessoas que v�o receber o auxilio ; max 5 dp
	private double valorAuxEduca��o;
	
	//codificar para o valor de nr aumentar
	
	Apoio(){
		valorAuxEduca��o = 60.00;
		nrDependentes = 1; 
	}
	
	public double fornecaDesconto(){
			return 0; //Apoios n�o tem desconto
	}
	public double fornecaSalarioLiquido(){
		return fornecaSalarioBruto(); // J� que n�o tem desconto, � retornado s� o salario bruto
	}
	
	
	
	public double fornecaSalarioBruto(){
		if (nrDependentes <=5){
			return getSalarioBase() + valorAuxEduca��o; // Fornece desconto se ele for <= que 5
		}else{
			return getSalarioBase();
		}	
	}
}
