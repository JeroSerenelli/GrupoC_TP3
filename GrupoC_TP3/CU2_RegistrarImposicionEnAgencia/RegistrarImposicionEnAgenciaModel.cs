using GrupoC_TP3.Almacenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC_TP3.CU2_RegistrarImposicionEnAgencia;

internal class RegistrarImposicionEnAgenciaModel
{
    //private long[] listaClientes = new long[] { 12345678910, 99999999 };


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
        //A este metodo le tenemos que pasar la cantidad de cajas para uqe genere una guía por caja.
        //encomiendas.NumeroGuia = encomiendas.NumeroGuia;

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

        /*if (!listaClientes.Contains(encomiendas.Cliente))
        {
            MessageBox.Show("El cliente no se encuentra registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }*/


        for (int i = 0; i < encomiendas.CantidadCajas; i++)
        {
            var listItem = new ListViewItem();
            //Generar numero de guia//
            encomiendas.NumeroGuia = (encomiendas.CodigoAgencia.ToString() + ((DateTime.Now.Ticks)).ToString());
            //Fin generar numero de guia//

            listItem.Text = encomiendas.NumeroGuia;
            listItem.SubItems.Add(encomiendas.Provincia);
            listItem.SubItems.Add(encomiendas.Localidad);
            listItem.SubItems.Add(encomiendas.MetodoEntrega);
            listItem.SubItems.Add(encomiendas.CodigoPostal.ToString());
            listItem.SubItems.Add(encomiendas.CentroDistribucionDestino);
            listItem.SubItems.Add(encomiendas.Domicilio);
            listItem.SubItems.Add(encomiendas.CantidadCajas.ToString());
            listItem.SubItems.Add(encomiendas.TipoCaja);
            listItem.SubItems.Add(encomiendas.NombreDestinatario);
            listItem.SubItems.Add(encomiendas.ApellidoDestinatario);
            listItem.SubItems.Add(encomiendas.DNI.ToString());
            listItem.SubItems.Add(encomiendas.CodigoAgencia.ToString());

            MessageBox.Show("Guia generada exitosamente: " + encomiendas.NumeroGuia);

            //ListViewItem.Item


        }
    }


    public Ubicacion ObtenerUbicacion()
    {

        var ubicacion = new Ubicacion
        {
            ProvinciasYLocalidades = new Dictionary<string, List<string>>
            {
                { "Buenos Aires", new List<string> { "La Plata", "Mar del Plata", "Bahía Blanca" } },
                { "Córdoba", new List<string> { "Córdoba Capital", "Villa María", "Río Cuarto" } },
                { "Santa Fe", new List<string> { "Rosario", "Santa Fe Capital", "Rafaela" } },

            },

            CodigoPostalCentroDistribucion = new Dictionary<string, string>
            {
                { "1900", "Centro La Plata" },
                { "7600", "Centro Mar del Plata" },
                { "8000", "Centro Bahía Blanca" },
                { "5000", "Centro Córdoba Capital" },
                { "5900", "Centro Villa María" },
                { "5800", "Centro Río Cuarto" },
                { "2000", "Centro Rosario" },
                { "3000", "Centro Santa Fe Capital" },
                { "2300", "Centro Rafaela" }
            }
        };

        return ubicacion;
    }
}
