using Exercicio_banco;

internal class Program
{
    private static void Main(string[] args)
    {

        Conta c1 = new Conta();

        Console.Write("Insira o número da conta: ");
        c1.Nconta = int.Parse(Console.ReadLine());
        Console.Write("Insira o titular da conta: ");
        c1.Tconta = Console.ReadLine();
        Console.WriteLine("Haverá depósito inicial? s/n");
        c1.DepInicialResposta = char.Parse(Console.ReadLine());
        if (c1.DepInicialResposta == 's')
        {
            Console.Write("Insira o valor do depósito inicial:");
            c1.QuantiaDepInicial = double.Parse(Console.ReadLine());
            c1.Saldo = c1.QuantiaDepInicial;
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(c1);
            
            Console.Write("Insira um valor para depósito: ");
            double quantiaDep = double.Parse(Console.ReadLine());
            c1.AumentarSaldo(quantiaDep);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c1);
            
            Console.Write("Insira um valor para levantamento: ");
            double quantiaLev = double.Parse(Console.ReadLine());
            c1.ReduzirSaldo(quantiaLev);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c1);
        }   
        else
        {
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(c1);

            Console.Write("Insira um valor para depósito: ");
            double quantiaDep = double.Parse(Console.ReadLine());
            c1.AumentarSaldo(quantiaDep);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c1);

            Console.WriteLine("Insira um valor para levantamento: ");
            double quantiaLev = double.Parse(Console.ReadLine());
            c1.ReduzirSaldo(quantiaLev);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c1);
        }












        /*Conta c1 = new Conta();

        Console.Write("Insira o número da conta: ");
        c1.Nconta = int.Parse(Console.ReadLine());
        Console.Write("Insira o titular da conta: ");
        c1.Tconta = Console.ReadLine();
        Console.Write("Haverá depósito inicial? s/n");
        c1.DepInicial = Console.ReadLine();
        if (c1.DepInicial = 's')
        {
            Console.Write("Insira o valor do depósito inicial:");
            c1.QuantiaDepInicial = double.Parse(Console.ReadLine());
            c1.Saldo = c1.QuantiaDepInicial;
            Console.WriteLine("Dados da conta:");
            Console.WriteLine("Conta " + c1.Nconta + ", Titular: " + c1.Tconta + ", Saldo: " + c1.Saldo + "€");
            Console.Write("Insira um valor para depósito: ");
            c1.quantiaDep = double.Parse(Console.ReadLine());
            c1.Saldo = c1.Saldo + c1.quantiaDep;
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine("Conta " + c1.Nconta + ", Titular: " + c1.Tconta + ", Saldo: " + c1.Saldo + "€");
            Console.WriteLine("Insira um valor para levanamento: ");
            c1.quantiaLev = double.Parse (Console.ReadLine());
            c1.Saldo = c1.Saldo - c1.quantiaLev - 5.0;
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine("Conta " + c1.Nconta + ", Titular: " + c1.Tconta + ", Saldo: " + c1.Saldo + "€");
        }
        else
        {
            Console.WriteLine("Dados da conta:");
            Console.WriteLine("Conta " + c1.Nconta + ", Titular: " + c1.Tconta + ", Saldo: " + c1.Saldo + "€");
            Console.Write("Insira um valor para depósito: ");
            c1.quantiaDep = double.Parse(Console.ReadLine());
            c1.Saldo = c1.Saldo + c1.quantiaDep;
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine("Conta " + c1.Nconta + ", Titular: " + c1.Tconta + ", Saldo: " + c1.Saldo + "€");
            Console.WriteLine("Insira um valor para levanamento: ");
            c1.quantiaLev = double.Parse(Console.ReadLine());
            c1.Saldo = c1.Saldo - c1.quantiaLev - 5.0;
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine("Conta " + c1.Nconta + ", Titular: " + c1.Tconta + ", Saldo: " + c1.Saldo + "€");
        }*/
    }
}