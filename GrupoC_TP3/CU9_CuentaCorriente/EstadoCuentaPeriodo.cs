using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC_TP3.CU9_CuentaCorriente
{
    public class EstadoCuentaPeriodo
    {
        public Cliente Cliente { get; set; } = new();
        public DateTime InicioPeriodo { get; set; }
        public DateTime FinPeriodo { get; set; }
        public decimal SaldoInicial { get; set; }
        public decimal SaldoFinal { get; set; }
        public List<EstadoCuentaItem> Items { get; set; } = new();
    }
}

