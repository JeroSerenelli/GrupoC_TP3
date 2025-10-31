using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC_TP3.Almacenes
{
    public enum EstadoEncomienda
    {
        ListoParaRetirarEnDomicilio,
        ListoParaRetirarEnAgencia,
        EnCaminoADomcilicioOAgencia,
        EntregadoEnCentroDeDistribucion,
        EnTransporteEntreCentroDeDistribucion,
        RecibidoEnCentroDistribucionDestino,
        ListoParaRetiroEnAgencia,
        EnCaminoADomicilioDestino,
        Entregado,
        Facturado
    }
}
