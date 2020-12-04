using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repara_Ya__App.Models
{
    //a cada clase se le asigno una base de datos y su respectiva libreria
    public class QuieroAdquirirUnServicio
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string ID { get; set; } = Guid.NewGuid().ToString();
        //public List<OrdenBebida> OrdenesBebida { get; set; }
        //public DateTime FechaNacimiento { get; set; }
        //Contiene las órdenes de este usuario
        //public List<Orden> Orden { get; set; }
    } 
}