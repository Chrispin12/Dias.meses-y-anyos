namespace dia-mes-año
   public class program
{
    public static void Main()
    {
        int año, año_siguiente, dia, dia_siguiente, mes, mes_siguiente;
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        Console.Write("Ingrese el numero del año: ");
        año = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el numero del dia: ");
        dia = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el numero del mes: ");
        mes = int.Parse(Console.ReadLine());
        if ((dia == 30 && (mes == 4 || mes == 6 || mes == 9 || mes == 11)) || (dia == 29 && mes == 2) || (dia == 28 && mes == 2 && ((año % 4 != 0) || (año % 100) == 0) && (año % 400) != 0) || dia == 31)
        {
            mes_siguiente = mes + 1;
            dia_siguiente = 1;
        }
        else
        {
            dia_siguiente = dia + 1;
            mes_siguiente = mes;
        }

        if (dia_siguiente == 1 && mes_siguiente == 13)
        {
            mes_siguiente = 1;
            año_siguiente = año + 1;
        }
        else
            año_siguiente = año;
        Console.WriteLine("numero de año siguiente: " + año_siguiente);
        Console.WriteLine("numero de dia suguiente: " + dia_siguiente);
        Console.WriteLine("numero de mes siguiente: " + mes_siguiente);
        Console.WriteLine();
        Console.Write("Presione enter para terminar . . . ");
        Console.ReadKey();

    }
}


