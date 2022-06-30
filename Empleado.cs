using System;

public class Empleado
{
    /*Los campos de valor empiezan con guion bajo, son privadas, y se declaran primero*/
    private string _nombre;
    private string _apellido;
    private DateTime _fecha_Nac;
    private char _estado_Civil;
    private char _genero;
    private DateTime _fecha_Ingreso;
    private double _sueldo_Basico;
    private Cargos _cargo;
    /*Las propiedades tienen el nombre deseado, son publicas y se establece get & set
      con los campos anteriormente definidos*/
    public string Nombre { get => _nombre; set => _nombre = value; }
    public string Apellido { get => _apellido; set => _apellido = value; }
    public DateTime Fecha_Nac { get => _fecha_Nac; set => _fecha_Nac = value; }
    public char Estado_Civil { get => _estado_Civil; set => _estado_Civil = value; }
    public char Genero { get => _genero; set => _genero = value; }
    public DateTime Fecha_Ingreso { get => _fecha_Ingreso; set => _fecha_Ingreso = value; }
    public double Sueldo_Basico { get => _sueldo_Basico; set => _sueldo_Basico = value; }
    public Cargos Cargo { get => _cargo; set => _cargo = value; }
    /*Lista enumerada*/
    public enum Cargos
    {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador,
    }
    /*Definicion de los metodos*/
    public int Antiguedad()
    {
        DateTime fecha_actual = DateTime.Today;
        int Antiguedad = fecha_actual.Year - Fecha_Ingreso1.Year;
        return Antiguedad;
    }
    public int Edad()
    {
        DateTime fecha_actual = DateTime.Today;
        int edad = fecha_actual.Year - Fecha_Nac1.Year;
        return edad;
    }
    public int Edad()
    {
        DateTime fecha_actual = DateTime.Today;
        int edad = fecha_actual.Year - Fecha_Nac1.Year;
        return edad;
    }
    public int anios_jubilacion()
    {
        int anios;

        if (Genero1 == 'm')
        {
            anios = 60 - Edad();
            return anios;
        }
        if (Genero1 == 'v')
        {
            anios = 65 - Edad();
            return anios;
        }
    }
    public double Salario()
    {
        double salario = Sueldo_Basico1;

        if (anios_jubilacion() > 0 && anios_jubilacion() < 20)//
        {
            salario = Sueldo_Basico1 * (Antiguedad() / 100);
            if (Cargo1 == Cargos.Especialista || Cargo1 == Cargos.Ingeniero)
            {
                salario = salario * 1.5;
                if (Estado_Civil1 == 'c')
                {
                    salario = salario + 15000;

                }
            }
            else
            {
                if (Estado_Civil1 == 'c')
                {
                    salario = salario + 15000;
                }
            }
        }
        else
        {
            if (anios_jubilacion() >= 20)
            {
                salario = Sueldo_Basico1 * 1.25 * Antiguedad();
                if (Cargo1 == Cargos.Especialista || Cargo1 == Cargos.Ingeniero)
                {
                    salario = salario * 1.5;
                    if (Estado_Civil1 == 'c')
                    {
                        salario = salario + 15000;

                    }
                }
                else
                {
                    if (Estado_Civil1 == 'c')
                    {
                        salario = salario + 15000;

                    }
                }

            }


        }

        return salario;
    }
}
