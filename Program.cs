using Laboratorio10.Registrador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                opcion = Interfazconsola.PantallaPrincipal();

                switch (opcion)
                {
                    case 0:
                        opcion = Interfazconsola.PantallaPrincipal();
                        break;
                    case 1:
                        opcion = Interfazconsola.PantallamPhone3000();
                        switch (opcion)
                        {
                            case 1:
                                opcion = Interfazconsola.VentamPhone3000();
                                break;
                            case 2:
                                opcion = Interfazconsola.DevolucionmPhone3000();
                                break;
                        }
                        break;
                    case 2:
                        opcion = Interfazconsola.PantallamPad3500();
                        switch (opcion)
                        {
                            case 1:
                                opcion = Interfazconsola.VentamPad3500();
                                break;
                            case 2:
                                opcion = Interfazconsola.DevolucionmPad3500();
                                break;
                        }
                        break;
                    case 3:
                        opcion = Interfazconsola.PantallaMAPBrook3800();
                        switch (opcion)
                        {
                            case 1:
                                opcion = Interfazconsola.VentaMAPBrook3800();
                                break;
                            case 2:
                                opcion = Interfazconsola.DevolucionmWatch8000();
                                break;
                        }
                        break;
                    case 4:
                        opcion = Interfazconsola.PantallamWatch8000();
                        switch (opcion)
                        {
                            case 1:
                                opcion = Interfazconsola.VentamWatch8000();
                                break;
                            case 2:
                                opcion = Interfazconsola.DevolucionmWatch8000();
                                break;
                        }
                        break;
                    case 5:
                        Interfazconsola.PantalladeSalida();
                        break;
                }
            } while (opcion != 5);

            Console.ReadKey();
        }
    }
}