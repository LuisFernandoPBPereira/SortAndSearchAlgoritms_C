using SortAndSearchAlgoritms.Algoritms.Search;
using SortAndSearchAlgoritms.Algoritms.Sort;

int[] numerosOrdenados = { 1,2,3,4,5,6,7,8,9 };
int[] numerosAleatorios = { 5,1,65,86,41,34,0,45,32 };
float[] numerosFloatAleatorios = { 0.78f, 0.17f, 0.39f, 0.26f, 0.72f, 0.94f, 0.21f, 0.12f, 0.23f, 0.68f };
int alvo = 6;
int operacao = 0;

try
{
    Menu();
}
catch (Exception exception)
{
    Console.Clear();
    Console.WriteLine($"Ocorreu um erro ao receber a entrada: {exception.Message}\n");
    Menu();
}

void Menu()
{
    Console.WriteLine("Digite a operação desejada:");
    Console.Write("1 - Busca\n2 - Ordenação\n3 - Sair\nOperação: ");
    operacao = int.Parse(Console.ReadLine()!);
    Console.Clear();

    switch ((EOperacao)operacao)
    {
        case EOperacao.Busca:
            EscolherBusca();
            break;
        case EOperacao.Ordenacao:
            EscolherOrdenacao();
            break;
        case EOperacao.Sair:
            return;
        default:
            Console.WriteLine("Operação inexistente...");
            break;
    }

    Menu();
}

void EscolherBusca()
{
    try
    {
        int operacaoBusca = 0;
        Console.WriteLine("Digite a Busca desejada:");
        Console.Write("1 - Binary Search\n2 - Jump Search\n3 - Interpolation Search\n4 - Ternary Search\nBusca: ");
        operacaoBusca = int.Parse(Console.ReadLine()!);
        Console.Clear();

        switch ((EBusca)operacaoBusca)
        {
            case EBusca.BinarySearch:
                var buscaBinary = BinarySearch.Execute(numerosOrdenados, alvo);
                ImprimeBusca(alvo, buscaBinary);
                break;
            case EBusca.JumpSearch:
                var buscaJump = JumpSearch.Execute(numerosOrdenados, alvo);
                ImprimeBusca(alvo, buscaJump);
                break;
            case EBusca.InterpolationSearch:
                var buscaInterpolation = InterpolationSearch.Execute(numerosOrdenados, alvo);
                ImprimeBusca(alvo, buscaInterpolation);
                break;
            case EBusca.TernarySearch:
                var buscaTernary = TernarySearch.Execute(numerosOrdenados, alvo);
                ImprimeBusca(alvo, buscaTernary);
                break;
        }
    }
    catch (Exception exception)
    {
        Console.Clear();
        Console.WriteLine($"Ocorreu um erro ao receber a entrada: {exception.Message}\n");
        Menu();
    }
}

void EscolherOrdenacao()
{
    try
    {
        int operacaoOrdenacao = 0;

        Console.WriteLine("Digite a Ordenação desejada:");
        Console.Write("1 - Bucket Sort\n2 - Merge Sort\n3 - Shell Sort\n4 - Bubble Sort\n5 - Radix Sort\n6 - Selection Sort\nOrdenação: ");
        operacaoOrdenacao = int.Parse(Console.ReadLine()!);
        Console.Clear();

        switch ((EOrdenacao)operacaoOrdenacao)
        {
            case EOrdenacao.BucketSort:
                var ordenacaoBucket = BucketSort.Execute(numerosFloatAleatorios);
                ImprimeLista(ordenacaoBucket);
                break;
            case EOrdenacao.MergeSort:
                var ordenacaoMerge = MergeSort.Execute(numerosAleatorios);
                ImprimeLista(ordenacaoMerge);
                break;
            case EOrdenacao.ShellSort:
                var ordenacaoShell = ShellSort.Execute(numerosAleatorios);
                ImprimeLista(ordenacaoShell);
                break;
            case EOrdenacao.BubbleSort:
                var ordenacaoBubble = BubbleSort.Execute(numerosAleatorios);
                ImprimeLista(ordenacaoBubble);
                break;
            case EOrdenacao.RadixSort:
                var ordenacaoRadix = RadixSort.Execute(numerosAleatorios);
                ImprimeLista(ordenacaoRadix);
                break;
            case EOrdenacao.SelectionSort:
                var ordenacaoSelection = SelectionSort.Execute(numerosAleatorios);
                ImprimeLista(ordenacaoSelection);
                break;
        }
    }
    catch (Exception exception)
    {
        Console.Clear();
        Console.WriteLine($"Ocorreu um erro ao receber a entrada: {exception.Message}\n");
        Menu();
    }
}

void ImprimeLista<Number>(Number[] numeros)
{
    Console.Write("Números ordenados: ");

    for (int i = 0; i < numeros.Length; i++)
    {
        Console.Write($"{numeros[i]} ");
    }

    Console.WriteLine("\n");
}

void ImprimeBusca(int alvo, int numeroBuscado)
{
    if(numeroBuscado != -1)
    {
        Console.WriteLine($"\nO número {alvo} está no índice: {numeroBuscado}\n");
        return;
    }

    Console.WriteLine("Número não encontrado");
}