﻿using System.ComponentModel.DataAnnotations;
namespace RegistroDePrioridades.Models
{
    public class Prioridades
    {
        [Key]
        public int PrioridadId { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        public string? Descripcion { get; set; }
        [Range(1, 365, ErrorMessage = "Valores Validos entre 1 y 31")]
        public int DiasCompromiso { get; set; }
    }
}
