# Ahorcado
Un juego sencillo escrito en C#

Este juego viola los Principios SOLID, ya que la clase  `Juego` tiene demasiadas responsabilidades.
SRP (Single Responsibility Principle): Juego controla turnos, dibuja el tablero, muestra mensaje y elige la palabra
DIP (Dependency Inversion Principle): Las palabras están hardcodeadas dentro del constructor 
OCP(Open/Closed Principle): Para agregar un segundo juego habria	 que modificar juego direcatamente