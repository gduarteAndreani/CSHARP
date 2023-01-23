// See https://aka.ms/new-console-template for more information

//Labo2:
//Ejercicio1:
//Dado el siguiente código:
//int nro1 = 100, nro2 = 500, nro3 = 250;
//Informar cuál de los tres números es mayor.

using System.Security.Cryptography;

Console.WriteLine("\n---------\n Laboratorio 2\n---------\n");
Console.ReadKey();
Console.Clear();
Console.WriteLine("---------\n Ejercicio 1\n---------\n");

int nro1 = 100;
int nro2 = 500;
int nro3 = 250;

if (nro1 > nro2 && nro1 > nro3) Console.WriteLine("El primer numero es el mayor\n");
else
{
    if (nro2 > nro3) Console.WriteLine("El segundo numero es el mayor\n");
    else
    {
        if (nro3 > nro2) Console.WriteLine("El tercer numero es el mayor\n");
        else Console.WriteLine("Ingreso tres numeros iguales\n");
    }
}

//Ejercicio 2
//int a = 10, b = -2, c = 5; // hay 2 números 
//positivos y 1 negativo.
//Informar la multiplicación de los dos números 
//positivos.

Console.WriteLine("---------\n Ejercicio 2\n---------\n");

int a = 10;
int b = -2;
int c = 5;

if (a > 0 && b > 0) Console.WriteLine(a * b);
if (c > 0 && a > 0) Console.WriteLine(a * c);
if (c > 0 && b > 0) Console.WriteLine(c * b);

//Ejercicio 3
//Dado el siguiente código:
//String usuario = “Pepito”, clave = “1234”;
//Informar los siguientes casos:
//Si usuario = “Pepito” y clave= “1234”
//informar Bienvenido pepito!”.
//Si usuario = “Pepito” y clave no es “1234”
//informar “Usuario incorrecto”.
//Si usuario no es “Pepito” y clave= 
//“1234”informar “Contraseña incorrecta”.

Console.WriteLine("\n---------\n Ejercicio 3\n---------\n");

String usuario = "Pepito", clave = "1234";
if (usuario == "Pepito" && clave == "1234") Console.WriteLine("Bienvenido Pepito!");
if (usuario == "Pepito" && clave != "1234") Console.WriteLine("Usuario incorrecto.");
if (usuario != "Pepito" && clave == "1234") Console.WriteLine("Contraseña Incorrecta");

Console.ReadKey();
Console.Clear();

//Labo3:
//Ejercicio 1:
//Ingresar dos números y ofrecer al usuario un menú con 
//las siguientes opciones: 
//“1 - Suma 2 - Resta 3 - Multiplicación 4 - División”.
//Luego, mostrar el resultado de la operación aritmética 
//elegida.

Console.WriteLine("\n---------\n Laboratorio 3\n---------\n");
Console.ReadKey();
Console.Clear();

Console.WriteLine("\n---------\n Ejercicio 1\n---------\n");
Console.Write("Ingrese un numero: ");
decimal num1 = Decimal.Parse(Console.ReadLine());
Console.Write("\nIngrese otro numero: ");
decimal num2 = Decimal.Parse(Console.ReadLine());
Console.Write("\nSeleccione la opcion que desea según la operatoria a realizar \n\n" +
    " 1 - Suma\n 2 - Resta\n 3 - Multiplicacion\n 4 - Division\n\n");
byte seleccion = Byte.Parse(Console.ReadLine());
switch (seleccion)
{
    case 1:
        Console.Write("\nLa suma es: {0}", num1 + num2);
        break;
    case 2:
        Console.Write("\nLa resta es: {0}", num1 - num2);
        break;
    case 3:
        Console.Write("\nEl producto es: {0}", num1 * num2);
        break;
    case 4:
        if (num2.Equals(0m)) Console.WriteLine("\nNo intente dividir por 0");
        else Console.Write("\nEl cociente es: {0}", Math.Round(num1 / num2, 4));
        break;
    default:
        Console.WriteLine("\nIngrese un valor correcto");
        break;
}

Console.ReadKey();

