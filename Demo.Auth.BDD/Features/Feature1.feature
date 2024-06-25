Feature: Creación de una cuenta digital
	Como usuario
	Quiero crear una cuenta digital
	Para poder acceder a los servicios digitales

@tag1
Scenario: Crear una cuenta digital con la identificación del cliente
	Given La página de registro de cuenta 
	And los Datos del cliente [<nombre>, <apellidos>, <dni>, <email>, <teléfono>]
	When pulson sobre el boton de Crear cuenta
	Then Cuenta digital creada

Examples: 
	| nombre | apellidos | dni       | email            | teléfono   |
	| Juan   | Pérez     | 12345678A | jperez@banco.com | 0986533325 |
