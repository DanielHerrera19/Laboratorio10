using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio10.Registrador
{
    public class Interfazconsola
    {
        public static int PantallaPrincipal()
        {
            Console.Clear();
            Console.Write("" +
                "================================\r\n" +
                "Productos de mPhone\r\n" +
                "================================\r\n" +
                "1: Ventas de mPhone 3000\r\n" +
                "2: Ventas de mPad 3500\r\n" +
                "3: Ventas de MAPBrook 3800\r\n" +
                "4: Ventas de mWatch 8000\r\n" +
                "5: Salir\r\n" +
                "================================\r\n" +
                "Ingrese una opción: ");

            return getOpcion();
        }

        public static void PantallaOpciones(string texto)
        {
            Console.Clear();
            Console.Write("" +
                "================================\r\n" +
                "Registrar Venta de " + texto +
                "\n================================\r\n" +
                "1: Registrar Venta\r\n" +
                "2: Registrar Devolución\r\n" +
                "3: Menu Principal\r\n" +
                "================================\r\n" +
                "Ingrese una opción: ");

        }
        public static int getOpcion()
        {
            string opcionTexto = Console.ReadLine();
            return int.Parse(opcionTexto);
        }

        public static int PantallamPhone3000()
        {
            Console.Clear();
            PantallaOpciones("mPhone 3000");
            int opcion = getOpcion();
            if (opcion == 3) return 0;
            if (opcion == 1) return VentamPhone3000();
            if (opcion == 2) return DevolucionmPhone3000();
            return opcion;
        }

        public static int PantallamPad3500()
        {
            Console.Clear();
            PantallaOpciones("mPad 3500");
            int opcion = getOpcion();
            if (opcion == 3) return 0;
            if (opcion == 1) return VentamPad3500();
            if (opcion == 2) return DevolucionmPad3500();
            return opcion;
        }

        public static int PantallaMAPBrook3800()
        {
            Console.Clear();
            PantallaOpciones("MAPBrook 3800");
            int opcion = getOpcion();
            if (opcion == 3) return 0;
            if (opcion == 1) return VentaMAPBrook3800();
            if (opcion == 2) return DevolucioMAPBrook3800();
            return opcion;
        }

        public static int PantallamWatch8000()
        {
            Console.Clear();
            PantallaOpciones("mWatch 8000");
            int opcion = getOpcion();
            if (opcion == 3) return 0;
            if (opcion == 1) return VentamWatch8000();
            if (opcion == 2) return DevolucionmWatch8000();
            return opcion;
        }

        public static void PantallaDevolucion(string texto)
        {
            Console.Write("" +
                "================================\r\n" +
                "Registrar devolución de:\r\n" +
                "================================\r\n" +
                "Se va a registrar la devolución de\r\n" +
                texto + " ¿Desea Continuar?\r\n" +
                "1: Sí\r\n" +
                "2: No\r\n" +
                "================================\r\n" +
                "Ingrese una opción: ");
        }
        public static int DevolucionmPhone3000()
        {
            Console.Clear();
            PantallaDevolucion("mPhone 3000");
            int opcion = getOpcion();
            switch (opcion)
            {
                case 1:
                    break;
                case 2:
                    opcion = PantallamPhone3000();
                    break;
            }
            return opcion;
        }

        public static int DevolucionmPad3500()
        {
            Console.Clear();
            PantallaDevolucion("mPad 3500");
            int opcion = getOpcion();
            switch (opcion)
            {
                case 1:
                    break;
                case 2:
                    opcion = PantallamPad3500();
                    break;
            }
            return opcion;
        }

        public static int DevolucioMAPBrook3800()
        {
            Console.Clear();
            PantallaDevolucion("MAPBrook 3800 ");
            int opcion = getOpcion();
            switch (opcion)
            {
                case 1:
                    break;
                case 2:
                    opcion = PantallaMAPBrook3800();
                    break;
            }
            return opcion;
        }

        public static int DevolucionmWatch8000()
        {
            Console.Clear();
            PantallaDevolucion("mWatch 8000");
            int opcion = getOpcion();
            switch (opcion)
            {
                case 1:
                    break;
                case 2:
                    opcion = PantallamWatch8000();
                    break;
            }
            return opcion;
        }

        public static void PantallaVenta(string texto)
        {
            Console.Write("" +
                "================================\r\n" +
                "Registrar venta de:\r\n" +
                "================================\r\n" +
                "Se va a registrar la venta de un\r\n" +
                texto + " ¿Desea Continuar?\r\n" +
                "1: Sí\r\n" +
                "2: No\r\n" +
                "================================\r\n" +
                "Ingrese una opción: ");
        }

        public static int VentamPhone3000()
        {
            Console.Clear();
            PantallaVenta("mPhone 3000");
            int opcion = getOpcion();
            int Mphone3000 = 0;
            int total = 0;
            if (opcion == 2) return PantallamPhone3000();
            if (opcion == 1)
            {
                Mphone3000++;
                total += Mphone3000;
            }
            return opcion;
        }

        public static int VentamPad3500()
        {
            Console.Clear();
            PantallaVenta("mPad 3500");
            int opcion = getOpcion();
            switch (opcion)
            {
                case 1:
                    break;
                case 2:
                    opcion = PantallamPad3500();
                    break;
            }
            return opcion;
        }

        public static int VentaMAPBrook3800()
        {
            Console.Clear();
            PantallaVenta("MAPBrook 3800");
            int opcion = getOpcion();
            switch (opcion)
            {
                case 1:
                    break;
                case 2:
                    opcion = PantallaMAPBrook3800();
                    break;
            }
            return opcion;
        }

        public static int VentamWatch8000()
        {
            Console.Clear();
            PantallaVenta("mWatch 8000");
            int opcion = getOpcion();
            switch (opcion)
            {
                case 1:
                    break;
                case 2:
                    opcion = PantallamWatch8000();
                    break;
            }
            return opcion;
        }

        public static void PantalladeSalida()
        {
            Console.WriteLine("" +
                "================================\r\n" +
                "Reporte Final\r\n" +
                "================================\r\n" +
                "Productos Vendidos | Cantidad\r\n" +
                "--------------------------------\r\n" +
                "mPhones            | 15\r\n" +
                "mPads              | 2\r\n" +
                "MAPBrooks          | 5\r\n" +
                "mWatches           | 3\r\n" +
                "--------------------------------\r\n" +
                "Total              |" +
                "\n================================\r\n" +
                "¡Hasta Luego!\r\n" +
                "\n" +
                "\n" +
                "\n" +
                "Diseñado Por: Daniel Herrera");
        }
    }
}