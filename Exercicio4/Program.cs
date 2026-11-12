int tamanho = 10;

string[] vetorChar = new string[tamanho];
string[] vetorASCII = new string[tamanho * 2];

void AdicionarChar(string[] vetor)
{
    for (int i = 0; i < vetor.Length; i++)
    {
        Console.Write("Digite um caracter: ");
        vetor[i] = Console.ReadLine();
    }
}

int TransformarASCII(string letra)
{
    return ((int)char.Parse(letra));
}

void CriarVetorASCII()
{
    for(int i = 0;i < vetorChar.Length; i++)
    {
        vetorASCII[i*2] = vetorChar[i];
        vetorASCII[i * 2 + 1] = TransformarASCII(vetorChar[i]).ToString();
    }
}

void MostraVetor(string[] vetor)
{
    for (int i = 0; i < vetor.Length; i++)
    {
        Console.Write($"[{vetor[i]}] ");
    }
    Console.WriteLine("");
}

AdicionarChar(vetorChar);
Console.Write("Vetor Original -> ");
MostraVetor(vetorChar);

CriarVetorASCII();
Console.Write("Vetor com ASCII -> ");
MostraVetor(vetorASCII);
