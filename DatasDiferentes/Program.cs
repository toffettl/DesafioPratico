DateTime dataAtual = DateTime.Now;

Console.WriteLine("Data completa: " + dataAtual.ToString("dddd, dd 'de' MMMM 'de' yyyy HH:mm:ss"));

Console.WriteLine("Data (dd/MM/yyyy): " + dataAtual.ToString("dd/MM/yyyy"));

Console.WriteLine("Hora (HH:mm): " + dataAtual.ToString("HH:mm"));

Console.WriteLine("Data com mês por extenso: " + dataAtual.ToString("dd 'de' MMMM 'de' yyyy"));