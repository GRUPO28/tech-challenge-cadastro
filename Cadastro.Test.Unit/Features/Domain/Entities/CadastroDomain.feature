Feature: As regras de criacao das entidades do dominio devem ser respeitadas
    Caso os valores informados estejam incorretos, excecoes devem ser lancadas.

	Scenario: Cadastro com Email informado invalido
		Given tentativa de criar objeto da entidade
		When alocado Email errado
		Then excecao gerada



