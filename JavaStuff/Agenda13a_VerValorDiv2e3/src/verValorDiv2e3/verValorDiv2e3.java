package verValorDiv2e3;
//Douglas Silva Lacerda Forum Agenda 13
import java.util.Scanner;
public class verValorDiv2e3 {
	public static void main(String[] args) {
		Scanner Leitor = new Scanner(System.in);
		int []aVetor = new int[12];
		int nRecebe,nContador;
		nContador = 0;
		System.out.println("S� ser�o aceitos n�meros divisiveis por 2 ou 3.");
		while (nContador <=11){
			System.out.println("Entre com o n�mero "+nContador+": ");
		   nRecebe = Leitor.nextInt();
		   if ((nRecebe%2) == 0){
			   aVetor[nContador] = nRecebe;
			   nContador+=1;
		   }else{
			   if ((nRecebe%3) == 0){
				   aVetor[nContador] = nRecebe;
				   nContador+=1;
			   }else{
				   System.out.println("N�mero inv�lido.");
			   }	   
		   }
		}
		Leitor.close();
		System.out.println("Mostrando os valores: ");
		for(int x = 0;x<12;x++){
			System.out.println("vetor "+x+": "+aVetor[x]);
		}	
	}
}
