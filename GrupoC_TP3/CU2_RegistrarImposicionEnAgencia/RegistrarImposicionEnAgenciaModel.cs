using GrupoC_TP3.Almacenes;
using GrupoC_TP3.CU1_RegistrarImposicionRetiroPorDomicilio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC_TP3.CU2_RegistrarImposicionEnAgencia;

internal class RegistrarImposicionEnAgenciaModel
{
    private Dictionary<int, List<LocalidadEntidad>> _localidadesPorCodProv;
    private Dictionary<string, int> _codProvPorNombre;
    private bool _indicesConstruidos;

    private void ConstruirIndicesProvinciasYLocalidades()
    {
        if (_indicesConstruidos) return;

        var provincias = ProvinciaAlmacen.provincias ?? new List<ProvinciaEntidad>();
        var localidades = LocalidadAlmacen.localidades ?? new List<LocalidadEntidad>();

        _codProvPorNombre = provincias
            .GroupBy(p => p.Nombre, StringComparer.OrdinalIgnoreCase)
            .ToDictionary(g => g.Key, g => g.First().CodProv, StringComparer.OrdinalIgnoreCase);

        _localidadesPorCodProv = localidades
            .GroupBy(l => l.CodProv)
            .ToDictionary(
                g => g.Key,
                g => g.OrderBy(l => l.Nombre).ToList()
            );

        _indicesConstruidos = true;
    }

    public int CodigoAgenciaActual => AgenciaAlmacen.AgenciaActual?.CodAgencia ?? 0;

    public List<string> LocalidadesDeProvincia(string nombreProvincia)
    {
        ConstruirIndicesProvinciasYLocalidades();

        if (string.IsNullOrWhiteSpace(nombreProvincia))
            return new List<string>();

        if (!_codProvPorNombre.TryGetValue(nombreProvincia, out var codProv))
            return new List<string>();

        if (!_localidadesPorCodProv.TryGetValue(codProv, out var locs))
            return new List<string>();

        return locs.Select(l => l.Nombre)
                   .Distinct(StringComparer.OrdinalIgnoreCase)
                   .OrderBy(n => n, StringComparer.OrdinalIgnoreCase)
                   .ToList();
    }
    public Ubicacion ObtenerUbicacion1()
    {
        var ubicacion = new Ubicacion
        {
            ProvinciasYLocalidades = ProvinciaAlmacen.provincias.Select(p => new
            {
                p.Nombre,
                Localidades = LocalidadAlmacen.localidades.Where(l => l.CodProv == p.CodProv)
                                                          .Select(l => l.Nombre)
                                                          .OrderBy(n => n)
                                                          .ToList()
            }).ToDictionary(p => p.Nombre, v => v.Localidades),

            CodigoPostalCentroDistribucion = CentroDistribucionAlmacen.centrosDistribucion
                                                                      .ToDictionary(cd => cd.CodPostal.ToString("0000"), cd => cd.Nombre)
        };

        return ubicacion;
    }

