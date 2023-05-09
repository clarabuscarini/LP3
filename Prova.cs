class Media
{
    public static double Calculo(double nota1, double nota2)
    {
        double media = 0;
        media = (nota1 + nota2)/2;
        return media;    
    }
}

class Programa
{
    static void Main(string[] args)
    {
        bool fimPrograma = false;

        string notaUm = "";  //nota em strings para utilizar o TryParse
        string notaDois = "";

        double nota1 = 0;
        double nota2 = 0;

        double media;
        double mediaTurma;

        int alunos = 0; //para calcular a quantidade de alunos que foram  cadastrados
        double somaNotas = 0; //para realizar o calculo da media da turma
    
        Console.WriteLine("Media de notas da classe em C#\r");
        Console.WriteLine("-------------------------\n");
        while (!fimPrograma)
        {
            Console.Write("Digite a nota 1: ");
            notaUm = Console.ReadLine();
    
            while (!double.TryParse(notaUm, out nota1))
                {
                Console.Write("Nota Inválida. Digite uma nota válida: ");
                notaUm = Console.ReadLine();
                }
            
            Console.Write("Digite a nota 2: ");
            notaDois = Console.ReadLine();
            
            while (!double.TryParse(notaDois, out nota2))
                {
                Console.Write("Nota Inválida. Digite uma nota válida: ");
                notaDois = Console.ReadLine();
                }

            try
            {
                media = Media.Calculo(nota1, nota2);
                Console.WriteLine("A media do aluno foi : {0:0.##}\n", media);
                alunos += 1;
                somaNotas += media;
            }   
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu uma exceção.\n - Detalhes: " + e.Message);
            }
            
            Console.Write("Pressione 'n' para fechar a aplicação, ou pressione qualquer tecla para continuar: ");
            if (Console.ReadLine() == "n")
            {
                fimPrograma = true;
            Console.WriteLine("\n");
            mediaTurma = somaNotas/alunos;
            Console.WriteLine("A media da turma foi : {0:0.##}\n", mediaTurma);
            }
        }
        return;
    }
}
