using Laboratorio2.DAO;
using Laboratorio2.Models;

CrudNotas CrudNotas = new CrudNotas();
Notum Notum = new Notum();
bool Bucle = true;

Console.Write("Bienvenido a su registrador de notas");

while (Bucle == true) { 

Console.Write("\nA continuacion ingrese una de las opciones del menú");
Console.Write(@"
Menu
1- Calcular Notas
2- Listar Notas
3- Salir

-> ");

var Menu = Convert.ToInt32(Console.ReadLine());

    switch (Menu)
    {
        case 1:
            Console.WriteLine("Se creara un nuevo registro de notas");
            Console.Write("Ingrese el nombre de la materia -> ");
            Notum.Materia = Console.ReadLine();
            Console.Write("\nIngresea el nombre del estudiante -> ");
            Notum.NombreEstudiante = Console.ReadLine();

            Console.Write("\nIngrese la nota del Lab 1 ->");
            Notum.Lab1 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("\nIngrese la nota del Parcial 1 ->");
            Notum.Parcial1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("\nIngrese la nota del Lab 2 ->");
            Notum.Lab2 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("\nIngrese la nota del Parcial 2 ->");
            Notum.Parcial2 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("\nIngrese la nota del Lab 3 ->");
            Notum.Lab3 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("\nIngrese la nota del Parcial 3 ->");
            Notum.Parcial3 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine(CrudNotas.Promedio(Notum));

            CrudNotas.AgregarNota(Notum);

            Console.Write("\nSu nota fue registrada  correctamente en la base de datos");
            break;

        case 2:
            Console.WriteLine("Lista de Notas");

            var ListaNotas = CrudNotas.ListarNotum();

            foreach (var i in ListaNotas)
            {
                Console.WriteLine($"\nId: {i.IdNotas}");
                Console.WriteLine($"Nombre del estudiante: {i.NombreEstudiante}");
                Console.WriteLine($"Materia: {i.Materia}");
                Console.WriteLine($"Lab 1: {i.Lab1}");
                Console.WriteLine($"Parcial 1: {i.Parcial1}");
                Console.WriteLine($"Lab 2: {i.Lab2}");
                Console.WriteLine($"Parcial 2: {i.Parcial2}");
                Console.WriteLine($"Lab 3: {i.Lab3}");
                Console.WriteLine($"Parcial 3: {i.Parcial3}");
                Console.WriteLine($"Promedio final: {i.Resultado}");
            }
            break;

        case 3:
            Console.Write("\nGracias por utilizar el programa");
            Bucle = false;
            break;

        default:
            Console.WriteLine("La opción no se encuentra en el menu");
            break;
    }
       
    }


