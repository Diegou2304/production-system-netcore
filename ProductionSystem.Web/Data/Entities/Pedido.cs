﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductionSystem.Web.Data.Entities
{
    public class Pedido: IEntity
    {


        public int Id { get; set; }
        
        public int Cantidad { get; set;}

        [Display(Name = "Fecha")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Fecha { get; set;}

        //Lo estados del pedido son (pendiente) (proceso) (finalizado)
        [DefaultValue("Pendiente")]
        public string estado { get; set; }

        public int NumeroFase { get; set; }
             
        public ProductoReal ProductoReal { get; set; }

        public ICollection<Produccion> Producciones { get; set; }

    }
}
