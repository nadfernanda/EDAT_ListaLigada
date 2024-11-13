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
                case 3: EliminarElemento(); break;

                case 0: Console.WriteLine("presiona una tecla cualquiera para salir"); break;
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

        }

       void EliminarElemento()
        {
            Console.WriteLine("\n** Eliminar elemento de la lista **");
            Console.WriteLine("\nEscriba el nombre del elemento");
            var elemento = Console.ReadLine();
           var result = singleList.Remove(elemento!);

            if (result == true)
            {
                Console.WriteLine("El elemento fue eliminado");
            }
            else
            {
                Console.WriteLine("No se encontro el elemento");
            }

        }
        


        Console.ReadKey();
    }//fin de main

    

    private static int Menu()
    {
        Console.WriteLine("\nMenu");
        Console.WriteLine("1.Agregar elemento");
        Console.WriteLine("2.Mostrar Lista");
        Console.WriteLine("3.Eliminar elemento");
        Console.WriteLine("0.Salir");

        bool esValido = false;

        int opcion = 0;
        do
        {
            Console.WriteLine("\nSeleccione una opcion del menu: \n");
            var opcionCapturada = Console.ReadLine();

            if (!int.TryParse(opcionCapturada, out opcion) || opcion < 0 || opcion > 3)
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