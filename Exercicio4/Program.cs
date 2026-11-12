string[] vetorChar = new string[10];
string[] vetorASCII = new string[20];

void AdicionaChar()
{
    for (int i = 0; i < vetorChar.Length; i++)
    {
        Console.Write("Digite um caracter: ");
        vetorChar[i] = Console.ReadLine();
    }
}

void TransformaAscii()
{
    for (int i = 0; i < vetorChar.Length; i++)
    {
        vetorASCII[i*2] = vetorChar[i];
        vetorASCII[i*2 + 1] = ((int)char.Parse(vetorChar[i])).ToString();
    }
}

void MostraVetor(string[] vetor)
{
    for (int i = 0; i < vetor.Length; i++)
    {
        Console.Write($"[{vetor[i]}] ");
    }
}

AdicionaChar();
TransformaAscii();
Console.Write("Vetor Original -> ");
MostraVetor(vetorChar);
Console.WriteLine(" ");
Console.Write("Vetor com ASCII -> ");
MostraVetor(vetorASCII);
