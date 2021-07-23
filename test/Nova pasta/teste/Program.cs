using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidarString(Console.ReadLine());
        }

        static void ValidarString(string cadeiaString)
        {
            char[] caracteresValidos = "qwertyuiopasdfghjklzxcvbnm".ToCharArray();

            for (int i = 0; i < 38; i++)
            {
                if (cadeiaString.Contains(caracteresValidos[i])) { }
                else { throw new Exception($"Simbolo inválido em {cadeiaString}."); }
            }
        }
        static string GerarSerial(int length)
        {
            char[] caracteres = "QWERTYUIOPASDFGHJKLZXCVBNM0123456789".ToCharArray();
            string serial = "@";
            Random r = new Random();

            for (int i = 0; i < length; i++)
            {
                serial += caracteres[r.Next(0, 35)];
            }
            return serial;
        }
    }
}
