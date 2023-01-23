// See https://aka.ms/new-console-template for more information
Console.WriteLine("-------------\nDesafios\n-------------\n");

Console.ReadKey();
Console.Clear();

//Ejercicio 1
//Ingresar una nota de un alumno, e informar 
//si está aprobado, si recupera o si promociona 
//la materia. 
//Datos
//Se aprueba con 4 y se promociona con 7

Console.WriteLine("-------------\nEjercicio 1\n-------------\n");

Console.WriteLine("Ingrese la nota de un alumno");
double nota = Convert.ToDouble(Console.ReadLine());
if(nota<4)
{
    Console.WriteLine("El alumno debe recuperar.");
}
else if (nota > 4 && nota < 7)
{
    Console.WriteLine("El alumno aprobo la materia.");
}
else
{
    Console.WriteLine("El alumno promocionó la materia.");
}

Console.ReadKey();
Console.Clear();

//Ejercicio 2
//Realizar un programa que lea por teclado dos 
//números, si el primero es mayor al segundo 
//informar su suma y diferencia, en caso contrario 
//informar el producto y la división del primero 
//respecto al segundo.

Console.WriteLine("-------------\nEjercicio 2\n-------------\n");

Console.WriteLine("Ingrese un numero");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingrese otro numero");
double num2 = Convert.ToDouble(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("Su suma es: {0}\nSu producto es: {1}", num1 + num2, num1 - num2);
}
else
{
    Console.WriteLine("Su producto es: {0}\nSu cociente es: {1}", num1 * num2, Math.Round(num1 / num2, 4));
}

Console.ReadKey();
Console.Clear();

//Ejercicio 3
//Ingresar 2 notas de parciales de un alumno,
//e informar si está aprobado, desaprobado o si 
//debe recuperar el primer parcial o el segundo,
//sabiendo que la nota de aprobación es 4 y se 
//deben aprobar los 2 parciales.

Console.WriteLine("-------------\nEjercicio 3\n-------------\n");

Console.WriteLine("Ingrese la nota del primer parcial");
double nota1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingrese la nota del segundo parcial");
double nota2 = Convert.ToDouble(Console.ReadLine());

if (nota1 > 4 && nota2 >4)
{
    Console.WriteLine("El alumno esta aprobado.");
}
else if (nota1 < 4 && nota2 > 4)
{
    Console.WriteLine("El alumno debe recuperar el primer parcial.");
}
else if (nota1 > 4 && nota2 < 4)
{
    Console.WriteLine("El alumno debe recuperar el segundo parcial.");
}
else
{
    Console.WriteLine("El alumno está desaprobado.");
}

Console.ReadKey();
Console.Clear();