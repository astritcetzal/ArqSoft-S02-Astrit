bool jugar = true;
while (jugar == true)
{
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


    
    jugar = ui.PreguntarOtraVez();

}