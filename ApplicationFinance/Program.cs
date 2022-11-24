using ApplicationFinance.Classes.Abstractions;
using ApplicationFinance.Classes.Implementations;

namespace ApplicationFinance
{
    internal class Program
    {
        static void Main()
        {
            Conta poupanca = new Poupanca();
            Conta contaCorretente = new ContaCorrente();
            // Conta investimento = new Investimento();

            //Console.WriteLine($"Valor atual do saldo: {poupanca.ObterSaldo()}");
            //poupanca.Depositar(1000m);
            //Console.WriteLine($"Valor atualizada do saldo: {poupanca.ObterSaldo()}");
            //poupanca.Sacar(300m);
            //Console.WriteLine($"Valor atualizada do saldo: {poupanca.ObterSaldo()}");

            //Console.WriteLine($"Valor atual do saldo: {contaCorretente.ObterSaldo()}");
            //contaCorretente.Depositar(1000m);
            //Console.WriteLine($"Valor atualizada do saldo: {contaCorretente.ObterSaldo()}");
            //contaCorretente.Sacar(300m);
            //Console.WriteLine($"Valor atualizada do saldo: {contaCorretente.ObterSaldo()}");

            //Console.WriteLine($"Valor atual do saldo: {investimento.ObterSaldo()}");
            //investimento.Depositar(1000m);
            //Console.WriteLine($"Valor atualizada do saldo: {investimento.ObterSaldo()}");
            //investimento.Sacar(300m);
            //Console.WriteLine($"Valor atualizada do saldo: {investimento.ObterSaldo()}");

            
            poupanca.Depositar(1000m);

            Console.WriteLine($"Valor atualizado da poupança Saldo: {poupanca.ObterSaldo()}");
            Console.WriteLine($"Valor atualizado da conta corrente Saldo: {contaCorretente.ObterSaldo()}");

            poupanca.Transferir(300, poupanca, contaCorretente);

            Console.WriteLine($"Valor atualizado da poupança Saldo: {poupanca.ObterSaldo()}");
            Console.WriteLine($"Valor atualizado da conta corrente Saldo: {contaCorretente.ObterSaldo()}");

        }
    }
}