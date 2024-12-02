using BinarySearchNaPratica;

try
{
    BuscarLirvo();
}
catch (Exception exception)
{
    Console.Clear();
    Console.WriteLine(exception.Message);
    BuscarLirvo();
}

void BuscarLirvo()
{
    try
    {
        Console.Write("Digite o índice do livro que deseja buscar: ");
        int isbn = int.Parse(Console.ReadLine()!);

        Livro[] livros = {
            new Livro(1000, "livro 1"),
            new Livro(2000, "livro 2"),
            new Livro(3000, "livro 3"),
            new Livro(4000, "livro 4"),
            new Livro(5000, "livro 5"),
        };

        int indiceDoLivro = BinarySearch.Execute(livros, isbn);

        if (indiceDoLivro == -1)
        {
            Console.WriteLine("Livro não encontrado");
            return;
        }

        Console.WriteLine($"\n\nO livro encontrado é: {livros[indiceDoLivro].Nome}, e está no índice {indiceDoLivro}");
    }
    catch (Exception exception)
    {
        Console.Clear();
        Console.WriteLine(exception.Message);
        BuscarLirvo();
    }
}