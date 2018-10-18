rep = 1

while (rep == 1)
	print ("Digite o código do produto (de 1 á 8): ")
	x = gets.chomp
	
	case x
	when "1" then print ("O produto vem do SUL.")
	when "2" then print ("O produto vem do NORTE.")
	when "3" then print ("O produto vem do LESTE.")
	when "4" then print ("O produto vem do OESTE.")
	when "5" then print ("O produto vem do NORDESTE.")
	when "6" then print ("O produto vem do SUDESTE.")
	when "7" then print ("O produto vem do  CENTRO OESTE.")
	when "8" then print ("O produto vem do NOROESTE.")
	else print("O produto não consta no bando de dados.")
	end
	
	print("\nDeseja verificar outro código? Digite 1 para sim e 0 para não.")
	rep = gets.chomp
end
