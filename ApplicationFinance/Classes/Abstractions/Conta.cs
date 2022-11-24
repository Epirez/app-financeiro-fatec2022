namespace ApplicationFinance.Classes.Abstractions
{
    public abstract class Conta : IConta
    {
        protected decimal Saldo { get; set; }

        public abstract void Sacar(decimal valorSaque);

        public abstract void Depositar(decimal valorDeposito);

        public decimal ObterSaldo() => Saldo;

        public virtual void Transferir(decimal valorTransferencia, Conta origem, Conta destino)
        {
            if (origem.ObterSaldo() - valorTransferencia < 0)
                Console.WriteLine($"Saldo Induficiente");
            else
            {
                origem.Sacar(valorTransferencia);
                destino.Depositar(valorTransferencia);
            }
        }
    }
}