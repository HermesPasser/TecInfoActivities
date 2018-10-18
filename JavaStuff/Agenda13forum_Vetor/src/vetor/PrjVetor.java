package vetor;
//Douglas Silva Lacerda Agenda 13 Forum

// usar fef: http://java.ittoolbox.com/groups/technical-functional/java-l/removing-null-value-from-string-1114615
import javax.swing.JOptionPane;

public class PrjVetor {

	public static void main(String[] args) {
		Guess convite = new Guess();
		String msg = "";
		int cont = 1;
		do{
			if (cont <= 10){
				convite.lerConvidado();
				msg = JOptionPane.showInputDialog("Adicionado, deseja continuar? S/N");
				cont++;
			}else{
				JOptionPane.showInputDialog(null,":( Você já escolheu os 10 convidados.");
				msg = "n";
			}
		}while(msg.equals("S"));
		convite.mostrarConvidados();
	}
}
