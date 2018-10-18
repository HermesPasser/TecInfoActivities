class ContaDados
	def initialize(name, saldo)
		@nome_cliente = name
		@saldo = saldo
	end
	
	def exibir_nome
		@nome_cliente
	end
	
	def mostrar_saldo
		@saldo
	end
end

conta1 = ContaDados.new("Pedro", 2500)
puts "O nome do cliente é #{conta1.exibir_nome}" 
puts "O saldo do cliente é #{conta1.mostrar_saldo}" 
