using System;
                Console.Write("Digite o número:");
                int n = Convert.ToInt32(Console.ReadLine());

                if (n % 2 == 0)
                {
                    Console.WriteLine($"{n} é um número par.");
                }
                else
                {

                    Console.WriteLine($"{n} não é um número par.");
                }
            