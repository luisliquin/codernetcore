string sContrasenaActual = "usSystem-2022";
IntentarEscribirContrasena(sContrasenaActual);

static bool ValidarContrasena(string sContrasenaActual)
{
    string sPassword = sContrasenaActual;
    int iIntentos;

    for (iIntentos = 0; iIntentos < 5; iIntentos++)
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
            int numCaracteres = sPassword.Length;
            Console.WriteLine(new string('*', numCaracteres) + " es correcta");
            return true;
        }
        else
        {
            int iIntentosPendientes = 4 - iIntentos;
            Console.WriteLine($"Contraseña incorrecta. Quedan {iIntentosPendientes} intentos.");
        }
    }

    if (iIntentos == 5)
    {
        Console.WriteLine("No es posible acceder al sistema. La aplicación se cerrará.");
        Environment.Exit(0);
    }

    return false;
}

static void IntentarEscribirContrasena(string sContrasenaActual)
{
    bool contrasenaCorrecta = false;

    while (!contrasenaCorrecta)
    {
        contrasenaCorrecta = ValidarContrasena(sContrasenaActual);
    }
}