package maioridade;

public class Calculo {
	
	public void calculaIdade(int atual,int nasc){
		nasc = atual - nasc;
		if (nasc<18){
			System.out.printf("Voc� � menor de idade, sua idade �: "+nasc);
		}else{
			System.out.printf("Voc� � maior de idade, sua idade �: "+nasc);
		}
	}
}