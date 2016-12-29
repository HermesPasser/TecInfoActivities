//Douglas Silva Lacerda Forum Agenda 10
package contacorrente;

public class ContaCorrente {

	public static void main(String[] args){
		ContaDados conta1 = new ContaDados();
		System.out.println("O nome do cliente é: " + conta1.exibirNome());
		System.out.println("O saldo da conta é: " + conta1.mostrarSaldo());	
	}
}