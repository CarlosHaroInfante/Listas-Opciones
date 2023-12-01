
using CopiaCajero.Dtos;

namespace CajeroMenuC.Controladores


{
    /// <summary>
    /// Clase Principal de la aplicación
    /// 250923 - chi
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método de entrada a la aplicación
        /// 250923 - chi
        /// </summary>
        /// <param name="args"></param>
        static void Main(String[] args)
        {
            /*
            //Añadir
            List<int> listaEnteros = new List<int>();
            listaEnteros.Add(22); //Método 1
            
            int entero = 6; //Método 2
            listaEnteros.Add(entero);

            //Acceder

            //Directamente

            listaEnteros[0] = entero;
            listaEnteros[1] = 22;
            int posicionCero = listaEnteros[0];
            int posicionUno = listaEnteros[1];

            //Indirecto (Recorriendo Líneas)
            for (int posicion = 0; posicion < listaEnteros.Count();posicion++)
            {
                Console.WriteLine(listaEnteros[posicion]);
            }

            //Lista con tipo objeto

           ;

            //Crear un cliente 
            List<ClienteDto> listaClientes = new List<ClienteDto>();
            ClienteDto cliente1 = new ClienteDto();
            cliente1.nombreCliente = "Carlos";
            cliente1.apellidosCliente = "Haro";
            string nombreCompleto = cliente1.nombreCliente + cliente1.apellidosCliente;
            ClienteDto cliente2 = new ClienteDto();
            cliente2.nombreCliente = "Pepe";
            cliente2.apellidosCliente = "Castro";
            //Añadir cliente a la lista
            listaClientes.Add(cliente1);
            listaClientes.Add(cliente2);
            //[cliente1][cliente2]

            //Accerder a un cliente específico por su posición
            
            ClienteDto cliente2primas = listaClientes[1];

            //Accedido al cliente2 que estaba en la posición 1 de la lista
            //y dentro de ese cliente hemos accedido a su campo nombre
            Console.WriteLine(listaClientes[1].nombreCliente);

            //Modificación de un campo del objeto cliente 2
            listaClientes[1].nombreCliente = "Pepito";

            //Accedemos a la referencia de memoria de la lista
            Console.WriteLine(listaClientes);
            //Accedemos a la referencia de memoria del objeto cliente1
            Console.WriteLine(listaClientes[0]);

            int posicion;
            for (posicion = 0; posicion<listaClientes.Count();posicion++)
            {
                Console.WriteLine("Nombre: " + listaClientes[posicion].nombreCliente);
            }

            //Eliminar, cuando se elimina la lista se desplaza para cubrir el espacio libre
            //listaClientes.RemoveAt(0);
            //Console.WriteLine(listaClientes.Count());

            //foreach
            //[cliente1][cliente2]
            Console.WriteLine(cliente2.nombreCliente);
            Console.WriteLine(cliente2primas.nombreCliente);
            Console.WriteLine(listaClientes[1].nombreCliente);
            cliente2primas.nombreCliente = "Paquito";
            Console.WriteLine(cliente2.nombreCliente);
            Console.WriteLine(cliente2primas.nombreCliente);
            Console.WriteLine(listaClientes[1].nombreCliente);
            
            foreach (ClienteDto cliente in listaClientes)
            {
               cliente2primas.nombreCliente = "Ediondo";
            }

            Console.WriteLine(cliente2.nombreCliente);
            Console.WriteLine(cliente2primas.nombreCliente);
            Console.WriteLine(listaClientes[1].nombreCliente);

            //Modificar 
            foreach (ClienteDto cliente in listaClientes)
            {
                if (cliente.nombreCliente == "Ediondo")
                {
                    cliente.apellidosCliente = "Martinez";

                }

            }
            Console.WriteLine(cliente2.apellidosCliente);*/
            /*
            //Atributos en privado
           

            List<int> listaEnteros = new List<int>() { 1, 2, 3, 4, 5 };
            listaEnteros.RemoveAt(1); //Elimina por posición en lista
            //1,3,4,5 (quedan)
            listaEnteros.Remove(4); //Mira el valor que está dentro
                                    //(si quedan 1,3,4,5 borraría la posición dos por que coincide con el valor)
                                    //quedan 1,3,5
            listaEnteros.RemoveRange(1, 2); //Borra a partir del primer numero que pongas(1);
                                            //Borra las posiciones después de número anterior.
                                            //Borra a partir del numero 1 (3) 2 num (el 3 y 5)
                                            //Solo queda el 1

            listaEnteros.Add(8);
            listaEnteros.Add(7);
            listaEnteros.Add(4);
            //Lista actual 1,8,7,4
            //listaEnteros.RemoveAll( x => x<5 ); //Esto hace que si el numero de la lista es menor a 5
            //Lo borrará, sin importar su posición en lista.
            //Lista actual 8,7

            //listaEnteros.Clear();
            //Borra la lista completa, lista vacía.


            listaEnteros.Reverse(); //Ordena descendentemente (8,7,4,1)
            listaEnteros.Sort();//Ordena ascendentemente (1,4,7,8)

            */
            
            ClienteDto cliente1 = new ClienteDto("Ediondo", "12345678J");
            Console.WriteLine(cliente1.ToString());

            
            

        }


    }
}