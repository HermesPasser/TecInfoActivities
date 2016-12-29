package vetor;

import javax.swing.JOptionPane;

public class Guess {
	String convidados[] = new String[10];
	int contador = 0;
	
	public void lerConvidado(){
		String nomeconvidado;
		nomeconvidado = JOptionPane.showInputDialog("Digite o nome do "+String.valueOf(this.contador+1));
		convidados[this.contador] = nomeconvidado;
		this.contador +=1;
	}
	public void mostrarConvidados(){
		String listaconvidados = "Convidados: ";
		int contadorvalor;
		
		for(contadorvalor=0; contadorvalor<10; contadorvalor++){
			listaconvidados = listaconvidados + " " + this.convidados[contadorvalor];
		}
		JOptionPane.showInputDialog(null,listaconvidados);
	}
}
