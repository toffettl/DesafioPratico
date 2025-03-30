Console.WriteLine("Digite uma ou mais palavras:");

string input = Console.ReadLine();

string[] palavras = input.Split(' ');

foreach (string palavra in palavras)
{
    Console.WriteLine($"A palavra '{palavra}' tem {palavra.Length} caracteres.");
}