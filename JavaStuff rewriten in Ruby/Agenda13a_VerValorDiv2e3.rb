aVetor = Array.new(12)
nContador = 0
puts("Só serão aceitos numeros divisíveis por 2 ou 3") 

while nContador < 12
	puts("Entre com o número #{nContador}:")
	nRecebe = gets.chomp
	
	if ((nRecebe.to_i % 2) == 0 || (nRecebe.to_i % 3) == 0)
		aVetor[nContador] = nRecebe
		nContador += 1
	else
		puts("Número inválido. Por favor, insira outro.")
	end
end

for nContador in 0..11
	puts("\nvetor: #{nContador}: #{aVetor[nContador]}")
end
