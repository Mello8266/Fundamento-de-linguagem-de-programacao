Console.Clear();

//! Exercicio 1
double media, valor1, valor2;

Console.Write("Digite o primeiro valor: ");
valor1 = double.Parse(Console.ReadLine());

Console.Write("Digite o segundo valor: ");
valor2 = double.Parse(Console.ReadLine());

media = Math.Sqrt(valor1 * valor2);

Console.WriteLine("A média geométrica é {0}", media);
Console.ReadKey();

//! Exercicio 2
double milhasMaritimas, km, milhasToMetro;

milhasToMetro = 1852; 

Console.Write("Digite o valor das milhas maritímas: ");
milhasMaritimas = double.Parse(Console.ReadLine());

km = (milhasMaritimas * milhasToMetro) / 1000;

Console.WriteLine("{0} milhas maritímas equivalem a {1} km", milhasMaritimas, km);
Console.ReadKey();

//! Exercicio 3
double celsius, fahrenheit;

Console.Write("Digite a temperatura em celsius: ");
celsius = double.Parse(Console.ReadLine());

fahrenheit = (celsius * 9.0/5) + 32;

Console.WriteLine("{0}ºC equivalem a {1}ºF", celsius, fahrenheit);
Console.ReadKey();

//! Exercicio 4
double diametro, raio, area, pi;

Console.Write("Digite o diâmetro do círculo: ");
diametro = double.Parse(Console.ReadLine());

raio = diametro / 2;

area = Math.PI * Math.Pow(raio, 2);

Console.WriteLine("A área do círculo é {0:F2}", area);
Console.ReadKey();

//! Exercicio 5
double altura, raioBase, volume;

Console.Write("Digite a altura do cone: ");
altura = double.Parse(Console.ReadLine());

Console.Write("Digite o raio da base do cone: ");
raioBase = double.Parse(Console.ReadLine());

volume = (1.0/3 * Math.PI * Math.Pow(raioBase, 2) * altura );

Console.WriteLine("O volume do cone é {0:F2}", volume);
Console.ReadKey();

//! Exercicio 6
double velocidade_inicial, aceleracao, tempo, velocidade_final;

Console.Write("Digite a velocidade inicial: ");
velocidade_inicial = double.Parse(Console.ReadLine());

Console.Write("Digite a aceleração: ");
aceleracao = double.Parse(Console.ReadLine());

Console.Write("Digite o tempo do percurso: ");
tempo = double.Parse(Console.ReadLine());

velocidade_final = (velocidade_inicial + aceleracao * tempo) * 3.6;

Console.WriteLine("Velocidade final é de {0:F2}", velocidade_final);
Console.ReadKey();
