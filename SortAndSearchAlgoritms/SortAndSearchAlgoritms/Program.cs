﻿using SortAndSearchAlgoritms.Algoritms.Search;
using SortAndSearchAlgoritms.Algoritms.Sort;

int[] numerosOrdenados = { 1,2,3,4,5,6,7,8,9 };
int[] numerosAleatorios = new int[10];
float[] numerosFloatAleatorios = new float[10];
int alvo = 0;
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
    try
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
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Operação inexistente...");
                break;
        }

        Menu();
    }
    catch (Exception exception)
    {
        Console.Clear();
        Console.WriteLine($"Ocorreu um erro ao receber a entrada: {exception.Message}\n");
        Menu();
    }
}

void EscolherAlvo()
{
    try
    {
        Console.Write("Escolha um alvo entre 1 e 9 para ser buscado (será retornado o índice do elemento): ");
        alvo = int.Parse(Console.ReadLine()!);

        if(alvo < 1 || alvo > 9)
        {
            EscolherAlvo();
        }
    }
    catch (Exception exception)
    {
        Console.Clear();
        Console.WriteLine($"Ocorreu um erro ao receber a entrada: {exception.Message}\n");
        Menu();
    }
}

void InsereItens(int[] numeros)
{
    try
    {
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Digite o {i+1}º número para a lista: ");
            int numero = int.Parse(Console.ReadLine()!);
            numeros[i] = numero;
        }
    }
    catch (Exception exception)
    {
        Console.Clear();
        Console.WriteLine($"Ocorreu um erro ao receber a entrada: {exception.Message}\n");
        Menu();
    }
}

void InsereItensFloat(float[] numeros)
{
    try
    {
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Digite o {i+1}º número para a lista: ");
            float numero = float.Parse(Console.ReadLine()!);
            numeros[i] = numero;
        }
    }
    catch (Exception exception)
    {
        Console.Clear();
        Console.WriteLine($"Ocorreu um erro ao receber a entrada: {exception.Message}\n");
        Menu();
    }
}

void EscolherBusca()
{
    try
    {
        int operacaoBusca = 0;
        Console.WriteLine("Digite a Busca desejada:");
        Console.Write("1 - Binary Search\n2 - Jump Search\n3 - Interpolation Search\n4 - Ternary Search\n5 - ExponentialSearch\nBusca: ");
        operacaoBusca = int.Parse(Console.ReadLine()!);
        Console.Clear();

        EscolherAlvo();
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
            case EBusca.ExponentialSearch:
                var buscaExponential = ExponentialSearch.Execute(numerosOrdenados, alvo);
                ImprimeBusca(alvo, buscaExponential);
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
        Console.Write("1 - Bucket Sort\n2 - Merge Sort\n3 - Shell Sort\n4 - Bubble Sort\n5 - Radix Sort\n6 - Selection Sort\n7 - Quick Sort\nOrdenação: ");
        operacaoOrdenacao = int.Parse(Console.ReadLine()!);
        Console.Clear();

        switch ((EOrdenacao)operacaoOrdenacao)
        {
            case EOrdenacao.BucketSort:
                Console.WriteLine($"Digite números de 2 casas decimais entre 0 e 1");
                InsereItensFloat(numerosFloatAleatorios);
                var ordenacaoBucket = BucketSort.Execute(numerosFloatAleatorios);
                ImprimeLista(ordenacaoBucket);
                break;
            case EOrdenacao.MergeSort:
                InsereItens(numerosAleatorios);
                var ordenacaoMerge = MergeSort.Execute(numerosAleatorios);
                ImprimeLista(ordenacaoMerge);
                break;
            case EOrdenacao.ShellSort:
                InsereItens(numerosAleatorios);
                var ordenacaoShell = ShellSort.Execute(numerosAleatorios);
                ImprimeLista(ordenacaoShell);
                break;
            case EOrdenacao.BubbleSort:
                InsereItens(numerosAleatorios);
                var ordenacaoBubble = BubbleSort.Execute(numerosAleatorios);
                ImprimeLista(ordenacaoBubble);
                break;
            case EOrdenacao.RadixSort:
                InsereItens(numerosAleatorios);
                var ordenacaoRadix = RadixSort.Execute(numerosAleatorios);
                ImprimeLista(ordenacaoRadix);
                break;
            case EOrdenacao.SelectionSort:
                InsereItens(numerosAleatorios);
                var ordenacaoSelection = SelectionSort.Execute(numerosAleatorios);
                ImprimeLista(ordenacaoSelection);
                break;
            case EOrdenacao.QuickSort:
                InsereItens(numerosAleatorios);
                var ordenacaoQuick = QuickSort.Execute(numerosAleatorios);
                ImprimeLista(ordenacaoQuick);
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