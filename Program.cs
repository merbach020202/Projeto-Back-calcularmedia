// Console.WriteLine("Digite sua idade: ");
// int idade = int.Parse(Console.ReadLine());

// int meses = idade * 12;
// int dias = idade * 365;
// int horas = dias * 24;
// int minutos = horas * 60;

// Console.WriteLine($"Sua idade corresponde a: {idade} anos, ou {meses} meses, ou {dias} dias, ou {horas} horas, ou {minutos} minutos!");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Digite sua nota 1: ");
float nota1 = float.Parse(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Digite sua nota 2: ");
float nota2 = float.Parse(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Digite sua nota 3: ");
float nota3 = float.Parse(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Digite sua nota 4: ");
float nota4 = float.Parse(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Digite sua nota 5: ");
float nota5 = float.Parse(Console.ReadLine());
Console.ResetColor();

float média = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;

Console.WriteLine($"Sua média foi de: {média}");












