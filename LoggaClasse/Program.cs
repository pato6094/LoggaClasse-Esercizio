using System;
using System.Collections.Generic;

namespace LoggaClasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona()
            {
                name = "giovanni",
                surname = "serra"
            };

              


            Log.saveToFile<Persona>(persona, "C:\\Users\\cuffi\\Desktop\\Account.csv");
        }
    }
}

