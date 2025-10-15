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


        public List<Factura> CuilValido { get; } = new List<Factura>()
        {
            new Factura {Cuil = 12345678910,NroGuia= 123, SubTotal= 2500 },
            new Factura {Cuil = 12345678910, NroGuia= 789, SubTotal= 3500},
            new Factura {Cuil = 12345678911, NroGuia= 456, SubTotal= 1500},
            new Factura {Cuil = 12345678911, NroGuia= 101, SubTotal= 5000},
        };

       //vamos a vincular el numero de cuil con un listado de numeros de guia nuevos 

        internal void ValidacionCuil(Factura Cuil)
        {
            
            //Sea positivo
            if (Cuil.Cuil <= 0)
            {
                MessageBox.Show("El campo CUIL/CUIT debe ser un numero positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                
            }
            //Sea de 11 digitos
            if (Cuil.Cuil.ToString().Length != 11)
            {
                MessageBox.Show("El campo CUIL/CUIT debe tener 11 digitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
         
            // Validar que el CUIL/CUIT sea un numero valido
         
            //Validamos que no pueda ingresar caracteres especiales
            if (Cuil.Cuil.ToString().Any(ch => !char.IsDigit(ch)))
            {
                MessageBox.Show("El CUIT/CUIL no debe contener caracteres especiales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           /* if ()
                {
                MessageBox.Show("El cliente no se encuentra registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                };

            */

            bool existe = CuilValido.Any(g => g.Cuil == Cuil.Cuil);
            if (!existe)
            {
                MessageBox.Show("El CUIL/CUIT ingresado no tiene pedidos para facturar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            return;

        }
    }
}
