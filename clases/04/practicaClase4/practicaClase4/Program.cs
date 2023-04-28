//Bienvenida
const string sMensaje = "Ingresa una cadena de texto y te dire la cantidad de letras que tiene y cual es la primer letra: ";
Console.WriteLine(sMensaje);

string sCadena = Console.ReadLine();

//Validacion
if (string.IsNullOrEmpty(sCadena))
{
    Console.WriteLine("No ha ingresado ninguna contraseña. Por favor, inténtelo de nuevo.");
}
else
{
    //Calculo
    int iCantLetras = sCadena.Length;
    string sPrLetra = sCadena.Substring(0, 1);
    string sResp = $"La cantidad de letras que tiene la frase son:  {iCantLetras} y la primer letra de  la cadena es: {sPrLetra}.";
    Console.WriteLine(sResp);
}
