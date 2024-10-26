Feature: As regras de criacao das entidades do dominio devem ser respeitadas
    Caso os valores informados estejam incorretos, excecoes devem ser lancadas.

	Scenario: Cadstro com Email informado invalido
		Given Tentativa de criar objeto da entidade
		When alocado Email errado
		Then excecao gerada

	Scenario: Cadstro com CPF informado invalido
		Given Tentativa de criar objeto da entidade
		When alocado CPF errado
		Then excecao gerada

