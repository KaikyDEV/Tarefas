using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Tarefa
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public DateTime DataCriacao { get; set; }
    public DateTime DataVencimento { get; set; }
    public string Status { get; set; } // Ex: "Pendente", "Concluída"
}

public class ToDoList
{
    private List<Tarefa> tarefas = new List<Tarefa>();
    private int contadorId = 1;

    public void AdicionarTarefa()
    {
        Console.WriteLine("Digite o nome da tarefa:");
        string? nome = Console.ReadLine();
        Console.WriteLine("Digite a descrição da tarefa:");
        string? descricao = Console.ReadLine();
        Console.WriteLine("Digite a data de vencimento (dd/mm/yyyy):");
        DateTime dataVencimento = DateTime.Parse(Console.ReadLine());

        Tarefa novaTarefa = new Tarefa
        {
            Id = contadorId++,
            Nome = nome,
            Descricao = descricao,
            DataCriacao = DateTime.Now,
            DataVencimento = dataVencimento,
            Status = "Pendente"
        };

        tarefas.Add(novaTarefa);
        Console.WriteLine("Tarefa adicionada com sucesso!");
    }

    public void ListarTarefas()
    {
        Console.WriteLine("Lista de Tarefas:");
        foreach (var tarefa in tarefas)
        {
            Console.WriteLine($"Id: {tarefa.Id} | Nome: {tarefa.Nome} | Status: {tarefa.Status} | Vencimento: {tarefa.DataVencimento.ToShortDateString()}");
        }
    }

    public void BuscarTarefa(string termo)
    {
        var resultado = tarefas.Where(t => t.Nome.Contains(termo, StringComparison.OrdinalIgnoreCase) || t.Descricao.Contains(termo, StringComparison.OrdinalIgnoreCase)).ToList();
        if (resultado.Any())
        {
            foreach (var tarefa in resultado)
            {
                Console.WriteLine($"Id: {tarefa.Id} | Nome: {tarefa.Nome} | Status: {tarefa.Status} | Vencimento: {tarefa.DataVencimento.ToShortDateString()}");
            }
        }
        else
        {
            Console.WriteLine("Nenhuma tarefa encontrada com esse termo.");
        }
    }

    public void FiltrarPorStatus(string status)
    {
        var resultado = tarefas.Where(t => t.Status.Equals(status, StringComparison.OrdinalIgnoreCase)).ToList();
        if (resultado.Any())
        {
            foreach (var tarefa in resultado)
            {
                Console.WriteLine($"Id: {tarefa.Id} | Nome: {tarefa.Nome} | Status: {tarefa.Status} | Vencimento: {tarefa.DataVencimento.ToShortDateString()}");
            }
        }
        else
        {
            Console.WriteLine("Nenhuma tarefa com o status especificado.");
        }
    }

    public void OrdenarTarefasPorData(bool crescente)
    {
        var ordenado = crescente
            ? tarefas.OrderBy(t => t.DataVencimento).ToList()
            : tarefas.OrderByDescending(t => t.DataVencimento).ToList();

        foreach (var tarefa in ordenado)
        {
            Console.WriteLine($"Id: {tarefa.Id} | Nome: {tarefa.Nome} | Vencimento: {tarefa.DataVencimento.ToShortDateString()}");
        }
    }

    public void MarcarComoConcluida(int id)
    {
        var tarefa = tarefas.FirstOrDefault(t => t.Id == id);
        if (tarefa != null)
        {
            tarefa.Status = "Concluída";
            Console.WriteLine("Tarefa marcada como concluída.");
        }
        else
        {
            Console.WriteLine("Tarefa não encontrada.");
        }
    }

    public void RemoverTarefa(int id)
    {
        var tarefa = tarefas.FirstOrDefault(t => t.Id == id);
        if (tarefa != null)
        {
            tarefas.Remove(tarefa);
            Console.WriteLine("Tarefa removida.");
        }
        else
        {
            Console.WriteLine("Tarefa não encontrada.");
        }
    }

    public void SalvarTarefas()
    {
        // Salvar em um arquivo JSON ou texto simples
    }

    public void CarregarTarefas()
    {
        // Carregar tarefas de um arquivo
    }
}

public class Program
{
    static void Main(string[] args)
    {
        ToDoList lista = new ToDoList();

        // Adicionar código para menu interativo aqui

        lista.AdicionarTarefa();
        lista.ListarTarefas();
    }
}
