// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n--------------\n Ejercicio 1: \n--------------\n");

//Ejercicio 1
//Dados n1 = true, n2 = false y n3=true. 
//Informar:
//a.n1 ^ n2
//b. (n1 & !n2) | n3
//c. (n1 | n2) & !n3

bool n1 = true;
bool n2 = false;
bool n3 = true;

Console.WriteLine(n1 ^ n2);
Console.WriteLine((n1 & !n2) | n3);
Console.WriteLine((n1 | n2) & !n3);

//Ejercicio 2
//Declarar dos variables n1=5 y n2=10.
//Utilizando concatenación entre las variables 
//y los literales, mostrar en pantalla la siguiente 
//expresión:
//n1 es igual a 5, n2 es igual a 10 y n1 más n2 es 
//igual a 15.

Console.WriteLine("\n--------------\n Ejercicio 2: \n--------------\n");

int n4= 5;
int n5 = 10;
Console.WriteLine("n4 es igual a {0}, n5 es igual a {1} y " +
    "n4 más n5 es igual a {2}", n4, n5, n4+n5);

//Ejercicio 3
//Haciendo uso de la constante IVA=21, calcular 
//el precio con IVA de los siguientes productos 
//e informar: 
//a.Remera: 59.90$
//b.Pantalón: 99.90$ 
//c.Campera: 149.90$

Console.WriteLine("\n--------------\n Ejercicio 3: \n--------------\n");

const double IVA = 21;
double remera = 59.90;
double pantalon = 99.90;
double campera = 149.90;
Console.WriteLine("Precio remera: {0}", Math.Round(remera * IVA, 2) );
Console.WriteLine("Precio pantalon: {0}", Math.Round(pantalon * IVA, 2) );
Console.WriteLine("Precio campera: {0}", Math.Round(campera * IVA, 2));
Console.ReadLine();