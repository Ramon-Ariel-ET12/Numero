namespace Biblioteca;

public class Natural
{
    public int Numero;
    public Natural() { }
    public Natural(int numero)
    {
        Numero = numero;
    }

    public void Mostar()
    {
        EsNatural();
        EsUno();
        EsPrimo();
        EsCompuesto();
    }
    public bool EsNatural()
    {
        if (Numero < 1)
        {
            Console.WriteLine($"El numero ingresado no es natural, vuelva a intentarlo");
            Thread.Sleep(3000);
            return false;
        }
        return true;
    } 
    

    private bool EsUno()
    {
        if (Numero == 1)
        {
            Console.WriteLine("El numero ingresado es uno");
            return false;
        }
        Console.WriteLine("El numero ingresado no es uno");
        return true;
    }

    private bool EsPrimo()
    {
        if (Numero == 1)
        {
            Console.WriteLine("Es Primo");
            return true;
        }
        for (int i = 2; i < Numero; i++)
        {
            if (Numero % i == 0)
            {
                Console.WriteLine("No es primo");
                return false;
            }
        }
        Console.WriteLine("Es Primo");
        return true;
    }
    private bool EsCompuesto()
    {
        for (int i = 2; i < Numero; i++)
        {
            if (Numero % i == 0)
            {
                Console.WriteLine("Es Compuesto");
                return true;
            }
        }
        Console.WriteLine("No es Compuesto");
        return false;
    }

    public void Sumar(int numero) => Numero = +numero;
    public void Sumar(Natural natural) => Numero =+ natural.Numero;
    public void OperadorPlus(int numero) { }
    public void OperadorPlus(Natural natural) { }
    public void OperadorPlusPlus() => Numero++;
    public void PlusPlusOperador()
    {
        if (Numero == 1)
        {
            Console.WriteLine("\nEl numero natural no puede ser menor a 1\n");
            Thread.Sleep(2000);
        }
        else
            Numero--;
    }
}