# **Requisitos da Aplicação - ConomySquad**

Voltar ao **[Início](../Readme.md)** 

## **Usuário**

- O `usuário` **deve** possuir um id
- O `usuário` **deve** conter um nome
- O `usuário` **deve** conter um e-mail
- O `usuário` **deve** conter um login
- O `usuário` **deve** conter uma senha
- O `usuário` **pode** informar seus `movimentos`
- O `usuário` **pode** enviar uma `interação` ao `grupo`
- O `usuário` **pode** consultar seus `movimentos` ou `metas`
- O `usuário` **deve** estar em um `grupo`
- O `usuário` **pode** estar em mais de um `grupo`
- O `usuário` **pode** ser um `líder` do `grupo`
- O `usuário` **deve** possuir suas devídas `permissões` no `grupo` 

## **Líder : Usuário**

- O `líder` **pode** definir novas metas no `grupo`
- O `líder` **pode** adicionar ou remover `usuários` do `grupo`
- O `líder` **pode** alterar configurações do `grupo`
- O `líder` **pode** alterar `permissões` do `usuário`
- O `líder` **pode** informar um `movimento` no `grupo` de outro `usuário`  

## **Grupo**

- O `grupo` **deve** possuir um id
- O `grupo` **deve** possuir um nome
- O `grupo` **deve** conter uma ***timeline*** com as respectivas `interações` dos `usuários` e `metas` do `grupo`
- O `grupo` **deve** conter mais de um `usuário`
- O `grupo` **pode** conter mais de um `líder`
- O `grupo` **deve** conter uma `meta`
- O `grupo` **pode** conter mais de uma `meta`

## **Interação**
- A `interação` **deve** possuir um id
- A `interação` **deve** possuir um `usuário` como responsável
- A `interação` **deve** possuir uma descrição
- A `interação` **pode** mencionar outros usuário
- A `interação` **pode** possuir um id

## **Movimento : Interação**
- O `movimento` **deve** possuir um **valor**
- O `movimento` **não pode** possuir valor zerado
- O `movimento` **pode** possuir uma descrição

## **Comentario : Interação**
- O `comentário` **deve** possuir uma descrição
 
## **Metas**
- A `meta` **deve** possuir um id




