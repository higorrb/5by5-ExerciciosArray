int[] vetorNum = new int[5];
int[] vetorNumInverso = new int[5];
int[] vetorNumPar = new int[5];
int[] vetorNumImpar = new int[5];
int contador = 0;
string opcao;

void AdicionaNum()
{
    do
    {
        Console.Write("Digite um numero para o vetor: ");
        vetorNum[contador] = int.Parse(Console.ReadLine());

        contador++;

    } while (contador < vetorNum.Length);
}

int[] CopiaVetor(string opcao, int[] vetorMain)
{
    int[] vetorCopia = new int[vetorMain.Length];
    int contador = 0;

    switch (opcao)
    {
        case"inverso":
            for (int i = 0; i < vetorMain.Length; i++)
            {
                vetorCopia[i] = vetorMain[(vetorMain.Length - 1) - i];
            }
            return vetorCopia;
            break;

        case "par":
            for (int i = 0; i < vetorMain.Length; i++)
            {
                if (vetorMain[i] % 2 == 0)
                {
                    vetorCopia[contador] = vetorMain[i];
                    contador++;
                }
            }
            return vetorCopia;
            break;

        case "impar":
            for (int i = 0; i < vetorMain.Length; i++)
            {
                if (vetorMain[i] % 2 == 1)
                {
                    vetorCopia[contador] = vetorMain[i];
                    contador++;
                }
            }
            return vetorCopia;
            break;

        default:
            return null;
            break;
    }
}

void MostraVetor(int[] vetor)
{
    for (int i = 0; i < vetor.Length; i++)
    {
        Console.Write($"[{vetor[i]}] ");
    }
}

AdicionaNum();

do
{
    Console.WriteLine("\n\n[inverso] - inverte o vetor \n[par] - mostra apenas os pares \n[impar] - mostra apenas os impares \n[nada]-mostra apenas o vetor original");
    Console.Write("Digite uma opcao para copiar o vetor: ");
    opcao = Console.ReadLine();

    Console.Write("\nOriginal: ");
    MostraVetor(vetorNum);
    Console.WriteLine(" ");

    switch (opcao)
    {
        case "inverso":
            vetorNumInverso = CopiaVetor(opcao, vetorNum);
            Console.Write("Inverso: ");
            MostraVetor(vetorNumInverso);
            break;
        case "par":
            vetorNumPar = CopiaVetor(opcao, vetorNum);
            Console.Write("Par: ");
            MostraVetor(vetorNumPar);
            break;
        case "impar":
            vetorNumImpar = CopiaVetor(opcao, vetorNum);
            Console.Write("Impar: ");
            MostraVetor(vetorNumImpar);
            break;

        case "nada":
            break;

        case null:
            Console.WriteLine("vetor invalido");
            break;
    }
} while (opcao != "nada");