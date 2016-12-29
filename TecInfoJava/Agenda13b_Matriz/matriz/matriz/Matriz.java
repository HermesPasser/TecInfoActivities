//Douglas Silva Lacerda Forum Agenda 13
package matriz;
import java.util.Scanner;

public class Matriz {
	public static void main(String[] args){

		Scanner Leitor = new Scanner(System.in);
		int[][] aMatriz = new int[3][3];
		for (int aLinha = 0; aLinha<3; aLinha++){
			for (int aColuna = 0; aColuna<3; aColuna++){
			  System.out.println ("Entre com o número "+aLinha+","+aColuna+": ");
		      aMatriz[aLinha][aColuna] = Leitor.nextInt();
		      if (aLinha == aColuna){
		         aMatriz[aLinha][aColuna] *=2;
			  }
			}
		}
		Leitor.close();
		//Saida de dados
		System.out.println("Mostrando os valores: \n");
		for (int aLinha = 0; aLinha<3; aLinha++){
			for (int aColuna = 0; aColuna<3; aColuna++){
		      System.out.print(aMatriz[aLinha][aColuna]+"|");
			}
			System.out.println ("");
		}
	}
}