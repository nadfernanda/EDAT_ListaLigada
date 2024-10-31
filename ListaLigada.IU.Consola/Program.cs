using ListaLigada.Logica;


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Lista Ligada simple");

        var singleList = new SingleList<String>();
        int opcion = 0;

        do
        {
            opcion = Menu();
            switch (opcion)
            {
                case 1: AgregarElemento(); break;
                case 2: MostrarLista(); break;

                    //default: Console.WriteLine("la opcion no existe");
                    //    break;
            }




        }
        while (opcion != 0);

        void AgregarElemento()
        {
            Console.Write("** Agregar elementos a la lista **\n ");
            Console.Write("Escriba el nombre del nodo: ");
            var nombre = Console.ReadLine();
            singleList.Add(nombre);
        }

        void MostrarLista()
        {

            if (singleList.isEmpty)
            {
                Console.WriteLine("La lista esta vacia");
            }
            else
            {
                Console.WriteLine(singleList);
            }

            Console.WriteLine(singleList);

        }

        Console.ReadKey();
    }//fin de main



    private static int Menu()
    {
        Console.WriteLine("Menu\n");
        Console.WriteLine("1.Agregar elemento");
        Console.WriteLine("2.Agregar lista");
        Console.WriteLine("0.Salir");

        bool esValido = false;

        int opcion = 0;
        do
        {
            Console.WriteLine("\nSeleccione una opcion del menu: ");
            var opcionCapturada = Console.ReadLine();

            if (!int.TryParse(opcionCapturada, out opcion) || opcion < 0 || opcion > 2)
            {
                Console.WriteLine("Ingresa una opcion valida\n");
                esValido = false;
            }
            else
            {
                esValido = true;

            }


        } while (esValido == false);
        return opcion;

    }
}