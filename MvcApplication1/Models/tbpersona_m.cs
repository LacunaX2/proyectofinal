using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using MvcApplication1.Models;

namespace MvcApplication1.Models
{
    [MetadataType(typeof(itbpersona))]
    public partial class tbpersona
    {
    }

    public interface itbpersona
    {
        [Key]
        [ScaffoldColumn(false)]
        object cod_persona { get; set; }

        [Display(Name = "Nombre")] 

        [Required]
        object nombre { get; set; }
        [Display(Name = "Apellido Paterno")]
        [Required]
        object ap_paterno { get; set; }
        [Display(Name = "Apellido Materno")]
        [Required]
        object ap_materno { get; set; }
        [Required]
        [Range(0, 2)]
        object estado { get; set; }
        [Required]
        [DataType(DataType.Text, ErrorMessage = "error de fecha")]
        object fecha_creacion { get; set; } 
        
        

        
    }
}