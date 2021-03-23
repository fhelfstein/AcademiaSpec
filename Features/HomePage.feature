#language: pt
Funcionalidade: HomePage

Cenário: AbrirProduto
	Dado que o usuário esta na homePage
	Quando Clicar em um produto
	Então deverá ser exibido os detelhes do produto

Esquema do Cenário: BuscarItem
	Dado que o usuário esta na homePage
	Quando Realizar uma busca por "<termo>"
	E Clicar em um produto
	Então deverá ser exibido os detelhes do produto

	Exemplos: 
	| termo   |
	| blouse  |
	| t-shirt |
	| skirt   |
	| dress   |