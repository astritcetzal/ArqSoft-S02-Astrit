string categoriaElegida = Ahorcado.ConsolaUI.PedirCategoriaInicio();
var repositorio = new Ahorcado.PalabrasEnMemoria(categoriaElegida);
var motor = new Ahorcado.MotorAhorcado(repositorio);
var ui = new Ahorcado.ConsolaUI(motor);

Console.Clear();
Console.WriteLine($"=== AHORCADO: Categoría {categoriaElegida.ToUpper()} ===");



while (!motor.Ganado() && !motor.Perdido())
{
    ui.MostrarTablero();
    char letra = ui.PedirLetra();

    if (motor.LetraYaUsada(letra))
    {
        ui.MostrarMensaje("Ya usaste esa letra.");
        continue;
    }

    motor.RegistrarLetra(letra);
}

ui.MostrarTablero();

if (motor.Ganado())
{
    ui.MostrarMensaje($"\n¡Ganaste! La palabra era: {motor.PalabraSecreta}");
}
else
{
    ui.MostrarMensaje($"\nPerdiste. La palabra era: {motor.PalabraSecreta}");
}

if (ui.PreguntarOtraVez())
{
    Console.WriteLine("Por ahora, reinicia la aplicación para volver a jugar.");

    // OJO: En este punto se instancian los objetos, pero no se reinicia el juego.
    // Para que funcione, tendrías que encapsular toda esta lógica en un ciclo 
    // o llamar al método principal nuevamente.
}