using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GrupoC_TP3.Almacenes
{
    static class HojaRutaFleteAlmacen
    {
        public static List<HojaRutaFleteEntidad> hojasRutaFletes = new List<HojaRutaFleteEntidad>();

        static HojaRutaFleteAlmacen()
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Datos", "HojaDeRutaFlete.json");
            if (!File.Exists(path)) path = @"Datos\HojaDeRutaFlete.json";

            if (File.Exists(path))
            {
                var json = File.ReadAllText(path);
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };
                options.Converters.Add(new JsonStringEnumConverter());

                hojasRutaFletes = JsonSerializer.Deserialize<List<HojaRutaFleteEntidad>>(json, options)
                                  ?? new List<HojaRutaFleteEntidad>();
            }
        }

        public static void GuardarHojaDeRutaFlete()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            options.Converters.Add(new JsonStringEnumConverter());

            var json = JsonSerializer.Serialize(hojasRutaFletes, options);
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Datos", "HojaDeRutaFlete.json");
            var dir = Path.GetDirectoryName(path);
            if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir)) Directory.CreateDirectory(dir);
            File.WriteAllText(path, json);
        }
    }
}