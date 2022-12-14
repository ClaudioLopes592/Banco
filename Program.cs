using Banco;

Conta conta = new Conta();
conta.numero = 1;
conta.titular = "Claudio Lopes";
conta.saldo = 1000.00;
string acao = "";

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine();
Console.WriteLine("############# - C A I X A  E L E T R Ô N I C O - #############");
Console.WriteLine($"          Bem Vindo - {conta.titular} - Numero conta: {conta.numero}");
Console.WriteLine("##############################################################");
Console.ResetColor();


Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("#############- M E N U -#############");
Console.WriteLine("E - Saldo ###########################");
Console.WriteLine("D - Depósito ########################");
Console.WriteLine("R - Saque ###########################");
Console.WriteLine("T - Transferência ###################");
Console.WriteLine("S - Sair ############################");
Console.WriteLine("#####################################");
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write("Informe a operação desejada ");
Console.ResetColor();

acao = Console.ReadLine().ToUpper();
Console.WriteLine();

while (acao != "S")
{
    if (acao == "E")
    {
        Console.WriteLine($"Seu saldo é de R$ {conta.saldo}");
    }
    else if (acao == "D")
    {
        Console.WriteLine("Informe o valor do depósito R$ ");
        double valorDeposito = Convert.ToDouble(Console.ReadLine());
        conta.Deposita(valorDeposito);
        Console.WriteLine("Depósito realizado com sucesso!");
    }
    else if (acao == "R")
    {
        Console.WriteLine("Informe o valor do saque R$ ");
        double valorSaque = Convert.ToDouble(Console.ReadLine());

        bool deuCerto = conta.Saca(valorSaque);
        if (deuCerto)
        {
            Console.WriteLine("Saque realizado com sucesso! Saldo atual R$ " + conta.saldo);
        }
        else
        {
            Console.WriteLine("Saldo insuficiente!");
        }
    }
    else if (acao == "T")
    {
        Console.WriteLine("Em manutenção!");
    }

    Console.WriteLine();
    Console.WriteLine("Pressione uma tecla para continuar...");
    Console.ReadKey();

    Console.Clear();
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("#############- M E N U -#############");
    Console.WriteLine("E - Saldo ###########################");
    Console.WriteLine("D - Depósito ########################");
    Console.WriteLine("R - Saque ###########################");
    Console.WriteLine("T - Transferência ###################");
    Console.WriteLine("S - Sair ############################");
    Console.WriteLine("#####################################");
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.Write("Informe a operação desejada ");
    Console.ResetColor();

    acao = Console.ReadLine().ToUpper();
    Console.WriteLine();
}

//Console.WriteLine(conta.numero);
//Console.WriteLine(conta.titular);
//Console.WriteLine(conta.saldo);
