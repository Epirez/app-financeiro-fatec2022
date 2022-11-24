﻿using ApplicationFinance.Classes.Abstractions;

namespace ApplicationFinance.Classes.Implementations
{
    public class Investimento : Conta
    {
        public override void Depositar(decimal valorDeposito) => Saldo += valorDeposito;
        
        public override void Sacar(decimal valorSaque) => Saldo -= ((valorSaque - 0.10m) - valorSaque);        
    }
}