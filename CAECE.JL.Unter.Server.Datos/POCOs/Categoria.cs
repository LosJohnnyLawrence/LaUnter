﻿using System.ComponentModel.DataAnnotations;

namespace CAECE.JL.Unter.Server.Datos
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Nombre { get; set; }

    }
}