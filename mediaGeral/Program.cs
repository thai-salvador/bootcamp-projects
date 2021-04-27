using System;

namespace mediaGeral 
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;    //determino que começa a partir de 0 no meu array
            string OpcaoUsuario = ObterOpcaoUsuario();

            while (OpcaoUsuario.ToUpper() != "X") // transforma um eventual x minúsculo em maiúsculo e o compara
            {
                switch (OpcaoUsuario)
                {
                    case "1":
                        Console.WriteLine("Informe o nome do aluno:");
                        Aluno aluno = new Aluno();  //instancio um objeto/variável do tipo aluno. Poderia usar 'var aluno = new Aluno()'
                        aluno.Nome = Console.ReadLine();    //insere na variável o nome inserido

                        Console.WriteLine("Informe a nota do aluno:");
        
                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))  //se ele conseguir converter a nota para decimal, ela já é atribuída à variável nota
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("O valor da nota deve ser decimal");
                        }

                        alunos[indiceAluno] = aluno; //o primeiro aluno vai para o índice 0 e assim por diante
                        indiceAluno++;

                        break;

                    case "2":
                        foreach(var student in alunos) //para cada aluno no meu array alunos, imprima nome e nota
                        {
                            if (!string.IsNullOrEmpty(student.Nome)) //se o nome não for nulo/vazio, imprimir
                            {
                                Console.WriteLine($"ALUNO: {student.Nome} - NOTA: {student.Nota}");
                            }
                        }

                        break;

                    case "3":
                        decimal notaTotal = 0;
                        var numAlunos = 0;

                        for (int i=0; i < alunos.Length; i++)
                        {
                            if (!string.IsNullOrEmpty(alunos[i].Nome))
                            {
                                notaTotal = notaTotal + alunos[i].Nota;
                                numAlunos++;     //para saber quantos alunos eu tenho, eu incremento
                            }
                        }

                        var mediaGeral = notaTotal / numAlunos;
                        Conceito conceitoGeral;

                        if (mediaGeral < 5)
                        {
                            conceitoGeral = Conceito.E;
                        }
                        else if (mediaGeral < 6)
                        {
                            conceitoGeral = Conceito.D;
                        }
                        else if (mediaGeral < 7)
                        {
                            conceitoGeral = Conceito.C;
                        }
                        else if (mediaGeral <= 8)
                        {
                            conceitoGeral = Conceito.B;
                        }
                        else
                        {
                            conceitoGeral = Conceito.A;
                        }

                        Console.WriteLine($"MÉDIA GERAL: {mediaGeral} - CONCEITO: {conceitoGeral}");
                        break;
                    
                    default:
                        throw new ArgumentOutOfRangeException("Digite uma opção válida");
                }
                OpcaoUsuario = ObterOpcaoUsuario();
            }
        }

        private static string ObterOpcaoUsuario()   //novo método
        {   
            Console.WriteLine();    //só para pular uma linha antes de imprimir o menu, para não ficar tudo junto
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("X - Sair");  // para que não fique um looping
            Console.WriteLine();    // para deixar uma linha em branco e ficar mais legível

            string OpcaoUsuario = Console.ReadLine(); // pega opção do usuário e a atribui à variável
            Console.WriteLine(); //pular linha após ler
            return OpcaoUsuario;
        }
    }

}

