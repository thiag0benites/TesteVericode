# language: pt
Funcionalidade: Menu e formularios
	Como um usuário
	Quero navegar pelo menu
	Para preencher os formulários

Contexto: Acessar a pagina Tricentis
	Dado que eu acesse a pagina Tricentis

@test
Cenario: Valida preenchimento dos campos e preenche formularios
	Quando o [Campo] for preenchido com [Valor] invalido e exibido o [Aviso]
		| Campo               | Valor   | Aviso                                   |
		| Engine Performance  | xxx     | Must be a number between 1 and 2000     |
		| List Price          | 200     | Must be a number between 500 and 100000 |
		| Date of Manufacture | 2222222 | Must be a valid date                    |
		| Annual Mileage      | ssddd   | Must be a number between 100 and 100000 |
	E preencho os campos do formulario Enter Vehicle Data com valores validos
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
	E clico no botao Next do formulario "Enter Vehicle Data"
	E deve ser apresentado o formulario "Enter Insurant Data"
	E preencho os campos do formulario Enter Insurant Data com valores validos
		| Campo          | Valor         |
		| First Name     | Joao          |
		| Last Name      | Silva         |
		| Date of Birth  | 24/10/1988    |
		| Gender         | Male          |
		| Street Address | Rua 1         |
		| Country        | Brazil        |
		| Zip Code       | 123456        |
		| City           | Sao Paulo     |
		| Occupation     | Employee      |
		| Hobbies        | Speeding      |
		| Website        | www.teste.com |
		| Picture        | test.jpg      |
	E clico no botao Next do formulario "Enter Insurant Data"
	E deve ser apresentado o formulario "Enter Product Data"