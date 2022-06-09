using System;

namespace TareaAdicional1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            string resultado = "";
            char operacion = ' ';// "" != " "
            bool repetir = true;
            int posicion = 0;
            string anterior = "";
            string posterior = "";
            string cadena = "", remplazar = "";

            do
            {
                // Lógica ya vista para pedir número y operación de forma que comprobemos
                // que cumple con los parámetros establecidos

                Repetir(ref numero, ref resultado, ref operacion, ref repetir);

                while (resultado.Contains('*') || resultado.Contains('/'))
                    PosicionMultiDivi(ref resultado, ref posicion, ref operacion, ref anterior, ref posterior, ref cadena, ref remplazar);

                while (resultado.Contains('+') || resultado.Contains('-'))
                    PosicionSumaResta(ref resultado, ref posicion, ref operacion, ref anterior, ref posterior, ref cadena, ref remplazar);
                
                Console.WriteLine("El resultado es: " + resultado);
                resultado = "";
                Console.WriteLine();
            
            } while (repetir);
            Console.WriteLine("FIN DE PROGRAMA");
        }

        static void PedirNumero(ref int numero)
        {
            bool incorrecto = true;
            do
            {
                try
                {
                    Console.Write("Dame un número: ");
                    numero = Convert.ToInt32(Console.ReadLine());
                    incorrecto = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("--> Número incorrecto");

                }
            } while (incorrecto);
        }

        static void Operacion(ref char operacion, ref string resultado, ref int numero)
        {
            resultado += numero;
            bool incorrecta = true;
            do
            {
                try
                {
                    Console.Write("Dame una operacion: ");
                    operacion = Convert.ToChar(Console.ReadLine());
                    switch (operacion)
                    {
                        case '+':
                        case '-':
                        case '*':
                        case '/':
                        case '=':
                        case 's':
                            incorrecta = false; break;
                        default:
                            Console.WriteLine("--> Operacion incorrecta"); break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("--> Operacion incorrecta");
                }
            } while (incorrecta);
        }

        static void Repetir(ref int numero, ref string resultado, ref char operacion, ref bool repetir)
        {
            do
            {
                PedirNumero(ref numero);
                Operacion(ref operacion, ref resultado, ref numero);


                if (operacion != '=' && operacion != 's')
                    resultado += operacion;
                if (operacion == 's')
                    repetir = false;

            } while (operacion != '=' && operacion != 's');
        }

        static void PosicionMultiDivi(ref string resultado, ref int posicion, ref char operacion, ref string anterior, ref string posterior, ref string cadena, ref string remplazar)
        {
            if (resultado.IndexOf('*') == -1)
            {
                posicion = resultado.IndexOf('/');
                operacion = '/';
            }
            else
            {
                posicion = resultado.IndexOf('*');
                operacion = '*';
            }

            for (int i = posicion - 1; i >= 0; i--)
            {
                if (anterior == "")
                {
                    switch (resultado[i])
                    {
                        case '+':
                        case '-':
                        case '/':
                        case '*':
                            anterior = resultado.Substring(i + 1, posicion - i - 1); break;
                    }
                }
            }

            if (anterior == "")
                anterior = resultado.Substring(0, posicion);
            posicion++;

            for (int i = posicion; i < resultado.Length; i++)
            {
                if (posterior == "")
                {
                    switch (resultado[i])
                    {
                        case '+':
                        case '-':
                        case '*':
                        case '/':
                            posterior = resultado.Substring(posicion, i - posicion); break;
                    }
                }
            }

            if (posterior == "")
                posterior = resultado.Substring(posicion, resultado.Length - posicion);

            cadena = anterior + operacion + posterior;

            if (operacion == '*')
                remplazar = "" + (Convert.ToInt32(anterior) * Convert.ToInt32(posterior));
            else
                remplazar = "" + (Convert.ToInt32(anterior) / Convert.ToInt32(posterior));

            resultado = resultado.Replace(cadena, remplazar);
            anterior = posterior = "";
        }

        static void PosicionSumaResta(ref string resultado, ref int posicion, ref char operacion, ref string anterior, ref string posterior, ref string cadena, ref string remplazar)
        {
            if (resultado.IndexOf('+') == -1)
            {
                posicion = resultado.IndexOf('-');
                operacion = '-';
            }
            else
            {
                posicion = resultado.IndexOf('+');
                operacion = '+';
            }

            for (int i = posicion - 1; i >= 0; i--)
            {
                if (anterior == "")
                {
                    switch (resultado[i])
                    {
                        case '+':
                        case '-':
                            anterior = resultado.Substring(i + 1, posicion - i - 1); break;
                    }
                }
            }

            if (anterior == "")
                anterior = resultado.Substring(0, posicion);
            posicion++;

            for (int i = posicion; i < resultado.Length; i++)
            {
                if (posterior == "")
                {
                    switch (resultado[i])
                    {
                        case '+':
                        case '-':
                            posterior = resultado.Substring(posicion, i - posicion); break;
                    }
                }
            }

            if (posterior == "")
                posterior = resultado.Substring(posicion, resultado.Length - posicion);

            cadena = anterior + operacion + posterior;

            if (operacion == '+')
                remplazar = "" + (Convert.ToInt32(anterior) + Convert.ToInt32(posterior));
            else
                remplazar = "" + (Convert.ToInt32(anterior) - Convert.ToInt32(posterior));

            resultado = resultado.Replace(cadena, remplazar);
            anterior = posterior = "";
        }
    }
}
