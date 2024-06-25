Feature: Creación de una cuenta digital
	Como usuario
	Quiero crear una cuenta digital
	Para poder acceder a los servicios digitales

Background:
	Given que estoy en la página de de creación de cuenta digital

@tag1
Scenario: Crear una cuenta digital con la identificación del cliente
	And los Datos del cliente '<Nombre>' ,'<Apellido>', '<FechaNacimiento>'
	When pulso sobre el boton de Crear cuenta
	Then Cuenta digital creada

Examples: 
	| Nombre | Apellido | FechaNacimiento | 
	| Juan   | Parra    |	25.06.1980    |
	| Maria  | Perez    |	25.06.1980    |
	| Pedro  | Gomez    |	25.06.1980    |

Scenario Outline: Error Crear una cuenta digital con la identificación del cliente ya que no existe
	And los Datos del cliente  '<Identificación>'
	When pulso sobre el boton de Crear cuenta
	Then Error cliente no existe

Examples:
	| Identificación |
	| 1718586952     |
	| 1718586953     |
	| 1718586954     |