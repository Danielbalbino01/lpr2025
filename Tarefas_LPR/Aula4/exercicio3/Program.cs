using System;

        Console.WriteLine("Escolha uma classe de personagem:");
        Console.WriteLine("1 - Guerreiro");
        Console.WriteLine("2 - Mago");
        Console.WriteLine("3 - Arqueiro");

        int escolha = int.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 1:
                Console.WriteLine("\nHabilidades da Guerreiro:");
                Console.WriteLine("1. Ataque Pesado");
                Console.WriteLine("2. Defesa Total");
                break;

            case 2:
                Console.WriteLine("\nHabilidades do Mago:");
                Console.WriteLine("1. Bola de Fogo");
                Console.WriteLine("2. Escudo de Gelo");
                break;

            case 3:
                Console.WriteLine("\nHabilidades da Arqueiro:");
                Console.WriteLine("1. Flecha Precisa");
                Console.WriteLine("2. Disparo Triplo");
                break;

            default:
                Console.WriteLine("Escolha uma opçao valida.");
                break;
        }
    

