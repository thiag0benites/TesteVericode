# language: pt
Funcionalidade: Formulario Enter Vehicle Data
	Como um usuário
	Quero preencher o formulário Enter Vehicle Data
	Para que eu possa avançar para a próxima etapa

Contexto: Acessar a pagina Tricentis
	Dado que eu acesse a pagina Tricentis

@test
Cenario: Valida preenchimento dos campos e preenche formulario
	Quando o [Campo] for preenchido com [Valor] invalido e exibido o [Aviso]
		| Campo               | Valor   | Aviso                                   |
		| Engine Performance  | xxx     | Must be a number between 1 and 2000     |
		| List Price          | 200     | Must be a number between 500 and 100000 |
		| Date of Manufacture | 2222222 | Must be a valid date                    |
		| Annual Mileage      | ssddd   | Must be a number between 100 and 100000 |
	E preencho os campos com valores validos
		| Campo						 | Valor      |
		| Make                       | Honda      |
		| Model                      | Scooter    |
		| Cylinder Capacity          | 100        |
		| Engine Performance         | 100        |
		| Date of Manufacture        | 03/24/2025 |
		| Number of Seats            | 1          |
		| Right Hand Drive		     | Yes        |
		| Number of Seats Motorcycle | 1          |
		| Fuel Type                  | Gas        |
		| Payload                    | 100        |
		| Total Weight               | 400        |
		| List Price                 | 20000      |
		| License Plate Number       | 123456     |
		| Annual Mileage             | 10000      |
	E clico no botao Next
	Entao deve ser apresentado o formulario "Enter Insurant Data"