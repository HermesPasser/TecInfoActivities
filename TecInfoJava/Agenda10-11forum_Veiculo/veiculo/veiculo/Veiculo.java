package veiculo;

public class Veiculo {
	public String marca;
	public String modelo;
	public String cor;
	public int marcha;
	
	public void dirigir (){
		System.out.println("Dirigindo um "+this.marca+" "+this.modelo+" da cor "+this.cor+" na marcha "+this.marcha+".");
	}
	
	public void aumertarMarcha(){
		this.marcha = this.marcha+1;
		System.out.println("Marcha aumentada, seu "+this.modelo+" está na marcha "+this.marcha+".");
	}
	
	public void diminuirMarcha(){
		this.marcha = this.marcha+1;
		System.out.println("Marcha diminuida, seu "+this.modelo+" está na marcha "+this.marcha+".");
	}
	
	public void alterarCor (String novaCor){
		this.cor = novaCor;
		System.out.println("Pintura relizada, seu "+this.modelo+" está com a cor "+this.cor+".");
	}
}
