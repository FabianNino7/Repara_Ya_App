using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace REPARA_YA_APP.Models {

    //a cada clase se le asigno una base de datos y su respectiva libreria
    public class OpcionesdeServicio : QuieroAdquirirUnServicio
    {
        [key, DatabaseGenerated(DatabaseGeneratedOption.None)]

        public string ID { get; set; } = Guid.NewGuid().ToString();

        public string ServiciosID { get; set; }
        public Servicios Servicios { get; set; }
    }

}
