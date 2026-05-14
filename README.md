# 🔤 Juego de Ahorcado - Consola C#

## 📖 Descripción
Este proyecto es una implementación clásica del juego del Ahorcado para la consola, donde el jugador debe adivinar una palabra secreta oculta antes de quedarse sin intentos. El proyecto destaca por tener un diseño refactorizado y limpio que facilita la escalabilidad y el mantenimiento del código.

## 🛠️ Cómo se construyó
* **Lenguaje:** C# (Aplicación de consola).
* **Arquitectura:** Programación Orientada a Objetos (POO).
* **Patrones y Principios:** Se aplicaron los principios SOLID, destacando la **Inversión de Dependencias (DIP)**. El motor del juego (`MotorAhorcado`) es independiente de la interfaz de usuario (`ConsolaUI`) y de la fuente de datos. Las palabras se inyectan a través de la interfaz `IRepositorioPalabras`, lo que permite cambiar el origen de los datos (memoria, base de datos, texto) sin modificar la lógica del juego.