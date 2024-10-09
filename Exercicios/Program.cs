using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        while (true)
        {
            // Exibir o menu
            Console.Clear();
            Console.WriteLine("< Escolha uma atividade >");
            Console.WriteLine("1. Atividade 01");
            Console.WriteLine("2. Atividade 02");
            Console.WriteLine("3. Atividade 03");
            Console.WriteLine("4. Atividade 04");
            Console.WriteLine("5. Atividade 05");
            Console.WriteLine("0. Sair");
            Console.Write("\nDigite o número da atividade corresponde: ");
            // Ler a escolha do usuário
            string escolha = Console.ReadLine();

            // Processar a escolha
            switch (escolha)
            {
                case "1":
                    Atividade1();
                    break;
                case "2":
                    Atividade2();
                    break;
                case "3":
                    Atividade3();
                    break;
                case "4":
                    Atividade4();
                    break;
                case "5":
                    Atividade5();
                    break;
                case "0":
                    Console.WriteLine("Saindo...");
                    return; // Encerra o programa
                default:
                    Console.WriteLine("Escolha inválida. Tente novamente.");
                    break;
            }

            // Esperar o usuário pressionar uma tecla para continuar
            Console.WriteLine("Pressione qualquer tecla para voltar para o menu e continuar...");
            Console.ReadKey();
        }
    }
    
    static void Atividade1()
    {
        Console.WriteLine("Executando Atividade 1...");
        // Solicita ao usuário um número

        Console.Write("Informe um número para verificar se pertence à sequência de Fibonacci: ");
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            // Inicializa os primeiros dois números da sequência de Fibonacci
            int a = 0, b = 1;

            // Flag para verificar se o número pertence à sequência
            bool pertence = (numero == a || numero == b);

            // Calcula a sequência de Fibonacci até o número informado
            while (b < numero)
            {
                int temp = a;
                a = b;
                b = temp + b;

                if (b == numero)
                {
                    pertence = true;
                    break;
                }
            }

            // Imprime o resultado
            if (pertence)
            {
                Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");
            }
        }
        else
        {
            Console.WriteLine("Número inválido.");
        }

    }

    static void Atividade2()
    {
        Console.WriteLine("Executando Atividade 2...");

        // Solicita ao usuário que informe a string
        Console.WriteLine("Informe uma palavra ou frase:");
        string input = Console.ReadLine();

        // Variável para contar as ocorrências de 'a' ou 'A'
        int contador = 0;

        // Loop para verificar cada caractere na string
        foreach (char c in input)
        {
            if (c == 'a' || c == 'A')
            {
                contador++;
            }
        }

        // Verifica se 'a' foi encontrado e exibe a quantidade
        if (contador > 0)
        {
            Console.WriteLine($"A letra 'a' (maiúscula ou minúscula) foi encontrada {contador} vezes.");
        }
        else
        {
            Console.WriteLine("A letra 'a' (maiúscula ou minúscula) não foi encontrada.");
        }
    }

    static void Atividade3()
    {
        Console.WriteLine("Executando Atividade 3...");

        // Observe o trecho de código abaixo: 

        int INDICE = 12, SOMA = 0, K = 1;
        while (K < INDICE)
        {
            K = K + 1; // Incrementa K
            SOMA = SOMA + K; // Adiciona K à SOMA
        }
        Console.WriteLine($"SOMA: {SOMA}"); // Imprime o valor final de SOMA

        // Ao final do processamento, qual será o valor da variável SOMA?
        // Resposta: O valor final da variável SOMA será 77.
    }

    static void Atividade4()
    {
        {
            Console.WriteLine("Executando Atividade 4...");

            // a) Sequência: 1, 3, 5, 7, ___
            Console.WriteLine("a) Próximo número é: " + ProximoNumeroA());

            // b) Sequência: 2, 4, 8, 16, 32, 64, ____
            Console.WriteLine("b) Próximo número é: " + ProximoNumeroB());

            // c) Sequência: 0, 1, 4, 9, 16, 25, 36, ____
            Console.WriteLine("c) Próximo número é: " + ProximoNumeroC());

            // d) Sequência: 4, 16, 36, 64, ____
            Console.WriteLine("d) Próximo número é: " + ProximoNumeroD());

            // e) Sequência: 1, 1, 2, 3, 5, 8, ____
            Console.WriteLine("e) Próximo número é: " + ProximoNumeroE());

            // f) Sequência: 2, 10, 12, 16, 17, 18, 19, ____
            Console.WriteLine("f) Próximo número é: " + ProximoNumeroF());
        }

        int ProximoNumeroA()
        {
            // Sequência de números ímpares: 1, 3, 5, 7
            return 9;
        }

        int ProximoNumeroB()
        {
            // Sequência que dobra: 2, 4, 8, 16, 32, 64
            return 128;
        }

        int ProximoNumeroC()
        {
            // Sequência dos quadrados perfeitos: 0, 1, 4, 9, 16, 25, 36
            return 49; // 7^2
        }

        int ProximoNumeroD()
        {
            // Sequência dos quadrados perfeitos de números pares: 2^2, 4^2, 6^2, 8^2
            return 100; // 10^2
        }

        int ProximoNumeroE()
        {
            // Sequência de Fibonacci: 1, 1, 2, 3, 5, 8
            return 13; // Próximo é 5 + 8
        }

        int ProximoNumeroF()
        {
            // Sequência alternada: 2, 10, 12, 16, 17, 18, 19
            return 20; // Próximo número é 20 (incrementa +1)
        }
    }

    static void Atividade5()
    {
        Console.WriteLine("Executando Atividade 5...");

        // Entrada de string definida manualmente
        Console.Write("Para descobrir qual interruptor controla cada lâmpada com apenas duas idas até a sala das lâmpadas, a estratégia é a seguinte: Ligue um interruptor e deixe-o ligado por alguns minutos. " +
            "Em seguida, desligue-o e ligue um segundo interruptor. Vá até a sala das lâmpadas. A lâmpada que estiver acesa será controlada pelo segundo interruptor, a lâmpada que estiver apagada mas quente " +
            "será controlada pelo primeiro interruptor, e a lâmpada que estiver apagada e fria será controlada pelo terceiro interruptor.\r\n\r\nEstratégia para identificar os interruptores:\r\na) Preparação " +
            "inicial  \r\n\r\nLigue o primeiro interruptor e espere alguns minutos. Esse tempo é suficiente para que a lâmpada controlada por esse interruptor aqueça. Após esse tempo, desligue o primeiro " +
            "interruptor e ligue o segundo interruptor.\r\nb) Primeira ida à sala das lâmpadas  \r\n\r\nAo chegar à sala das lâmpadas, você observará três possíveis situações:\r\n\r\nA lâmpada acesa estará " +
            "conectada ao segundo interruptor, que foi o último a ser ligado.\r\nA lâmpada apagada e quente será a que estava conectada ao primeiro interruptor, que foi ligado inicialmente e depois desligado." +
            "\r\nA lâmpada apagada e fria será a que está conectada ao terceiro interruptor, que não foi ligado em nenhum momento.\r\nDesse modo, com essa sequência de ações, é possível identificar com clareza" +
            " qual interruptor controla cada lâmpada utilizando apenas duas idas à sala.:");        
    }
}

