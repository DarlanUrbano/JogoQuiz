using System;

class Program
{
    static void Main()
    {
        int pontuacao = 0;

        // Defina suas perguntas e respostas aqui
        string[] perguntas = new string[]
        {
            "Qual é a capital do Brasil?",
            "Qual é o maior planeta do sistema solar?",
            "Quem escreveu a peça 'Romeu e Julieta'?",
            "Qual é o maior mamífero terrestre?",
            "Qual é o símbolo químico para o ouro?"
        };

        string[][] opcoesResposta = new string[][]
        {
            new string[] { "Brasília", "Rio de Janeiro", "São Paulo", "Belo Horizonte" },
            new string[] { "Terra", "Marte", "Júpiter", "Saturno" },
            new string[] { "William Shakespeare", "Charles Dickens", "Jane Austen", "F. Scott Fitzgerald" },
            new string[] { "Elefante Africano", "Girafa", "Rinoceronte", "Hipopótamo" },
            new string[] { "Au", "Ag", "Fe", "Pt" }
        };

        int[] respostasCorretas = new int[] { 0, 2, 0, 0, 3 };

        Console.WriteLine("Bem-vindo ao Quiz!");
        Console.WriteLine("Responda às seguintes perguntas:");

        for (int i = 0; i < perguntas.Length; i++)
        {
            Console.WriteLine($"Pergunta {i + 1}: {perguntas[i]}");

            for (int j = 0; j < opcoesResposta[i].Length; j++)
            {
                Console.WriteLine($"{j + 1}. {opcoesResposta[i][j]}");
            }

            Console.Write("Escolha uma opção (1-4): ");
            int escolha = int.Parse(Console.ReadLine());

            if (escolha == respostasCorretas[i] + 1)
            {
                Console.WriteLine("Resposta correta!\n");
                pontuacao++;
            }
            else
            {
                Console.WriteLine("Resposta incorreta. A resposta correta era: " + opcoesResposta[i][respostasCorretas[i]] + "\n");
            }
        }

        Console.WriteLine($"Você acertou {pontuacao} de {perguntas.Length} perguntas.");
        Console.WriteLine("Obrigado por jogar!");
    }
}
