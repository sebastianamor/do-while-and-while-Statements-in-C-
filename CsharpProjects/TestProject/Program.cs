int reintentos = 0;
bool exito = false;
const int maxReintentos = 3;

do
{
    exito = IntentarConexion();
    reintentos++;
    
    if (!exito && reintentos < maxReintentos)
    {
        Console.WriteLine($"Reintentando... ({reintentos}/{maxReintentos})");
        Thread.Sleep(1000); // Espera 1 segundo
    }
} while (!exito && reintentos < maxReintentos);

Console.WriteLine(exito ? "Conectado!" : "Falló después de reintentos");