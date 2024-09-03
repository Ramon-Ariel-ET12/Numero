using Biblioteca;

while (true)
{
    Console.Write("Ingrese un numero: ");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Natural a = new(num1);

    Console.WriteLine("\nIngrese '1' para terminar o '0' para continuar\n");
    if (Convert.ToInt32(Console.ReadLine()) == 1)
        break;
}