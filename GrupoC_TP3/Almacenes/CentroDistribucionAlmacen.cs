using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC_TP3.Almacenes
{
    static class CentroDistribucionAlmacen
    {
        public static List<CentroDistribucionEntidad> centrosDistribucion = new List<CentroDistribucionEntidad>();

        static CentroDistribucionAlmacen()
        {
            if (File.Exists("CentrosDistribucion.json"))
            {
                var centroDistribucionJson = File.ReadAllText("CentrosDistribucion.json");
                centrosDistribucion = System.Text.Json.JsonSerializer.Deserialize<List<CentroDistribucionEntidad>>(centroDistribucionJson) ?? new List<CentroDistribucionEntidad>();
            }
        }

        /*public static void GuardarCentroDistribucion() ABM 30/10: comentado dado que no tenemos por que guardar cambios en este almacen.
        {
            var centroDistribucionJson = System.Text.Json.JsonSerializer.Serialize(centrosDistribucion);
            File.WriteAllText("CentrosDistribucion.json", centroDistribucionJson);

        }*/
    }
}
