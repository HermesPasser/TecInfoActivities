package folhaPagamento;

public class Apoio extends Funcionario {
	private int nrDependentes; // numero de pessoas que vão receber o auxilio ; max 5 dp
	private double valorAuxEducação;
	
	//codificar para o valor de nr aumentar
	
	Apoio(){
		valorAuxEducação = 60.00;
		nrDependentes = 1; 
	}
	
	public double fornecaDesconto(){
			return 0; //Apoios não tem desconto
	}
	public double fornecaSalarioLiquido(){
		return fornecaSalarioBruto(); // Já que não tem desconto, é retornado só o salario bruto
	}
	
	
	
	public double fornecaSalarioBruto(){
		if (nrDependentes <=5){
			return getSalarioBase() + valorAuxEducação; // Fornece desconto se ele for <= que 5
		}else{
			return getSalarioBase();
		}	
	}
}
