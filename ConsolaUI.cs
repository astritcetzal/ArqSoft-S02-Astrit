using System;
using System.Collections.Generic;
using System.Text;

namespace Ahorcado
{
    public class ConsolaUI
    {
        private readonly MotorAhorcado _motor;

        public ConsolaUI(MotorAhorcado motor)
        {
            _motor = motor;
        }

        public void MostrarTablero()
        {
            Console.Clear();
            MostrarAhorcado(); // Asegúrate de tener este método definido en tu clase

            Console.WriteLine($"Intentos restantes: {_motor.IntentosRestantes}");
            Console.WriteLine($"Letras usadas: {string.Join(", ", _motor.LetrasUsadas)}");
            Console.Write("Palabra: ");

            foreach (char c in _motor.PalabraSecreta)
            {
                Console.Write(_motor.LetrasUsadas.Contains(c) ? c : '_');
            }
            Console.WriteLine();
        }

        public char PedirLetra()
        {
            Console.Write("\nIngresa una letra: ");
            return Console.ReadLine()[0];
        }

        public void MostrarMensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        public bool PreguntarOtraVez()
        {
            Console.Write("\n¿Jugar otra vez? (s/n): ");
            return Console.ReadLine()?.ToLower() == "s";
        }
    }
}