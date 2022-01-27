# Projeto Abstraindo um jogo de RPG usando Orientação a Objetos

Projeto com base nas aulas do bootcamp GFT Start, pela Digital Innovation One;

- Neste projeto criei a classe abstrata Character, esta não pode ser instânciada. A classe Character é a classe mãe;
- A classe mãe tem como atributos: Name, Level, Strength, Vitality e Intelligency;
- A classe mãe tem os métodos Attack e Status;
- Suas classes filhas são: Assassin, Healer, Knight e Mage, e herdam os métodos da classe mãe;
- As classes filhas sobrescrevem os métodos da classe mãe, fazendo uso do polimorfismo;
- As classes filhas possuem seus próprios atributos, que geram os valores de HP, MP e dão bônus de acordo com a classe(cavaleiro, mago...);
- As classes Knight e Assasin, em seu método Attack(), fazem uso do encapsulamento, onde aleatóriamente realizam ações específicas como bloquear um golpe ou causar dano crítico. O usuário só precisa chamar o método.
- A Classe Healer possui o método Heal() que não é herança da classe mãe.


----

# O que é um objeto no mundo real?

No mundo real um objeto pode ser uma garrafa plástica, por exemplo.
Este objeto tem suas características e funções.

----

# O que é um objeto para um computador

Já para a máquina a garrafa também é um objeto, mas pessoas também são objetos. Na realidade, tudo que vamos representar do mundo real no código, será tratado com um objeto, tendo suas características e funções.

----

# O que é uma classe?

Classes são como uma forma, ou seja, ela é um molde para criar determinado objeto. Vamos supor a Classe chamada FormaDeBolo, a partir dela é possivel criar objetos diferentes mas que possuem um padrão de caracteristícas. Se a forma é retangular, todo bolo vai ser retangular, mas é possível fazer bolo de cenoura, bolo de limão, bolo de chocolate, etc...

Ou seja o bolo é um objeto, instanciado a partir da classe FormadeBolo

-----

# O que é uma propriedade?

Propriedades são as caracteristicas que declaramos dentro das classes, por exemplo: Uma Classe Pessoa, pode ter como atributos/propriedades altura, peso... mas devemos trazer para nossa classe somente o que é relevante para o projeto. Neste caso, um cadastro de clientes deveria contar com Nome, Sobrenome, CPF... propriedades ue de fato serão relevantes ao uso do programa em questão

----

# 1 - Abstração

A abstração é um dos 4 pilares da orientação objetos. É a maneira de se representar algo de modo genérico para que possa ser reaproveitado posteriormente.

- Criar 'forma' de alguma coisa do mundo real;
- Propriedades;
- Métodos.

---

# 2 - Herança

Herança é um dos 4 pilares da orientação a objetos.

- Herda comportamentos da classe mãe (super/classe)

Para fazer a herança deve se utilizar : e o nome da classe mãe

Ex.:

    public class ClasseFilha : ClasseMae

----

# 3 - Polimorfismo

É um dos 4 pilares da orientação a objetos.

- Muitas formas para mesma coisa

Utilizamos para alterar a forma que um método herdado por uma classe filha se comporta.

Utilizamos o termo 'virtual' no método da classe mãe e 'override' no da classe filha

Ex.:

    public class ClasseMae{
        public virtual string Apresentar()
        {
            Console.WriteLine("Olá sou a classe mãe");
        }
    }

        public class ClasseFilha : ClasseMae{
        
        public override string Apresentar()
        {
            Console.WriteLine("Olá sou a classe filha");
        }
    }

Também é possível fazer polimorfismo através de sobrecarga.
A sobrecarga é você reescrever um método já existente na classe mãe, mas que pode recerber diferentes parâmetros. 

# 4 - Encapsulamento

- Criar um efeito de capsula: fácil consumo de algo concentrado (no caso regras de negócio);