    internal void ValidarCliente(ValidarCliente validarCliente)
    {
        if (validarCliente.CUITCUIL <= 0)
        {
            MessageBox.Show("El campo CUIT/CUIL debe ser un numero positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return;
        }

        if (validarCliente.CUITCUIL.ToString().Length != 11)
        {
            MessageBox.Show("El campo CUIT/CUIL debe tener 11 digitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return;
        }


        if (!ClienteAlmacen.clientes.Any(c => c.CUITCUIL == validarCliente.CUITCUIL))
        {
            MessageBox.Show("El cliente no se encuentra registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            MessageBox.Show("El cliente es válido.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    internal void CrearEncomienda(Encomienda encomiendas)
    {
        if (encomiendas.DNI < 100000 || encomiendas.DNI > 99999999)
        {
            MessageBox.Show("El DNI del destinatario ingresado es invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (encomiendas.CodigoPostal < 1000)
        {
            MessageBox.Show("El Codigo Postal ingresado es invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (encomiendas.Cliente <= 0)
        {
            MessageBox.Show("El campo CUIT/CUIL debe ser un numero positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return;
        }

        if (encomiendas.Cliente.ToString().Length != 11)
        {
            MessageBox.Show("El campo CUIT/CUIL debe tener 11 digitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return;
        }

        if (!ClienteAlmacen.clientes.Any(c => c.CUITCUIL == encomiendas.Cliente))
        {
            MessageBox.Show("El cliente no se encuentra registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        int codAgencia = AgenciaAlmacen.AgenciaActual.CodAgencia;

        int codCentroDistribucionOrigen = AgenciaAlmacen.agencias
            .Where(a => a.CodAgencia == codAgencia)
            .Select(a => a.CodCentroDist)
            .FirstOrDefault();

        int codCentroDistribucionDestino = CentroDistribucionAlmacen.centrosDistribucion
            .Where(cd => cd.Nombre.Equals(encomiendas.CentroDistribucionDestino, StringComparison.OrdinalIgnoreCase))
            .Select(cd => cd.CodCentroDist)
            .FirstOrDefault();

        var numerosCreados = new List<int>();

        

        for (int i = 0; i < encomiendas.CantidadCajas; i++)
        {
            int ultimoNumeroGuia = GuiaAlmacen.guias.LastOrDefault()?.NumeroGuia ?? 0;

            ultimoNumeroGuia += 1;

            string ultimosCincoDigitos = (ultimoNumeroGuia % 100000).ToString("D5");

            var tamañoSeleccionado = Enum.Parse<TamañoCaja>(encomiendas.TipoCaja?.Trim(), ignoreCase: true);

            decimal importeBase = TarifaAlmacen.tarifas
                         .Where(t => t.TamañoCaja == tamañoSeleccionado
                             && t.CentroDistribucionOrigen == codCentroDistribucionOrigen
                             && t.CentroDistribucionDestino == codCentroDistribucionDestino)
                             .Select(t => t.Importe)
                             .Single();

            decimal cargoAgencia = 0;

            if (encomiendas.MetodoEntrega.Equals("Entrega en Domicilio", StringComparison.OrdinalIgnoreCase))
            {
                importeBase += AdicionalesYComisionesAlmacen.adicionalesComisiones
                                    .Where(a => a.Concepto == Concepto.EntregaDomicilio)
                                    .Select(a => a.Monto)
                                    .Sum();
            }

            if (encomiendas.MetodoEntrega.Equals("Retiro en Agencia", StringComparison.OrdinalIgnoreCase))
            {
                importeBase += AdicionalesYComisionesAlmacen.adicionalesComisiones
                                    .Where(a => a.Concepto == Concepto.EntregaAgencia)
                                    .Select(a => a.Monto)
                                    .Sum();

                cargoAgencia += AdicionalesYComisionesAlmacen.adicionalesComisiones
                                    .Where(a => a.Concepto == Concepto.EntregaAgencia)
                                    .Select(a => a.Monto).Single();
            }

            cargoAgencia += AdicionalesYComisionesAlmacen.adicionalesComisiones
                                .Where(c => c.Concepto == Concepto.EntregaAgencia)
                                .Select(c => c.Monto).Single();

            decimal finalAgencia = cargoAgencia / 2m;

            decimal importe = importeBase;

            decimal cargoFlete = AdicionalesYComisionesAlmacen.adicionalesComisiones
                                .Where(f => f.Concepto == Concepto.ComisionFleteroPorBulto)
                                .Select(f => f.Monto).Single();


            GuiaAlmacen.guias.Add(new GuiaEntidad
            {
                NumeroGuia = int.Parse(codAgencia.ToString() + ultimosCincoDigitos),
                CUITCUIL = encomiendas.Cliente,
                CodPostalDest = encomiendas.CodigoPostal,
                MetodoEntrega = encomiendas.MetodoEntrega switch
                {
                    "Retiro en Agencia" => MetodoEntrega.EntregaEnAgencia,
                    "Entrega en Domicilio" => MetodoEntrega.EntregaEnDomicilio,
                    "Retiro en CD Destino" => MetodoEntrega.EntregaEnCentroDeDistribucion
                },
                DomicilioDest = encomiendas.Domicilio,
                TamañoCaja = encomiendas.TipoCaja switch
                {
                    "S" => TamañoCaja.S,
                    "M" => TamañoCaja.M,
                    "L" => TamañoCaja.L,
                    "XL" => TamañoCaja.XL
                },
                CodPostalOrig = AgenciaAlmacen.agencias
                                    .Where(a => a.CodAgencia == codAgencia)
                                    .Select(a => a.CodPostalAgencia)
                                    .FirstOrDefault(),
                DomicilioOrigen = "Retiro en Agencia",
                NombreDestinatario = encomiendas.NombreDestinatario,
                ApellidoDestinatario = encomiendas.ApellidoDestinatario,
                DNIDestinatario = encomiendas.DNI,
                Importe = importe,
                CargosFleteros = cargoFlete,
                CargosAgencia = finalAgencia,
                CodAgenciaOrigen = codAgencia,
                CodCentroDistOrigen = codCentroDistribucionOrigen,
                EstadoEncomienda = EstadoEncomiendaEnum.ListoParaRetirarEnAgencia,
                HistorialEstadosGuia = new List<HistorialEstadoGuia>
                {
                    new HistorialEstadoGuia
                    {
                        EstadoGuia = EstadoEncomiendaEnum.ListoParaRetirarEnAgencia,
                        Fecha = DateTime.Now,
                        Descripcion = "Encomienda creada y lista para ser retirada en agencia."
                    }
                }
            });

            GuiaAlmacen.GuardarGuia();

            numerosCreados.Add(GuiaAlmacen.guias.Last().NumeroGuia);

            MessageBox.Show("La encomienda ha sido creada con exito. El numero de guia es: " + GuiaAlmacen.guias.Last().NumeroGuia.ToString(), "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        GenerarHojaDeRutaFleteParaRetiro(encomiendas, numerosCreados);
        GenerarHojaDeRutaFleteParaEntrega(encomiendas, numerosCreados);
        GenerarHojaDeRutaMicro(encomiendas, numerosCreados);
    }


    internal void GenerarHojaDeRutaFleteParaRetiro(Encomienda encomiendas, List<int> numerosGuiasCreadas)
        {
            if (numerosGuiasCreadas == null || numerosGuiasCreadas.Count == 0) return;

            // 1) Número de hoja de ruta: último + 1
            int nuevoNumeroHoja = (HojaRutaFleteAlmacen.hojasRutaFletes.LastOrDefault()?.HojaRutaFlete ?? 0) + 1;

            // 2) DNI del fletero por CP de ORIGEN de la encomienda
            int cpOrigen = encomiendas.CodigoPostal; // <-- usa el CP de la encomienda
            int dniFletero = FleteroAlmacen.fleteros
                                .FirstOrDefault(f => f.CodPostalActividad == cpOrigen)?.DNIFletero ?? 0;

            // 3) Armar los NumerosGuiaFlete con estado inicial apropiado
            var numerosGuiaFlete = numerosGuiasCreadas
                .Distinct()
                .Select(n => new NumeroGuiaFlete
                {
                    NumeroGuia = n,
                    // Para retiros por domicilio recién creados:
                    EstadoEncomienda = EstadoEncomiendaEnum.ListoParaRetirarEnAgencia
                })
                .ToList();

            // 4) Crear entidad y persistir
            var hoja = new HojaRutaFleteEntidad
            {
                HojaRutaFlete = nuevoNumeroHoja,
                NumerosGuiaFlete = numerosGuiaFlete,
                DNIFletero = dniFletero,                       // puede quedar 0 si no hay fletero para ese CP
                EstadoHojaRutaFlete = EstadoHojaRutaFlete.PendienteAsignacion,
                TipoHojaRuta = TipoHojaRuta.Retiro,
                CodPostal = cpOrigen
            };

            HojaRutaFleteAlmacen.hojasRutaFletes.Add(hoja);
            HojaRutaFleteAlmacen.GuardarHojaDeRutaFlete();
        }

    internal void GenerarHojaDeRutaFleteParaEntrega(Encomienda encomiendas, List<int> numerosGuiasCreadas)
    {
        if (encomiendas.MetodoEntrega == "Entrega en Domicilio")
        {

            if (numerosGuiasCreadas == null || numerosGuiasCreadas.Count == 0) return;

            // 1) Número de hoja de ruta: último + 1
            int nuevoNumeroHoja = (HojaRutaFleteAlmacen.hojasRutaFletes.LastOrDefault()?.HojaRutaFlete ?? 0) + 1;

            // 2) DNI del fletero por CP de ORIGEN de la encomienda
            int cpDestino = AgenciaAlmacen.agencias
                                .Where(a => a.CodAgencia == encomiendas.CodigoAgencia)
                                .Select(a => a.CodPostalAgencia)
                                .FirstOrDefault(); // <-- usa el CP de la encomienda
            int dniFletero = FleteroAlmacen.fleteros
                                .FirstOrDefault(f => f.CodPostalActividad == cpDestino)?.DNIFletero ?? 0;

            // 3) Armar los NumerosGuiaFlete con estado inicial apropiado
            var numerosGuiaFlete = numerosGuiasCreadas
                .Distinct()
                .Select(n => new NumeroGuiaFlete
                {
                    NumeroGuia = n,
                    // Para retiros por domicilio recién creados:
                    EstadoEncomienda = EstadoEncomiendaEnum.ListoParaRetirarEnAgencia
                })
                .ToList();

            // 4) Crear entidad y persistir
            var hoja = new HojaRutaFleteEntidad
            {
                HojaRutaFlete = nuevoNumeroHoja,
                NumerosGuiaFlete = numerosGuiaFlete,
                DNIFletero = dniFletero,                       // puede quedar 0 si no hay fletero para ese CP
                EstadoHojaRutaFlete = EstadoHojaRutaFlete.PendienteAsignacion,
                TipoHojaRuta = TipoHojaRuta.Entrega,
                CodPostal = cpDestino
            };

            HojaRutaFleteAlmacen.hojasRutaFletes.Add(hoja);
            HojaRutaFleteAlmacen.GuardarHojaDeRutaFlete();
        }
    }

    internal void GenerarHojaDeRutaMicro(Encomienda encomiendas, List<int> numerosGuiasCreadas)
    {


        if (numerosGuiasCreadas == null || numerosGuiasCreadas.Count == 0) return;

        // 1) Número de hoja de ruta: último + 1
        int nuevoNumeroHoja = (HojaRutaMicroAlmacen.hojasRutaMicros.LastOrDefault()?.HojaRutaMicro ?? 0) + 1;

        // 2) DNI del fletero por CP de ORIGEN de la encomienda
        //int cpDestino = encomiendas.CPDestino; // <-- usa el CP de la encomienda
        //int dniFletero = FleteroAlmacen.fleteros
        //                 .FirstOrDefault(f => f.CodPostalActividad == cpDestino)?.DNIFletero ?? 0;

        // 3) Armar los NumerosGuiaFlete con estado inicial apropiado
        var numerosGuiaMicro = numerosGuiasCreadas
            .Distinct()
            .Select(n => new NumeroGuiaMicro
            {
                NumeroGuia = n,
                // Para retiros por domicilio recién creados:
                EstadoEncomienda = EstadoEncomiendaEnum.EntregadoEnCentroDeDistribucion
            })
            .ToList();

        static DateTime ProximaFecha(IReadOnlyCollection<DayOfWeek> dias, TimeSpan hora, DateTime refNow)
        {
            // Asume que 'hora' es la hora en que el micro inicia su cronograma (primer CD del recorrido).
            // Si tu cronograma guarda hora "en cada parada", reemplazalo por esa hora en el origen.
            for (int i = 0; i <= 7; i++)
            {
                var d = refNow.Date.AddDays(i);
                if (dias.Contains(d.DayOfWeek))
                {
                    var candidato = d + hora;
                    if (candidato >= refNow) return candidato;
                }
            }
            // En teoría no llega acá, pero por las dudas:
            return refNow;
        }

        // --- 3) Buscar el mejor micro que haga DIRECTO origen -> destino ---
        var candidato = CronogramaOmnibusAlmacen.cronogramasOmnibus
            .Select(c => new
            {
                Crono = c,
                IdxO = AgenciaAlmacen.agencias
                        .Where(a => a.CodAgencia == CodigoAgenciaActual)
                        .Select(a => a.CodCentroDist)
                                                .FirstOrDefault(),
                IdxD = CentroDistribucionAlmacen.centrosDistribucion
                                                        .First(cd => cd.CodPostal == encomiendas.CodigoPostal)
                                                        .CodCentroDist,

            })
            .Where(x => x.IdxO >= 0 && x.IdxD >= 0) // respeta el sentido
            .Select(x =>
            {
                // Si tuvieras tiempos por tramo, podés sumar el offset al llegar al origen:
                // var offset = TimeSpan.FromMinutes(x.IdxO * MINUTOS_PROMEDIO_POR_TRAMO);
                // ej. TimeSpan 08:00
                // + offset si corresponde
                return new
                {
                    x.Crono.PatenteMicro,


                };
            })
            // (tie-break: el que arranca más cerca del origen)
            .FirstOrDefault();

        //var patenteMicro = CronogramaOmnibusAlmacen.cronogramasOmnibus
        //   .Select(e => e.PatenteMicro)
        // .Where(e => CronogramaOmnibusAlmacen.reco)

        // 4) Crear entidad y persistir
        var hoja = new HojaRutaMicroEntidad
        {
            HojaRutaMicro = nuevoNumeroHoja,
            NumerosGuiaMicro = numerosGuiaMicro,
            PatenteMicro = candidato.PatenteMicro,
            FechaEmisionHojaDeRuta = DateTime.Now,
            EstadoHojaRutaMicro = EstadoHojaRutaMicro.ListoParaDespacharEnCentroDeDistribucion,
            CentroDistribucionDestino = CentroDistribucionAlmacen.centrosDistribucion
                                                        .First(cd => cd.CodPostal == encomiendas.CodigoPostal)
                                                        .CodCentroDist,
            CentroDistribucionOrigen = AgenciaAlmacen.agencias
                        .Where(a => a.CodAgencia == CodigoAgenciaActual)
                        .Select(a => a.CodCentroDist)
                                                .FirstOrDefault(),

            
        };

        HojaRutaMicroAlmacen.hojasRutaMicros.Add(hoja);
        HojaRutaMicroAlmacen.GuardarHojaDeRutaMicro();
    }

}
