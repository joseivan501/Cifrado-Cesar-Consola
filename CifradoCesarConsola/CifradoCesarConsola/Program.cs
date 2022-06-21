class Program
{
    static void Main(String[] args)
    {
        char[] chrAlfabeto = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K','L','M','N',
        'O','P','Q','R','S','T','U','V','W','X','Y','Z'};

        char[] chrMensaje;

        int intValorASCII;
        string strCifradoFinal = "", strDescifradoFinal = "";
        Console.WriteLine("Metodo de cifrado Cesar");
        Console.WriteLine("");
        int intContinuar = 1;

        do
        {
            Console.WriteLine("Ingrese la opcion a realizar:\n[1]Cifrar \n[2]Descifrar\n");
            int intOpcion = int.Parse(Console.ReadLine());
            switch (intOpcion)
            {
                case 1:
                    Console.Write("Ingrese mensaje a cifrar:");
                    chrMensaje = Console.ReadLine().ToUpper().ToCharArray();

                    for (int i = 0; i < chrMensaje.Length; i++)
                    {
                        for (int j = 0; j < chrAlfabeto.Length; j++)
                        {
                            if (chrMensaje[i] == chrAlfabeto[j])
                            {
                                intValorASCII = chrAlfabeto[j];

                                int intFormula = ((intValorASCII - 65) + 2) % chrAlfabeto.Length;

                                int intOperacionConversionASCII = intFormula + 65;

                                strCifradoFinal = strCifradoFinal + (char)intOperacionConversionASCII + "";
                            }
                        }
                    }

                    if (strCifradoFinal != "")
                    {
                        Console.WriteLine("Mensaje cifrado:" + strCifradoFinal);
                        strCifradoFinal = "";
                    }
                    else
                    {
                        Console.WriteLine("Cadena vacia");
                    }
                    break;


                case 2:
                    Console.Write("Ingrese mensaje a descifrar: ");

                    chrMensaje = Console.ReadLine().ToUpper().ToCharArray();

                    for (int i = 0; i < chrMensaje.Length; i++)
                    {
                        for (int j = 0; j < chrAlfabeto.Length; j++)
                        {
                            if (chrMensaje[i] == chrAlfabeto[j])
                            {
                                intValorASCII = chrAlfabeto[j];

                                int intOperacion = ((intValorASCII - 65) - 2) % chrAlfabeto.Length;

                                int intOperacionConversionASCII = intOperacion + 65;

                                if (intOperacionConversionASCII == 63 || intOperacionConversionASCII == 64)
                                {
                                    strDescifradoFinal = strDescifradoFinal + ((char)(intOperacionConversionASCII + 26) + "");
                                }

                                if (intOperacionConversionASCII >= 65 && intOperacionConversionASCII <= 90)
                                {
                                    strDescifradoFinal = strDescifradoFinal + (char)intOperacionConversionASCII + "";
                                }
                            }
                        }
                    }
                    if (strDescifradoFinal != "")
                    {
                        Console.WriteLine("Mensaje descifrado: " + strDescifradoFinal);
                        strDescifradoFinal = "";
                    }
                    else
                    {
                        Console.WriteLine("Cadena Vacia");
                    }
                    break;

                default:
                    Console.WriteLine("Ingrese una opcion valida");
                    break;
            }
            Console.WriteLine("");
            Console.WriteLine("\t\r¿Desea cifrar o descifrar otro texto?");
            Console.Write("[1]Cifrar/descifrar \n [2]Salir\n");
            intContinuar = int.Parse(Console.ReadLine());
            Console.WriteLine("\n-------------------------\n");
        }
        while (intContinuar == 1);
        Environment.Exit(0);
    }
}
