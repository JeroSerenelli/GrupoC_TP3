using GrupoC_TP3.CU6_EntregaEncomiendas;
using GrupoC_TP3.CU7_ConsultaEstadoGuia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GrupoC_TP3.CU6_EntregaEncomiendas.Encomienda;

namespace GrupoC_TP3.Entrega_de_Encomiendas_en_Agencia
{
    internal class EntregaEncomiendasModel
    {
        public List<Encomienda> Encomiendas { get; } = new List<Encomienda>()
        {
            new Encomienda { Dni = 1111, Nombre = "Juan", Apellido = "Perez", NroGuia = "1234" , Estado = "En camino a CD" },
            new Encomienda { Dni = 1111, Nombre = "Juan", Apellido = "Perez", NroGuia = "1234" , Estado = "En camino a CD" },
            new Encomienda { Dni = 1111, Nombre = "Juan", Apellido = "Perez", NroGuia = "1234" , Estado = "En camino a CD" },
        };
    }
}


