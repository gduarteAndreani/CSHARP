// See https://aka.ms/new-console-template for more information
Console.WriteLine("-------------\n Integrador \n-------------\n");
Console.ReadKey();
Console.Clear();

//1.Realizar una interfaz que solicite al alumno:
//● Nombre.
//● Apellido.
//● Edad.
//● Correo electrónico.

Console.WriteLine("Bienvenidx. Ingrese su nombre: ");
string nombre = Console.ReadLine();
Console.WriteLine("Ingrese su apellido: ");
string apellido = Console.ReadLine();
Console.WriteLine("Ingrese su edad: ");
string edad = Console.ReadLine();
Console.WriteLine("Ingrese su correo: ");
string email = Console.ReadLine();
Console.Clear();

//2.Una vez cargados estos 4 datos, mostrar
//los datos ingresados y pedir al alumno una 
//confirmación para saber si los datos son 
//correctos. Si se confirman los datos, deberá 
//solicitar al alumno que seleccione un código
//de carrera. En caso contrario, pedir que 
//ejecute nuevamente la aplicación y finalizará.


Console.WriteLine("Datos ingresados:\nNombre: {0}\nApellido: {1}\nEdad: {2}\n" +
    "Correo electrónico: {3}\n", nombre, apellido, edad, email);
char opcion = 'q';
char codigoCarrera = '0';
string carrera = "";
while (opcion != 's' && opcion != 'n') {
    Console.WriteLine("¿Los datos ingresados son correctos? Ingrese (S)i/(N)o");
    opcion = Convert.ToChar(Console.ReadLine());
    if (opcion == 's')
    {
        Console.WriteLine("Ingrese el código de carrera: \n1. Programacion Java\n2." +
            " Programacion PHP\n3. Programacion C#");
        codigoCarrera = Convert.ToChar(Console.ReadLine());
        switch (codigoCarrera)
        {
            case '1':
                carrera = "Programacion Java";
                break;
            case '2':
                carrera = "Programacion PHP";
                break;
            case '3':
                carrera = "Programacion C#";
                break;
            default:
                Console.WriteLine("Ingrese un valor correcto. Finalizando la aplicacion...");
                Environment.Exit(1);
                Console.ReadLine();
                break;
        }
        Console.Clear();
    }
    else if (opcion == 'n')
    {
        Console.WriteLine("Los datos son incorrectos, finalizando aplicacion...");
        Console.ReadLine();
        Environment.Exit(1);
    }
    else
    {
        Console.WriteLine("Ingrese una opción correcta");
    }
}

//3.Mostrar por pantalla un mensaje con los 
//datos personales del alumno y la carrera 
//elegida.

Console.WriteLine("\nDatos del alumno:\nNombre: {0}\nApellido: {1}\nEdad: {2}\n" +
    "Correo electrónico: {3}\nCarrera elegida: {4}\n", nombre, apellido, edad, email, carrera);

//4. En caso de que el código de la carrera 
//seleccionado sea incorrecto, mostrar un mensaje de 
//error notificando que la carrera es inexistente,
//y solicite al alumno que vuelva a iniciar la 
//aplicación finalizando su ejecución.

//Solucionado en el apartado 2
