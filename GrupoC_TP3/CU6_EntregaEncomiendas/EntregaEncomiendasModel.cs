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
            new Encomienda { Dni = 1111, Nombre = "Juan", Apellido = "Perez", NroGuia = "1234", Estado = "En camino a CD" },
            new Encomienda { Dni = 2222, Nombre = "Maria", Apellido = "Gomez", NroGuia = "1235", Estado = "Despachada" },
            new Encomienda { Dni = 3333, Nombre = "Carlos", Apellido = "Lopez", NroGuia = "1236", Estado = "En preparación" },
            new Encomienda { Dni = 4444, Nombre = "Ana", Apellido = "Martinez", NroGuia = "1237", Estado = "En camino a CD" },
            new Encomienda { Dni = 5555, Nombre = "Luis", Apellido = "Fernandez", NroGuia = "1238", Estado = "Entregada" },
            new Encomienda { Dni = 6666, Nombre = "Sofia", Apellido = "Diaz", NroGuia = "1239", Estado = "Despachada" },
            new Encomienda { Dni = 7777, Nombre = "Pedro", Apellido = "Ramirez", NroGuia = "1240", Estado = "En preparación" }


        };
    }
}


