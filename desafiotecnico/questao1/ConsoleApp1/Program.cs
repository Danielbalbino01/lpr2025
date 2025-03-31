using System;
using System.Diagnostics;
Console.WriteLine("Digite o nome do seu personagem:");
string nome = string.Concat(Console.ReadLine());
Console.WriteLine("Digite o lugar de onde ele é:");
string lugar = string.Concat(Console.ReadLine());
Console.WriteLine("Digite a idade do seu personagem:");
int idade = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o número da quantidade de redes sociais seu personagem tem:");
int redesocial = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a altura do seu personagem");
double altura = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o peso do seu personagem:");
double peso = double.Parse(Console.ReadLine());
Console.WriteLine("                                ");
Console.WriteLine($"aqui estão as informações do seu personagem:");
Console.WriteLine($"nome:{nome}");
Console.WriteLine($"idade:{idade}");
Console.WriteLine($"altura:{altura}");
Console.WriteLine($"peso:{peso}");
Console.WriteLine($"lugar de onde ele vem:{lugar}");
Console.WriteLine($"quantidade de redes sociais:{redesocial}");





