package mudaSalario;
//Douglas Silva Lacerda Agenda 12
import java.util.Scanner;
public class MudaSalario {

	private static double salarioAtualizado;
	
	public static double aumentaSal�rio(double salario){
		if(salario > 0 && salario <= 750){
			salario += (salario*0.05)/10;
		}else if(salario >=750.1 && salario <= 1000){
			salario += (salario*.12)/10;
		}else if(salario >=1000.1 && salario <= 1800){
			salario += (salario*0.10)/10;
		}else if(salario >=1800.1 && salario <= 2500){
			salario += (salario*0.07)/10;
		}else{
			if (salario>0){	
			}
		}
		salarioAtualizado = salario;
		return salario;
	}
    
	public static void main(String[] args) {
		Scanner entrada = new Scanner(System.in);
		int x = 0;
		//double salarioAtualizado = 0; //s� para fins de teste
		while(x == 0){
			System.out.print("Digite o seu nome: ");		
			String nome = entrada.next();
	
			System.out.print("\nDigite o seu CNPJ: ");		
			int cnpj = entrada.nextInt();
			
			System.out.print("\nDigite o seu sal�rio: ");		
			double salarioAtual = entrada.nextDouble();

			aumentaSal�rio(salarioAtual);
			
			System.out.println(nome+" (cnpj: "+cnpj+")"+", seu sal�rio era de "+salarioAtual+"R$ e agora � de "+salarioAtualizado+"R$."
					+"\nPara continuar no programa aperte 0, aperte qualquer outro n�mero para sair.");
			x = entrada.nextInt();
		}
		entrada.close();	         

		System.out.println("\n---\nExplica��o: O If � usado porque o Case n�o pode realizar checagens que utilizem os operadores logicos."
				+ "\nFim");
		System.out.close();
	}
}