package contacorrente;

public class ContaDados {
	String nome_cliente;
	int idade_cliente;
	double saldo;
	
	public String exibirNome()
	{
		nome_cliente = "Pedro";
		return nome_cliente;
	}
	public double mostrarSaldo()
	{
		saldo = 2500;
		return saldo;
	}

}