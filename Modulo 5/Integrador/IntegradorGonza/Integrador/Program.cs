using System;

bool validacion = false, validacion2 = false;
string nombre = "", apellido = "", email = "", opcion = "", carrera = "";
char continuar = 'S';

int edad = 0, codCarrera = 0, codCurso = 0;
string[] carreras = new string[3];

string[] carreraCursos = new string[3];
string[] cursosC = {"Programacion C#", "Programacion C++", "Programacion Gráfica con Windows Forms"};
string[] cursosJava = {"Programacion Java básico", "Introduccion a Spring", "Construccion de APIs"};
string[] cursosPHP = { "Programacion PHP básico", "Diseño web con HTML y CSS", "Introduccion a javascript" };
do
{
    Console.Clear();
    System.Console.WriteLine("\nIngresar nombre del alumno");
    nombre = System.Console.ReadLine();

    System.Console.WriteLine("\nIngresar apellido del alumno");
    apellido = System.Console.ReadLine();

    System.Console.WriteLine("\nIngrese la edad del alumno");
    edad = System.Convert.ToInt32(System.Console.ReadLine());

    System.Console.WriteLine("\nIngrese correo electronico del alumno");
    email = System.Console.ReadLine();

    System.Console.WriteLine("<<<<<<<<<Datos del alumno>>>>>>>:\n");
    System.Console.WriteLine($"Nombre: {nombre} \nApellido: {apellido} \nEdad: {edad}\nCorreo: {email}\n");
    System.Console.WriteLine("\n¿Los datos son correctos? 'YES' para confirmar, 'NO' para cancelar");
    opcion = System.Console.ReadLine();

    //  System.Console.ReadKey();
    if (opcion == "YES")
    {
        //validacion= true;
        do
        {
            System.Console.Clear();
            System.Console.WriteLine("\nDatos guardados.");
            System.Console.WriteLine("\n<<<< Selecciona el codigo de la carrera elegida>>>>>");
            System.Console.WriteLine("\n1.Programacion .NET");
            System.Console.WriteLine("\n2.Programacion JAVA");
            System.Console.WriteLine("\n3.Programacion PHP");

            codCarrera = Convert.ToInt32(Console.ReadLine());
            if (codCarrera == 1 || codCarrera == 2 || codCarrera == 3)
            {
                if (codCarrera == 1)
                {
                    carrera = "Programacion .NET";
                    carreraCursos = cursosC;
                }
                if (codCarrera == 2)
                {
                    carrera = "Programacion JAVA";
                    carreraCursos = cursosJava;
                }
                if (codCarrera == 3)
                {
                    carrera = "Programacion PHP";
                    carreraCursos = cursosPHP;
                }
                System.Console.WriteLine("\nDatos guardados. Presione una tecla para continuar");
                System.Console.WriteLine("\n<<<< Constancia de datos >>>>>");
                System.Console.WriteLine($"Alumno:{nombre},\nCorreo:{email}\nCarrera:{carrera}");

                System.Console.WriteLine("\nPresione una tecla para continuar");
                System.Console.ReadKey();

                validacion2 = true;
            }
            else
            {
                System.Console.WriteLine("\nCarrera inexistente ,ingrese nuevamente");
                System.Console.ReadKey();
                validacion2 = false;
            }


        } while (validacion2 == false);
        validacion = true;
    }
    else { System.Console.WriteLine("\nDatos erroneos ingrese nuevamente"); }


} while (validacion == false);

Console.Clear();

while (continuar == 'S' || continuar == 's')
{
    System.Console.WriteLine("\n<<<< Seleccione algun curso para incribirse: >>>>>");
    switch (codCarrera) {
        case 1:
            System.Console.WriteLine("\n1. Programacion C#");
            System.Console.WriteLine("\n2. Programacion C++");
            System.Console.WriteLine("\n3. Programacion gráfica con Windows Forms");
            codCurso = Convert.ToInt32(Console.ReadLine());
            break;
        case 2:
            System.Console.WriteLine("\n1. Programacion Java Basico");
            System.Console.WriteLine("\n2. Introduccion a Spring");
            System.Console.WriteLine("\n3. Construccion de APIs");
            codCurso = Convert.ToInt32(Console.ReadLine());
            break;
        case 3:
            System.Console.WriteLine("\n1. Programacion PHP Basico");
            System.Console.WriteLine("\n2. Diseño Web con HTML y CSS");
            System.Console.WriteLine("\n3. Introduccion a Javascript");
            codCurso = Convert.ToInt32(Console.ReadLine());
            break;
    }
    if (codCurso == 1 || codCurso == 2 || codCurso == 3) {
        carreras[codCurso - 1] = carreraCursos[codCurso -1];
        Console.WriteLine("Desea agregar otro curso? (S)i/(N)o");
        continuar = Convert.ToChar(Console.ReadLine());
    }
    else Console.WriteLine("Ingrese una opcion correcta.");
}

System.Console.WriteLine("\n<<<< Constancia de datos >>>>>");
System.Console.WriteLine($"Alumno:{nombre},\nCorreo:{email}\nCarrera:{carrera}");
System.Console.WriteLine("Cursos: ");
for(int i = 0; i < carreras.Length; i++)
{
    System.Console.WriteLine("{0}. {1}", i+1, carreras[i]);
}

System.Console.WriteLine("\nPresione una tecla para continuar");
System.Console.ReadKey();