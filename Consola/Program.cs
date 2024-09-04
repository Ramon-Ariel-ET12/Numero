using Biblioteca;

while (true)
{
    Console.Clear();
    Console.Write("Ingrese el primer numero natural: ");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Natural a = new(num1);
    if (!a.EsNatural())
        continue;
    Console.Write("Ingrese el segundo numero natural: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    Natural b = new(num2);
    if (!b.EsNatural())
        continue;
    


    Console.WriteLine("---------------------------");
    Console.WriteLine("|  Primer numero natural  |");
    Console.WriteLine("---------------------------");
    a.Mostar();

    Console.WriteLine("----------------------------");
    Console.WriteLine("|  Segundo numero natural  |");
    Console.WriteLine("----------------------------");
    b.Mostar();

    while (true)
    {
        Console.WriteLine();
        Console.WriteLine($"1. Incrementar el primer numero natural ({a.Numero})");
        Console.WriteLine($"2. Reducir el primer numero natural ({a.Numero})");
        Console.WriteLine($"3. Incrementar el segundo numero natural ({b.Numero})");
        Console.WriteLine($"4. Reducir el segundo numero natural ({b.Numero})");
        Console.WriteLine($"0. Continuar con el programa");
        int num = Convert.ToInt32(Console.ReadLine());
        switch (num)
        {
            case 0:
            break;
            case 1:
            a.OperadorPlusPlus();
            break;
            case 2:
            a.PlusPlusOperador();
            break;
            case 3:
            b.OperadorPlusPlus();
            break;
            case 4:
            b.PlusPlusOperador();
            break;
            default:
            Console.WriteLine("\nPor favor, elija una de las opciones\n");
            Thread.Sleep(2000);
            continue;
        }
        if (num == 0)
            break;
    }

    Console.WriteLine($"\nLa suma de los 2 numeros naturales es: {a.Numero+b.Numero}\n");
    a.Sumar(b);
    Console.WriteLine("-----------------------------------------------------------------");
    Console.WriteLine("|  Ingrese '1' para finalizar el programa o '0' para continuar  |");
    Console.WriteLine("-----------------------------------------------------------------");
    Console.Write("Respuesta: ");
    if (Convert.ToInt32(Console.ReadLine()) == 1)
        break;
}