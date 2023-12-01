using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopiaCajero.Dtos
{
    internal class ClienteDto
    {

        //Atributo (características)

         string nombreCliente; 

         string apellidosCliente;

         string dniCliente;

         string emailCliente;

         DateOnly fechaNacimientoCliente;

         int telfCliente;

         DateOnly fechaAltaCliente;

         DateOnly fechaBajaCliente;

        //getter and setter
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidosCliente { get => apellidosCliente; set => apellidosCliente = value; }
        public string DniCliente { get => dniCliente; set => dniCliente = value; }
        public string EmailCliente { get => emailCliente; set => emailCliente = value; }
        public DateOnly FechaNacimientoCliente { get => fechaNacimientoCliente; set => fechaNacimientoCliente = value; }
        public int TelfCliente { get => telfCliente; set => telfCliente = value; }
        public DateOnly FechaAltaCliente { get => fechaAltaCliente; set => fechaAltaCliente = value; }
        public DateOnly FechaBajaCliente { get => fechaBajaCliente; set => fechaBajaCliente = value; }

        



        //Constructores
        public ClienteDto()
        {

        }

        public ClienteDto(string nombreCliente, string dniCliente)
        {
            this.nombreCliente = nombreCliente;
            this.dniCliente = dniCliente;
        }



        //ToString
        //Instancia un nuevo cliente al que se le informe el nombre y dni directamente
        //Se imprima por consola el nombre y dni utilizando un metodo string de dentro de la clase.
       /* public override string ToString() //Modo 2
        {

            return string.Format(nombreCliente+dniCliente);
        }
       */
       public string toString() //Modo 1
        {
            string objeto = this.nombreCliente +" ", dniCliente;

            return objeto;
        }


    }
}
