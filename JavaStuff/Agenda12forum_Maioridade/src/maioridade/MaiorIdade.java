package maioridade;
//Douglas Silva Lacerda Forum Agenda 12

import java.util.Scanner;

public class MaiorIdade {
	public static void main(String[] args){
	
		Scanner Leitor = new Scanner(System.in);
		System.out.printf("Digite o ano em que nasceu: ");
		Calculo calc = new Calculo();
		int anoNasc = Leitor.nextInt();
		System.out.printf("Digite o ano atual: ");
		int anoAtual = Leitor.nextInt();
		calc.calculaIdade(anoAtual,anoNasc);
		Leitor.close();
	}
}