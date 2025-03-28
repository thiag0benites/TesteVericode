# language: pt
Funcionalidade: Formulario Enter Vehicle Data
	Como um usuário
	Quero preencher o formulário Enter Vehicle Data
	Para que eu possa avançar para a próxima etapa

Contexto: Acessar a pagina Tricentis
	Dado que eu acesse a pagina Tricentis

@test
Cenario: Valida layout do formulario
	Quando acessar a pagina Tricentis
	Entao o formulario Enter Vehicle Data deve ser exibido com os campos unicos
		| Make | Model | Cylinder Capacity [ccm] | Engine Performance [kW] | Date of Manufacture | Number of Seats | Right Hand Drive | Fuel Type | Payload [kg] | Total Weight [kg] | List Price | License Plate Number | Annual Mileage [km] |