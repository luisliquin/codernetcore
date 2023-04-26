//declaracion de las varaibles
string sPassword = "usSystem-2022";
int iIntentos;

for (iIntentos=0; iIntentos < 5; iIntentos++)
{
    Console.Write("Ingrese la contraseña: ");
    string input = Console.ReadLine();

    if (string.IsNullOrEmpty(input))
    {
        Console.WriteLine("No ha ingresado ninguna contraseña. Por favor, inténtelo de nuevo.");
        iIntentos--;
        continue;
    }

    if (input == sPassword)
    {
        Console.WriteLine("Bienvenido al sistema.");
        break;
    }
    else
    {
        int remainingAttempts = 4 - iIntentos;

        Console.WriteLine($"Contraseña incorrecta. Quedan {remainingAttempts} intentos.");
    }
}

if (iIntentos == 5)
{
    Console.WriteLine("No es posible acceder al sistema. La aplicación se cerrará.");
    Environment.Exit(0);
}
