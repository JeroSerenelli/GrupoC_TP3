using System;
using System.Collections.Generic;
using System.Linq;
using GrupoC_TP3.Almacenes;
using GrupoC_TP3.CU9_CuentaCorriente;       

namespace GrupoC_TP3.CU9_CuentaCorriente     // ⚠ Ajustá al namespace de tu proyecto
{
    internal class CuentaCorrienteModel
    {
        // -------------------------
        // Helpers
        // -------------------------
        private static string Digitos(string s) =>
            new string((s ?? string.Empty).Where(char.IsDigit).ToArray());

        private static bool TryCuitToLong(string? cuit, out long value)
        {
            var digits = Digitos(cuit ?? "");
            return long.TryParse(digits, out value);
        }

        // -------------------------
        // Validaciones
        // -------------------------
        public bool IsValidCuitSelected(string? cuit) =>
            !string.IsNullOrWhiteSpace(cuit);

        public bool IsValidDateRange(DateTime inicio, DateTime fin) =>
            fin.Date >= inicio.Date;

        // -------------------------
        // Datos para la UI
        // -------------------------
        public IEnumerable<string> GetCuits()
        {
            // Devuelve CUITs como vienen de los almacenes (solo dígitos)
            return ClienteAlmacen.clientes
                .Select(c => c.CUITCUIL.ToString())
                .Distinct()
                .OrderBy(c => c);
        }

        public Cliente? GetClienteByCuit(string cuit)
        {
            if (!TryCuitToLong(cuit, out var cuitNum))
                return null;

            // Comparación NUMÉRICA con la entidad del almacén
            var ce = ClienteAlmacen.clientes
                .FirstOrDefault(c => c.CUITCUIL == cuitNum);

            if (ce is null) return null;

            // Map Entidad → Clase del CU9
            return new Cliente
            {
                CUITCUIL = ce.CUITCUIL.ToString(),
                RazonSocial = ce.RazonSocial
            };
        }

        // -------------------------
        // Cálculo principal
        // -------------------------
        public EstadoCuentaPeriodo CalcularEstadoCuenta(string cuit, DateTime inicio, DateTime fin)
        {
                    var cliente = GetClienteByCuit(cuit)
                ?? throw new InvalidOperationException("CUIT inexistente.");

            if (!TryCuitToLong(cuit, out var cuitNum))
                throw new InvalidOperationException("CUIT inválido.");

            // 1) Todos los movimientos del cliente (comparación numérica)
            var movsCliente = CuentaCorrienteAlmacen.cuentasCorrientes
                .Where(m => m.CUITCUIL == cuitNum)
                .OrderBy(m => m.FechaMovimiento)
                .ToList();

            // 2) Saldo anterior al período
            decimal saldoInicial = movsCliente
                .Where(m => m.FechaMovimiento.Date < inicio.Date)
                .Sum(m => m.Monto);

            // 3) Movimientos dentro del período (inclusive)
            var movsPeriodo = movsCliente
                .Where(m => m.FechaMovimiento.Date >= inicio.Date &&
                            m.FechaMovimiento.Date <= fin.Date)
                .ToList();

            // 4) Construcción de items con saldo acumulado
            var items = new List<EstadoCuentaItem>();
            decimal saldo = saldoInicial;

            foreach (var m in movsPeriodo)
            {
                saldo += m.Monto;
                items.Add(new EstadoCuentaItem
                {
                    Fecha = m.FechaMovimiento.Date,
                    Monto = m.Monto,
                    Saldo = saldo
                });
            }

            return new EstadoCuentaPeriodo
            {
                Cliente = cliente,
                InicioPeriodo = inicio.Date,
                FinPeriodo = fin.Date,
                SaldoInicial = saldoInicial,
                SaldoFinal = saldo,
                Items = items
            };
        }
    }
}
