// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System;

int opcion = 0;
Calculadora calc = new Calculadora(0);

do
{
    Console.WriteLine("\nQue operacion desea realizar?");
    Console.WriteLine("SUMAR---> 1  -  RESTAR---> 2  -  MULTIPLICAR---> 3  -  DIVIDIR---> 4  -  LIMPIAR---> 5  -  SALIR---> 6:  ");
    opcion = Convert.ToInt32(Console.ReadLine());

    double opcion = 0;

    if (opcion == 1 || opcion == 2 || opcion == 3 || opcion == 4)
    {
        Console.WriteLine("Ingrese una opción: ");
        opcion = Convert.ToDouble(Console.ReadLine());
    }


    switch (opcion)
    {
        case 1:
            calc.Sumar(opcion);
            break;
        case 2:
            calc.Restar(opcion);
            break;
        case 3:
            calc.Multiplicar(opcion);
            break;
        case 4:
            calc.Dividir(opcion);
            break;
        case 5:
            calc.Limpiar();
            break;
        default:
            break;
    }

    Console.WriteLine("RESULTADO DE LA OPERACION: " + calc.resultado);


} while (opcion != 6);
