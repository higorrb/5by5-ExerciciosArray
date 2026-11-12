char[] vetorCaracter = new char[6];
int contador = 0;

void AdicionaChar()
{
    do
    {
        Console.Write("Digite um caracter: ");
        vetorCaracter[contador] = char.Parse(Console.ReadLine());

        contador++;

    } while (contador < vetorCaracter.Length);
}

void MostraChar()
{
    for (int i = 0; i < vetorCaracter.Length; i++)
    {
        Console.WriteLine(vetorCaracter[i]);
    }
    for (int i = vetorCaracter.Length - 1; i >= 0; i--)
    {
        Console.WriteLine(vetorCaracter[i]);
    }
}

AdicionaChar();
MostraChar();