# language: pt-br

Funcionalidade: Limite Carteira

@cenario1
Cenário: Alteracao do limite carteira do usuario ao realizar uma operacao de venda de ativo 
	Dado que eu possua um limite carteira de "50000" reais
	Quando eu realizar uma operacao de venda do valor de "10000" reais
	Entao o meu novo limite carteira deve ser "40000" reais