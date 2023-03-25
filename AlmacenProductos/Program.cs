// See https://aka.ms/new-console-template for more information
using AlmacenProductos.DAO;
using AlmacenProductos.Models;

Console.WriteLine("\n---------------------------------------------------------");
Console.WriteLine("            BIENVENIDOS/AS A SU ALMACEN PREFERIDO          ");
Console.WriteLine("              --  Sera un placer atenderte  --             ");
Console.WriteLine("---------------------------------------------------------");


CrudProductos CrudProductos = new CrudProductos();
Producto Producto = new Producto();

bool comprobar = true;
while (comprobar == true)
{
    Console.WriteLine("\n\n Coloque el numero de la accion a realizar ");
    Console.WriteLine("------------------------------------");
    Console.WriteLine("               MENU                 ");
    Console.WriteLine("------------------------------------");
    Console.WriteLine("      1. Insertar Productos         ");
    Console.WriteLine("      2. Productos registrados      ");
    Console.WriteLine("      3. Salir                      ");
    Console.WriteLine("------------------------------------");

    Console.Write("- ¿Que desea hacer? ");
    var Menu = Convert.ToInt32(Console.ReadLine());

    switch (Menu)
    {
        case 1:
            int bucle = 1;
            while (bucle == 1)
            {
                Console.WriteLine("\n\n  AGREGAR PRODUCTOS:");
                Console.WriteLine("------------------------------------");

                Console.WriteLine("- Nombre del producto: ");
                Producto.Nombre = Console.ReadLine();
                Console.WriteLine("- Descripcion:");
                Producto.Descripcion = Console.ReadLine();
                Console.WriteLine("- Precio: ");
                Producto.Precio = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("- Cantidad de productos existentes: ");
                Producto.Stock = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-----------------------------------\n");
                CrudProductos.AgregarProductos(Producto);

                Console.WriteLine(" - PRODUCTO INGRESADO CORRECTAMENTE \n");

                Console.WriteLine("Coloque: ");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("   1. Continuar ingresando          ");
                Console.WriteLine("      productos                     ");
                Console.WriteLine("   2. Salir                         ");
                Console.WriteLine("-----------------------------------");
                Console.Write("- ¿Que desea hacer? ");
                bucle = Convert.ToInt32(Console.ReadLine());

            }
            break;

        case 2:
            Console.WriteLine("\n\n  PRODUCTOS REGISTRADOS:");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine(" Id Cant. Producto Descripcion Precio ");
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("\n- No se puede acceder en este momento: ");
            Console.WriteLine("  Apartado en mantenimiento, esto puede tardar un tiempo.");
            Console.WriteLine("  Intente mas tarde..\n\n");

            comprobar = false;

            break;

        case 3:

            Console.WriteLine("\n\n----------------------------------------------------------");
            Console.WriteLine("           ¡GRACIAS POR VISITAR NUESTRO ALMACEN!           ");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine(" - Vueva pronto");
            Console.WriteLine(" - Lo esperamos\n");

            comprobar = false;

            break;

    }
}


