//Douglas Silva Lacerda Forum Agenda 10
package veiculo;

public class Principal {
	public static void main(String[] args){
		Veiculo carro = new Veiculo();
		carro.marca = "Ferrari";
		carro.marcha = 2;
		carro.modelo = "Enzo";
		carro.cor = "Vermelho";
		System.out.println("Dirigindo.");
		carro.dirigir();
		System.out.println("Aumentando a marcha.");
		carro.aumertarMarcha();
		System.out.println("Diminuindo a marcha.");
		carro.diminuirMarcha();
		System.out.println("Pintando.");
		carro.alterarCor("Rosa choque");
		System.out.println("FIM DO PROGRAMA.");
	}
}