//Ejercicio 2
//Definir n1 y n2 como double, ejecutar nuevamente y 
//analizar resultado. ¿Qué diferencia existe en la salida? 
//¿Por qué?

Console.WriteLine("\n---------\n Ejercicio 2\n---------\n");
Console.Write("Ingrese un numero: ");
double num3 = Double.Parse(Console.ReadLine());
Console.Write("\nIngrese otro numero: ");
double num4 = Double.Parse(Console.ReadLine());
Console.Write("\nSeleccione la opcion que desea según la operatoria a realizar \n" +
    " 1 - Suma\n 2 - Resta\n 3 - Multiplicacion\n 4 - Division\n");
byte select = Byte.Parse(Console.ReadLine());
switch (select)
{
    case 1:
        Console.Write("La suma es: {0}", num3 + num4);
        break;
    case 2:
        Console.Write("La resta es: {0}", num3 - num4);
        break;
    case 3:
        Console.Write("El producto es: {0}", num3 * num4);
        break;
    case 4:
        if (num4.Equals(0d)) Console.WriteLine("No intente dividir por 0");
        else Console.Write("El cociente es: {0}", Math.Round(num3 / num4, 4));
        break;
    default:
        Console.WriteLine("Ingrese un valor correcto");
        break;
}

Console.ReadKey();

//Laboratorio 4
//Ejercicio 1
//Imprimir los números del 1 al 10 uno abajo del otro.


Console.WriteLine("\n---------\n Laboratorio 4\n---------\n");
Console.ReadKey();
Console.Clear();

Console.WriteLine("\n---------\n Ejercicio 1\n---------\n");
for(int i = 1; i<=10; i++)
{
    Console.WriteLine("{0} \n", i);
}

//Ejercicio 2
//Imprimir los números del 1 al 10 salteando de a 2 uno abajo del otro.

Console.WriteLine("\n---------\n Ejercicio 2\n---------\n");
for (int i = 1; i <= 10; i+=2)
{
    Console.WriteLine("{0} \n", i);
}

//Ejercicio 3
//Imprimir los números del 10 al 1 uno abajo del otro. 

Console.WriteLine("\n---------\n Ejercicio 3\n---------\n");
for (int i = 10; i >= 1; i--)
{
    Console.WriteLine("{0} \n", i);
}

//Ejercicio 4
////Imprimir los números del 1 al 10 sin imprimir 
//números 2,5 y 9 uno abajo del otro.
//Requisito: se necesita tener conocimiento del 
//operador AND (&&) y del operador NOT (!=).

Console.WriteLine("\n---------\n Ejercicio 4\n---------\n");
for (int i = 1; i <= 10; i++)
{
   if(i != 2 && i != 5 && i !=9)  Console.WriteLine("{0} \n", i);
}


//Ejercicio 5
//Imprimir los números del 1 al 30 sin imprimir 
//números entre el 10 y el 20 uno abajo del otro.
//Requisito: se necesita tener conocimientos del 
//operador OR (||).

Console.WriteLine("\n---------\n Ejercicio 5\n---------\n");
for (int i = 1; i <= 30; i++)
{
    if (i <= 10 || i >= 20) Console.WriteLine("{0} \n", i);
}

//Ejercicio 6
//Imprimir la suma de los números del 1 al 10.

Console.WriteLine("\n---------\n Ejercicio 6\n---------\n");
int acum = 0;
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("{0} \n", acum+=i);
}

//Ejercicio 7
//Imprimir la suma de los números pares del 1 al 
//25.
//Requisito: se necesita tener conocimientos del 
//operador RESTO (%).

Console.WriteLine("\n---------\n Ejercicio 7\n---------\n");
acum = 0;
for (int i = 2; i <= 25; i+=2)
{
    Console.WriteLine("{0} \n", acum += i);
}

//Ejercicio 8
//Imprimir la multiplicación de los números impares 
//que se encuentran entre -10 y 10.

Console.WriteLine("\n---------\n Ejercicio 8\n---------\n");
acum = 1;
for (int i = -10; i <= 10; i += 2)
{
    if(!(i.Equals(0))) Console.WriteLine("{0} \n", acum *= i);
}