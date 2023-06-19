# ***Documentação da API***
Esta é a documentação da API do Chapter. Aqui você encontrará informações sobre os endpoints disponíveis, bem como os parâmetros e respostas correspondentes.

# Autenticação
## *Método HTTP*
GET
## *Parâmetros de entrada*

| Parâmetro | Tipo   | Descrição        |
| --------- | ----   | ----------       |
| email     | string | email do usuário |
| senha     | string | Senha do usuário |

#
# Livros
## **Listar livros**
Retorna uma lista de todos os livros cadastrados.
## *Método HTTP*
GET
## **Buscar livro por ID**
Retorna as informações de um livro específico com base no ID fornecido.
## *Método HTTP*
GET
## *Parâmetros de entrada*

| Parâmetro | Tipo | Descrição   |
|-----------|------|-------------|
| id        | int  | ID do livro |

## **Cadastrar livro**
Cadastra um novo livro.
## *Método HTTP*
POST
## *Parâmetros de entrada*
Os parâmetros devem ser enviados no corpo da solicitação em formato JSON.

|Parâmetro        |Tipo	 |Descrição                     |
|-----------------|------|---------------               |
|Titulo           |string|Título do livro               |
|QuantidadePaginas|int   |Quantidade de páginas do livro|
|Disponivel       |bool	 |Disponibilidade do livro      |

## *Resposta de sucesso*
Caso o cadastro seja bem-sucedido, a resposta será o código de status *"201 Created"*.
## **Excluir livro**
Exclui um livro com base no ID fornecido.
## *Método HTTP*
DELETE
## *Parâmetros de entrada*

|Parâmetro|Tipo|Descrição  |
|---------|----|---------  |
|id       |int |ID do livro|

## *Resposta de sucesso*
Caso a exclusão seja bem-sucedida, a resposta será uma mensagem de sucesso.
*"Livro exluido com sucesso!"*
## **Atualizar livro**
Atualiza as informações de um livro específico com base no ID fornecido.
## *Método HTTP*
PUT
## *Parâmetros de entrada*
Os parâmetros devem ser enviados no corpo da solicitação em formato JSON.

|Parâmetro       |Tipo  |Descrição                          |
|----------------|------|-----------------------------------|
|Titulo          |string|Novo título do livro               |
QuantidadePaginas|int	|Nova quantidade de páginas do livro|
Disponivel       |bool  |Nova disponibilidade do livro      |

## *Resposta de sucesso*
Caso a atualização seja bem-sucedida, a resposta será o código de status *"204 No Content"*.
# Usuários
## **Listar usuários**
Retorna uma lista de todos os usuários cadastrados.
## *Método HTTP*
GET
## *Resposta de sucesso*
Caso a solicitação seja bem-sucedida, a resposta será um objeto JSON contendo a lista de usuários.
## **Buscar usuário por ID**
Retorna as informações de um usuário específico com base no ID fornecido.
## *Método HTTP*
GET
## *Parâmetros de entrada*

|Parâmetro|Tipo|Descrição    |
|---------|----|-------------|
|id       |int |ID do usuário|

## *Resposta de sucesso*
Caso a solicitação seja bem-sucedida e o usuário seja encontrado, a resposta será um objeto JSON contendo as informações do usuário.
## **Cadastrar usuário**
Cadastra um novo usuário.
## *Método HTTP*
POST
## *Parâmetros de entrada*
Os parâmetros devem ser enviados no corpo da solicitação em formato JSON.

|Parâmetro|Tipo  |Descrição                     |
|---------|------|------------------------------|    
Email     |string|E-mail do usuário             |
Senha     |string|Senha do usuário              |
Tipo      |string|Tipo de usuário (admin/normal)|

## *Resposta de sucesso*
Caso o cadastro seja bem-sucedido, a resposta será o código de status "201 Created".
## **Excluir usuário**
Exclui um usuário com base no ID fornecido.
## *Método HTTP*
DELETE
## *Parâmetros de entrada*

|Parâmetro|Tipo|Descrição    |
|---------|----|-------------|
|id       |int |ID do usuário|

## *Resposta de sucesso*
Caso a exclusão seja bem-sucedida, a resposta será uma mensagem de sucesso.
*"usuário removido com sucesso!"*
## **Atualizar usuário**
Atualiza as informações de um usuário específico com base no ID fornecido.
## *Método HTTP*
PUT
## *Parâmetros de entrada*
Os parâmetros devem ser enviados no corpo da solicitação em formato JSON.

|Parâmetro|Tipo  |Descrição             |
|---------|------|----------------------|
|Email    |string|Novo e-mail do usuário|
|Senha    |string|Nova senha do usuário |
|Tipo     |string|Novo tipo de usuário  |

## *Resposta de sucesso*
Caso a atualização seja bem-sucedida, a resposta será uma mensagem de sucesso.
*"Atualizado com sucesso"*
















