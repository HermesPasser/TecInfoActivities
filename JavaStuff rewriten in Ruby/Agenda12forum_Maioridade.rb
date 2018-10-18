def calculaIdade(atual, nasc)
	if nasc < 18
		puts "Você é menor de idade, sua idade é #{nasc - atual}"
	else
		puts "Você é maior de idade, sua idade é #{nasc - atual}"
	end
end


puts "Digite o ano em que você nasceu: "
nasc = gets.chomp

puts "Digite o ano atual: "
atual = gets.chomp

calculaIdade(nasc.to_i, atual.to_i)
