namespace qlqcoisa{
	class Pessoa{
	private string nome;
	   private string enderoco;
	   private string telefone;

	   public Pessoa (){
		   nome = "no name"
	   }
	   
	   public Pessoa (string nome, string enderoco, string telefone){
		   inserirDadosPessoa (nome, enderoco, telefone);
	   }
	   
	   public string getNome(){
			 return nome;
	   }

	   public void setNome(string nome){
			 this.nome = nome;
	   }
	   
	   public string getEnderoco(){
			 return enderoco;
	   }

	   public void getEnderoco(string enderoco){
			 this.enderoco = enderoco;
	   }
	   
		  public string getTelefone(){
			 return telefone;
	   }

	   public void getTelefone(string telefone){
			 this.telefone = telefone;
	   }
	   
	   public inserirDadosPessoa(string nome, string enderoco, string telefone){
		   this.nome = nome;
		   this.enderoco = enderoco;
		   this.telefone = telefone;
	   }
	   
	   public void apresentarPessoa(){
		   Console.Write("Sou o " + nome + ", moro em " + enderoco + " e meu telefone é " + telefone);
	   }

        static void Main(string[] args)
        {
            Pessoa fedrerico = new Pessoa();
			fedrerico.setNome("Joseppe Adanastor");
        }
	}
}