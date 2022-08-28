using System;
using System.Data.Entity.Core;
using System.ComponentModel.DataAnnotations;

namespace HospitalEnCasa.App.Dominio
{
    /// <summary>Class <c>SugerenciaCuidado</c>
    /// Modela las sugerencias de cuidado del Paciente
    /// </summary>   
    public class SugerenciaCuidado 
    {
        // Identificador único de cada SugerenciaCuidado
        [Key]
        public int? Id { get; set; }
        /// Fecha y hora en que se escribe la sugerencia
        public DateTime FechaHora  { get; set; }
         /// Texto con la sugerencia
        public string Descripcion {get;set;}
    }
}