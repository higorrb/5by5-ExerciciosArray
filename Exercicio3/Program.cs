int[] Fibonacci(int num)
{
    int[] vetor = new int[num];

    int valor1 = 0, valor2 = 1, valor3 = 0;
    for (int i = 0; i < num; i++)
    {
        vetor[i] = valor1;

        valor3 = valor1 + valor2;
        valor1 = valor2;
        valor2 = valor3;

    }
    return vetor;
}

void MostraVetor(int[] vetor)
{
    for (int i = 0; i < vetor.Length; i++)
    {
        Console.Write($"[{vetor[i]}] ");
    }
}

Console.Write("Digite um numero: ");
MostraVetor(Fibonacci(int.Parse(Console.ReadLine())));