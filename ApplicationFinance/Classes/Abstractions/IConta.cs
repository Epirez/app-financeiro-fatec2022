using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationFinance.Classes.Abstractions
{
    public interface IConta

    {
        public void Transferir(decimal valorTransferencia, Conta origem, Conta destino);
    }
}
