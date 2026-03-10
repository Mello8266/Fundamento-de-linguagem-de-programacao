// ? Declaração de duas variáveis reais
//  double x, resp;
//  ? Limpar a tela
//  Console.Clear();
//  ? Exibir a mensagem para o usuário digitar um valor
//  Console.Write("Digite um valor : ");
/* Aguardar a digitação de um valor
 Converter a string digitada para o tipo double
 Armazenar o valor escolhido na variável x
*/
//  x = double.Parse(Console.ReadLine());
//  ? Calcular o dobro de x e armazenar o resultado em resp
//  resp = 2 * x;
//  ? Exibir o resultado
//  Console.WriteLine($"Dobro do valor escolhido : {resp}"); // Modo legal de usar string no print
//  ? Aguardar uma tecla, antes de encerrar o programa
//  Console.ReadKey();

// * Calculo de dias e horas vivida
int anos, dias, horas, horas_sono, dias_sono;
Console.Clear(); // ! Limpa a tela
Console.Write("Idade em anos : ");
anos = int.Parse(Console.ReadLine());

dias = anos * 365;
horas = dias * 24;
horas_sono = horas / 8;
dias_sono = horas_sono / 24;
Console.WriteLine("{0} anos de vida", anos);
Console.WriteLine("Aproximadamente {0} dias", dias);
Console.WriteLine("{0} horas! ", horas);
Console.WriteLine($"Horas dormidas aproximadamente {horas_sono}");
Console.WriteLine($"Dias dormidas aproximadamente {dias_sono}");