using System;
using System.Collections.Generic;

namespace Ahorcado
{
    public class PalabrasEnMemoria : IRepositorioPalabras
    {
        private readonly string _categoriaSeleccionada;
        // Usamos un diccionario para manejar las categorías y sus palabras
        private readonly Dictionary<string, List<string>> _categorias = new(StringComparer.OrdinalIgnoreCase)
        {
            { "Arquitectura", new List<string> { "microservicios", "monolito", "cliente", "servidor", "patrones" } },
            { "POO", new List<string> { "polimorfismo", "herencia", "encapsulamiento", "abstraccion", "clase" } },
            { ".NET", new List<string> { "clr", "nuget", "sdk", "views", "framework" } }
        };
        public PalabrasEnMemoria(string categoria) {
        _categoriaSeleccionada = categoria; // Categoría por defecto
        }

        // Este método NO cambia su firma, por lo que MotorAhorcado ni se entera del cambio
        public string ObtenerPalabraAleatoria()
        {
            var random = new Random();
            if (_categorias.ContainsKey(_categoriaSeleccionada))
            {
                var palabras = _categorias[_categoriaSeleccionada];
                return palabras[random.Next(palabras.Count)];

            }

            return "error";
        }
    }
}