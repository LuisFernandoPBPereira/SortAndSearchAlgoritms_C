using OrdenarNotas;



Aluno[] alunos = {
    new Aluno("Aluno 1", 50),
    new Aluno("Aluno 2", 100),
    new Aluno("Aluno 3", 75),
    new Aluno("Aluno 4", 95),
    new Aluno("Aluno 5", 61),
    new Aluno("Aluno 6", 50),
    new Aluno("Aluno 7", 100),
    new Aluno("Aluno 8", 75),
    new Aluno("Aluno 9", 95),
    new Aluno("Aluno 10", 61),
};

Console.Write("Digite a nota do aluno que será buscado: ");
int nota = int.Parse(Console.ReadLine()!);

var alunosOrdenados = BucketSort.Execute(alunos);
var indiceDoAluno = InterpolationSearch.Execute(alunosOrdenados, nota);

Console.WriteLine("Lista de alunos ordenada:\n");

foreach (var aluno in alunosOrdenados)
{
    Console.WriteLine($"Nome: {aluno.Nome}, Nota: {aluno.Nota}");    
}

Console.WriteLine($"\n\nAluno buscado: {alunos[indiceDoAluno].Nome}, nota: {alunos[indiceDoAluno].Nota}. O aluno está no índice: {indiceDoAluno}");
