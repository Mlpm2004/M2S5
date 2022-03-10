using ClassExercicios.Entidades;
/*
Exercício 2

Fornecedor f1 = new Fornecedor("Mauro","48999476799","Rua Olinda 555",1000.00,250.00);
Fornecedor f2 = new Fornecedor("Kudegundes", "48999476799", "Plastex 555", 10000.00, 7500.00);
Fornecedor f3 = new Fornecedor("Jacinto", "48999476799", "Aquino 555", 3000.00, 2500.00);
Console.WriteLine(f1.Nome + " - " + f1.ObterSaldo().ToString());
Console.WriteLine(f2.Nome + " - " + f2.ObterSaldo().ToString());
Console.WriteLine(f3.Nome + " - " + f3.ObterSaldo().ToString());

*/

/*
Exercício 3

Empregado e1 = new Empregado("Mauro","48999476799","Rua Olinda 555",1000,20);
Empregado e2 = new Empregado("Kudegundes", "48999476799", "Plastex 555", 10000,15);
Empregado e3 = new Empregado("Jacinto", "48999476799", "Aquino 555", 3000, 25);
Console.WriteLine(e1.Nome + " - " + e1.CalcularSalario().ToString());
Console.WriteLine(e2.Nome + " - " + e2.CalcularSalario().ToString());
Console.WriteLine(e3.Nome + " - " + e3.CalcularSalario().ToString());

*/

/*
Exercício 4

Administrador a1 = new Administrador("Mauro","48999476799","Rua Olinda 555",1000,20,250);
Console.WriteLine(a1.Nome + " - " + a1.CalcularSalario(a1.AjudadeCusto).ToString());
*/

/*
Exercício 5

Operario o1 = new Operario("Mauro","48999476799","Rua Olinda 555",1000,20,100000, 1);
Console.WriteLine(o1.Nome + " - " + o1.CalcularSalario(o1.ValorProducao * (o1.Comissao / 100)).ToString());
*/


/*
Exercício 6

Vendedor v1 = new Vendedor("Mauro","48999476799","Rua Olinda 555",1000,20,100000, 1);
Console.WriteLine(v1.Nome + " - " + v1.CalcularSalario(v1.ValorVendas * (v1.Comissao / 100)).ToString());

*/

/*
 * 
Exercício 7

Cachorro cao = new("Atila",8);
Console.WriteLine(cao.Nome+" - "+cao.Som+" - "+cao.Movimento);
Cavalo c = new( "Veloz", 8);
Console.WriteLine(c.Nome + " - " + c.Som + " - " + c.Movimento);
Preguica p = new( "Lerdo", 8);
Console.WriteLine(p.Nome + " - " + p.Som + " - " + p.Movimento);
*/

/*
Exercício 8


CriaAnimal animais =new CriaAnimal();
animais.CriaAnimais();
*/
/*
Exercício 9


Cachorro cao = new( "Atila", 8);
Console.WriteLine(cao.Nome + " - " + cao.Som + " - " + cao.Movimento);
Cavalo c = new( "Veloz", 8);
Console.WriteLine(c.Nome + " - " + c.Som + " - " + c.Movimento);
Preguica p = new( "Lerdo", 8);
Console.WriteLine(p.Nome + " - " + p.Som + " - " + p.Movimento);
Veterinario v = new Veterinario();
Console.WriteLine("Ao examinar o Animal " + v.Examinar(cao));
Console.WriteLine("Ao examinar o Animal " + v.Examinar(c));
Console.WriteLine("Ao examinar o Animal " + v.Examinar(p));
*/
/*
Exercício 10
*/

Jaulas animais = new ();
animais.Jaula();


