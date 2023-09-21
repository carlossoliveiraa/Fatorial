internal class Program
{
    private static void Main(string[] args)
    {
        int numero = 5; 
        long resultado = CalcularFatorial(numero);

        Console.WriteLine($"O fatorial de {numero} é: {resultado}");
    }

    static long CalcularFatorial(int n)
    {
        if (n == 0)
            return 1;
        else
            return n * CalcularFatorial(n - 1);
    }
}