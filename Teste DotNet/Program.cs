Random random = new Random();
int numeroProvas = 5;
string[] alunos = ["Alexandre", "Mateus", "Ariel", "Joao"];

int[] notasAlexandre = { 90, 86, 87, 98, 100, 94, 90 };
int[] notasMateus = { 92, 89, 81, 96, 90, 89 };
int[] notasAriel = { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] notasJoao = { 90, 95, 87, 88, 96, 96 };
int[] notasAluno = [10];



Console.WriteLine($"Estudante\tMedia\t\tExtra\tTotal\tNota");

foreach (string nome in alunos)
{

    string alunoAtual = nome;

    if (alunoAtual == "Alexandre")
    {
        notasAluno = notasAlexandre;
    }
    else if (alunoAtual == "Mateus")
    {
        notasAluno = notasMateus;
    }
    else if (alunoAtual == "Ariel")
    {
        notasAluno = notasAriel;
    }
    else if (alunoAtual == "Joao")
    {
        notasAluno = notasJoao;
    }

    string letraNotaAluno = "";

    int quantidadeGeralDeCoisasQueOAlunoFez = 0;
    int quantidadeTrabalhos = 0;

    int somaTrabalhos = 0;
    int somaProvas = 0;

    decimal mediaAlunoTotal = 0;
    decimal notaProvaAtual = 0;
    decimal notaTrabalhoAtual = 0;

    
    

    foreach (int nota in notasAluno)
    {
        quantidadeGeralDeCoisasQueOAlunoFez++;
        
        if (quantidadeGeralDeCoisasQueOAlunoFez <= numeroProvas)
        {
            somaProvas += nota;
        }
        else
        {
            quantidadeTrabalhos++;
            somaTrabalhos += nota;
        }
    }
    
    notaProvaAtual = (decimal) somaProvas / numeroProvas;   
    notaTrabalhoAtual = (decimal) somaTrabalhos / 10 / numeroProvas;
    mediaAlunoTotal = ((decimal) somaProvas + (decimal) somaTrabalhos / 10) / numeroProvas;

    if (mediaAlunoTotal >= 97)
        letraNotaAluno = "A+";
    else if (mediaAlunoTotal >= 93)
        letraNotaAluno = "A";
    else if (mediaAlunoTotal >= 90)
        letraNotaAluno = "A-";
    else if (mediaAlunoTotal >= 87)
        letraNotaAluno = "B+";
    else if (mediaAlunoTotal >= 83)
        letraNotaAluno = "B";
    else if (mediaAlunoTotal >= 80)
        letraNotaAluno = "B-";
    else if (mediaAlunoTotal >= 77)
        letraNotaAluno = "C+";
    else if (mediaAlunoTotal >= 73)
        letraNotaAluno = "C";
    else if (mediaAlunoTotal >= 70)
        letraNotaAluno = "C-";
    else if (mediaAlunoTotal >= 67)
        letraNotaAluno = "D+";
    else if (mediaAlunoTotal >= 63)
        letraNotaAluno = "D";
    else if (mediaAlunoTotal >= 60)
        letraNotaAluno = "D-";
    else
        letraNotaAluno = "F";

    Console.WriteLine($"{nome}:    \t{notaProvaAtual}\t\t{notaTrabalhoAtual}\t{mediaAlunoTotal}\t{letraNotaAluno}");
}


Console.WriteLine("Aperte Enter para continuar");