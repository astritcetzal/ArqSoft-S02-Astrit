using System;
using System.Collections.Generic;
using System.Text;

namespace Ahorcado // O el nombre del namespace que estés utilizando
{
    public class PalabrasEnMemoria : IRepositorioPalabras
    {
        private readonly List<string> _palabras = new()
        {
            "arquitectura",
            "interfaz",
            "polimorfismo",
            "encapsulamiento",
            "herencia"
        };

        public string ObtenerPalabraAleatoria()
        {
            var random = new Random();
            return _palabras[random.Next(_palabras.Count)];
        }
    }
}