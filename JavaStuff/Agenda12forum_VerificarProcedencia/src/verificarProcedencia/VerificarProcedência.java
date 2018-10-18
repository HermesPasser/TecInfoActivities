package verificarProcedencia;
// Autor : DOUGLAS SL / Data : 03/11/2015
import java.util.Scanner;
public class VerificarProcedência {
	public static void main(String[] args) {
		int x, rep;
		Scanner scan = new Scanner(System.in);
		rep = 1;
		scan.close();
		while (rep == 1){
			System.out.println ("Digite o código do produto (de 1 á 8): ");
			x = scan.nextInt();
			switch (x){
				case 1:
					System.out.println ("O produto vem do SUL.");
					break;
				case 2:
					System.out.println ("O produto vem do NORTE.");
					break;
				case 3:
					System.out.println ("O produto vem do LESTE.");
					break;
				case 4:
					System.out.println ("O produto vem do OESTE.");
					break;
				case 5:
					System.out.println ("O produto vem do NORDESTE.");
					break;
				case 6:
					System.out.println ("O produto vem do SUDESTE.");
					break;
				case 7:
					System.out.println ("O produto vem do  CENTRO OESTE.");
					break;
				case 8:
					System.out.println ("O produto vem do NOROESTE.");
					break;
				default:
					System.out.println ("O produto não consta no banco de dados.");
					break;
			}
		 System.out.println("Deseja verificar outro código? Digite 1 para sim e 0 para não. ");
		 rep = scan.nextInt();
		}	
	}
}
