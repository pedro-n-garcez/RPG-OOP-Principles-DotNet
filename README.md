# RPG: OOP Principles in DotNet
#### Demonstração de princípios de Programação Orientada a Objeto (POO). Feito para o desafio de projeto da DIO "Abstraindo um Jogo de RPG Usando Orientação a Objetos com C#" de https://github.com/felipeAguiarCode

## O que é o projeto
#### Este projeto demonstra os princípios de POO por meio de abstração de conceitos de um jogo de RPG.
#### O projeto usa os conceitos de herança, encapsulamento, polimorfismo e abstração para criar uma Console Application com personagens de RPG e um exemplo de batalha contra um inimigo.

## Princípios de POO
1. Herança: nesta implementação, uma classe abstrata ```Character``` serve de base mãe para as bases filhas ```Hero``` e ```Enemy```. Da classe ```Hero``` derivam as classes de tipos mais específicos de heróis, ```Wizard```, ```Knight``` e ```Ninja```.
2. Encapsulamento: Cada classe concentra as regras de negócio específicas à elas. A classe ```Inventory```, por exemplo, possui variáveis e métodos que implementam as regras que pertencem ao propósito da classe. A classe esconde a implementação do usuário, facilitando o seu uso por meio de seus métodos.
3. Polimorfismo: Funções e métodos possuem mais de uma forma. Na classe ```Character``` e suas classes filhas, por exemplo, há polimorfismo do método ```Attack()```, que é sobrescrita nas classes filhas e também sobrecarregado com ```Attack(int index)```, que recebe um parâmetro para indicar o item do inventório a ser usado.
4. Abstração: Abstrair a ideia de conceitos como Hero e Inventory de um jogo de RPG e implementá-los como classes que servem como uma "fôrma" para objetos do tipo. Cada classe tem campos e variáveis que representam parâmetros de um personagem, inventório etc., e métodos que representam possíveis ações a serem tomadas por objetos instanciados da classe.
