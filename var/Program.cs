using System.Reflection.Metadata;
using System.Threading.Tasks.Dataflow;
Console.Clear();
string nome = "Erik";
string sobrenome = "Sabino";

Console.Write($"{nome.PadRight(11, '.')}: ");
nome = Console.ReadLine();
Console.Write($"{sobrenome.PadRight(11, '.')}: ");
sobrenome = Console.ReadLine();
Console.WriteLine($"Meu nome é {nome} {sobrenome}");

// Console.Write("meu nome é ");
// Console.Write(nome);
// Console.Write(" ");
// Console.WriteLine(sobrenome);



