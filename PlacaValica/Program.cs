Console.Write("Digite a placa do veículo: ");
string placa = Console.ReadLine();

if (placa.Length == 7)
{
    bool primeiroCondicao = char.IsLetter(placa[0]) && char.IsLetter(placa[1]) && char.IsLetter(placa[2]);

    bool segundaCondicao = char.IsDigit(placa[3]) && char.IsDigit(placa[4]) && char.IsDigit(placa[5]) && char.IsDigit(placa[6]);

    if (primeiroCondicao && segundaCondicao)
    {
        Console.WriteLine("Placa válida!");
    }
    else
    {
        Console.WriteLine("Placa inválida!");
    }
}
else
{
    Console.WriteLine("A placa deve conter 7 caracteres alfanuméricos");
}

