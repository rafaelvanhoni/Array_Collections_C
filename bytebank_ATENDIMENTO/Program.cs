using bytebank_ATENDIMENTO.bytebank.Atendimento;
Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");
//new ByteBankAtendimento().AtendimentoCliente();


void TestaArrayInt()
{
    int[] idades = new int[5];

    idades[0] = 15;
    idades[1] = 20;
    idades[2] = 35;
    idades[3] = 40;
    idades[4] = 55;

    Console.WriteLine($"Tamanho do array = {idades.Length}");

    int acumulador = 0;
    for (int i = 0; i < idades.Length; i++)
    {
        int idade = idades[i];
        acumulador += idade;
        Console.WriteLine($"Idade [{i}] = {idade}");

    }

    int media = acumulador / idades.Length;

    Console.WriteLine($"Média de Idades = {media}");
}

void TestaArrayDePalavras()
{
    string[] arrayDePalavras = new string[5];

    for (int i = 0; i < arrayDePalavras.Length; i++)
    {
        Console.Write($"Digite a {i+1}a palavra: ");
        arrayDePalavras[i] = Console.ReadLine();
    }

    Console.Write("Digite a palavra a ser encontrada: ");
    string? busca = Console.ReadLine();

    foreach (var palavra in arrayDePalavras)
    {
        if (palavra.Equals(busca))
        {
            Console.WriteLine($"Palavra '{busca}' encontrada");
            break;
        }
    }

}

void TestaMediana(Array array)
{
    if ((array == null) || (array.Length == 0))
    {
        Console.WriteLine("Array para o cálculo da mediana está vazio ou nulo!");
    }

    double[] numerosOrdenados = (double[]) array.Clone();
    Array.Sort(numerosOrdenados);

    int tamanho = numerosOrdenados.Length;
    int meio = tamanho / 2;
    double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] : (numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;

    Console.WriteLine("Amostra: ");
    foreach (var amostra in array)
    {
        Console.WriteLine($"-> {amostra}");
    }

    Console.WriteLine("\r\nAmostra Ordenada: ");
    foreach (var amostra in numerosOrdenados)
    {
        Console.WriteLine($"-> {amostra}");
    }


    Console.WriteLine($"\r\nCom base na amostra, a mediana é {mediana}");

}

double MediaDaAmostra(double[] amostra)
{

    if ((amostra == null) || (amostra.Length == 0))
    {
        Console.WriteLine("Amostra para o cálculo da Média está vazio ou nulo!");
        return 0;
    }

    double media;
    double acumulador = 0;

    for (int i = 0; i < amostra!.Length; i++)
    {
        acumulador += amostra[i];
    }

    media = acumulador / amostra.Length;

    return media;

}


//TestaArrayInt();

//TestaArrayDePalavras();


Array amostra = Array.CreateInstance(typeof(double), 5);
amostra.SetValue(5.9, 0);
amostra.SetValue(1.8, 1);
amostra.SetValue(7.1, 2);
amostra.SetValue(10, 3);
amostra.SetValue(6.9, 4);


//TestaMediana(amostra);

double media = MediaDaAmostra((double[])amostra);
Console.WriteLine($"\r\nA média da amostra é {Math.Round(media, 2)}");

Console.ReadKey();
