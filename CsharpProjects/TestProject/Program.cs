while (true) // Bucle infinito aparente
{
    var resultado = ProcesarDatos();
    
    if (resultado.EsExitoso)
    {
        Console.WriteLine("Proceso completado");
        break; // Salida controlada
    }
    
    if (resultado.Intentos > 3)
    {
        Console.WriteLine("Demasiados intentos");
        break;
    }
}