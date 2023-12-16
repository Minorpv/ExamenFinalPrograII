using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace ExamenFinalPrograII_Encuesta.CLS
{
    public class Partido
    {
        public static int id;
        public string Nombre;

        public Partido(string nombre)
        {
            Nombre = nombre;
        }

        public Partido()
        {
        }

        public static int getID(string Nombre) 
        {
            if (Nombre != null)
            {
                if (Nombre == "PUSC")
                {
                    id= 1;
                }
                if (Nombre == "PLN")
                {
                    id = 2;
                }
                if (Nombre == "PAC")
                {
                    id = 3;
                }
            }
            return id;
        }
    }
}