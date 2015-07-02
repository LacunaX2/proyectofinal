using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using MvcApplication1.Models;

namespace MvcApplication1.Models
{
    [MetadataType(typeof(itbnotas))]
    public partial class tbnotas
    {
    }
    public interface itbnotas 
    {
        [Key]
        [ScaffoldColumn(false)]
        object cod_notas { get; set; }

        [Required]
        [RegularExpression(@"[0-9]*\.?[0-9]+", ErrorMessage = "Error dato incorrecto")]
        object cod_agenda { get; set; }

        [Display(Name = "Titulo de la nota")]
        [Required]
        object titulo { get; set; }

        [Display(Name = "Descripcion")]
        [Required]
        object descripcion { get; set; }

        [Required]
        [DataType(DataType.Text, ErrorMessage = "error de fecha")]
        object fecha_creacion { get; set; }


    }
}