namespace BinarySearchNaPratica;

public class Livro
{
    public int Isbn { get; set; }
    public string Nome { get; set; } = string.Empty;

    public Livro(int isbn, string nome)
    {
        Isbn = isbn;
        Nome = nome;
    }
}
