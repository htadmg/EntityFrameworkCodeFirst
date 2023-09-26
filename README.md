# EntityFrameworkCodeFirst

# Projeto MVC

Este projeto implementa um sistema de gerenciamento de clientes usando o padrão MVC (Model-View-Controller) no ASP.NET.

## Estrutura do Projeto

O projeto consiste em três partes principais:

### 1. Model: Cliente

A classe `Cliente` representa um cliente e possui os seguintes atributos:

- `Id`: Identificador único do cliente.
- `Nome`: Nome do cliente.
- `Telefone`: Número de telefone do cliente.
- `CPF`: Número do CPF do cliente.

### 2. Controller: ClientesController

A classe `ClientesController` é um controlador que gerencia as ações relacionadas aos clientes. Ela inclui métodos para listar, visualizar, criar, editar e excluir clientes. Além disso, possui um contexto de banco de dados `MVCContext` para interagir com a base de dados.

### 3. Context: MVCContext

A classe `MVCContext` é uma extensão do DbContext do Entity Framework e define o conjunto de dados para os clientes.

## Utilização

O controlador `ClientesController` é responsável por lidar com as operações relacionadas aos clientes. Abaixo estão algumas das ações disponíveis:

- `Index`: Lista todos os clientes cadastrados.
- `Details`: Exibe os detalhes de um cliente específico.
- `Create`: Cria um novo cliente.
- `Edit`: Edita as informações de um cliente existente.
- `Delete`: Exclui um cliente.

Para usar este projeto, siga os passos abaixo:

1. Configure o banco de dados e a conexão no contexto `MVCContext`.
2. Execute o projeto e acesse as diferentes ações do controlador através da interface.

## Observações

Certifique-se de configurar corretamente a conexão com o banco de dados no contexto `MVCContext`. Além disso, personalize as visões (Views) conforme necessário para atender aos requisitos específicos do seu aplicativo.

Este é um projeto básico de exemplo e pode ser expandido conforme necessário para atender aos requisitos específicos do seu aplicativo.

