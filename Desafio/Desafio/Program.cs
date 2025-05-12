using System.Text.Json;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercicio 1:");
        Exercicio1.Run();
        Console.WriteLine();
        Console.WriteLine("---------------------------------");

        Console.WriteLine("Exercicio 2:");
        Exercicio2.Run();
        Console.WriteLine();
        Console.WriteLine("---------------------------------");

        Console.WriteLine("Exercicio 3:");
        Exercicio3.Run();
        Console.WriteLine();
        Console.WriteLine("---------------------------------");

        Console.WriteLine("Exercicio 4:");
        Exercicio4.Run();
        Console.WriteLine();
        Console.WriteLine("---------------------------------");

        Console.WriteLine("Exercicio 5:");
        Exercicio5.Run();
        Console.WriteLine();

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
public class Exercicio1
{
    public static void Run()
    {
        int INDICE = 13, SOMA = 0, K = 0;

        while (K < INDICE)
        {
            K = K + 1;
            SOMA = SOMA + K;
        }

        Console.WriteLine("SOMA = " + SOMA); // Resultado: 91
    }
}
public class Exercicio2
{
    public static void Run()
    {
        int numero = 21; 
        int a = 0, b = 1;

        while (a < numero)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }

        if (a == numero)
            Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
        else
            Console.WriteLine($"{numero} NÃO pertence à sequência de Fibonacci.");
    }
}
public class Exercicio3
{
    public static void Run()
    {
        string json = File.ReadAllText("dados.json");

        var dados = JsonSerializer.Deserialize<List<Invoicing>>(json);

        var faturamentos = dados.Where(f => f.valor > 0).Select(f => f.valor).ToList();

        double menor = faturamentos.Min();
        double maior = faturamentos.Max();
        double media = faturamentos.Average();
        int diasAcimaDaMedia = faturamentos.Count(v => v > media);

        Console.WriteLine($"Menor: R${menor:F2}");
        Console.WriteLine($"Maior: R${maior:F2}");
        Console.WriteLine($"Dias acima da média: {diasAcimaDaMedia}");
    }
}
public class Exercicio4
{
    public static void Run()
    {
        var faturamento = new Dictionary<string, double>
        {
            {"SP", 67836.43},
            {"RJ", 36678.66},
            {"MG", 29229.88},
            {"ES", 27165.48},
            {"Outros", 19849.53}
        };

        double total = 0;
        foreach (var valor in faturamento.Values)
            total += valor;

        foreach (var item in faturamento)
        {
            double percentual = (item.Value / total) * 100;
            Console.WriteLine($"{item.Key}: {percentual:F2}%");
        }
    }
}
public class Exercicio5
{
    public static void Run()
    {
        string texto = "Target Sistemas";
        string invertida = "";

        for (int i = texto.Length - 1; i >= 0; i--)
            invertida += texto[i];

        Console.WriteLine("Original: " + texto);
        Console.WriteLine("Invertida: " + invertida);
    }
}
