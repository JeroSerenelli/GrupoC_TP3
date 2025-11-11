using GrupoC_TP3.Almacenes;
using GrupoC_TP3.CU8_EmisionFacturas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GrupoC_TP3.CU8_EmisionFacturas.Factura;

namespace GrupoC_TP3.CU3_EmisionFacturas
{
    internal class EmisionFacturasModel
    {
        internal bool GenerarFactura(long Cuit, decimal Importe)
        {
            //NO SE COMO ES EL TEMA DE NUMERO DE FACTURA, SE ME OCURRIO ESTA IDEA DE AGARRAR LA ULTIMA FACTURA Y SUMARLE 1, EL CODIGO LO HIZO CHATGPT
            int NumeroFactura = Almacenes.FacturaAlmacen.facturas.Max(f => f.NumeroFactura) + 1;

            //BUSCAMOS EL CLIENTE EN EL ALMACEN DE CLIENTES Y LO ASIGNO A LA VARIABLE CLIENTE, PARA LUEGO TRABAJAR CON ELLO
            Almacenes.ClienteEntidad? Cliente = Almacenes.ClienteAlmacen.clientes.FirstOrDefault(c => c.CUITCUIL == Cuit);
            //SI EL CLIENTE ES NULO, QUIERE DECIR QUE NO ESTA REGISTRADO
            if (Cliente is null)
            {
                MessageBox.Show("El cliente no se encuentra registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //CREO LA NUEVA FACTURA Y LE ASIGNO LOS VALORES CORRESPONDIENTES
            Almacenes.FacturaEntidad FacturaNueva = new();
            //COMIENZO A ASIGNAR LOS VALORES
            FacturaNueva.NumeroFactura = NumeroFactura;
            FacturaNueva.TipoFactura = Cliente.CondicionCliente == CondicionCliente.ResponsableInscripto ? TipoFactura.A : TipoFactura.B;
            FacturaNueva.CUITCUIL = Cuit;   
            FacturaNueva.Total = Importe;   
            FacturaNueva.FechaEmision = DateTime.Now;   
            FacturaNueva.EstadoFactura = EstadoFactura.Emitida;
            //AHORA LO AÑADO AL ALMACEN DE FACTURAS Y GUARDO LOS CAMBIOS
            Almacenes.FacturaAlmacen.facturas.Add(FacturaNueva);
            //LLAMO AL METODO DE GUARDAR FACTURAS YA CREADO ANTERIORMENTE EN EL ALMACEN
            Almacenes.FacturaAlmacen.GuardarFacturas();

            return true;
            
        }

        //vamos a vincular el numero de cuil con un listado de numeros de guia nuevos 

        internal bool ValidacionCuil(string Cuil)
        {
            
            //Que sea un NUMERO
            if (!long.TryParse(Cuil, out long salida))
            {
                MessageBox.Show("El numero de CUIT/CUIL ingresado es invalido, por favor revise", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //Que sea POSITIVO
            if (salida <= 0)
            {
                MessageBox.Show("El campo CUIL/CUIT debe ser un numero positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                
            }
            //Que tenga 11 digitos
            if (salida.ToString().Length != 11)
            {
                MessageBox.Show("El campo CUIL/CUIT debe tener 11 digitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            //BUSCAMOS EN EL ALMACEN DE CLIENTE ALMACEN SI EXISTEN LOS CLIENTES
            if (!ClienteAlmacen.clientes.Any(g => g.CUITCUIL == salida))
            {
                MessageBox.Show("El cliente no se encuentra registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //BUSCAMOS EN EL ALMACEN DE GUIA ALMACEN SI TIENE PEDIDOS PARA FACTURAR EL CUIL INGRESADO
            if (!GuiaAlmacen.guias.Any(g => g.CUITCUIL == salida))
            {
                MessageBox.Show("El CUIL/CUIT ingresado no tiene pedidos para facturar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //BUSCAMOS EN EL ALMACEN DE GUIA ALMACEN SI LA GUIA TIENE ESTADO ENTREGADO
            if (!GuiaAlmacen.guias.Any(g => g.CUITCUIL == salida && g.EstadoEncomienda == EstadoEncomienda.Entregado))
            {
                MessageBox.Show("El CUIL/CUIT ingresado no tiene pedidos entregados para facturar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;

        }

        //CREO UNA LISTA DE GUIAS QUE VINCULA EL CUIL CON LAS GUIAS
        internal List<Almacenes.GuiaEntidad> ObtenerGuia(long cuit)
        {
            return Almacenes.GuiaAlmacen.guias.Where(g => g.CUITCUIL == cuit).ToList();
        }
    }
}
