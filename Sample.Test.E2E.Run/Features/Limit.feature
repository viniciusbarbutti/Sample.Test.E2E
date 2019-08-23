# language: pt-br

Funcionalidade: Limite

Cenário: Alteracao do limite do usuario ao realizar uma operacao financeira 
	Dado que possua um limite inicial de "500000" reais
	Quando realizo uma operacao financeira de "1000000" reais
	Entao o meu novo limite deve ser "1500000" reais
