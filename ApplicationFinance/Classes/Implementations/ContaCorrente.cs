using ApplicationFinance.Classes.Abstractions;

namespace ApplicationFinance.Classes.Implementations
{
    public class ContaCorrente : Conta
    {
        public override void Depositar(decimal valorDeposito) => Saldo += valorDeposito;

        public override void Sacar(decimal valorSaque) => Saldo -= valorSaque;

        //public override void Transferir(decimal valorTransferencia, Conta origem, Conta destino)
        //{
        //    if (origem.ObterSaldo() - valorTransferencia < 0)
        //        Console.WriteLine($"Saldo Induficiente");
        //    else
        //    {
        //        origem.Sacar(valorTransferencia);
        //        destino.Depositar(valorTransferencia);
        //    }
        //}
    }
}