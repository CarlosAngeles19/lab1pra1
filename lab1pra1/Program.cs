using System;

class Program
{
    static void Main()
    {
        int salona, salonb, salonc, HyM = 0;

        Console.Write("Primer salón en tardar en minutos: ");
        salona = Convert.ToInt32(Console.ReadLine());

        Console.Write("Segundo salón en tardar en minutos: ");
        salonb = Convert.ToInt32(Console.ReadLine());

        Console.Write("Tercer salón en tardar en minutos: ");
        salonc = Convert.ToInt32(Console.ReadLine());

        HyM = salona + salonb + salonc;

        Console.WriteLine("El instructor tardará " + HyM + " minutos en revisar los exámenes de todos los salones.");
    }
}