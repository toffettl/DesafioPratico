Console.WriteLine("Digite um numero:");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite outro numero:");
double num2 = Convert.ToDouble(Console.ReadLine());


double soma = num1 + num2;
Console.WriteLine("Soma: " + soma);

double subtracao = num1 - num2;
Console.WriteLine("Subtração: " + subtracao);

double multiplicacao = num1 * num2;
Console.WriteLine("Multiplicação: " + multiplicacao);

if (num2 != 0)
{
    double divisao = num1 / num2;
    Console.WriteLine("Divisão: " + divisao);
}
else
{
    Console.WriteLine("Não é possível dividir por zero");
}

double media = (num1 + num2) / 2;
Console.WriteLine("Média: " + media);