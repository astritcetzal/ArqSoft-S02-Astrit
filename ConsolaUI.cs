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
        public static string PedirCategoriaInicio()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== BIENVENIDO AL AHORCADO ===");
                Console.WriteLine("Elige una categoría:");
                Console.WriteLine("1. Arquitectura");
                Console.WriteLine("2. POO");
                Console.WriteLine("3. .NET");
                Console.Write("\nEscribe el nombre de la categoría: ");
                string palabra = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(palabra))
                {
                    Console.WriteLine("Categoría incorrecta, intenta de nuevo.");
                    Console.ReadLine();
                }
                else if (palabra.ToUpper().Equals("ARQUITECTURA") || palabra.ToUpper().Equals("POO") || palabra.ToUpper().Equals(".NET"))
                {
                    return palabra;
                }
                else
                {
                    Console.WriteLine("Error al escribir una opción. Presiona Enter para intentar de nuevo.");
                    Console.ReadLine();
                }
            }
        }

        public void MostrarTablero()
        {
            Console.Clear();
            MostrarAhorcado();

            Console.WriteLine($"Intentos restantes: {_motor.IntentosRestantes}");
            Console.WriteLine($"Letras usadas: {string.Join(", ", _motor.LetrasUsadas)}");
            Console.Write("Palabra: ");

            foreach (char c in _motor.PalabraSecreta)
            {
                Console.Write(_motor.LetrasUsadas.Contains(c) ? c : '_');
            }
            Console.WriteLine();

            if (_motor.MostrarPista)
                Console.WriteLine($"Pista: la palabra empieza con '{_motor.PalabraSecreta[0]} '.");
        }

        private void MostrarAhorcado()
        {
            string[] etapas = new string[]
            {
                "-----\n |   |\n     |\n     |\n     |\n     |\n=========",
                "-----\n |   |\n O   |\n     |\n     |\n     |\n=========",
                "-----\n |   |\n O   |\n |   |\n     |\n     |\n=========",
                "-----\n |   |\n O   |\n/|   |\n     |\n     |\n=========",
                "-----\n |   |\n O   |\n/|\\  |\n     |\n     |\n=========",
                "-----\n |   |\n O   |\n/|\\  |\n/    |\n     |\n=========",
                "-----\n |   |\n O   |\n/|\\  |\n/ \\  |\n     |\n========="
            };

            // Lee los intentos restantes a través de la instancia del motor
            Console.WriteLine(etapas[6 - _motor.IntentosRestantes]);
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