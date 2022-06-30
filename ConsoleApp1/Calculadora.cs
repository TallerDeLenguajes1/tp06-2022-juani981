using System;

public class Calculadora
{
    public double resultado;

    public Calculadora(double valorInicial)
    {
        resultado = valorInicial;
    }

    public void Sumar(double valor)
    {
        resultado += valor;
    }

    public void Restar(double valor)
    {
        resultado -= valor;
    }

    public void Multiplicar(double valor)
    {
        resultado *= valor;
    }

    public void Dividir(double valor)
    {
        resultado /= valor;
    }
    public void Limpiar()
    {
        resultado = 0;
    }
    /*public void MostrarCalculadora()
    { 
        int opcion;
        do
        {
            Console.WriteLine("\nQue operacion desea realizar?");
            Console.WriteLine("SUMAR---> 1  -  RESTAR---> 2  -  MULTIPLICAR---> 3  -  DIVIDIR---> 4  -  LIMPIAR---> 5  -  SALIR---> 6:  ");
            opcion = Convert.ToInt32(Console.ReadLine());


            if (opcion == 1 || opcion == 2 || opcion == 3 || opcion == 4)
            {
                Console.WriteLine("Ingrese una opción: ");
                opcion = Convert.ToDouble(Console.ReadLine());
            }


            switch (opcion)
            {
                case 1:
                    Calculadora.Sumar(opcion);
                    break;
                case 2:
                    Calculadora.Restar(opcion);
                    break;
                case 3:
                    Calculadora.Multiplicar(opcion);
                    break;
                case 4:
                    Calculadora.Dividir(opcion);
                    break;
                case 5:
                    Calculadora.Limpiar();
                    break;
                default:
                    break;
            }

            Console.WriteLine("RESULTADO DE LA OPERACION: " + Calculadora.resultado);


        } while (opcion != 6) ;
    }*/
}
