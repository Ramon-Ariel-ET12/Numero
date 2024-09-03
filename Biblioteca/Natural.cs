namespace Biblioteca;

public class Natural
{
    public int Numero;
    public Natural(){}
    public Natural(int numero)
    {
        if (EsNatural(numero))
        {
            Numero = numero;
        }
        EsUno();
        EsPrimo();
    }
    private bool EsNatural(int numero)
    {
        if (numero < 1)
        {
            Console.WriteLine($"El {numero} no es natural");
            return false;
        }
        Console.WriteLine($"El {numero} es natural");
        return true;
    }

    private bool EsUno()
    {
        if (Numero == 1)
        {
            System.Console.WriteLine("El numero ingresado es uno");
            return false;
        }
        Console.WriteLine("El numero ingresado no es uno");
        return true;
    }

    private bool EsPrimo()
    {
        if (Numero == 1)
        {
            System.Console.WriteLine("Es Primo");
            return true;
        }
        for (int i = 2; i < Numero; i++)
        {
            if (Numero%i == 0)
            {
                Console.WriteLine("No es primo");
                return false;
            }
        }
        System.Console.WriteLine("Es Primo");
        return true;
    }
}