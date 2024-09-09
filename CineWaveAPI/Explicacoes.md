## INTEGRANTES DO GRUPO:
	- Alberto R. Peruchi – RM99706 -  2TDSR
	- Angelo Augusto Pelluci - RM98310 - 2TDSR
	- Gabrielle da Silva Stanguini RM98786 - 2TDSA
	- Maria Fernanda Ribeiro Melo RM98818 - 2TDSA
	- Nicolas Reis do Espírito Santo RM98819 - 2TDSA


## EXPLÇICAÇÃO DA ARQUITETURA ESCOLHIDA: 
	Optei pela arquitetura monolítica por ser mais simples de implementar e gerenciar em projetos menores ou em fase inicial. 
	Ela permite um desenvolvimento mais rápido, já que todas as funcionalidades estão centralizadas, facilitando o gerenciamento e o debugging. 
	Além disso, como estou em fase de aprendizado, a arquitetura monolítica oferece uma visão clara da aplicação como um todo, o que me ajuda a consolidar conceitos 
	antes de migrar para estruturas mais complexas, como microserviços


## DIFERENÇA ENTRE MONOLITICA X MICROSERVICES:

	A arquitetura monolítica consiste em um único aplicativo onde todas as funcionalidades e componentes
	(como interface de usuário, lógica de negócios e banco de dados) estão centralizados e interligados em uma única unidade de código

	A arquitetura de microservices divide uma aplicação em serviços menores e independentes, 
	onde cada serviço é responsável por uma funcionalidade específica e se comunica com outros serviços via API, geralmente usando HTTP/REST, gRPC ou mensageria.


## DESIGN PARTTERN UTILIZADOS
	- Repository Patter
	- Dependency Injection


## OQUE FOI IMPLEMENTADO?
	- CRUD do usuário