/*

Exercício 1

Crie uma Classe Pessoa, contendo os atributos encapsulados, com seus respectivos seletores (_getters_) e modificadores (_setters_), e ainda o construtor padrão e pelo menos mais duas opções de construtores conforme sua percepção. 

**Atributos**: String nome; String endereço; String telefone;
*
Exercício 2

Considere, como subclasse da classe Pessoa (desenvolvida no exercício anterior) a classe Fornecedor. 

Considere que cada instância da classe **Fornecedor** tem, para além dos atributos que caracterizam a classe Pessoa, os atributos _valorCredito_ (correspondente ao crédito máximo atribuído ao fornecedor) e _valorDivida_ (montante da dívida para com o fornecedor). 

Implemente na classe Fornecedor, para além dos usuais métodos seletores e
modificadores, um método **Fornecedor**() que devolve a diferença entre os valores dos atributos _valorCredito_ e _valorDivida_. 

Depois de implementada a classe **Fornecedor**, crie um programa de teste adequado que lhe permita verificar o funcionamento dos métodos implementados na classe Fornecedor e os herdados da classe Pessoa.

Exercício 3

Considere, como subclasse da classe **Pessoa**, a classe **Empregado**. 

Considere que cada instância da classe **Empregado** tem, para além dos atributos que caracterizam a classe **Pessoa**, os atributos:

-  _codigoSetor_ (inteiro),
- _salarioBase_ (vencimento base)
-  _imposto_ (porcentagem retida dos impostos). 

Implemente a classe **Empregado**  com métodos seletores e modificadores e um método _calcularSalario_. 

Escreva um programa de teste adequado para a classe **Empregado**.

Exercício 4

Implemente a classe **Administrador** como subclasse da classe **Empregado**. 

Um determinado administrador tem como atributos, para além dos atributos da classe **Pessoa** e da classe **Empregado**, o atributo _ajudaDeCusto_ (ajudas referentes a viagens, estadias, ...). 

Note que deverá redefinir na classe Administrador o método herdado
_calcularSalario_ (o salário de um administrador é equivalente ao salário de um empregado usual acrescido das ajuda de custo). 

Escreva um programa de teste adequado para esta classe.

Exercício 5

Implemente a classe **Operario** como subclasse da classe **Empregado**. 

Um determinado operário tem como atributos, para além dos atributos da classe **Pessoa** e da classe **Empregado**, os atributos:

-  _valorProducao_ (que corresponde ao valor monetário dos artigos efetivamente produzidos pelo operário)
-  _comissao_ (que corresponde à porcentagem do valorProducao que será adicionado ao vencimento base do operário). 

Note que deverá redefinir nesta subclasse o método herdado _calcularSalario_ (o salário de um operário é equivalente ao salário de um empregado usual acrescido da referida comissão). 

Escreva um programa de teste adequado para esta classe.

Exercício 6

Implemente a classe **Vendedor** como subclasse da classe **Empregado**. 

Um determinado vendedor tem como atributos, para além dos atributos da classe **Pessoa** 
e da classe **Empregado**, o atributo _valorVendas_ (correspondente ao valor monetário dos 
artigos vendidos) e o atributo _comissao_ (porcentagem do valorVendas que será adicionado 
ao vencimento base do Vendedor). 

Note que deverá redefinir nesta subclasse o método herdado _calcularSalario_ (o salário de 
um vendedor é equivalente ao salário de um empregado usual acrescido da referida comissão). 

Escreva um programa de teste adequado para esta classe.

Exercício 7

Crie uma hierarquia de classes conforme abaixo com os seguintes atributos e
comportamentos (observe a tabela), utilize os seus conhecimentos e distribua 
as características de forma que tudo o que for comum a todos os animais fique na 
classe Animal 

Exercício 8

Implemente um programa que crie os 3 tipos de animais definidos no exercício anterior 
e invoque o método que emite o som de cada um de forma polimórfica, isto é, independente 
do tipo de animal.

Exercício 9

Implemente uma classe Veterinario que contenha um método examinar() cujo
parâmetro de entrada é um Animal, quando o animal for examinado ele deve 
emitir um som, passe os 3 animais com parâmetro.

Exercício 10

Crie uma classe Zoologico, com 10 jaulas (utilize um array) coloque em cada 
jaula um animal diferente, percorra cada jaula e emita o som e, se o tipo de
animal possuir o comportamento, faça-o correr.
*/