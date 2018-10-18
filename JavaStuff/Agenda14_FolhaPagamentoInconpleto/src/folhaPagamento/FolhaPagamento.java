//Douglas Silva Lacerda Agenda 14
package folhaPagamento;

import javax.swing.JOptionPane;

public class FolhaPagamento {

	public static void main(String[] args) {

		Funcionario f1 = new Funcionario();
		f1.setSalarioBase(200);
		f1.setMatricula("acaca");
		f1.setGratificacaoProd(2);

		Chefe f2 = new Chefe();
		f2.setSalarioBase(245);
		f2.setMatricula("aa2");
		f2.setGratificacaoProd(8);
		
		Apoio f3 = new Apoio();
		f3.setSalarioBase(2300);
		f3.setMatricula("aca3");
		f3.setGratificacaoProd(10);
		

		String texto = (f1.getMatricula()+", salario bruto "+f1.fornecaSalarioBruto()+"\nSalario liquido "+f1.fornecaSalarioLiquido()+"\nTeve um desconto de "+f1.fornecaDesconto()+
				"\n\n"+f2.getMatricula()+", salario bruto "+f2.fornecaSalarioBruto()+"\nSalario liquido "+f2.fornecaSalarioLiquido()+"\nTeve um desconto de "+f2.fornecaDesconto()+
				"\n\n"+f3.getMatricula()+", salario bruto "+f3.fornecaSalarioBruto()+"\nSalario liquido "+f3.fornecaSalarioLiquido()+"\nTeve um desconto de "+f3.fornecaDesconto());
	
		JOptionPane.showMessageDialog(null,texto);
	}

}
