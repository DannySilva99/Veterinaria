using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    class Menu
    {
        List<AgregarMascota> ListaDeMascotas;
        List<AgregarEnfermedad> ListaDeEnfermedades;
        int Opc;
        RepoMascotas RM = new RepoMascotas();
        RepoEnfermedades RE = new RepoEnfermedades();
        public void MenuDeInicio()
        {
            ListaDeMascotas = new List<AgregarMascota>();
            ListaDeEnfermedades = new List<AgregarEnfermedad>();
            do
            {
                do
                {
                    Console.WriteLine("Bienvenido a la clinica veterinaria Silva");
                    Console.WriteLine("Elija la opcion que desee realizar: ");
                    Console.WriteLine("1.-Agregar Mascota ");
                    Console.WriteLine("2.-Lista de Mascotas ");
                    Console.WriteLine("3.-Agregar Enfermedad ");
                    Console.WriteLine("4.-Lista de Enfermedades ");
                    Console.WriteLine("5.-Salir ");
                    Opc = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (Opc < 1 || Opc > 5)
                    {
                        Console.WriteLine("Introduzca una opcion valida ");
                    }
                } while (Opc < 1 || Opc > 5);
                switch(Opc)
                {
                    case 1:
                        RM.CrearMascota();
                        break;
                    case 2:
                        RM.ListarMascotas();
                        break;
                    case 3:
                        RE.CrearEnfermedad();
                        break;
                    case 4:
                        RE.ListarEnfermedades();
                        break;
                    case 5:
                        Console.WriteLine("Gracias por usar el programa de la veterinaria, Vuelva pronto");
                        Console.ReadKey();
                        break;
                }
            } while (Opc != 5);
        }
    }
}
