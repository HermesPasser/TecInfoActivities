package loops;
import java.util.Scanner;

//@Autor:Douglas Silva Lacerda

public class Repeticao {
	public static void enquanto(){
		System.out.println("Testando while.\nPara sair do loop aperte X.");
		Scanner scan = new Scanner(System.in);
		String x = "z";
		while(!(x.equals("x"))){
			System.out.println("Dentro do la�o, x �: "+x+".");
			 x = scan.next();
		}
		scan.close();
		System.out.println("\nMuito semelhante ao While\nEsta estrutura pode realizar suas instru��es de 'nenhuma' at� o n�mero de vezes que o programador desejar. Ela 'pergunta' e depois faz.\nEla pode checar v�rios tipos de valores\nEle n�o tem contador no cabe�alho");
	}
	public static void facaEnquanto(){
		System.out.println("Testando do-while.");
		
		int x = 0;
		do{
			System.out.println("Entrei no la�o mesmo valendo: "+x+"! (a condi��o � x==3)");
			x++;
		}while(x==3);
		System.out.println("\nEsta estrutura garante que as instru��es sejam executadas pelo menos uma vez. Ela faz e depois 'pergunta'.");
	}
	public static void para(){
		System.out.println("Testando for. Vamos contar os pares at� dez.");
		
		for(int x=0;x<=10;x+=2){
			System.out.print("	x:"+x+" ");
		}
		System.out.println("\nEsta estrutura � usada quando voc� sabe o n�mero exato de vezes que a estrutura deve ser repetida.\nEla s� pode usar n�meros.");
	}
	public static void main(String[] args) {
		enquanto();
		System.out.println("\n");
		facaEnquanto();
		System.out.println("\n");
		para();
		System.out.println("\n--\nCada uma delas pode ser usada em casos especif�cos, cabe ao programador descidor qual melhor se adequa"
				+ "a seu contexto.\nFim");
	}
}