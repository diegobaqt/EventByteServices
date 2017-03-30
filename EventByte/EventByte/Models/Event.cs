using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EventByte.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El nombre es requerido")]
        public string Name { get; set; }

        [Display(Name = "Categoría")]
        [Required(ErrorMessage = "La categoría es requerida")]
        public string Category { get; set; }

        [Display(Name = "Fecha")]
        [Required(ErrorMessage = "La fecha es requerida")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Precio")]
        [Required(ErrorMessage = "El precio es requerido")]
        public decimal Price { get; set; }

        [Display(Name = "Latitud")]
        [Required(ErrorMessage = "La latitud es requerida")]
        public double Latitude { get; set; }

        [Display(Name = "Longitud")]
        [Required(ErrorMessage = "La longitud es requerida")]
        public double Longitude { get; set; }
    }
}