#language: pt

Funcionalidade: Realizar umaa compra com sucesso
Eu como usuario desejo realiza uma compra
  Dado eu acesso o sitema
  E efetuo o login

Cenario: Realizando uma compra com sucesso

Dado eu acesso o site saucedemo
E desejo ordenar os produtos 'NAME Z TO A'
Quando seleciono um produto para compra
Quando eu acesso o carinho
E Realizo o checkout
Entao eu finalizo minha compra