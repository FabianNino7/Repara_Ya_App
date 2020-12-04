using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repara_Ya__App.Models
{

    //a cada clase se le asigno una base de datos y su respectiva libreria
    public class RegistrateOfrecer
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]

        public string ID { get; set; } = Guid.NewGuid().ToString();

        //propiedades de la clase usuario
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Cedula { get; set; }
        //public string Email { get; set; }
        //public string Contraseña { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public int Celular { get; set; }
        public string Pais { get; set; }
    }

}
