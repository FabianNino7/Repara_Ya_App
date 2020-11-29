using System;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

namespace Repara_Ya__App.Models
{
    //a cada clase se le asigno una base de datos y su respectiva libreria
    public class Ingresar : QuieroOfrecerMisServicios
    {
        //[key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        //public string ID { get; set; } = Guid.NewGuid().ToString();
        public string Nombre { get;  set; }
        public string Apellido { get;  set; }
        public string Telefono { get;  set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Cuidad { get; set; }
        public string Pais { get;  set; }
        //public DateTime FechaNacimiento { get; set; }
        // Contiene las órdenes de este usuario
        // public List<Orden> Orden { get; set; }
    }

}