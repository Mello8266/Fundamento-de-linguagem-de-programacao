//! Exercício 1
double area, b, altura;

Console.Clear();

Console.Write("Digite a base do retângulo: ");
b = double.Parse(Console.ReadLine());

Console.Write("Digite a altura do retângulo: ");
altura = double.Parse(Console.ReadLine());

area = b * altura;

Console.WriteLine($"A área do retângulo é {area}");

//! Exercício 2
double areaQuadrado, aresta;

Console.Clear();

Console.Write("Digite a aresta do quadrado: ");
aresta = double.Parse(Console.ReadLine());

areaQuadrado = aresta * aresta;

Console.WriteLine($"Área do quadrado é {areaQuadrado}");

//! Exercício 3
double diagonal, area;

Console.Clear();

Console.Write("Digite a diagonal do quadrado: ");
diagonal = double.Parse(Console.ReadLine());

area = (diagonal * diagonal) / 2;
Console.WriteLine($"A área do quadrado é: {area}");

//! Exercício 4
double baseTriangulo, alturaTriangulo, area;

Console.Clear();

Console.Write("Digite a base do triângulo: ");
baseTriangulo = double.Parse(Console.ReadLine());

Console.Write("Digite a altura do triângulo: ");
alturaTriangulo = double.Parse(Console.ReadLine());

area = (baseTriangulo * alturaTriangulo) / 2;
Console.WriteLine($"A área do triângulo é: {area}");

//! Exercício 5
double volume, diametro, pi, raio;

Console.Clear();

Console.Write("Digite o valor do diâmetro: ");
diametro = double.Parse(Console.ReadLine());

raio = diametro / 2;
pi = 3.14;

volume = (4.0/3.0) * pi * (raio * raio * raio);

Console.WriteLine("Volume da esfera é: {0:F2}", volume); 

//! Exercício 6
double v1, v2, v3, v4, media;

Console.Clear();

Console.Write("Digite o primeiro valor: ");
v1 = double.Parse(Console.ReadLine());

Console.Write("Digite o segundo valor: ");
v2 = double.Parse(Console.ReadLine());

Console.Write("Digite o terceiro valor: ");
v3 = double.Parse(Console.ReadLine());

Console.Write("Digite o quarto valor: ");
v4 = double.Parse(Console.ReadLine());

media = (v1 + v2 + v3 + v4) / 4;

Console.WriteLine("Média aritmética dos quatro valores: {0}", media);

//! Exercício 7
double cotacao, dolar, real;

Console.Clear();

Console.Write("Entre com a cotação do dólar: ");
cotacao = double.Parse(Console.ReadLine());

Console.Write("Entre com a quantidade do dólares: ");
dolar = double.Parse(Console.ReadLine());

real = dolar * cotacao;

Console.WriteLine("{0} dolares equivale a R$ {1:F2}", dolar, real);

//! Exercício 8
double item1, item2, item3, item4, item5, precoTotal, pagamento, troco;

Console.Clear();

Console.Write("Digite o valor do primeiro item: ");
item1 = double.Parse(Console.ReadLine());
Console.Write("Digite o valor do segundo item: ");
item2 = double.Parse(Console.ReadLine());
Console.Write("Digite o valor do terceiro item: ");
item3 = double.Parse(Console.ReadLine());
Console.Write("Digite o valor do quarto item: ");
item4 = double.Parse(Console.ReadLine());
Console.Write("Digite o valor do quinto item: ");
item5 = double.Parse(Console.ReadLine());

precoTotal = item1 + item2 + item3 + item4 + item5;

Console.Write("Digite o valor do pagamento: ");
pagamento = double.Parse(Console.ReadLine());

troco = pagamento - precoTotal;

Console.WriteLine("O valor do troco é: {0}", troco);
