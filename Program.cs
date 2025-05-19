Console.Clear();

double valorEmprestimo = 0.0;
double quantidadeParcelas = 0.0;
double rendaMensal = 0.0;

double parcela = 0.0;
double porcentagemRenda = 0.0;

Console.Write("Digite o valor desejado para emprestimo: ");
    valorEmprestimo = Convert.ToDouble(Console.ReadLine()!);

    Console.Write("Digite sua renda mensal: ");
    rendaMensal = Convert.ToDouble(Console.ReadLine()!);

    Console.Write("Digite a quantidade de parcelas desejadas: ");
    quantidadeParcelas = Convert.ToDouble(Console.ReadLine()!);

    parcela = valorEmprestimo / quantidadeParcelas;
    porcentagemRenda = rendaMensal / 100 * 30;

        if (parcela >= porcentagemRenda)
        {
        Console.WriteLine("Sinto muito, seu empréstimo foi negado. Parcelas com valor superior a 30% da renda mensal.");
        }
        else
        {
        Console.WriteLine("Parabéns, seu empréstimo foi aprovado! Contate seu banco para prosseguir.");
        }
