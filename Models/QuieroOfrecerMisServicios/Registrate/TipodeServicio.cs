using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace REPARA_YA_APP.Models {

    //a cada clase se le asigno una base de datos y su respectiva libreria
    public class TipodeServicio : QuieroAdquirirUnServicio
    {
        [key, DatabaseGenerated(DatabaseGeneratedOption.None)]

        public string ID { get; set; } = Guid.NewGuid().ToString();

        public OpcionServicio OpcionServicio { get; set; }

        public List<OpcionesdeServicio> OpcionesdeServicio { get; set; }
    }

    public enum OpcionServicio{
        MantenimientodeMoviles,
        MantenimientodeComputo,
        MantenimientodeElectrodomesticos,
        MantenimientodeMaquinaria,
    }

}
