package loops;
import java.util.Scanner;

//@Autor:Douglas Silva Lacerda

public class Repeticao {
	public static void enquanto(){
		System.out.println("Testando while.\nPara sair do loop aperte X.");
		Scanner scan = new Scanner(System.in);
		String x = "z";
		while(!(x.equals("x"))){
			System.out.println("Dentro do laço, x é: "+x+".");
			 x = scan.next();
		}
		scan.close();
		System.out.println("\nMuito semelhante ao While\nEsta estrutura pode realizar suas instruções de 'nenhuma' até o número de vezes que o programador desejar. Ela 'pergunta' e depois faz.\nEla pode checar vários tipos de valores\nEle não tem contador no cabeçalho");
	}
	public static void facaEnquanto(){
		System.out.println("Testando do-while.");
		
		int x = 0;
		do{
			System.out.println("Entrei no laço mesmo valendo: "+x+"! (a condição é x==3)");
			x++;
		}while(x==3);
		System.out.println("\nEsta estrutura garante que as instruções sejam executadas pelo menos uma vez. Ela faz e depois 'pergunta'.");
	}
	public static void para(){
		System.out.println("Testando for. Vamos contar os pares até dez.");
		
		for(int x=0;x<=10;x+=2){
			System.out.print("	x:"+x+" ");
		}
		System.out.println("\nEsta estrutura é usada quando você sabe o número exato de vezes que a estrutura deve ser repetida.\nEla só pode usar números.");
	}
	public static void main(String[] args) {
		enquanto();
		System.out.println("\n");
		facaEnquanto();
		System.out.println("\n");
		para();
		System.out.println("\n--\nCada uma delas pode ser usada em casos especifícos, cabe ao programador descidor qual melhor se adequa"
				+ "a seu contexto.\nFim");
	}
}