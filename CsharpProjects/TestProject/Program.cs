int opcion;
int monster = 0;  // Inicializado
int hero = 0;     // Inicializado
int i = 0;

do
{
    Console.WriteLine($" Contador: {i}, Monstruos: {monster}, Héroes: {hero}");
    Console.WriteLine("\npelea:");
    Console.WriteLine("1. pegar");
    Console.WriteLine("2. daño");
    Console.WriteLine("3. cubrirse");
    Console.WriteLine("4. Salir");
    
    if (!int.TryParse(Console.ReadLine(), out opcion))
    {
        Console.WriteLine("Error: Ingrese un número válido");
        continue;
    }
    
    switch(opcion)
    {
        case 1: 
            i++;
            monster++; // Ejemplo: incrementar monstruos
            Console.WriteLine($"Agregado. Total: {i}");
            break;
        case 2: 
            if (i > 0) 
            {
                i--;
                hero++; // Ejemplo: incrementar héroes
                Console.WriteLine($"Editado. Total: {i}");
            }
            else
            {
                Console.WriteLine("No hay elementos para editar");
            }
            break;
        case 3: 
            Console.WriteLine($"Repitiendo... Contador actual: {i}");
            break;
        case 4: 
            Console.WriteLine("Saliendo del programa...");
            break;
        default:
            Console.WriteLine("Opción no válida");
            break;
    }
} while (opcion != 4);

Console.WriteLine($"Resultados finales - Contador: {i}, Monstruos: {monster}, Héroes: {hero}");