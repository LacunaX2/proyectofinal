using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using MvcApplication1.Models;

namespace MvcApplication1.Models
{
    [MetadataType(typeof(itbagenda))]
    public partial class tbagenda
    {
    }
    public interface itbagenda 
    {
        [Key]
        [ScaffoldColumn(false)]
        object cod_agenda { get; set; }

        [Required]
        [RegularExpression(@"[0-9]*\.?[0-9]+", ErrorMessage = "Error dato incorrecto")]
        object cod_usuario { get; set; }

        [Required]
        [DataType(DataType.Text, ErrorMessage = "error de fecha")]
        object fecha { get; set; } 
         

    }
}