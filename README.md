# `ConomySquad`
## `*O que é o ConomySquad?`
>ConomySquad é um Software desenvolvido para gerir, armazenar e calcular finanças pessoais ou de casais, amigos, familiares, etc. 

### `Como funciona?` 
O ConomySquad funciona a partir de um App onde o usuário fará todos os registros de gastos cotidianos, ou não cotidianos em seu celular. Todos os registros serão codificados e enviados ao banco de dados que poderá ser visualizado por um Software no computador, no próprio App do Celular, ou, a partir de uma viewer DB inserida no Excel.

Os usuários acessarão o Software com login e senha, tanto no App quanto no Desktop. Cada usuário participará de um Squad, que é codificado por chave primária, hash (como código do DS). 

Todos os usuários da Squad terão acesso à carteira, onde seus ganhos serão somados, e seus saldos serão subtraídos no valor total da Squad. A regra será feita na camada de domínio, seguindo 
