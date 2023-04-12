using Laboratorio2.DAO;
using Laboratorio2.Models;

Notum notas = new Notum();
ClsNotas clnotas = new ClsNotas();
do
{
    int op = 0;

    do
    {
        Console.Clear();
        Console.WriteLine("\n     Menu\n");
        Console.WriteLine("1- Calcular Notas");
        Console.WriteLine("2- Listar Notas");
        Console.WriteLine("3- Salir\n");
        Console.Write("Selecciona una opcion valida ");
        op = int.Parse(Console.ReadLine());
        if (!(op >= 1 && op <= 3))
        {
            Console.WriteLine("\nOpcion invalida, intentalo de nuevo!");
            Thread.Sleep(1000);
        }
        else
        {
            break;
        }
    } while (true);
    switch (op)
    {
        case 1:
            Console.Write("Ingrese el nombre de la materia: ");
            notas.NombreMateria = Console.ReadLine();

            Console.Write("Ingrese el nombre del estudiante: ");
            notas.NombreEstudiante = Console.ReadLine();
            Console.Write("Ingrese lab 1: ");
            notas.Lab1 = decimal.Parse(Console.ReadLine());
            Console.Write("Ingrese parcial 1: ");
            notas.Parcial1 = decimal.Parse(Console.ReadLine());

            Console.Write("Ingrese lab 2: ");
            notas.Lab2 = decimal.Parse(Console.ReadLine());
            Console.Write("Ingrese parcial 2: ");
            notas.Parcial2 = decimal.Parse(Console.ReadLine());

            Console.Write("Ingrese lab 3: ");
            notas.Lab3 = decimal.Parse(Console.ReadLine());
            Console.Write("Ingrese parcial 3: ");
            notas.Parcial3 = decimal.Parse(Console.ReadLine());

            clnotas.CalcularResultado(notas);
            Console.WriteLine($"Su resultado es {Math.Round(Convert.ToDecimal(notas.Resultado), 2)}");
            clnotas.Guardar(notas);
            Console.WriteLine("Su nota fue almacenada correctamente en la base de datos");
            Console.Write("\nPresiona una tecla para regresar");
            Console.ReadKey();
            break;
        case 2:
            foreach (var lista in clnotas.Listar())
            {
                Console.WriteLine("\n---------------------------------------");
                Console.WriteLine($"Registro #{lista.IdNotas}");
                Console.WriteLine($"Nombre Materia: {lista.NombreMateria}");
                Console.WriteLine($"Nombre estudiante: {lista.NombreEstudiante}");
                Console.WriteLine($"Nota Laboratorio 1: {lista.Lab1}");
                Console.WriteLine($"Nota Parcial 1: {lista.Parcial1}");
                Console.WriteLine($"Nota Laboratorio 2: {lista.Lab2}");
                Console.WriteLine($"Nota Parcial 2: {lista.Parcial2}");
                Console.WriteLine($"Nota Laboratorio 3: {lista.Lab3}");
                Console.WriteLine($"Nota Parcial 3: {lista.Parcial3}");
                Console.WriteLine($"Promedio Final: {lista.Resultado}");
                Console.WriteLine("---------------------------------------\n");
            }
            Console.Write("\nPresiona una tecla para regresar");
            Console.ReadKey();
            break;

        case 3:
            Console.WriteLine("\nFinalizando ejecucion!");
            break;
        default:
            Console.WriteLine("\nFinalizando ejecucion!");
            break;
    }
    if (op != 1 && op != 2) { break; }
} while (true);
