using System;

class Program
{
    static string[] nomes = new string[5];
    static string[] poderes = new string[5];
    static int[] pontuacoes = new int[5];
    static int heroisCadastrados = 0;

    static int[] equipe = new int[3];

    static void Main()
    {
        int opcao;

        do
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1 - Cadastrar Herói");
            Console.WriteLine("2 - Selecionar Equipe");
            Console.WriteLine("3 - Exibir Equipe");
            Console.WriteLine("0 - Sair");
            Console.Write("Digite sua opção: ");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                cadastrarHeroi();
            }
            else if (opcao == 2)
            {
                selecionarEquipe();
            }
            else if (opcao == 3)
            {
                exibirEquipe();
            }

        } while (opcao != 0);
    }

    static void cadastrarHeroi()
    {
        if (heroisCadastrados < 5)
        {
            Console.Write("Nome do herói: ");
            nomes[heroisCadastrados] = Console.ReadLine();

            Console.Write("Poder do herói: ");
            poderes[heroisCadastrados] = Console.ReadLine();

            Console.Write("Pontuação do herói: ");
            pontuacoes[heroisCadastrados] = int.Parse(Console.ReadLine());

            heroisCadastrados++;
        }
        else
        {
            Console.WriteLine("Já foram cadastrados 5 heróis.");
        }
    }

    static void selecionarEquipe()
    {
        Console.WriteLine("\nHeróis disponíveis:");

        for (int i = 0; i < heroisCadastrados; i++)
        {
            Console.WriteLine((i + 1) + " - " + nomes[i]);
        }

        for (int i = 0; i < 3; i++)
        {
            Console.Write("Escolha o " + (i + 1) + "º herói (pelo número): ");
            equipe[i] = int.Parse(Console.ReadLine()) - 1;
        }
    }

    static void exibirEquipe()
    {
        int total = 0;
        Console.WriteLine("\n--- Equipe Selecionada ---");

        for (int i = 0; i < 3; i++)
        {
            int idx = equipe[i];

            Console.WriteLine(nomes[idx] + " - Poder: " + poderes[idx] + " - Pontuação: " + pontuacoes[idx]);
            total += pontuacoes[idx];
        }

        Console.WriteLine("Pontuação total da equipe: " + total);
    }
}
