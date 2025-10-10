using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Globalization;

namespace GrupoC_TP3.CU9_CuentaCorriente
{
    internal class CuentaCorrienteModel
    {
        private readonly List<Cliente> _clientes;

        public CuentaCorrienteModel()
        {
            _clientes = new List<Cliente>
            {
                new Cliente
                {
                    CUITCUIL = "20-12345678-9",
                    RazonSocial = "Jorgito SRL",
                    Movimientos = new List<MovimientoCC>
                    {
                        new MovimientoCC{ Fecha = new DateTime(2025, 9, 20), Importe =  5400},
                        new MovimientoCC{ Fecha = new DateTime(2025, 9, 22), Importe = 12000},
                        new MovimientoCC{ Fecha = new DateTime(2025, 9, 22), Importe = 3800},
                        new MovimientoCC{ Fecha = new DateTime(2025, 10, 02), Importe =  9000},
                        new MovimientoCC{ Fecha = new DateTime(2025, 10, 05), Importe = 2500},
                    }
                },
                new Cliente
                {
                    CUITCUIL = "27-98765432-1",
                    RazonSocial = "Racing Club SA",
                    Movimientos = new List<MovimientoCC>
                    {
                        new MovimientoCC{ Fecha = new DateTime(2025, 9, 25), Importe = 3000},
                        new MovimientoCC{ Fecha = new DateTime(2025, 9, 27), Importe =  7800},
                        new MovimientoCC{ Fecha = new DateTime(2025, 10,10), Importe = 6500},
                    }
                }
            };
        }

        public IEnumerable<string> GetCuits() => _clientes.Select(c => c.CUITCUIL);

        public Cliente? GetClienteByCuit(string cuit) =>
            _clientes.FirstOrDefault(c => string.Equals(c.CUITCUIL, cuit, StringComparison.OrdinalIgnoreCase));

        public bool IsValidCuitSelected(string? cuit) =>
            !string.IsNullOrWhiteSpace(cuit);

        public bool IsValidDateRange(DateTime inicio, DateTime fin) =>
            fin.Date >= inicio.Date;


        public EstadoCuentaPeriodo CalcularEstadoCuenta(string cuit, DateTime inicio, DateTime fin)
        {
            var cli = GetClienteByCuit(cuit) ?? throw new InvalidOperationException("CUIT inexistente.");

            var saldoInicial = cli.Movimientos
                                  .Where(m => m.Fecha.Date < inicio.Date)
                                  .Sum(m => m.Importe);

            var movsPeriodo = cli.Movimientos
                                 .Where(m => m.Fecha.Date >= inicio.Date && m.Fecha.Date <= fin.Date)
                                 .OrderBy(m => m.Fecha)
                                 .ToList();

            var items = new List<EstadoCuentaItem>();
            decimal saldo = saldoInicial;
            foreach (var m in movsPeriodo)
            {
                saldo += m.Importe;
                items.Add(new EstadoCuentaItem
                {
                    Fecha = m.Fecha.Date,
                    Monto = m.Importe,
                    Saldo = saldo,
                });
            }

            return new EstadoCuentaPeriodo
            {
                Cliente = cli,
                InicioPeriodo = inicio.Date,
                FinPeriodo = fin.Date,
                SaldoInicial = saldoInicial,
                SaldoFinal = saldo,
                Items = items
            };
        }
    }
}


