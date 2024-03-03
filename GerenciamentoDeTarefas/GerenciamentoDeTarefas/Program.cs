
    using System;
using System.Collections.Generic;

class Program
{
    static List<string> tarefas = new List<string>();

    static void Main(string[] args)
    {
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("=== Sistema de Gerenciamento de Tarefas ===");
            Console.WriteLine("1. Adicionar Tarefa");
            Console.WriteLine("2. Remover Tarefa");
            Console.WriteLine("3. Listar Tarefas");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    AdicionarTarefa();
                    break;
                case "2":
                    RemoverTarefa();
                    break;
                case "3":
                    ListarTarefas();
                    break;
                case "4":
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void AdicionarTarefa()
    {
        Console.Write("Digite a tarefa a ser adicionada: ");
        string tarefa = Console.ReadLine();
        tarefas.Add(tarefa);
        Console.WriteLine("Tarefa adicionada com sucesso!");
    }

    static void RemoverTarefa()
    {
        Console.Write("Digite o número da tarefa a ser removida: ");
        int numeroTarefa;
        if (int.TryParse(Console.ReadLine(), out numeroTarefa) && numeroTarefa >= 1 && numeroTarefa <= tarefas.Count)
        {
            string tarefaRemovida = tarefas[numeroTarefa - 1];
            tarefas.RemoveAt(numeroTarefa - 1);
            Console.WriteLine($"Tarefa '{tarefaRemovida}' removida com sucesso!");
        }
        else
        {
            Console.WriteLine("Número de tarefa inválido!");
        }
    }

    static void ListarTarefas()
    {
        Console.WriteLine("Lista de Tarefas:");
        if (tarefas.Count == 0)
        {
            Console.WriteLine("Nenhuma tarefa disponível.");
        }
        else
        {
            for (int i = 0; i < tarefas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tarefas[i]}");
            }
        }
    }
}
