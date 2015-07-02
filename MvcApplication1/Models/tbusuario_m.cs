using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using MvcApplication1.Models;

namespace MvcApplication1.Models
{
    [MetadataType(typeof(itbusuario))]
    public partial class tbusuario
    {
        
    }
    public interface itbusuario 
    {
        [Key]
        [ScaffoldColumn(false)]
        object cod_usuario { get; set; }

        [Required]
        [RegularExpression(@"[0-9]*\.?[0-9]+", ErrorMessage = "Error dato incorrecto")]
        object cod_persona { get; set; }

        [Display(Name = "ID Login")]
        [Required]
        object login { get; set; }

        [Display(Name = "Contraseña")]
        [Required]
        object pass { get; set; }

        [Required]
        [DataType(DataType.Text, ErrorMessage = "error de fecha")]
        object fecha_creacion { get; set; } 




    }


}