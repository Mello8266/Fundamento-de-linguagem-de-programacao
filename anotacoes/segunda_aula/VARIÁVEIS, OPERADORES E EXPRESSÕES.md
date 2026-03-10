## Básico
C# é case Sensitive, ou seja, a palavra em maiúscula não é a mesma coisa que ela em minuscula

## Memória
### Memória permanente
Onde fica armazenado os programas do computador.
HD, SSD, NVME, etc.

### RAM
Todo processamento é feito na memória Ram. 
Ela é uma memória volátil para processar o trabalho, conhecida como memória principal. 

Ela puxa uma cópia da memória permanente para processar na memória

Ao desligar o computador, os dados da memória ram são excluídos.

#### Bytes
Cada unidade de memória ram tem 17 bytes, sendo um carácter (letra, símbolo, número) por byte.
Cada byte tem 8 bits

Cada byte tem um endereço especifico para o computador encontrar e recuperar os dados que estão armazenadas. Cada memória é indexada

##### bits
Menor medida de memória

### Compilador
É um software de tradução do código em alto nível para baixo nível

#### Tabela ASCII
Computador converter letras para binário por meio de uma tabela, a ASCII. Ela é uma tabela necessária para fazer uma tradução do carácter para binário.

### Operadores
#### Operador de incremento
`int x = 1;
`x++;` - sufixo
`++x;` - prefixo

#### Operador decremento
`int y = 5;`
`y = y - 1;`
`y--;`
`--y;`

### Formas de usar
`int l = 10;`
`l /= 2;`
`l += 4;`
`l *= 2;`

#### Loucura do C\#
`int x = 5;`
`int y = x++ * 2;` 
	- y vai valer 10. Nesse caso, o compilador ignora o incremento do tipo sufixo

`int y = ++x * 2;`
	- Agora y vai valer 12, pois o compilador não ignora o incremento prefixo.